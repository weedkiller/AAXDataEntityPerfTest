﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:55:10 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for AddressDistrictSingle in the schema.
    /// </summary>
    public partial class AddressDistrictSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AddressDistrict>
    {
        /// <summary>
        /// Initialize a new AddressDistrictSingle object.
        /// </summary>
        public AddressDistrictSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AddressDistrictSingle object.
        /// </summary>
        public AddressDistrictSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AddressDistrictSingle object.
        /// </summary>
        public AddressDistrictSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AddressDistrict> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressStateSingle State
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._State == null))
                {
                    this._State = new global::Microsoft.Dynamics.DataEntities.AddressStateSingle(this.Context, GetPath("State"));
                }
                return this._State;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressStateSingle _State;
        /// <summary>
        /// There are no comments for County in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressCountySingle County
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._County == null))
                {
                    this._County = new global::Microsoft.Dynamics.DataEntities.AddressCountySingle(this.Context, GetPath("County"));
                }
                return this._County;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressCountySingle _County;
        /// <summary>
        /// There are no comments for City in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressCitySingle City
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._City == null))
                {
                    this._City = new global::Microsoft.Dynamics.DataEntities.AddressCitySingle(this.Context, GetPath("City"));
                }
                return this._City;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressCitySingle _City;
        /// <summary>
        /// There are no comments for CountryRegion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressCountryRegionSingle CountryRegion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CountryRegion == null))
                {
                    this._CountryRegion = new global::Microsoft.Dynamics.DataEntities.AddressCountryRegionSingle(this.Context, GetPath("CountryRegion"));
                }
                return this._CountryRegion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressCountryRegionSingle _CountryRegion;
    }
    /// <summary>
    /// There are no comments for AddressDistrict in the schema.
    /// </summary>
    /// <KeyProperties>
    /// District
    /// CityKey
    /// CountryRegionId
    /// StateId
    /// CountyId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("District", "CityKey", "CountryRegionId", "StateId", "CountyId")]
    [global::Microsoft.OData.Client.EntitySet("AddressDistricts")]
    public partial class AddressDistrict : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AddressDistrict object.
        /// </summary>
        /// <param name="district">Initial value of District.</param>
        /// <param name="cityKey">Initial value of CityKey.</param>
        /// <param name="countryRegionId">Initial value of CountryRegionId.</param>
        /// <param name="stateId">Initial value of StateId.</param>
        /// <param name="countyId">Initial value of CountyId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AddressDistrict CreateAddressDistrict(string district, string cityKey, string countryRegionId, string stateId, string countyId)
        {
            AddressDistrict addressDistrict = new AddressDistrict();
            addressDistrict.District = district;
            addressDistrict.CityKey = cityKey;
            addressDistrict.CountryRegionId = countryRegionId;
            addressDistrict.StateId = stateId;
            addressDistrict.CountyId = countyId;
            return addressDistrict;
        }
        /// <summary>
        /// There are no comments for Property District in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string District
        {
            get
            {
                return this._District;
            }
            set
            {
                this.OnDistrictChanging(value);
                this._District = value;
                this.OnDistrictChanged();
                this.OnPropertyChanged("District");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _District;
        partial void OnDistrictChanging(string value);
        partial void OnDistrictChanged();
        /// <summary>
        /// There are no comments for Property CityKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CityKey
        {
            get
            {
                return this._CityKey;
            }
            set
            {
                this.OnCityKeyChanging(value);
                this._CityKey = value;
                this.OnCityKeyChanged();
                this.OnPropertyChanged("CityKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CityKey;
        partial void OnCityKeyChanging(string value);
        partial void OnCityKeyChanged();
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
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressState State
        {
            get
            {
                return this._State;
            }
            set
            {
                this.OnStateChanging(value);
                this._State = value;
                this.OnStateChanged();
                this.OnPropertyChanged("State");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressState _State;
        partial void OnStateChanging(global::Microsoft.Dynamics.DataEntities.AddressState value);
        partial void OnStateChanged();
        /// <summary>
        /// There are no comments for Property County in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressCounty County
        {
            get
            {
                return this._County;
            }
            set
            {
                this.OnCountyChanging(value);
                this._County = value;
                this.OnCountyChanged();
                this.OnPropertyChanged("County");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressCounty _County;
        partial void OnCountyChanging(global::Microsoft.Dynamics.DataEntities.AddressCounty value);
        partial void OnCountyChanged();
        /// <summary>
        /// There are no comments for Property City in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressCity City
        {
            get
            {
                return this._City;
            }
            set
            {
                this.OnCityChanging(value);
                this._City = value;
                this.OnCityChanged();
                this.OnPropertyChanged("City");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressCity _City;
        partial void OnCityChanging(global::Microsoft.Dynamics.DataEntities.AddressCity value);
        partial void OnCityChanged();
        /// <summary>
        /// There are no comments for Property CountryRegion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressCountryRegion CountryRegion
        {
            get
            {
                return this._CountryRegion;
            }
            set
            {
                this.OnCountryRegionChanging(value);
                this._CountryRegion = value;
                this.OnCountryRegionChanged();
                this.OnPropertyChanged("CountryRegion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressCountryRegion _CountryRegion;
        partial void OnCountryRegionChanging(global::Microsoft.Dynamics.DataEntities.AddressCountryRegion value);
        partial void OnCountryRegionChanged();
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