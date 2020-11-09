﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/8/2020 8:07:52 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for ProductStyleGroupLineTranslationSingle in the schema.
        /// </summary>
    public partial class ProductStyleGroupLineTranslationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductStyleGroupLineTranslation>
    {
        /// <summary>
        /// Initialize a new ProductStyleGroupLineTranslationSingle object.
        /// </summary>
        public ProductStyleGroupLineTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductStyleGroupLineTranslationSingle object.
        /// </summary>
        public ProductStyleGroupLineTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductStyleGroupLineTranslationSingle object.
        /// </summary>
        public ProductStyleGroupLineTranslationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductStyleGroupLineTranslation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductStyleGroupLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductStyleGroupLineSingle ProductStyleGroupLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductStyleGroupLine == null))
                {
                    this._ProductStyleGroupLine = new global::Microsoft.Dynamics.DataEntities.ProductStyleGroupLineSingle(this.Context, GetPath("ProductStyleGroupLine"));
                }
                return this._ProductStyleGroupLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductStyleGroupLineSingle _ProductStyleGroupLine;
    }
        /// <summary>
        /// There are no comments for ProductStyleGroupLineTranslation in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ProductStyleGroupId
    /// ProductStyleId
    /// LanguageId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductStyleGroupId", "ProductStyleId", "LanguageId")]
    [global::Microsoft.OData.Client.EntitySet("ProductStyleGroupLineTranslations")]
    public partial class ProductStyleGroupLineTranslation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductStyleGroupLineTranslation object.
        /// </summary>
        /// <param name="productStyleGroupId">Initial value of ProductStyleGroupId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="languageId">Initial value of LanguageId.</param>
        /// <param name="productStyleGroupLine">Initial value of ProductStyleGroupLine.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductStyleGroupLineTranslation CreateProductStyleGroupLineTranslation(string productStyleGroupId, string productStyleId, string languageId, global::Microsoft.Dynamics.DataEntities.ProductStyleGroupLine productStyleGroupLine)
        {
            ProductStyleGroupLineTranslation productStyleGroupLineTranslation = new ProductStyleGroupLineTranslation();
            productStyleGroupLineTranslation.ProductStyleGroupId = productStyleGroupId;
            productStyleGroupLineTranslation.ProductStyleId = productStyleId;
            productStyleGroupLineTranslation.LanguageId = languageId;
            if ((productStyleGroupLine == null))
            {
                throw new global::System.ArgumentNullException("productStyleGroupLine");
            }
            productStyleGroupLineTranslation.ProductStyleGroupLine = productStyleGroupLine;
            return productStyleGroupLineTranslation;
        }
        /// <summary>
        /// There are no comments for Property ProductStyleGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductStyleGroupId
        {
            get
            {
                return this._ProductStyleGroupId;
            }
            set
            {
                this.OnProductStyleGroupIdChanging(value);
                this._ProductStyleGroupId = value;
                this.OnProductStyleGroupIdChanged();
                this.OnPropertyChanged("ProductStyleGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductStyleGroupId;
        partial void OnProductStyleGroupIdChanging(string value);
        partial void OnProductStyleGroupIdChanged();
        /// <summary>
        /// There are no comments for Property ProductStyleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductStyleId
        {
            get
            {
                return this._ProductStyleId;
            }
            set
            {
                this.OnProductStyleIdChanging(value);
                this._ProductStyleId = value;
                this.OnProductStyleIdChanged();
                this.OnPropertyChanged("ProductStyleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductStyleId;
        partial void OnProductStyleIdChanging(string value);
        partial void OnProductStyleIdChanged();
        /// <summary>
        /// There are no comments for Property LanguageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LanguageId
        {
            get
            {
                return this._LanguageId;
            }
            set
            {
                this.OnLanguageIdChanging(value);
                this._LanguageId = value;
                this.OnLanguageIdChanged();
                this.OnPropertyChanged("LanguageId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LanguageId;
        partial void OnLanguageIdChanging(string value);
        partial void OnLanguageIdChanged();
        /// <summary>
        /// There are no comments for Property TranslatedStyleDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TranslatedStyleDescription
        {
            get
            {
                return this._TranslatedStyleDescription;
            }
            set
            {
                this.OnTranslatedStyleDescriptionChanging(value);
                this._TranslatedStyleDescription = value;
                this.OnTranslatedStyleDescriptionChanged();
                this.OnPropertyChanged("TranslatedStyleDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TranslatedStyleDescription;
        partial void OnTranslatedStyleDescriptionChanging(string value);
        partial void OnTranslatedStyleDescriptionChanged();
        /// <summary>
        /// There are no comments for Property TranslatedStyleName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TranslatedStyleName
        {
            get
            {
                return this._TranslatedStyleName;
            }
            set
            {
                this.OnTranslatedStyleNameChanging(value);
                this._TranslatedStyleName = value;
                this.OnTranslatedStyleNameChanged();
                this.OnPropertyChanged("TranslatedStyleName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TranslatedStyleName;
        partial void OnTranslatedStyleNameChanging(string value);
        partial void OnTranslatedStyleNameChanged();
        /// <summary>
        /// There are no comments for Property ProductStyleGroupLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductStyleGroupLine ProductStyleGroupLine
        {
            get
            {
                return this._ProductStyleGroupLine;
            }
            set
            {
                this.OnProductStyleGroupLineChanging(value);
                this._ProductStyleGroupLine = value;
                this.OnProductStyleGroupLineChanged();
                this.OnPropertyChanged("ProductStyleGroupLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductStyleGroupLine _ProductStyleGroupLine;
        partial void OnProductStyleGroupLineChanging(global::Microsoft.Dynamics.DataEntities.ProductStyleGroupLine value);
        partial void OnProductStyleGroupLineChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
