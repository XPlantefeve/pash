﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Management.Automation {
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
    public class GetErrorText {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal GetErrorText() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Management.Automation.GetErrorText", typeof(GetErrorText).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command execution stopped due to the Stop policy..
        /// </summary>
        public static string ActionPreferenceStop {
            get {
                return ResourceManager.GetString("ActionPreferenceStop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot retrieve message &quot;{0}&quot; &quot;{1}&quot; &quot;{2}&quot; because assembly was not registered..
        /// </summary>
        public static string AssemblyNotRegistered {
            get {
                return ResourceManager.GetString("AssemblyNotRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot retrieve message &quot;{0}&quot; &quot;{1}&quot; &quot;{2}&quot;. Template string format is not valid in template string &quot;{3}&quot;..
        /// </summary>
        public static string BadTemplate {
            get {
                return ResourceManager.GetString("BadTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot retrieve message &quot;{0}&quot; &quot;{1}&quot; &quot;{2}&quot;. Template string exists but is blank..
        /// </summary>
        public static string BlankTemplate {
            get {
                return ResourceManager.GetString("BlankTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The pipeline failed due to call depth overflow..
        /// </summary>
        public static string PipelineDepthException {
            get {
                return ResourceManager.GetString("PipelineDepthException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The pipeline has been stopped..
        /// </summary>
        public static string PipelineStoppedException {
            get {
                return ResourceManager.GetString("PipelineStoppedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot load resource with base name &quot;{0}&quot;..
        /// </summary>
        public static string ResourceBaseNameFailure {
            get {
                return ResourceManager.GetString("ResourceBaseNameFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot load resource string with ID &quot;{0}&quot;..
        /// </summary>
        public static string ResourceIdFailure {
            get {
                return ResourceManager.GetString("ResourceIdFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The script failed due to call depth overflow..
        /// </summary>
        public static string ScriptCallDepthException {
            get {
                return ResourceManager.GetString("ScriptCallDepthException", resourceCulture);
            }
        }
    }
}
