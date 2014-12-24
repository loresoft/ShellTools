using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ShellTools.Utility;

namespace ShellTools.Commands
{
    public class CopyNameCommand : ShellCommandBase
    {
        public override bool TryCommand(ShellToolsArguments arguments, out int errorCode)
        {
            errorCode = 0;

            if (!arguments.Command.Equals(this.CommandName, StringComparison.OrdinalIgnoreCase))
                return false;

            string fullPath = Path.GetFileName(arguments.Path);
            Clipboard.SetText(fullPath);
            return true;
        }

        public override string DisplayName
        {
            get { return "Copy Name to Clipboard"; }
        }

        protected override string GetSendToPath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
            path = Path.Combine(path, "Clipboard (as Name).lnk");
            return path;
        }

        public override int IconIndex
        {
            get { return 134; }
        }

        public override string CommandName
        {
            get { return "CopyFile"; }
        }

        public override string Description
        {
            get { return "Copy the current File name to the clipboard."; }
        }

    }
}
