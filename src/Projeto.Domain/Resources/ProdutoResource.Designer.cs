﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto.Domain.Resources {
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
    public class ProdutoResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ProdutoResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Projeto.Domain.Resources.ProdutoResource", typeof(ProdutoResource).Assembly);
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
        ///   Looks up a localized string similar to Falha inesperada ao inserir produto na base..
        /// </summary>
        public static string DbCreateUnexpectedError {
            get {
                return ResourceManager.GetString("DbCreateUnexpectedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Falha inesperada ao excluir produto da base..
        /// </summary>
        public static string DbDeleteUnexpectedError {
            get {
                return ResourceManager.GetString("DbDeleteUnexpectedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ocorreu um erro inesperado ao {0} o produto {1}..
        /// </summary>
        public static string ExceptionUnexpectedly {
            get {
                return ResourceManager.GetString("ExceptionUnexpectedly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tamanho do Nome inválido..
        /// </summary>
        public static string NomeMaximumLength {
            get {
                return ResourceManager.GetString("NomeMaximumLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nome é obrigatório.
        /// </summary>
        public static string NomeRequired {
            get {
                return ResourceManager.GetString("NomeRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SKU informado não pertence ao produto informado..
        /// </summary>
        public static string SkuIncorret {
            get {
                return ResourceManager.GetString("SkuIncorret", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SKU informado já está em uso..
        /// </summary>
        public static string SkuInUse {
            get {
                return ResourceManager.GetString("SkuInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SKU informado não existe..
        /// </summary>
        public static string SkuNotFound {
            get {
                return ResourceManager.GetString("SkuNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SKU é obrigatório..
        /// </summary>
        public static string SkuRequired {
            get {
                return ResourceManager.GetString("SkuRequired", resourceCulture);
            }
        }
    }
}
