﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common.Utils.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class GeneralMessage {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal GeneralMessage() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Common.Utils.Resources.GeneralMessage", typeof(GeneralMessage).Assembly);
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
        ///   Looks up a localized string similar to Error interno en la aplicación.
        /// </summary>
        public static string Error500 {
            get {
                return ResourceManager.GetString("Error500", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Propiedad no encontrada.
        /// </summary>
        public static string NoFoundProperty {
            get {
                return ResourceManager.GetString("NoFoundProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error al asociar imagen..
        /// </summary>
        public static string PropertyAddImageError {
            get {
                return ResourceManager.GetString("PropertyAddImageError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Imagen asociada exitosamente..
        /// </summary>
        public static string PropertyAddImageSuccess {
            get {
                return ResourceManager.GetString("PropertyAddImageSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No se pudo guardar propiedad.
        /// </summary>
        public static string PropertySaveError {
            get {
                return ResourceManager.GetString("PropertySaveError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Propiedad guardada existosamente..
        /// </summary>
        public static string PropertySaveSuccess {
            get {
                return ResourceManager.GetString("PropertySaveSuccess", resourceCulture);
            }
        }
    }
}
