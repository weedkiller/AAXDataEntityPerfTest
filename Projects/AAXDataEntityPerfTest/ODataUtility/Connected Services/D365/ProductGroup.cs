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
        /// There are no comments for ProductGroupSingle in the schema.
        /// </summary>
    public partial class ProductGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductGroup>
    {
        /// <summary>
        /// Initialize a new ProductGroupSingle object.
        /// </summary>
        public ProductGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductGroupSingle object.
        /// </summary>
        public ProductGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductGroupSingle object.
        /// </summary>
        public ProductGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductsV2 == null))
                {
                    this._ReleasedProductsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(GetPath("ReleasedProductsV2"));
                }
                return this._ReleasedProductsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2;
        /// <summary>
        /// There are no comments for RevRecSetupBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RecSetupBasis> RevRecSetupBasis
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RevRecSetupBasis == null))
                {
                    this._RevRecSetupBasis = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RecSetupBasis>(GetPath("RevRecSetupBasis"));
                }
                return this._RevRecSetupBasis;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RecSetupBasis> _RevRecSetupBasis;
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
        /// There are no comments for ProductGroup in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// GroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "GroupId")]
    [global::Microsoft.OData.Client.EntitySet("ProductGroups")]
    public partial class ProductGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="groupId">Initial value of GroupId.</param>
        /// <param name="revRecMedianPriceMaximumTolerance">Initial value of RevRecMedianPriceMaximumTolerance.</param>
        /// <param name="revRecMedianPriceMinimumTolerance">Initial value of RevRecMedianPriceMinimumTolerance.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductGroup CreateProductGroup(string dataAreaId, string groupId, decimal revRecMedianPriceMaximumTolerance, decimal revRecMedianPriceMinimumTolerance)
        {
            ProductGroup productGroup = new ProductGroup();
            productGroup.dataAreaId = dataAreaId;
            productGroup.GroupId = groupId;
            productGroup.RevRecMedianPriceMaximumTolerance = revRecMedianPriceMaximumTolerance;
            productGroup.RevRecMedianPriceMinimumTolerance = revRecMedianPriceMinimumTolerance;
            return productGroup;
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
        /// There are no comments for Property GroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GroupId
        {
            get
            {
                return this._GroupId;
            }
            set
            {
                this.OnGroupIdChanging(value);
                this._GroupId = value;
                this.OnGroupIdChanged();
                this.OnPropertyChanged("GroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupId;
        partial void OnGroupIdChanging(string value);
        partial void OnGroupIdChanged();
        /// <summary>
        /// There are no comments for Property DefaultPurchaseSalesTaxItemGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultPurchaseSalesTaxItemGroupCode
        {
            get
            {
                return this._DefaultPurchaseSalesTaxItemGroupCode;
            }
            set
            {
                this.OnDefaultPurchaseSalesTaxItemGroupCodeChanging(value);
                this._DefaultPurchaseSalesTaxItemGroupCode = value;
                this.OnDefaultPurchaseSalesTaxItemGroupCodeChanged();
                this.OnPropertyChanged("DefaultPurchaseSalesTaxItemGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultPurchaseSalesTaxItemGroupCode;
        partial void OnDefaultPurchaseSalesTaxItemGroupCodeChanging(string value);
        partial void OnDefaultPurchaseSalesTaxItemGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property DefaultSalesSalesTaxItemGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultSalesSalesTaxItemGroupCode
        {
            get
            {
                return this._DefaultSalesSalesTaxItemGroupCode;
            }
            set
            {
                this.OnDefaultSalesSalesTaxItemGroupCodeChanging(value);
                this._DefaultSalesSalesTaxItemGroupCode = value;
                this.OnDefaultSalesSalesTaxItemGroupCodeChanged();
                this.OnPropertyChanged("DefaultSalesSalesTaxItemGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultSalesSalesTaxItemGroupCode;
        partial void OnDefaultSalesSalesTaxItemGroupCodeChanging(string value);
        partial void OnDefaultSalesSalesTaxItemGroupCodeChanged();
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
        /// There are no comments for Property ShipmentPhysicalLoadTemplateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ShipmentPhysicalLoadTemplateId
        {
            get
            {
                return this._ShipmentPhysicalLoadTemplateId;
            }
            set
            {
                this.OnShipmentPhysicalLoadTemplateIdChanging(value);
                this._ShipmentPhysicalLoadTemplateId = value;
                this.OnShipmentPhysicalLoadTemplateIdChanged();
                this.OnPropertyChanged("ShipmentPhysicalLoadTemplateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShipmentPhysicalLoadTemplateId;
        partial void OnShipmentPhysicalLoadTemplateIdChanging(string value);
        partial void OnShipmentPhysicalLoadTemplateIdChanged();
        /// <summary>
        /// There are no comments for Property DefaultForecastAllocationKeyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultForecastAllocationKeyId
        {
            get
            {
                return this._DefaultForecastAllocationKeyId;
            }
            set
            {
                this.OnDefaultForecastAllocationKeyIdChanging(value);
                this._DefaultForecastAllocationKeyId = value;
                this.OnDefaultForecastAllocationKeyIdChanged();
                this.OnPropertyChanged("DefaultForecastAllocationKeyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultForecastAllocationKeyId;
        partial void OnDefaultForecastAllocationKeyIdChanging(string value);
        partial void OnDefaultForecastAllocationKeyIdChanged();
        /// <summary>
        /// There are no comments for Property RevRecMedianPriceMaximumTolerance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal RevRecMedianPriceMaximumTolerance
        {
            get
            {
                return this._RevRecMedianPriceMaximumTolerance;
            }
            set
            {
                this.OnRevRecMedianPriceMaximumToleranceChanging(value);
                this._RevRecMedianPriceMaximumTolerance = value;
                this.OnRevRecMedianPriceMaximumToleranceChanged();
                this.OnPropertyChanged("RevRecMedianPriceMaximumTolerance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RevRecMedianPriceMaximumTolerance;
        partial void OnRevRecMedianPriceMaximumToleranceChanging(decimal value);
        partial void OnRevRecMedianPriceMaximumToleranceChanged();
        /// <summary>
        /// There are no comments for Property RevRecMedianPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> RevRecMedianPrice
        {
            get
            {
                return this._RevRecMedianPrice;
            }
            set
            {
                this.OnRevRecMedianPriceChanging(value);
                this._RevRecMedianPrice = value;
                this.OnRevRecMedianPriceChanged();
                this.OnPropertyChanged("RevRecMedianPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _RevRecMedianPrice;
        partial void OnRevRecMedianPriceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnRevRecMedianPriceChanged();
        /// <summary>
        /// There are no comments for Property RevRecDefaultRevenueRecognitionSchedule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RevRecDefaultRevenueRecognitionSchedule
        {
            get
            {
                return this._RevRecDefaultRevenueRecognitionSchedule;
            }
            set
            {
                this.OnRevRecDefaultRevenueRecognitionScheduleChanging(value);
                this._RevRecDefaultRevenueRecognitionSchedule = value;
                this.OnRevRecDefaultRevenueRecognitionScheduleChanged();
                this.OnPropertyChanged("RevRecDefaultRevenueRecognitionSchedule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RevRecDefaultRevenueRecognitionSchedule;
        partial void OnRevRecDefaultRevenueRecognitionScheduleChanging(string value);
        partial void OnRevRecDefaultRevenueRecognitionScheduleChanged();
        /// <summary>
        /// There are no comments for Property RevRecExcludeFromCarveOut in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> RevRecExcludeFromCarveOut
        {
            get
            {
                return this._RevRecExcludeFromCarveOut;
            }
            set
            {
                this.OnRevRecExcludeFromCarveOutChanging(value);
                this._RevRecExcludeFromCarveOut = value;
                this.OnRevRecExcludeFromCarveOutChanged();
                this.OnPropertyChanged("RevRecExcludeFromCarveOut");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _RevRecExcludeFromCarveOut;
        partial void OnRevRecExcludeFromCarveOutChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnRevRecExcludeFromCarveOutChanged();
        /// <summary>
        /// There are no comments for Property RevRecMedianPriceMinimumTolerance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal RevRecMedianPriceMinimumTolerance
        {
            get
            {
                return this._RevRecMedianPriceMinimumTolerance;
            }
            set
            {
                this.OnRevRecMedianPriceMinimumToleranceChanging(value);
                this._RevRecMedianPriceMinimumTolerance = value;
                this.OnRevRecMedianPriceMinimumToleranceChanged();
                this.OnPropertyChanged("RevRecMedianPriceMinimumTolerance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RevRecMedianPriceMinimumTolerance;
        partial void OnRevRecMedianPriceMinimumToleranceChanging(decimal value);
        partial void OnRevRecMedianPriceMinimumToleranceChanged();
        /// <summary>
        /// There are no comments for Property RevRecRevenueRecognitionEnabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> RevRecRevenueRecognitionEnabled
        {
            get
            {
                return this._RevRecRevenueRecognitionEnabled;
            }
            set
            {
                this.OnRevRecRevenueRecognitionEnabledChanging(value);
                this._RevRecRevenueRecognitionEnabled = value;
                this.OnRevRecRevenueRecognitionEnabledChanged();
                this.OnPropertyChanged("RevRecRevenueRecognitionEnabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _RevRecRevenueRecognitionEnabled;
        partial void OnRevRecRevenueRecognitionEnabledChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnRevRecRevenueRecognitionEnabledChanged();
        /// <summary>
        /// There are no comments for Property RevRecRevenueType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RevRecRevenueType> RevRecRevenueType
        {
            get
            {
                return this._RevRecRevenueType;
            }
            set
            {
                this.OnRevRecRevenueTypeChanging(value);
                this._RevRecRevenueType = value;
                this.OnRevRecRevenueTypeChanged();
                this.OnPropertyChanged("RevRecRevenueType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RevRecRevenueType> _RevRecRevenueType;
        partial void OnRevRecRevenueTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RevRecRevenueType> value);
        partial void OnRevRecRevenueTypeChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                return this._ReleasedProductsV2;
            }
            set
            {
                this.OnReleasedProductsV2Changing(value);
                this._ReleasedProductsV2 = value;
                this.OnReleasedProductsV2Changed();
                this.OnPropertyChanged("ReleasedProductsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedProductsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> value);
        partial void OnReleasedProductsV2Changed();
        /// <summary>
        /// There are no comments for Property RevRecSetupBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecSetupBasis> RevRecSetupBasis
        {
            get
            {
                return this._RevRecSetupBasis;
            }
            set
            {
                this.OnRevRecSetupBasisChanging(value);
                this._RevRecSetupBasis = value;
                this.OnRevRecSetupBasisChanged();
                this.OnPropertyChanged("RevRecSetupBasis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecSetupBasis> _RevRecSetupBasis = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecSetupBasis>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRevRecSetupBasisChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecSetupBasis> value);
        partial void OnRevRecSetupBasisChanged();
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
