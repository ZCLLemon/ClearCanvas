//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Enterprise.Configuration {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class ConfigurationStoreSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ConfigurationStoreSettings defaultInstance = ((ConfigurationStoreSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ConfigurationStoreSettings())));
        
        public static ConfigurationStoreSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Specifies whether configuration document caching is enabled.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies whether configuration document caching is enabled.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ConfigurationCachingEnabled {
            get {
                return ((bool)(this["ConfigurationCachingEnabled"]));
            }
        }
        
        /// <summary>
        /// Specifies configuration document cache TTL in seconds.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies configuration document cache TTL in seconds.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public int ConfigurationCachingTimeToLiveSeconds {
            get {
                return ((int)(this["ConfigurationCachingTimeToLiveSeconds"]));
            }
        }
        
        /// <summary>
        /// Specifies whether settings meta-data caching is enabled.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies whether settings meta-data caching is enabled.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SettingsMetadataCachingEnabled {
            get {
                return ((bool)(this["SettingsMetadataCachingEnabled"]));
            }
        }
        
        /// <summary>
        /// Specifies settings meta-data cache TTL in seconds.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies settings meta-data cache TTL in seconds.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("180")]
        public int SettingsMetadataCachingTimeToLiveSeconds {
            get {
                return ((int)(this["SettingsMetadataCachingTimeToLiveSeconds"]));
            }
        }
    }
}
