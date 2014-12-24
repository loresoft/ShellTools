using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ShellTools.Utility;
using System.IO;

namespace ShellTools.Commands
{
    public abstract class ShellCommandBase : IShellCommand, IDisposable
    {
        protected virtual string GetSendToPath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
            path = Path.Combine(path, this.DisplayName + ".lnk");
            return path;
        }

        public virtual string IconPath
        {
            get { return @"%SystemRoot%\system32\SHELL32.dll"; }
        }

        public virtual int IconIndex 
        {
            get { return 2; }  
        }

        #region IShellCommand Members

        public abstract bool TryCommand(ShellToolsArguments arguments, out int errorCode);

        public virtual bool InstallRegistry()
        {
            string command = string.Format("\"{0}\" /c:{1} \"%L\"",
                Application.ExecutablePath, this.CommandName);

            ShellExtensionHelper.Register(
                ShellExtensionHelper.PredefinedShellTypes.AllFiles,
                this.CommandName,
                this.DisplayName,
                command);

            ShellExtensionHelper.Register(
                ShellExtensionHelper.PredefinedShellTypes.Directory,
                this.CommandName,
                this.DisplayName,
                command);

            return true;
        }

        public virtual bool InstallSentTo()
        {
            string path = GetSendToPath();
            ShellShortcut shortCut = new ShellShortcut(path);
            shortCut.Arguments = string.Format("/c:{0}", this.CommandName);
            shortCut.Description = this.Description;
            shortCut.Path = Application.ExecutablePath;
            shortCut.WorkingDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            shortCut.IconPath = this.IconPath;
            shortCut.IconIndex = this.IconIndex;
            shortCut.Save();

            return true;
        }

        public virtual bool Uninstall()
        {
            ShellExtensionHelper.Unregister(
                ShellExtensionHelper.PredefinedShellTypes.AllFiles,
                this.CommandName);

            ShellExtensionHelper.Unregister(
                ShellExtensionHelper.PredefinedShellTypes.Directory,
                this.CommandName);

            string path = GetSendToPath();
            if (File.Exists(path))
                File.Delete(path);

            return true;
        }

        public abstract string CommandName { get; }

        public virtual string DisplayName
        {
            get { return this.CommandName; }
        }

        public virtual string Description
        {
            get { return string.Empty; }
        }

        public virtual bool UseForm
        {
            get { return false; }
        }

        public virtual Form CommandForm
        {
            get { return null; }
        }

        #endregion

        #region IDisposable Members

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases unmanaged and  managed resources
        /// </summary>
        /// <param name="disposing">
        /// <c>true</c> to release both managed and unmanaged resources; 
        /// <c>false</c> to release only unmanaged resources.
        /// </param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.CommandForm != null)
                    this.CommandForm.Dispose();
            }
        }
        #endregion

    }
}
