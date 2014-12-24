using System;
using System.Collections.Generic;
using System.Text;
using ShellTools.CommandLine;

namespace ShellTools
{
    
    
    public class ShellToolsArguments
    {
        [Argument(ArgumentType.AtMostOnce,
            ShortName = "?",
            LongName = "Help",
            HelpText = "Display Help.")]
        public bool Help;

        [Argument(ArgumentType.AtMostOnce,
            ShortName = "i",
            LongName = "Install",
            HelpText = "Install Shell Tools by adding to the Send To menu.")]
        public bool Install;

        [Argument(ArgumentType.AtMostOnce,
           ShortName = "u",
           LongName = "Uninstall",
           HelpText = "Uninstall Shell Tools.")]
        public bool Uninstall;

        [Argument(ArgumentType.AtMostOnce,
           ShortName = "r",
           LongName = "Registry",
           HelpText = "Install Shell Tools in registry instead of Send To menu.")]
        public bool Registry;
        
        [Argument(ArgumentType.AtMostOnce,
           ShortName = "c",
           LongName = "Command",
           HelpText = "The command to run.")]
        public string Command;
        
        [DefaultArgument(ArgumentType.AtMostOnce,
            HelpText = "The current path to work with.")]
        public string Path;
        
    }
}
