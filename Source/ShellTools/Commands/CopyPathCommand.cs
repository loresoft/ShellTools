using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ShellTools.Utility;

namespace ShellTools.Commands
{
    public class CopyPathCommand : ShellCommandBase
    {
        public override bool TryCommand(ShellToolsArguments arguments, out int errorCode)
        {
            errorCode = 0;
            
            if (!arguments.Command.Equals(this.CommandName, StringComparison.OrdinalIgnoreCase))
                return false;
            
            string fullPath = Path.GetFullPath(arguments.Path);
            Clipboard.SetText(fullPath);
            return true;
        }

        public override string DisplayName
        {
            get { return "Copy Path to Clipbard"; }
        }

        protected override string GetSendToPath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
            path = Path.Combine(path, "Clipboard (as Full Path).lnk");
            return path;
        }

        public override int IconIndex
        {
            get { return 134; }
        }

        public override string CommandName
        {
            get { return "CopyPath"; }
        }

        public override string Description
        {
            get { return "Copy the full path to the clipboard."; }
        }

    }
}
