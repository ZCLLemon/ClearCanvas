//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Ris.Server {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ClearCanvas.Ris.Server.SR", typeof(SR).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This shred hosts the Ris Server..
        /// </summary>
        internal static string MessageRisServerDescription {
            get {
                return ResourceManager.GetString("MessageRisServerDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Ris Server has failed to start.  Please check the log for more details..
        /// </summary>
        internal static string ServiceFailedToStart {
            get {
                return ResourceManager.GetString("ServiceFailedToStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Ris Server has failed to stop.  Please check the log for more details..
        /// </summary>
        internal static string ServiceFailedToStop {
            get {
                return ResourceManager.GetString("ServiceFailedToStop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Ris Server has started successfully..
        /// </summary>
        internal static string ServiceStartedSuccessfully {
            get {
                return ResourceManager.GetString("ServiceStartedSuccessfully", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Ris Server has stopped successfully..
        /// </summary>
        internal static string ServiceStoppedSuccessfully {
            get {
                return ResourceManager.GetString("ServiceStoppedSuccessfully", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ris Server.
        /// </summary>
        internal static string TitleRisServer {
            get {
                return ResourceManager.GetString("TitleRisServer", resourceCulture);
            }
        }
    }
}
