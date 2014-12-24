using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ShellTools.Commands
{
    public interface IShellCommand
    {
        bool TryCommand(ShellToolsArguments arguments, out int errorCode);
        bool InstallRegistry();
        bool InstallSentTo();
        bool Uninstall();
        string CommandName { get; }
        string DisplayName { get; }
        string Description { get; }
        bool UseForm { get;}
        Form CommandForm { get; }
    }
}
