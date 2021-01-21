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
        /// There are no comments for AddressPostalCodeV3Single in the schema.
        /// </summary>
    public partial class AddressPostalCodeV3Single : global::Microsoft.OData.Client.DataServiceQuerySingle<AddressPostalCodeV3>
    {
        /// <summary>
        /// Initialize a new AddressPostalCodeV3Single object.
        /// </summary>
        public AddressPostalCodeV3Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AddressPostalCodeV3Single object.
        /// </summary>
        public AddressPostalCodeV3Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AddressPostalCodeV3Single object.
        /// </summary>
        public AddressPostalCodeV3Single(global::Microsoft.OData.Client.DataServiceQuerySingle<AddressPostalCodeV3> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetLocation> AssetLocation
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetLocation == null))
                {
                    this._AssetLocation = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetLocation>(GetPath("AssetLocation"));
                }
                return this._AssetLocation;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetLocation> _AssetLocation;
    }
        /// <summary>
        /// There are no comments for AddressPostalCodeV3 in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ZipCode
    /// CountryRegionId
    /// StateId
    /// CountyId
    /// CityId
    /// DistrictId
    /// StreetNumberMinimum
    /// StreetNumberMaximum
    /// StreetNumberValidity
    /// Street
    /// TimeZone
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ZipCode", "CountryRegionId", "StateId", "CountyId", "CityId", "DistrictId", "StreetNumberMinimum", "StreetNumberMaximum", "StreetNumberValidity", "Street", "TimeZone")]
    [global::Microsoft.OData.Client.EntitySet("AddressPostalCodesV3")]
    public partial class AddressPostalCodeV3 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AddressPostalCodeV3 object.
        /// </summary>
        /// <param name="zipCode">Initial value of ZipCode.</param>
        /// <param name="countryRegionId">Initial value of CountryRegionId.</param>
        /// <param name="stateId">Initial value of StateId.</param>
        /// <param name="countyId">Initial value of CountyId.</param>
        /// <param name="cityId">Initial value of CityId.</param>
        /// <param name="districtId">Initial value of DistrictId.</param>
        /// <param name="streetNumberMinimum">Initial value of StreetNumberMinimum.</param>
        /// <param name="streetNumberMaximum">Initial value of StreetNumberMaximum.</param>
        /// <param name="street">Initial value of Street.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AddressPostalCodeV3 CreateAddressPostalCodeV3(string zipCode, 
                    string countryRegionId, 
                    string stateId, 
                    string countyId, 
                    string cityId, 
                    string districtId, 
                    int streetNumberMinimum, 
                    int streetNumberMaximum, 
                    string street)
        {
            AddressPostalCodeV3 addressPostalCodeV3 = new AddressPostalCodeV3();
            addressPostalCodeV3.ZipCode = zipCode;
            addressPostalCodeV3.CountryRegionId = countryRegionId;
            addressPostalCodeV3.StateId = stateId;
            addressPostalCodeV3.CountyId = countyId;
            addressPostalCodeV3.CityId = cityId;
            addressPostalCodeV3.DistrictId = districtId;
            addressPostalCodeV3.StreetNumberMinimum = streetNumberMinimum;
            addressPostalCodeV3.StreetNumberMaximum = streetNumberMaximum;
            addressPostalCodeV3.Street = street;
            return addressPostalCodeV3;
        }
        /// <summary>
        /// There are no comments for Property ZipCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ZipCode
        {
            get
            {
                return this._ZipCode;
            }
            set
            {
                this.OnZipCodeChanging(value);
                this._ZipCode = value;
                this.OnZipCodeChanged();
                this.OnPropertyChanged("ZipCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ZipCode;
        partial void OnZipCodeChanging(string value);
        partial void OnZipCodeChanged();
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
        /// There are no comments for Property StateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string StateId
        {
            get
            {
                return this._StateId;
            }
            set
            {
                this.OnStateIdChanging(value);
                this._StateId = value;
                this.OnStateIdChanged();
                this.OnPropertyChanged("StateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StateId;
        partial void OnStateIdChanging(string value);
        partial void OnStateIdChanged();
        /// <summary>
        /// There are no comments for Property CountyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CountyId
        {
            get
            {
                return this._CountyId;
            }
            set
            {
                this.OnCountyIdChanging(value);
                this._CountyId = value;
                this.OnCountyIdChanged();
                this.OnPropertyChanged("CountyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountyId;
        partial void OnCountyIdChanging(string value);
        partial void OnCountyIdChanged();
        /// <summary>
        /// There are no comments for Property CityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CityId
        {
            get
            {
                return this._CityId;
            }
            set
            {
                this.OnCityIdChanging(value);
                this._CityId = value;
                this.OnCityIdChanged();
                this.OnPropertyChanged("CityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CityId;
        partial void OnCityIdChanging(string value);
        partial void OnCityIdChanged();
        /// <summary>
        /// There are no comments for Property DistrictId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DistrictId
        {
            get
            {
                return this._DistrictId;
            }
            set
            {
                this.OnDistrictIdChanging(value);
                this._DistrictId = value;
                this.OnDistrictIdChanged();
                this.OnPropertyChanged("DistrictId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DistrictId;
        partial void OnDistrictIdChanging(string value);
        partial void OnDistrictIdChanged();
        /// <summary>
        /// There are no comments for Property StreetNumberMinimum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int StreetNumberMinimum
        {
            get
            {
                return this._StreetNumberMinimum;
            }
            set
            {
                this.OnStreetNumberMinimumChanging(value);
                this._StreetNumberMinimum = value;
                this.OnStreetNumberMinimumChanged();
                this.OnPropertyChanged("StreetNumberMinimum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _StreetNumberMinimum;
        partial void OnStreetNumberMinimumChanging(int value);
        partial void OnStreetNumberMinimumChanged();
        /// <summary>
        /// There are no comments for Property StreetNumberMaximum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int StreetNumberMaximum
        {
            get
            {
                return this._StreetNumberMaximum;
            }
            set
            {
                this.OnStreetNumberMaximumChanging(value);
                this._StreetNumberMaximum = value;
                this.OnStreetNumberMaximumChanged();
                this.OnPropertyChanged("StreetNumberMaximum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _StreetNumberMaximum;
        partial void OnStreetNumberMaximumChanging(int value);
        partial void OnStreetNumberMaximumChanged();
        /// <summary>
        /// There are no comments for Property StreetNumberValidity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AllEvenOdd> StreetNumberValidity
        {
            get
            {
                return this._StreetNumberValidity;
            }
            set
            {
                this.OnStreetNumberValidityChanging(value);
                this._StreetNumberValidity = value;
                this.OnStreetNumberValidityChanged();
                this.OnPropertyChanged("StreetNumberValidity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AllEvenOdd> _StreetNumberValidity;
        partial void OnStreetNumberValidityChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AllEvenOdd> value);
        partial void OnStreetNumberValidityChanged();
        /// <summary>
        /// There are no comments for Property Street in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Street
        {
            get
            {
                return this._Street;
            }
            set
            {
                this.OnStreetChanging(value);
                this._Street = value;
                this.OnStreetChanged();
                this.OnPropertyChanged("Street");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Street;
        partial void OnStreetChanging(string value);
        partial void OnStreetChanged();
        /// <summary>
        /// There are no comments for Property TimeZone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Timezone> TimeZone
        {
            get
            {
                return this._TimeZone;
            }
            set
            {
                this.OnTimeZoneChanging(value);
                this._TimeZone = value;
                this.OnTimeZoneChanged();
                this.OnPropertyChanged("TimeZone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Timezone> _TimeZone;
        partial void OnTimeZoneChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Timezone> value);
        partial void OnTimeZoneChanged();
        /// <summary>
        /// There are no comments for Property CityAlias in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CityAlias
        {
            get
            {
                return this._CityAlias;
            }
            set
            {
                this.OnCityAliasChanging(value);
                this._CityAlias = value;
                this.OnCityAliasChanged();
                this.OnPropertyChanged("CityAlias");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CityAlias;
        partial void OnCityAliasChanging(string value);
        partial void OnCityAliasChanged();
        /// <summary>
        /// There are no comments for Property AssetLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetLocation> AssetLocation
        {
            get
            {
                return this._AssetLocation;
            }
            set
            {
                this.OnAssetLocationChanging(value);
                this._AssetLocation = value;
                this.OnAssetLocationChanged();
                this.OnPropertyChanged("AssetLocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetLocation> _AssetLocation = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetLocation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetLocationChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetLocation> value);
        partial void OnAssetLocationChanged();
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
