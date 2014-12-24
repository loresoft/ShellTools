using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ShellTools.Utility;

namespace ShellTools.Commands
{
    public class RelativeCommand : ShellCommandBase
    {

        private RelativeForm _relativeForm;

        public override bool TryCommand(ShellToolsArguments arguments, out int errorCode)
        {
            errorCode = 0;

            if (!arguments.Command.Equals(this.CommandName, StringComparison.OrdinalIgnoreCase))
                return false;

            _relativeForm = new RelativeForm(arguments.Path);
            return true;
        }
        
        public override string DisplayName
        {
            get { return "Calculate Relative Path"; }
        }

        public override int IconIndex
        {
            get { return 132; }
        }

        public override string CommandName
        {
            get { return "RelativePath"; }
        }

        public override string Description
        {
            get { return "Calculate a relative path from one folder to another path."; }
        }

        public override bool UseForm
        {
            get { return true; }
        }

        public override Form CommandForm
        {
            get { return _relativeForm; }
        }

    }
}
