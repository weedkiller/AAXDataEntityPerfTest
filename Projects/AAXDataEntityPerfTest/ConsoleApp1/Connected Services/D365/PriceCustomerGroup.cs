﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:24:13 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for PriceCustomerGroupSingle in the schema.
    /// </summary>
    public partial class PriceCustomerGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PriceCustomerGroup>
    {
        /// <summary>
        /// Initialize a new PriceCustomerGroupSingle object.
        /// </summary>
        public PriceCustomerGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PriceCustomerGroupSingle object.
        /// </summary>
        public PriceCustomerGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PriceCustomerGroupSingle object.
        /// </summary>
        public PriceCustomerGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PriceCustomerGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for OpenSalesPriceJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.OpenSalesPriceJournalLine> OpenSalesPriceJournalLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OpenSalesPriceJournalLine == null))
                {
                    this._OpenSalesPriceJournalLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.OpenSalesPriceJournalLine>(GetPath("OpenSalesPriceJournalLine"));
                }
                return this._OpenSalesPriceJournalLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.OpenSalesPriceJournalLine> _OpenSalesPriceJournalLine;
        /// <summary>
        /// There are no comments for RetailLoyaltyPriceGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailLoyaltyPriceGroup> RetailLoyaltyPriceGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailLoyaltyPriceGroup == null))
                {
                    this._RetailLoyaltyPriceGroup = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailLoyaltyPriceGroup>(GetPath("RetailLoyaltyPriceGroup"));
                }
                return this._RetailLoyaltyPriceGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailLoyaltyPriceGroup> _RetailLoyaltyPriceGroup;
        /// <summary>
        /// There are no comments for RetailAffiliationPriceGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailAffiliationPriceGroup> RetailAffiliationPriceGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailAffiliationPriceGroup == null))
                {
                    this._RetailAffiliationPriceGroup = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailAffiliationPriceGroup>(GetPath("RetailAffiliationPriceGroup"));
                }
                return this._RetailAffiliationPriceGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailAffiliationPriceGroup> _RetailAffiliationPriceGroup;
    }
    /// <summary>
    /// There are no comments for PriceCustomerGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// GroupCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "GroupCode")]
    [global::Microsoft.OData.Client.EntitySet("PriceCustomerGroups")]
    public partial class PriceCustomerGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PriceCustomerGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="groupCode">Initial value of GroupCode.</param>
        /// <param name="pricingPriority">Initial value of PricingPriority.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PriceCustomerGroup CreatePriceCustomerGroup(string dataAreaId, string groupCode, int pricingPriority)
        {
            PriceCustomerGroup priceCustomerGroup = new PriceCustomerGroup();
            priceCustomerGroup.dataAreaId = dataAreaId;
            priceCustomerGroup.GroupCode = groupCode;
            priceCustomerGroup.PricingPriority = pricingPriority;
            return priceCustomerGroup;
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
        /// There are no comments for Property GroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GroupCode
        {
            get
            {
                return this._GroupCode;
            }
            set
            {
                this.OnGroupCodeChanging(value);
                this._GroupCode = value;
                this.OnGroupCodeChanged();
                this.OnPropertyChanged("GroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupCode;
        partial void OnGroupCodeChanging(string value);
        partial void OnGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property PricingPriority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int PricingPriority
        {
            get
            {
                return this._PricingPriority;
            }
            set
            {
                this.OnPricingPriorityChanging(value);
                this._PricingPriority = value;
                this.OnPricingPriorityChanged();
                this.OnPropertyChanged("PricingPriority");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PricingPriority;
        partial void OnPricingPriorityChanging(int value);
        partial void OnPricingPriorityChanged();
        /// <summary>
        /// There are no comments for Property GroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GroupName
        {
            get
            {
                return this._GroupName;
            }
            set
            {
                this.OnGroupNameChanging(value);
                this._GroupName = value;
                this.OnGroupNameChanged();
                this.OnPropertyChanged("GroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupName;
        partial void OnGroupNameChanging(string value);
        partial void OnGroupNameChanged();
        /// <summary>
        /// There are no comments for Property OpenSalesPriceJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenSalesPriceJournalLine> OpenSalesPriceJournalLine
        {
            get
            {
                return this._OpenSalesPriceJournalLine;
            }
            set
            {
                this.OnOpenSalesPriceJournalLineChanging(value);
                this._OpenSalesPriceJournalLine = value;
                this.OnOpenSalesPriceJournalLineChanged();
                this.OnPropertyChanged("OpenSalesPriceJournalLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenSalesPriceJournalLine> _OpenSalesPriceJournalLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenSalesPriceJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnOpenSalesPriceJournalLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenSalesPriceJournalLine> value);
        partial void OnOpenSalesPriceJournalLineChanged();
        /// <summary>
        /// There are no comments for Property RetailLoyaltyPriceGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailLoyaltyPriceGroup> RetailLoyaltyPriceGroup
        {
            get
            {
                return this._RetailLoyaltyPriceGroup;
            }
            set
            {
                this.OnRetailLoyaltyPriceGroupChanging(value);
                this._RetailLoyaltyPriceGroup = value;
                this.OnRetailLoyaltyPriceGroupChanged();
                this.OnPropertyChanged("RetailLoyaltyPriceGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailLoyaltyPriceGroup> _RetailLoyaltyPriceGroup = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailLoyaltyPriceGroup>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailLoyaltyPriceGroupChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailLoyaltyPriceGroup> value);
        partial void OnRetailLoyaltyPriceGroupChanged();
        /// <summary>
        /// There are no comments for Property RetailAffiliationPriceGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailAffiliationPriceGroup> RetailAffiliationPriceGroup
        {
            get
            {
                return this._RetailAffiliationPriceGroup;
            }
            set
            {
                this.OnRetailAffiliationPriceGroupChanging(value);
                this._RetailAffiliationPriceGroup = value;
                this.OnRetailAffiliationPriceGroupChanged();
                this.OnPropertyChanged("RetailAffiliationPriceGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailAffiliationPriceGroup> _RetailAffiliationPriceGroup = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailAffiliationPriceGroup>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailAffiliationPriceGroupChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailAffiliationPriceGroup> value);
        partial void OnRetailAffiliationPriceGroupChanged();
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