﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/4/2021 7:24:30 AM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for VendorGroupSingle in the schema.
        /// </summary>
    public partial class VendorGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VendorGroup>
    {
        /// <summary>
        /// Initialize a new VendorGroupSingle object.
        /// </summary>
        public VendorGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VendorGroupSingle object.
        /// </summary>
        public VendorGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VendorGroupSingle object.
        /// </summary>
        public VendorGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VendorGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ClearingPeriodPaymentTerm in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PaymentTermSingle ClearingPeriodPaymentTerm
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ClearingPeriodPaymentTerm == null))
                {
                    this._ClearingPeriodPaymentTerm = new global::Microsoft.Dynamics.DataEntities.PaymentTermSingle(this.Context, GetPath("ClearingPeriodPaymentTerm"));
                }
                return this._ClearingPeriodPaymentTerm;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PaymentTermSingle _ClearingPeriodPaymentTerm;
        /// <summary>
        /// There are no comments for DefaultPaymentTerm in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PaymentTermSingle DefaultPaymentTerm
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DefaultPaymentTerm == null))
                {
                    this._DefaultPaymentTerm = new global::Microsoft.Dynamics.DataEntities.PaymentTermSingle(this.Context, GetPath("DefaultPaymentTerm"));
                }
                return this._DefaultPaymentTerm;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PaymentTermSingle _DefaultPaymentTerm;
        /// <summary>
        /// There are no comments for DefaultTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxGroupSingle DefaultTaxGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DefaultTaxGroup == null))
                {
                    this._DefaultTaxGroup = new global::Microsoft.Dynamics.DataEntities.TaxGroupSingle(this.Context, GetPath("DefaultTaxGroup"));
                }
                return this._DefaultTaxGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxGroupSingle _DefaultTaxGroup;
        /// <summary>
        /// There are no comments for Prospects in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Prospect> Prospects
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Prospects == null))
                {
                    this._Prospects = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Prospect>(GetPath("Prospects"));
                }
                return this._Prospects;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Prospect> _Prospects;
        /// <summary>
        /// There are no comments for PlannedOrders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PlannedOrder> PlannedOrders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PlannedOrders == null))
                {
                    this._PlannedOrders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PlannedOrder>(GetPath("PlannedOrders"));
                }
                return this._PlannedOrders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PlannedOrder> _PlannedOrders;
        /// <summary>
        /// There are no comments for SupplyForecastEntries in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SupplyForecastEntry> SupplyForecastEntries
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SupplyForecastEntries == null))
                {
                    this._SupplyForecastEntries = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.SupplyForecastEntry>(GetPath("SupplyForecastEntries"));
                }
                return this._SupplyForecastEntries;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SupplyForecastEntry> _SupplyForecastEntries;
    }
        /// <summary>
        /// There are no comments for VendorGroup in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// VendorGroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "VendorGroupId")]
    [global::Microsoft.OData.Client.EntitySet("VendorGroups")]
    public partial class VendorGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VendorGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="vendorGroupId">Initial value of VendorGroupId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VendorGroup CreateVendorGroup(string dataAreaId, string vendorGroupId)
        {
            VendorGroup vendorGroup = new VendorGroup();
            vendorGroup.dataAreaId = dataAreaId;
            vendorGroup.VendorGroupId = vendorGroupId;
            return vendorGroup;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string dataAreaId
        {
            get
            {
                return this._dataAreaId;
            }
            set
            {
                this.OndataAreaIdChanging(value);
                this._dataAreaId = value;
                this.OndataAreaIdChanged();
                this.OnPropertyChanged("dataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _dataAreaId;
        partial void OndataAreaIdChanging(string value);
        partial void OndataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property VendorGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorGroupId
        {
            get
            {
                return this._VendorGroupId;
            }
            set
            {
                this.OnVendorGroupIdChanging(value);
                this._VendorGroupId = value;
                this.OnVendorGroupIdChanged();
                this.OnPropertyChanged("VendorGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorGroupId;
        partial void OnVendorGroupIdChanging(string value);
        partial void OnVendorGroupIdChanged();
        /// <summary>
        /// There are no comments for Property ClearingPeriodPaymentTermName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ClearingPeriodPaymentTermName
        {
            get
            {
                return this._ClearingPeriodPaymentTermName;
            }
            set
            {
                this.OnClearingPeriodPaymentTermNameChanging(value);
                this._ClearingPeriodPaymentTermName = value;
                this.OnClearingPeriodPaymentTermNameChanged();
                this.OnPropertyChanged("ClearingPeriodPaymentTermName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ClearingPeriodPaymentTermName;
        partial void OnClearingPeriodPaymentTermNameChanging(string value);
        partial void OnClearingPeriodPaymentTermNameChanged();
        /// <summary>
        /// There are no comments for Property IsExcludedFromSearchResults in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsExcludedFromSearchResults
        {
            get
            {
                return this._IsExcludedFromSearchResults;
            }
            set
            {
                this.OnIsExcludedFromSearchResultsChanging(value);
                this._IsExcludedFromSearchResults = value;
                this.OnIsExcludedFromSearchResultsChanged();
                this.OnPropertyChanged("IsExcludedFromSearchResults");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsExcludedFromSearchResults;
        partial void OnIsExcludedFromSearchResultsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsExcludedFromSearchResultsChanged();
        /// <summary>
        /// There are no comments for Property DefaultPaymentTermName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultPaymentTermName
        {
            get
            {
                return this._DefaultPaymentTermName;
            }
            set
            {
                this.OnDefaultPaymentTermNameChanging(value);
                this._DefaultPaymentTermName = value;
                this.OnDefaultPaymentTermNameChanged();
                this.OnPropertyChanged("DefaultPaymentTermName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultPaymentTermName;
        partial void OnDefaultPaymentTermNameChanging(string value);
        partial void OnDefaultPaymentTermNameChanged();
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
        /// There are no comments for Property VendorAccountNumberSequence in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorAccountNumberSequence
        {
            get
            {
                return this._VendorAccountNumberSequence;
            }
            set
            {
                this.OnVendorAccountNumberSequenceChanging(value);
                this._VendorAccountNumberSequence = value;
                this.OnVendorAccountNumberSequenceChanged();
                this.OnPropertyChanged("VendorAccountNumberSequence");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorAccountNumberSequence;
        partial void OnVendorAccountNumberSequenceChanging(string value);
        partial void OnVendorAccountNumberSequenceChanged();
        /// <summary>
        /// There are no comments for Property DefaultTaxGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultTaxGroupCode
        {
            get
            {
                return this._DefaultTaxGroupCode;
            }
            set
            {
                this.OnDefaultTaxGroupCodeChanging(value);
                this._DefaultTaxGroupCode = value;
                this.OnDefaultTaxGroupCodeChanged();
                this.OnPropertyChanged("DefaultTaxGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultTaxGroupCode;
        partial void OnDefaultTaxGroupCodeChanging(string value);
        partial void OnDefaultTaxGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property ClearingPeriodPaymentTerm in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PaymentTerm ClearingPeriodPaymentTerm
        {
            get
            {
                return this._ClearingPeriodPaymentTerm;
            }
            set
            {
                this.OnClearingPeriodPaymentTermChanging(value);
                this._ClearingPeriodPaymentTerm = value;
                this.OnClearingPeriodPaymentTermChanged();
                this.OnPropertyChanged("ClearingPeriodPaymentTerm");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PaymentTerm _ClearingPeriodPaymentTerm;
        partial void OnClearingPeriodPaymentTermChanging(global::Microsoft.Dynamics.DataEntities.PaymentTerm value);
        partial void OnClearingPeriodPaymentTermChanged();
        /// <summary>
        /// There are no comments for Property DefaultPaymentTerm in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PaymentTerm DefaultPaymentTerm
        {
            get
            {
                return this._DefaultPaymentTerm;
            }
            set
            {
                this.OnDefaultPaymentTermChanging(value);
                this._DefaultPaymentTerm = value;
                this.OnDefaultPaymentTermChanged();
                this.OnPropertyChanged("DefaultPaymentTerm");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PaymentTerm _DefaultPaymentTerm;
        partial void OnDefaultPaymentTermChanging(global::Microsoft.Dynamics.DataEntities.PaymentTerm value);
        partial void OnDefaultPaymentTermChanged();
        /// <summary>
        /// There are no comments for Property DefaultTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxGroup DefaultTaxGroup
        {
            get
            {
                return this._DefaultTaxGroup;
            }
            set
            {
                this.OnDefaultTaxGroupChanging(value);
                this._DefaultTaxGroup = value;
                this.OnDefaultTaxGroupChanged();
                this.OnPropertyChanged("DefaultTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxGroup _DefaultTaxGroup;
        partial void OnDefaultTaxGroupChanging(global::Microsoft.Dynamics.DataEntities.TaxGroup value);
        partial void OnDefaultTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property Prospects in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Prospect> Prospects
        {
            get
            {
                return this._Prospects;
            }
            set
            {
                this.OnProspectsChanging(value);
                this._Prospects = value;
                this.OnProspectsChanged();
                this.OnPropertyChanged("Prospects");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Prospect> _Prospects = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Prospect>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProspectsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Prospect> value);
        partial void OnProspectsChanged();
        /// <summary>
        /// There are no comments for Property PlannedOrders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PlannedOrder> PlannedOrders
        {
            get
            {
                return this._PlannedOrders;
            }
            set
            {
                this.OnPlannedOrdersChanging(value);
                this._PlannedOrders = value;
                this.OnPlannedOrdersChanged();
                this.OnPropertyChanged("PlannedOrders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PlannedOrder> _PlannedOrders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PlannedOrder>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPlannedOrdersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PlannedOrder> value);
        partial void OnPlannedOrdersChanged();
        /// <summary>
        /// There are no comments for Property SupplyForecastEntries in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SupplyForecastEntry> SupplyForecastEntries
        {
            get
            {
                return this._SupplyForecastEntries;
            }
            set
            {
                this.OnSupplyForecastEntriesChanging(value);
                this._SupplyForecastEntries = value;
                this.OnSupplyForecastEntriesChanged();
                this.OnPropertyChanged("SupplyForecastEntries");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SupplyForecastEntry> _SupplyForecastEntries = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SupplyForecastEntry>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSupplyForecastEntriesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SupplyForecastEntry> value);
        partial void OnSupplyForecastEntriesChanged();
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
