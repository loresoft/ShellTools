using System;
using System.Diagnostics;
using Microsoft.Win32;

namespace ShellTools.Utility
{
	/// <summary>
	/// Register and unregister simple shell context menus.
	/// </summary>
	public static class ShellExtensionHelper
	{

        public static class PredefinedShellTypes
        {
            public const string AllFiles = "*";
            public const string AllFilesAndFolders = "AllFileSystemObjects";
            public const string AllFolders = "Folder";
            public const string Directory = "Directory";
            public const string Drive = "Drive";
        }
	    
	    /// <summary>
		/// Register a simple shell context menu.
		/// </summary>
		/// <param name="fileType">The file type to register.</param>
		/// <param name="shellKeyName">Name that appears in the registry.</param>
		/// <param name="menuText">Text that appears in the context menu.</param>
		/// <param name="menuCommand">Command line that is executed.</param>
		public static void Register(
			string fileType, 
			string shellKeyName, 
			string menuText, 
			string menuCommand)
		{
			// create full path to registry location
			string regPath = string.Format(@"{0}\shell\{1}", fileType, shellKeyName);

			// add context menu to the registry
			using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(regPath))
			{
				key.SetValue(null, menuText);
			}
			
			// add command that is invoked to the registry
			using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(
				string.Format(@"{0}\command", regPath)))
			{				
				key.SetValue(null, menuCommand);
			}
		}

		/// <summary>
		/// Unregister a simple shell context menu.
		/// </summary>
		/// <param name="fileType">The file type to unregister.</param>
		/// <param name="shellKeyName">Name that was registered in the registry.</param>
		public static void Unregister(string fileType, string shellKeyName)
		{
			// full path to the registry location			
			string regPath = string.Format(@"{0}\shell\{1}", fileType, shellKeyName);

			// remove context menu from the registry
			Registry.ClassesRoot.DeleteSubKeyTree(regPath);
		}
	}

}
