﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 1/20/2021 5:35:39 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for FinancialDimensionValueTranslationSingle in the schema.
        /// </summary>
    public partial class FinancialDimensionValueTranslationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FinancialDimensionValueTranslation>
    {
        /// <summary>
        /// Initialize a new FinancialDimensionValueTranslationSingle object.
        /// </summary>
        public FinancialDimensionValueTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FinancialDimensionValueTranslationSingle object.
        /// </summary>
        public FinancialDimensionValueTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FinancialDimensionValueTranslationSingle object.
        /// </summary>
        public FinancialDimensionValueTranslationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FinancialDimensionValueTranslation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for FinancialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionAttributeSingle FinancialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FinancialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity == null))
                {
                    this._FinancialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity = new global::Microsoft.Dynamics.DataEntities.DimensionAttributeSingle(this.Context, GetPath("FinancialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity"));
                }
                return this._FinancialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionAttributeSingle _FinancialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity;
    }
        /// <summary>
        /// There are no comments for FinancialDimensionValueTranslation in the schema.
        /// </summary>
    /// <KeyProperties>
    /// FinancialDimension
    /// LanguageCode
    /// FinancialDimensionValue
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("FinancialDimension", "LanguageCode", "FinancialDimensionValue")]
    [global::Microsoft.OData.Client.EntitySet("FinancialDimensionValueTranslations")]
    public partial class FinancialDimensionValueTranslation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FinancialDimensionValueTranslation object.
        /// </summary>
        /// <param name="financialDimension">Initial value of FinancialDimension.</param>
        /// <param name="languageCode">Initial value of LanguageCode.</param>
        /// <param name="financialDimensionValue">Initial value of FinancialDimensionValue.</param>
        /// <param name="financialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity">Initial value of FinancialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FinancialDimensionValueTranslation CreateFinancialDimensionValueTranslation(string financialDimension, string languageCode, string financialDimensionValue, global::Microsoft.Dynamics.DataEntities.DimensionAttribute financialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity)
        {
            FinancialDimensionValueTranslation financialDimensionValueTranslation = new FinancialDimensionValueTranslation();
            financialDimensionValueTranslation.FinancialDimension = financialDimension;
            financialDimensionValueTranslation.LanguageCode = languageCode;
            financialDimensionValueTranslation.FinancialDimensionValue = financialDimensionValue;
            if ((financialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity == null))
            {
                throw new global::System.ArgumentNullException("financialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity");
            }
            financialDimensionValueTranslation.FinancialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity = financialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity;
            return financialDimensionValueTranslation;
        }
        /// <summary>
        /// There are no comments for Property FinancialDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FinancialDimension
        {
            get
            {
                return this._FinancialDimension;
            }
            set
            {
                this.OnFinancialDimensionChanging(value);
                this._FinancialDimension = value;
                this.OnFinancialDimensionChanged();
                this.OnPropertyChanged("FinancialDimension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FinancialDimension;
        partial void OnFinancialDimensionChanging(string value);
        partial void OnFinancialDimensionChanged();
        /// <summary>
        /// There are no comments for Property LanguageCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LanguageCode
        {
            get
            {
                return this._LanguageCode;
            }
            set
            {
                this.OnLanguageCodeChanging(value);
                this._LanguageCode = value;
                this.OnLanguageCodeChanged();
                this.OnPropertyChanged("LanguageCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LanguageCode;
        partial void OnLanguageCodeChanging(string value);
        partial void OnLanguageCodeChanged();
        /// <summary>
        /// There are no comments for Property FinancialDimensionValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FinancialDimensionValue
        {
            get
            {
                return this._FinancialDimensionValue;
            }
            set
            {
                this.OnFinancialDimensionValueChanging(value);
                this._FinancialDimensionValue = value;
                this.OnFinancialDimensionValueChanged();
                this.OnPropertyChanged("FinancialDimensionValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FinancialDimensionValue;
        partial void OnFinancialDimensionValueChanging(string value);
        partial void OnFinancialDimensionValueChanged();
        /// <summary>
        /// There are no comments for Property TranslatedDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TranslatedDescription
        {
            get
            {
                return this._TranslatedDescription;
            }
            set
            {
                this.OnTranslatedDescriptionChanging(value);
                this._TranslatedDescription = value;
                this.OnTranslatedDescriptionChanged();
                this.OnPropertyChanged("TranslatedDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TranslatedDescription;
        partial void OnTranslatedDescriptionChanging(string value);
        partial void OnTranslatedDescriptionChanged();
        /// <summary>
        /// There are no comments for Property FinancialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionAttribute FinancialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity
        {
            get
            {
                return this._FinancialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity;
            }
            set
            {
                this.OnFinancialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntityChanging(value);
                this._FinancialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity = value;
                this.OnFinancialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntityChanged();
                this.OnPropertyChanged("FinancialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionAttribute _FinancialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntity;
        partial void OnFinancialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntityChanging(global::Microsoft.Dynamics.DataEntities.DimensionAttribute value);
        partial void OnFinancialDimensionValueTranslationEntity_RelatedRole_DimensionAttributeEntityChanged();
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
