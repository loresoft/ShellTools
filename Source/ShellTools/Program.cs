using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using ShellTools.CommandLine;
using ShellTools.Commands;
using ShellTools.Properties;
using System.Diagnostics;

namespace ShellTools
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ShellToolsArguments arguments = new ShellToolsArguments();            
            bool result = Parser.ParseArguments(args, arguments);

            bool invalidCommand = !arguments.Install &&
                                !arguments.Uninstall &&
                                (string.IsNullOrEmpty(arguments.Command) ||
                                string.IsNullOrEmpty(arguments.Path));

            if (!result || arguments.Help || invalidCommand)
            {
                // TODO: Show usage
                string usage = Parser.ArgumentsUsage(typeof (ShellToolsArguments), 80);
                MessageBox.Show(usage, "Shell Tools Usage", MessageBoxButtons.OK, MessageBoxIcon.None);
                return arguments.Help ? 0 : 1;
            }

            
            foreach (string command in Settings.Default.CommandTypes)
            {
                IShellCommand commandInstance = GetCommandInstance(command);
                if (commandInstance == null)
                {
                    continue;
                }

                if (arguments.Install)
                {
                    if (arguments.Registry)
                        commandInstance.InstallRegistry();
                    else
                        commandInstance.InstallSentTo();
                    
                    continue;
                }

                if (arguments.Uninstall)
                {
                    commandInstance.Uninstall();
                    continue;
                }

                int errorCode;
                bool isCommand = commandInstance.TryCommand(arguments, out errorCode);
                if (isCommand && commandInstance.UseForm)
                {
                    Application.Run(commandInstance.CommandForm);
                }
                
                if (isCommand)
                {
                    return errorCode;                    
                }                
            } // foreach command

            if (arguments.Install || arguments.Uninstall)
                return 0;
            // no command found
            return 1;
        }

        private static IShellCommand GetCommandInstance(string command)
        {
            Type commandType = Type.GetType(command, false, true);
            if (commandType == null)
                return null;
            
            return Activator.CreateInstance(commandType) as IShellCommand;
        }
    }
}