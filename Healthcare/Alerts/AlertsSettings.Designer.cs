//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Healthcare.Alerts {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class AlertsSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static AlertsSettings defaultInstance = ((AlertsSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new AlertsSettings())));
        
        public static AlertsSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Comma separated list of language codes that are considered commonly spoken and understood, and hence do not generate a language alert
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Comma separated list of language codes that are considered commonly spoken and un" +
            "derstood, and hence do not generate a language alert")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en")]
        public string CommonSpokenLanguages {
            get {
                return ((string)(this["CommonSpokenLanguages"]));
            }
        }
        
        /// <summary>
        /// Causes an Incomplete Demographic Data alert to be generated if the healthcard information on a patient profie is incomplete.  Generally useful only in Canada.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Causes an Incomplete Demographic Data alert to be generated if the healthcard inf" +
            "ormation on a patient profie is incomplete.  Generally useful only in Canada.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MissingHealthcardInfoTriggersIncompleteDemographicDataAlert {
            get {
                return ((bool)(this["MissingHealthcardInfoTriggersIncompleteDemographicDataAlert"]));
            }
        }
    }
}
