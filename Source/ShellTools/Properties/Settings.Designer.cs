﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShellTools.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>ShellTools.Commands.CopyPathCommand, ShellTools</string>
  <string>ShellTools.Commands.CopyNameCommand, ShellTools</string>
  <string>ShellTools.Commands.RelativeCommand, ShellTools</string>
  <string>ShellTools.Commands.FileRenameCommand, ShellTools</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection CommandTypes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["CommandTypes"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string RenameSearchPattern {
            get {
                return ((string)(this["RenameSearchPattern"]));
            }
            set {
                this["RenameSearchPattern"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string RenameReplacePattern {
            get {
                return ((string)(this["RenameReplacePattern"]));
            }
            set {
                this["RenameReplacePattern"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SourceFolder {
            get {
                return ((string)(this["SourceFolder"]));
            }
            set {
                this["SourceFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Drawing.Size FileRenameSize {
            get {
                return ((global::System.Drawing.Size)(this["FileRenameSize"]));
            }
            set {
                this["FileRenameSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool RenameIgnoreCase {
            get {
                return ((bool)(this["RenameIgnoreCase"]));
            }
            set {
                this["RenameIgnoreCase"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RenameIncludeSubfolders {
            get {
                return ((bool)(this["RenameIncludeSubfolders"]));
            }
            set {
                this["RenameIncludeSubfolders"] = value;
            }
        }
    }
}
