﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WBFSManager.Properties {
    
    
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
        [global::System.Configuration.DefaultSettingValueAttribute("<path>C:\\utorrent</path><path>W:\\utorrent</path><path>X:\\utorrent</path>")]
        public string FileFolderPaths {
            get {
                return ((string)(this["FileFolderPaths"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0/1/2/3/4/5/6/7/8/9/10/11/12/13/14/15/16")]
        public string FileFolderGridViewColumnOrdering {
            get {
                return ((string)(this["FileFolderGridViewColumnOrdering"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1")]
        public string FileFolderGridViewColumnVisibility {
            get {
                return ((string)(this["FileFolderGridViewColumnVisibility"]));
            }
            set {
                this["FileFolderGridViewColumnVisibility"] = value;
            }
        }
    }
}
