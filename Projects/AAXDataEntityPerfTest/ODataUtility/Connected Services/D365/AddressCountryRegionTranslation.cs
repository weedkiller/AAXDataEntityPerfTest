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
        /// There are no comments for AddressCountryRegionTranslationSingle in the schema.
        /// </summary>
    public partial class AddressCountryRegionTranslationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AddressCountryRegionTranslation>
    {
        /// <summary>
        /// Initialize a new AddressCountryRegionTranslationSingle object.
        /// </summary>
        public AddressCountryRegionTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AddressCountryRegionTranslationSingle object.
        /// </summary>
        public AddressCountryRegionTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AddressCountryRegionTranslationSingle object.
        /// </summary>
        public AddressCountryRegionTranslationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AddressCountryRegionTranslation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AddressCountryRegion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressCountryRegionSingle AddressCountryRegion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AddressCountryRegion == null))
                {
                    this._AddressCountryRegion = new global::Microsoft.Dynamics.DataEntities.AddressCountryRegionSingle(this.Context, GetPath("AddressCountryRegion"));
                }
                return this._AddressCountryRegion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressCountryRegionSingle _AddressCountryRegion;
    }
        /// <summary>
        /// There are no comments for AddressCountryRegionTranslation in the schema.
        /// </summary>
    /// <KeyProperties>
    /// CountryRegionId
    /// LanguageId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CountryRegionId", "LanguageId")]
    [global::Microsoft.OData.Client.EntitySet("AddressCountryRegionTranslations")]
    public partial class AddressCountryRegionTranslation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AddressCountryRegionTranslation object.
        /// </summary>
        /// <param name="countryRegionId">Initial value of CountryRegionId.</param>
        /// <param name="languageId">Initial value of LanguageId.</param>
        /// <param name="addressCountryRegion">Initial value of AddressCountryRegion.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AddressCountryRegionTranslation CreateAddressCountryRegionTranslation(string countryRegionId, string languageId, global::Microsoft.Dynamics.DataEntities.AddressCountryRegion addressCountryRegion)
        {
            AddressCountryRegionTranslation addressCountryRegionTranslation = new AddressCountryRegionTranslation();
            addressCountryRegionTranslation.CountryRegionId = countryRegionId;
            addressCountryRegionTranslation.LanguageId = languageId;
            if ((addressCountryRegion == null))
            {
                throw new global::System.ArgumentNullException("addressCountryRegion");
            }
            addressCountryRegionTranslation.AddressCountryRegion = addressCountryRegion;
            return addressCountryRegionTranslation;
        }
        /// <summary>
        /// There are no comments for Property CountryRegionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CountryRegionId
        {
            get
            {
                return this._CountryRegionId;
            }
            set
            {
                this.OnCountryRegionIdChanging(value);
                this._CountryRegionId = value;
                this.OnCountryRegionIdChanged();
                this.OnPropertyChanged("CountryRegionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryRegionId;
        partial void OnCountryRegionIdChanging(string value);
        partial void OnCountryRegionIdChanged();
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
        /// There are no comments for Property LongName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LongName
        {
            get
            {
                return this._LongName;
            }
            set
            {
                this.OnLongNameChanging(value);
                this._LongName = value;
                this.OnLongNameChanged();
                this.OnPropertyChanged("LongName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LongName;
        partial void OnLongNameChanging(string value);
        partial void OnLongNameChanged();
        /// <summary>
        /// There are no comments for Property ShortName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ShortName
        {
            get
            {
                return this._ShortName;
            }
            set
            {
                this.OnShortNameChanging(value);
                this._ShortName = value;
                this.OnShortNameChanged();
                this.OnPropertyChanged("ShortName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShortName;
        partial void OnShortNameChanging(string value);
        partial void OnShortNameChanged();
        /// <summary>
        /// There are no comments for Property AddressCountryRegion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressCountryRegion AddressCountryRegion
        {
            get
            {
                return this._AddressCountryRegion;
            }
            set
            {
                this.OnAddressCountryRegionChanging(value);
                this._AddressCountryRegion = value;
                this.OnAddressCountryRegionChanged();
                this.OnPropertyChanged("AddressCountryRegion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressCountryRegion _AddressCountryRegion;
        partial void OnAddressCountryRegionChanging(global::Microsoft.Dynamics.DataEntities.AddressCountryRegion value);
        partial void OnAddressCountryRegionChanged();
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
