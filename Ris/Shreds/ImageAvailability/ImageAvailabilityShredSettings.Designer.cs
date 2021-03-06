//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Ris.Shreds.ImageAvailability {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class ImageAvailabilityShredSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ImageAvailabilityShredSettings defaultInstance = ((ImageAvailabilityShredSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ImageAvailabilityShredSettings())));
        
        public static ImageAvailabilityShredSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// AE title of this shred
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("AE title of this shred")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ImageAvailabilityScu")]
        public string DicomCallingAETitle {
            get {
                return ((string)(this["DicomCallingAETitle"]));
            }
        }
        
        /// <summary>
        /// AE title of DICOM server to query
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("AE title of DICOM server to query")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("serverAE")]
        public string DicomServerAETitle {
            get {
                return ((string)(this["DicomServerAETitle"]));
            }
        }
        
        /// <summary>
        /// Hostname of DICOM server to query
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Hostname of DICOM server to query")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("serverHost")]
        public string DicomServerHost {
            get {
                return ((string)(this["DicomServerHost"]));
            }
        }
        
        /// <summary>
        /// Port of DICOM server to query
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Port of DICOM server to query")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4006")]
        public int DicomServerPort {
            get {
                return ((int)(this["DicomServerPort"]));
            }
        }
        
        /// <summary>
        /// Number of items to pull from queue per read
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Number of items to pull from queue per read")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int BatchSize {
            get {
                return ((int)(this["BatchSize"]));
            }
        }
        
        /// <summary>
        /// Number of seconds to sleep when queue is empty
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Number of seconds to sleep when queue is empty")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int EmptyQueueSleepTime {
            get {
                return ((int)(this["EmptyQueueSleepTime"]));
            }
        }
        
        /// <summary>
        /// Queue item expiration time, in hours.  After expiration, image availability for the procedure will no longer be updated
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Queue item expiration time, in hours.  After expiration, image availability for t" +
            "he procedure will no longer be updated")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("24")]
        public int ExpirationTime {
            get {
                return ((int)(this["ExpirationTime"]));
            }
        }
        
        /// <summary>
        /// Specifies how often to poll the DICOM server when image availability is indeterminate (seconds)
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies how often to poll the DICOM server when image availability is indetermi" +
            "nate (seconds)")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("600")]
        public int PollingIntervalForIndeterminate {
            get {
                return ((int)(this["PollingIntervalForIndeterminate"]));
            }
        }
        
        /// <summary>
        /// Specifies how often to poll the DICOM server when image availability is zero (seconds)
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies how often to poll the DICOM server when image availability is zero (sec" +
            "onds)")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("600")]
        public int PollingIntervalForZero {
            get {
                return ((int)(this["PollingIntervalForZero"]));
            }
        }
        
        /// <summary>
        /// Specifies how often to poll the DICOM server when image availability is partial (seconds)
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies how often to poll the DICOM server when image availability is partial (" +
            "seconds)")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("300")]
        public int PollingIntervalForPartial {
            get {
                return ((int)(this["PollingIntervalForPartial"]));
            }
        }
        
        /// <summary>
        /// Specifies how often to poll the DICOM server when image availability is complete (seconds)
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies how often to poll the DICOM server when image availability is complete " +
            "(seconds)")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("600")]
        public int PollingIntervalForComplete {
            get {
                return ((int)(this["PollingIntervalForComplete"]));
            }
        }
        
        /// <summary>
        /// Specifies how often to poll the DICOM server when an error occured last attempt (seconds)
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies how often to poll the DICOM server when an error occured last attempt (" +
            "seconds)")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("600")]
        public int PollingIntervalForError {
            get {
                return ((int)(this["PollingIntervalForError"]));
            }
        }
    }
}
