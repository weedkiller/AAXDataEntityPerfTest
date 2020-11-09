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
        /// There are no comments for IssuingAgencySingle in the schema.
        /// </summary>
    public partial class IssuingAgencySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<IssuingAgency>
    {
        /// <summary>
        /// Initialize a new IssuingAgencySingle object.
        /// </summary>
        public IssuingAgencySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new IssuingAgencySingle object.
        /// </summary>
        public IssuingAgencySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new IssuingAgencySingle object.
        /// </summary>
        public IssuingAgencySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<IssuingAgency> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PersonIdentificationNumbers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumber> PersonIdentificationNumbers
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PersonIdentificationNumbers == null))
                {
                    this._PersonIdentificationNumbers = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumber>(GetPath("PersonIdentificationNumbers"));
                }
                return this._PersonIdentificationNumbers;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumber> _PersonIdentificationNumbers;
        /// <summary>
        /// There are no comments for i9DocumentTypes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.I9DocumentType> i9DocumentTypes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._i9DocumentTypes == null))
                {
                    this._i9DocumentTypes = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.I9DocumentType>(GetPath("i9DocumentTypes"));
                }
                return this._i9DocumentTypes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.I9DocumentType> _i9DocumentTypes;
    }
        /// <summary>
        /// There are no comments for IssuingAgency in the schema.
        /// </summary>
    /// <KeyProperties>
    /// IssuingAgency
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("IssuingAgency")]
    [global::Microsoft.OData.Client.EntitySet("IssuingAgencies")]
    public partial class IssuingAgency : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new IssuingAgency object.
        /// </summary>
        /// <param name="issuingAgency1">Initial value of IssuingAgency1.</param>
        /// <param name="addressValidTo">Initial value of AddressValidTo.</param>
        /// <param name="addressValidFrom">Initial value of AddressValidFrom.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static IssuingAgency CreateIssuingAgency(string issuingAgency1, global::System.DateTimeOffset addressValidTo, global::System.DateTimeOffset addressValidFrom)
        {
            IssuingAgency issuingAgency = new IssuingAgency();
            issuingAgency.IssuingAgency1 = issuingAgency1;
            issuingAgency.AddressValidTo = addressValidTo;
            issuingAgency.AddressValidFrom = addressValidFrom;
            return issuingAgency;
        }
        /// <summary>
        /// There are no comments for Property IssuingAgency1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("IssuingAgency")]
        public virtual string IssuingAgency1
        {
            get
            {
                return this._IssuingAgency1;
            }
            set
            {
                this.OnIssuingAgency1Changing(value);
                this._IssuingAgency1 = value;
                this.OnIssuingAgency1Changed();
                this.OnPropertyChanged("IssuingAgency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IssuingAgency1;
        partial void OnIssuingAgency1Changing(string value);
        partial void OnIssuingAgency1Changed();
        /// <summary>
        /// There are no comments for Property Extension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Extension
        {
            get
            {
                return this._Extension;
            }
            set
            {
                this.OnExtensionChanging(value);
                this._Extension = value;
                this.OnExtensionChanged();
                this.OnPropertyChanged("Extension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Extension;
        partial void OnExtensionChanging(string value);
        partial void OnExtensionChanged();
        /// <summary>
        /// There are no comments for Property AddressCountryRegionISOCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressCountryRegionISOCode
        {
            get
            {
                return this._AddressCountryRegionISOCode;
            }
            set
            {
                this.OnAddressCountryRegionISOCodeChanging(value);
                this._AddressCountryRegionISOCode = value;
                this.OnAddressCountryRegionISOCodeChanged();
                this.OnPropertyChanged("AddressCountryRegionISOCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressCountryRegionISOCode;
        partial void OnAddressCountryRegionISOCodeChanging(string value);
        partial void OnAddressCountryRegionISOCodeChanged();
        /// <summary>
        /// There are no comments for Property AddressDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressDescription
        {
            get
            {
                return this._AddressDescription;
            }
            set
            {
                this.OnAddressDescriptionChanging(value);
                this._AddressDescription = value;
                this.OnAddressDescriptionChanged();
                this.OnPropertyChanged("AddressDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressDescription;
        partial void OnAddressDescriptionChanging(string value);
        partial void OnAddressDescriptionChanged();
        /// <summary>
        /// There are no comments for Property TelexNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TelexNumber
        {
            get
            {
                return this._TelexNumber;
            }
            set
            {
                this.OnTelexNumberChanging(value);
                this._TelexNumber = value;
                this.OnTelexNumberChanged();
                this.OnPropertyChanged("TelexNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TelexNumber;
        partial void OnTelexNumberChanging(string value);
        partial void OnTelexNumberChanged();
        /// <summary>
        /// There are no comments for Property AddressCity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressCity
        {
            get
            {
                return this._AddressCity;
            }
            set
            {
                this.OnAddressCityChanging(value);
                this._AddressCity = value;
                this.OnAddressCityChanged();
                this.OnPropertyChanged("AddressCity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressCity;
        partial void OnAddressCityChanging(string value);
        partial void OnAddressCityChanged();
        /// <summary>
        /// There are no comments for Property AddressValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset AddressValidTo
        {
            get
            {
                return this._AddressValidTo;
            }
            set
            {
                this.OnAddressValidToChanging(value);
                this._AddressValidTo = value;
                this.OnAddressValidToChanged();
                this.OnPropertyChanged("AddressValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _AddressValidTo;
        partial void OnAddressValidToChanging(global::System.DateTimeOffset value);
        partial void OnAddressValidToChanged();
        /// <summary>
        /// There are no comments for Property AddressLocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressLocationId
        {
            get
            {
                return this._AddressLocationId;
            }
            set
            {
                this.OnAddressLocationIdChanging(value);
                this._AddressLocationId = value;
                this.OnAddressLocationIdChanged();
                this.OnPropertyChanged("AddressLocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressLocationId;
        partial void OnAddressLocationIdChanging(string value);
        partial void OnAddressLocationIdChanged();
        /// <summary>
        /// There are no comments for Property Pager in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Pager
        {
            get
            {
                return this._Pager;
            }
            set
            {
                this.OnPagerChanging(value);
                this._Pager = value;
                this.OnPagerChanged();
                this.OnPropertyChanged("Pager");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Pager;
        partial void OnPagerChanging(string value);
        partial void OnPagerChanged();
        /// <summary>
        /// There are no comments for Property AddressCounty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressCounty
        {
            get
            {
                return this._AddressCounty;
            }
            set
            {
                this.OnAddressCountyChanging(value);
                this._AddressCounty = value;
                this.OnAddressCountyChanged();
                this.OnPropertyChanged("AddressCounty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressCounty;
        partial void OnAddressCountyChanging(string value);
        partial void OnAddressCountyChanged();
        /// <summary>
        /// There are no comments for Property Email in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                this.OnEmailChanging(value);
                this._Email = value;
                this.OnEmailChanged();
                this.OnPropertyChanged("Email");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Email;
        partial void OnEmailChanging(string value);
        partial void OnEmailChanged();
        /// <summary>
        /// There are no comments for Property Fax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Fax
        {
            get
            {
                return this._Fax;
            }
            set
            {
                this.OnFaxChanging(value);
                this._Fax = value;
                this.OnFaxChanged();
                this.OnPropertyChanged("Fax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Fax;
        partial void OnFaxChanging(string value);
        partial void OnFaxChanged();
        /// <summary>
        /// There are no comments for Property AddressZipCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressZipCode
        {
            get
            {
                return this._AddressZipCode;
            }
            set
            {
                this.OnAddressZipCodeChanging(value);
                this._AddressZipCode = value;
                this.OnAddressZipCodeChanged();
                this.OnPropertyChanged("AddressZipCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressZipCode;
        partial void OnAddressZipCodeChanging(string value);
        partial void OnAddressZipCodeChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property AddressStreet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressStreet
        {
            get
            {
                return this._AddressStreet;
            }
            set
            {
                this.OnAddressStreetChanging(value);
                this._AddressStreet = value;
                this.OnAddressStreetChanged();
                this.OnPropertyChanged("AddressStreet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressStreet;
        partial void OnAddressStreetChanging(string value);
        partial void OnAddressStreetChanged();
        /// <summary>
        /// There are no comments for Property AddressCountryRegionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressCountryRegionId
        {
            get
            {
                return this._AddressCountryRegionId;
            }
            set
            {
                this.OnAddressCountryRegionIdChanging(value);
                this._AddressCountryRegionId = value;
                this.OnAddressCountryRegionIdChanged();
                this.OnPropertyChanged("AddressCountryRegionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressCountryRegionId;
        partial void OnAddressCountryRegionIdChanging(string value);
        partial void OnAddressCountryRegionIdChanged();
        /// <summary>
        /// There are no comments for Property InternetAddress in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InternetAddress
        {
            get
            {
                return this._InternetAddress;
            }
            set
            {
                this.OnInternetAddressChanging(value);
                this._InternetAddress = value;
                this.OnInternetAddressChanged();
                this.OnPropertyChanged("InternetAddress");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InternetAddress;
        partial void OnInternetAddressChanging(string value);
        partial void OnInternetAddressChanged();
        /// <summary>
        /// There are no comments for Property MobilePhone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MobilePhone
        {
            get
            {
                return this._MobilePhone;
            }
            set
            {
                this.OnMobilePhoneChanging(value);
                this._MobilePhone = value;
                this.OnMobilePhoneChanged();
                this.OnPropertyChanged("MobilePhone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MobilePhone;
        partial void OnMobilePhoneChanging(string value);
        partial void OnMobilePhoneChanged();
        /// <summary>
        /// There are no comments for Property AddressState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressState
        {
            get
            {
                return this._AddressState;
            }
            set
            {
                this.OnAddressStateChanging(value);
                this._AddressState = value;
                this.OnAddressStateChanged();
                this.OnPropertyChanged("AddressState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressState;
        partial void OnAddressStateChanging(string value);
        partial void OnAddressStateChanged();
        /// <summary>
        /// There are no comments for Property SMS in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SMS
        {
            get
            {
                return this._SMS;
            }
            set
            {
                this.OnSMSChanging(value);
                this._SMS = value;
                this.OnSMSChanged();
                this.OnPropertyChanged("SMS");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SMS;
        partial void OnSMSChanging(string value);
        partial void OnSMSChanged();
        /// <summary>
        /// There are no comments for Property Telephone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Telephone
        {
            get
            {
                return this._Telephone;
            }
            set
            {
                this.OnTelephoneChanging(value);
                this._Telephone = value;
                this.OnTelephoneChanged();
                this.OnPropertyChanged("Telephone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Telephone;
        partial void OnTelephoneChanging(string value);
        partial void OnTelephoneChanged();
        /// <summary>
        /// There are no comments for Property AddressValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset AddressValidFrom
        {
            get
            {
                return this._AddressValidFrom;
            }
            set
            {
                this.OnAddressValidFromChanging(value);
                this._AddressValidFrom = value;
                this.OnAddressValidFromChanged();
                this.OnPropertyChanged("AddressValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _AddressValidFrom;
        partial void OnAddressValidFromChanging(global::System.DateTimeOffset value);
        partial void OnAddressValidFromChanged();
        /// <summary>
        /// There are no comments for Property PersonIdentificationNumbers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumber> PersonIdentificationNumbers
        {
            get
            {
                return this._PersonIdentificationNumbers;
            }
            set
            {
                this.OnPersonIdentificationNumbersChanging(value);
                this._PersonIdentificationNumbers = value;
                this.OnPersonIdentificationNumbersChanged();
                this.OnPropertyChanged("PersonIdentificationNumbers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumber> _PersonIdentificationNumbers = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumber>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPersonIdentificationNumbersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumber> value);
        partial void OnPersonIdentificationNumbersChanged();
        /// <summary>
        /// There are no comments for Property i9DocumentTypes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.I9DocumentType> i9DocumentTypes
        {
            get
            {
                return this._i9DocumentTypes;
            }
            set
            {
                this.Oni9DocumentTypesChanging(value);
                this._i9DocumentTypes = value;
                this.Oni9DocumentTypesChanged();
                this.OnPropertyChanged("i9DocumentTypes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.I9DocumentType> _i9DocumentTypes = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.I9DocumentType>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void Oni9DocumentTypesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.I9DocumentType> value);
        partial void Oni9DocumentTypesChanged();
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
