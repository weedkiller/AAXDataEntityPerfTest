﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 9/11/2020 3:24:26 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for InfoManagementSingle in the schema.
    /// </summary>
    public partial class InfoManagementSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<InfoManagement>
    {
        /// <summary>
        /// Initialize a new InfoManagementSingle object.
        /// </summary>
        public InfoManagementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new InfoManagementSingle object.
        /// </summary>
        public InfoManagementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new InfoManagementSingle object.
        /// </summary>
        public InfoManagementSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<InfoManagement> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for InfoManagement in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Name
    /// LocationId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Name", "LocationId")]
    [global::Microsoft.OData.Client.EntitySet("InfoManagements")]
    public partial class InfoManagement : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new InfoManagement object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="locationId">Initial value of LocationId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static InfoManagement CreateInfoManagement(string name, string locationId)
        {
            InfoManagement infoManagement = new InfoManagement();
            infoManagement.Name = name;
            infoManagement.LocationId = locationId;
            return infoManagement;
        }
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
        /// There are no comments for Property LocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LocationId
        {
            get
            {
                return this._LocationId;
            }
            set
            {
                this.OnLocationIdChanging(value);
                this._LocationId = value;
                this.OnLocationIdChanged();
                this.OnPropertyChanged("LocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LocationId;
        partial void OnLocationIdChanging(string value);
        partial void OnLocationIdChanged();
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
        /// There are no comments for Property IsPrimary in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPrimary
        {
            get
            {
                return this._IsPrimary;
            }
            set
            {
                this.OnIsPrimaryChanging(value);
                this._IsPrimary = value;
                this.OnIsPrimaryChanged();
                this.OnPropertyChanged("IsPrimary");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPrimary;
        partial void OnIsPrimaryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPrimaryChanged();
        /// <summary>
        /// There are no comments for Property NumSeqGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string NumSeqGroup
        {
            get
            {
                return this._NumSeqGroup;
            }
            set
            {
                this.OnNumSeqGroupChanging(value);
                this._NumSeqGroup = value;
                this.OnNumSeqGroupChanged();
                this.OnPropertyChanged("NumSeqGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NumSeqGroup;
        partial void OnNumSeqGroupChanging(string value);
        partial void OnNumSeqGroupChanged();
        /// <summary>
        /// There are no comments for Property ECCNumberOthers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ECCNumberOthers
        {
            get
            {
                return this._ECCNumberOthers;
            }
            set
            {
                this.OnECCNumberOthersChanging(value);
                this._ECCNumberOthers = value;
                this.OnECCNumberOthersChanged();
                this.OnPropertyChanged("ECCNumberOthers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ECCNumberOthers;
        partial void OnECCNumberOthersChanging(string value);
        partial void OnECCNumberOthersChanged();
        /// <summary>
        /// There are no comments for Property TraderECCNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TraderECCNumber
        {
            get
            {
                return this._TraderECCNumber;
            }
            set
            {
                this.OnTraderECCNumberChanging(value);
                this._TraderECCNumber = value;
                this.OnTraderECCNumberChanged();
                this.OnPropertyChanged("TraderECCNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TraderECCNumber;
        partial void OnTraderECCNumberChanging(string value);
        partial void OnTraderECCNumberChanged();
        /// <summary>
        /// There are no comments for Property ManufacturerECCNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ManufacturerECCNumber
        {
            get
            {
                return this._ManufacturerECCNumber;
            }
            set
            {
                this.OnManufacturerECCNumberChanging(value);
                this._ManufacturerECCNumber = value;
                this.OnManufacturerECCNumberChanged();
                this.OnPropertyChanged("ManufacturerECCNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ManufacturerECCNumber;
        partial void OnManufacturerECCNumberChanging(string value);
        partial void OnManufacturerECCNumberChanged();
        /// <summary>
        /// There are no comments for Property STCNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string STCNumber
        {
            get
            {
                return this._STCNumber;
            }
            set
            {
                this.OnSTCNumberChanging(value);
                this._STCNumber = value;
                this.OnSTCNumberChanged();
                this.OnPropertyChanged("STCNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _STCNumber;
        partial void OnSTCNumberChanging(string value);
        partial void OnSTCNumberChanged();
        /// <summary>
        /// There are no comments for Property LargeTaxpayerUnitCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LargeTaxpayerUnitCode
        {
            get
            {
                return this._LargeTaxpayerUnitCode;
            }
            set
            {
                this.OnLargeTaxpayerUnitCodeChanging(value);
                this._LargeTaxpayerUnitCode = value;
                this.OnLargeTaxpayerUnitCodeChanged();
                this.OnPropertyChanged("LargeTaxpayerUnitCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LargeTaxpayerUnitCode;
        partial void OnLargeTaxpayerUnitCodeChanging(string value);
        partial void OnLargeTaxpayerUnitCodeChanged();
        /// <summary>
        /// There are no comments for Property IECNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string IECNumber
        {
            get
            {
                return this._IECNumber;
            }
            set
            {
                this.OnIECNumberChanging(value);
                this._IECNumber = value;
                this.OnIECNumberChanged();
                this.OnPropertyChanged("IECNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IECNumber;
        partial void OnIECNumberChanging(string value);
        partial void OnIECNumberChanged();
        /// <summary>
        /// There are no comments for Property GSTNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GSTNumber
        {
            get
            {
                return this._GSTNumber;
            }
            set
            {
                this.OnGSTNumberChanging(value);
                this._GSTNumber = value;
                this.OnGSTNumberChanged();
                this.OnPropertyChanged("GSTNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GSTNumber;
        partial void OnGSTNumberChanging(string value);
        partial void OnGSTNumberChanged();
        /// <summary>
        /// There are no comments for Property Range in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Range
        {
            get
            {
                return this._Range;
            }
            set
            {
                this.OnRangeChanging(value);
                this._Range = value;
                this.OnRangeChanged();
                this.OnPropertyChanged("Range");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Range;
        partial void OnRangeChanging(string value);
        partial void OnRangeChanged();
        /// <summary>
        /// There are no comments for Property TaxIdentificationNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxIdentificationNumber
        {
            get
            {
                return this._TaxIdentificationNumber;
            }
            set
            {
                this.OnTaxIdentificationNumberChanging(value);
                this._TaxIdentificationNumber = value;
                this.OnTaxIdentificationNumberChanged();
                this.OnPropertyChanged("TaxIdentificationNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxIdentificationNumber;
        partial void OnTaxIdentificationNumberChanging(string value);
        partial void OnTaxIdentificationNumberChanged();
        /// <summary>
        /// There are no comments for Property RegistrationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxRegistrationType_IN> RegistrationType
        {
            get
            {
                return this._RegistrationType;
            }
            set
            {
                this.OnRegistrationTypeChanging(value);
                this._RegistrationType = value;
                this.OnRegistrationTypeChanged();
                this.OnPropertyChanged("RegistrationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxRegistrationType_IN> _RegistrationType;
        partial void OnRegistrationTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxRegistrationType_IN> value);
        partial void OnRegistrationTypeChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxRegistrationNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesTaxRegistrationNumber
        {
            get
            {
                return this._SalesTaxRegistrationNumber;
            }
            set
            {
                this.OnSalesTaxRegistrationNumberChanging(value);
                this._SalesTaxRegistrationNumber = value;
                this.OnSalesTaxRegistrationNumberChanged();
                this.OnPropertyChanged("SalesTaxRegistrationNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesTaxRegistrationNumber;
        partial void OnSalesTaxRegistrationNumberChanging(string value);
        partial void OnSalesTaxRegistrationNumberChanged();
        /// <summary>
        /// There are no comments for Property Commissionarate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Commissionarate
        {
            get
            {
                return this._Commissionarate;
            }
            set
            {
                this.OnCommissionarateChanging(value);
                this._Commissionarate = value;
                this.OnCommissionarateChanged();
                this.OnPropertyChanged("Commissionarate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Commissionarate;
        partial void OnCommissionarateChanging(string value);
        partial void OnCommissionarateChanged();
        /// <summary>
        /// There are no comments for Property TaxAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxAccountNumber
        {
            get
            {
                return this._TaxAccountNumber;
            }
            set
            {
                this.OnTaxAccountNumberChanging(value);
                this._TaxAccountNumber = value;
                this.OnTaxAccountNumberChanged();
                this.OnPropertyChanged("TaxAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxAccountNumber;
        partial void OnTaxAccountNumberChanging(string value);
        partial void OnTaxAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property Division in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Division
        {
            get
            {
                return this._Division;
            }
            set
            {
                this.OnDivisionChanging(value);
                this._Division = value;
                this.OnDivisionChanged();
                this.OnPropertyChanged("Division");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Division;
        partial void OnDivisionChanging(string value);
        partial void OnDivisionChanged();
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