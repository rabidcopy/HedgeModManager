﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SLWModLoader.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SLWModLoader.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to SLW Mod Loader.
        /// </summary>
        internal static string ApplicationTitle {
            get {
                return ResourceManager.GetString("ApplicationTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SLW Mod Loader could not find a game executable in its startup directory. 
        ///The mod loader can attempt to look for your game and install itself automatically.
        ///.
        /// </summary>
        internal static string CannotFindExecutableText {
            get {
                return ResourceManager.GetString("CannotFindExecutableText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A &quot;mods&quot; folder must exist within your game installation directory for the mod loader to correctly function. Would you like to create one?.
        /// </summary>
        internal static string CannotFindModsDirectoryText {
            get {
                return ResourceManager.GetString("CannotFindModsDirectoryText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] Disable_Blue_Trail {
            get {
                object obj = ResourceManager.GetObject("Disable_Blue_Trail", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] Disable_FxPipeline {
            get {
                object obj = ResourceManager.GetObject("Disable_FxPipeline", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] Enable_Blue_Trail {
            get {
                object obj = ResourceManager.GetObject("Enable_Blue_Trail", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] Enable_FxPipeline {
            get {
                object obj = ResourceManager.GetObject("Enable_FxPipeline", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured! See &quot;SLWModLoader.log&quot; for more info and report the file if possible..
        /// </summary>
        internal static string ExceptionText {
            get {
                return ResourceManager.GetString("ExceptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} executable has not yet been patched for use with CPKREDIR, which is required to load mods.
        ///Would you like to patch the executable now?.
        /// </summary>
        internal static string ExecutableNotPatchedText {
            get {
                return ResourceManager.GetString("ExecutableNotPatchedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icon96 {
            get {
                object obj = ResourceManager.GetObject("icon96", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The mod &quot;{0}&quot; has an invalid includeDir ({1})
        ///Do you want SLWModLoader to attempt to fix this?.
        /// </summary>
        internal static string InvalidIncludeDirText {
            get {
                return ResourceManager.GetString("InvalidIncludeDirText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We have detected that you&apos;re using a pirated copy of {0}. Please purchase {0} off the Steam store..
        /// </summary>
        internal static string PiracyText {
            get {
                return ResourceManager.GetString("PiracyText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] update {
            get {
                object obj = ResourceManager.GetObject("update", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
