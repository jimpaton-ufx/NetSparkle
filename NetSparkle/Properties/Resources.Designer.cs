﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetSparkle.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NetSparkle.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Error!.
        /// </summary>
        internal static string DefaultNetSparkleUIFactory_ErrorTitle {
            get {
                return ResourceManager.GetString("DefaultNetSparkleUIFactory_ErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Info.
        /// </summary>
        internal static string DefaultNetSparkleUIFactory_MessageTitle {
            get {
                return ResourceManager.GetString("DefaultNetSparkleUIFactory_MessageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, either you aren&apos;t connected to the internet, or our server is having a problem..
        /// </summary>
        internal static string DefaultNetSparkleUIFactory_ShowCannotDownloadAppcastMessage {
            get {
                return ResourceManager.GetString("DefaultNetSparkleUIFactory_ShowCannotDownloadAppcastMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, there was a problem attempting to download the update
        ///
        ///{0}.
        /// </summary>
        internal static string DefaultNetSparkleUIFactory_ShowDownloadErrorMessage {
            get {
                return ResourceManager.GetString("DefaultNetSparkleUIFactory_ShowDownloadErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updater not supported, please execute {0} manually.
        /// </summary>
        internal static string DefaultNetSparkleUIFactory_ShowUnknownInstallerFormatMessageText {
            get {
                return ResourceManager.GetString("DefaultNetSparkleUIFactory_ShowUnknownInstallerFormatMessageText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have elected to skip this version..
        /// </summary>
        internal static string DefaultNetSparkleUIFactory_ShowVersionIsSkippedByUserRequestMessage {
            get {
                return ResourceManager.GetString("DefaultNetSparkleUIFactory_ShowVersionIsSkippedByUserRequestMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your current version is up to date..
        /// </summary>
        internal static string DefaultNetSparkleUIFactory_ShowVersionIsUpToDateMessage {
            get {
                return ResourceManager.GetString("DefaultNetSparkleUIFactory_ShowVersionIsUpToDateMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to more information.
        /// </summary>
        internal static string DefaultNetSparkleUIFactory_ToastCallToAction {
            get {
                return ResourceManager.GetString("DefaultNetSparkleUIFactory_ToastCallToAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New Version Available.
        /// </summary>
        internal static string DefaultNetSparkleUIFactory_ToastMessage {
            get {
                return ResourceManager.GetString("DefaultNetSparkleUIFactory_ToastMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap software_update_available1 {
            get {
                object obj = ResourceManager.GetObject("software_update_available1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
