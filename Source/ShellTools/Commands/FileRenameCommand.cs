using System;
using System.Collections.Generic;
using System.Text;
using ShellTools.Utility;
using System.Windows.Forms;

namespace ShellTools.Commands
{
    public class FileRenameCommand : ShellCommandBase
    {

        FileRenameForm _fileRenameForm;


        public override bool TryCommand(ShellToolsArguments arguments, out int errorCode)
        {
            errorCode = 0;

            if (!arguments.Command.Equals(this.CommandName, StringComparison.OrdinalIgnoreCase))
                return false;

            _fileRenameForm = new FileRenameForm(arguments.Path);
            return true;
        }
        
        public override bool InstallRegistry()
        {
            string command = string.Format("\"{0}\" /c:{1} \"%L\"",
                Application.ExecutablePath, this.CommandName);

            ShellExtensionHelper.Register(
                 ShellExtensionHelper.PredefinedShellTypes.Directory,
                 this.CommandName,
                 this.DisplayName,
                 command);

            return true;
        }

        public override int IconIndex
        {
            get
            {
                return 24;
            }
        }
        public override string DisplayName
        {
            get { return "Rename Files"; }
        }

        public override string CommandName
        {
            get { return "FileRename"; }
        }

        public override string Description
        {
            get { return "Rename files with with regular expressions."; }
        }

        public override bool UseForm
        {
            get { return true; }
        }

        public override Form CommandForm
        {
            get { return _fileRenameForm; }
        }

    }
}
