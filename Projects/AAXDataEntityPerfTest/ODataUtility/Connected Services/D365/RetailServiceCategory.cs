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
        /// There are no comments for RetailServiceCategorySingle in the schema.
        /// </summary>
    public partial class RetailServiceCategorySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailServiceCategory>
    {
        /// <summary>
        /// Initialize a new RetailServiceCategorySingle object.
        /// </summary>
        public RetailServiceCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailServiceCategorySingle object.
        /// </summary>
        public RetailServiceCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailServiceCategorySingle object.
        /// </summary>
        public RetailServiceCategorySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailServiceCategory> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Warehouse in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WarehouseSingle Warehouse
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Warehouse == null))
                {
                    this._Warehouse = new global::Microsoft.Dynamics.DataEntities.WarehouseSingle(this.Context, GetPath("Warehouse"));
                }
                return this._Warehouse;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WarehouseSingle _Warehouse;
        /// <summary>
        /// There are no comments for RetailReplenishmentRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailReplenishmentRuleSingle RetailReplenishmentRule
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailReplenishmentRule == null))
                {
                    this._RetailReplenishmentRule = new global::Microsoft.Dynamics.DataEntities.RetailReplenishmentRuleSingle(this.Context, GetPath("RetailReplenishmentRule"));
                }
                return this._RetailReplenishmentRule;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailReplenishmentRuleSingle _RetailReplenishmentRule;
    }
        /// <summary>
        /// There are no comments for RetailServiceCategory in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ServiceCategory
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ServiceCategory")]
    [global::Microsoft.OData.Client.EntitySet("RetailServiceCategories")]
    public partial class RetailServiceCategory : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailServiceCategory object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="serviceCategory">Initial value of ServiceCategory.</param>
        /// <param name="salesDate">Initial value of SalesDate.</param>
        /// <param name="localDeliveryDate">Initial value of LocalDeliveryDate.</param>
        /// <param name="warehouse">Initial value of Warehouse.</param>
        /// <param name="retailReplenishmentRule">Initial value of RetailReplenishmentRule.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailServiceCategory CreateRetailServiceCategory(string dataAreaId, 
                    string serviceCategory, 
                    int salesDate, 
                    int localDeliveryDate, 
                    global::Microsoft.Dynamics.DataEntities.Warehouse warehouse, 
                    global::Microsoft.Dynamics.DataEntities.RetailReplenishmentRule retailReplenishmentRule)
        {
            RetailServiceCategory retailServiceCategory = new RetailServiceCategory();
            retailServiceCategory.dataAreaId = dataAreaId;
            retailServiceCategory.ServiceCategory = serviceCategory;
            retailServiceCategory.SalesDate = salesDate;
            retailServiceCategory.LocalDeliveryDate = localDeliveryDate;
            if ((warehouse == null))
            {
                throw new global::System.ArgumentNullException("warehouse");
            }
            retailServiceCategory.Warehouse = warehouse;
            if ((retailReplenishmentRule == null))
            {
                throw new global::System.ArgumentNullException("retailReplenishmentRule");
            }
            retailServiceCategory.RetailReplenishmentRule = retailReplenishmentRule;
            return retailServiceCategory;
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
        /// There are no comments for Property ServiceCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ServiceCategory
        {
            get
            {
                return this._ServiceCategory;
            }
            set
            {
                this.OnServiceCategoryChanging(value);
                this._ServiceCategory = value;
                this.OnServiceCategoryChanged();
                this.OnPropertyChanged("ServiceCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ServiceCategory;
        partial void OnServiceCategoryChanging(string value);
        partial void OnServiceCategoryChanged();
        /// <summary>
        /// There are no comments for Property SalesDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int SalesDate
        {
            get
            {
                return this._SalesDate;
            }
            set
            {
                this.OnSalesDateChanging(value);
                this._SalesDate = value;
                this.OnSalesDateChanged();
                this.OnPropertyChanged("SalesDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _SalesDate;
        partial void OnSalesDateChanging(int value);
        partial void OnSalesDateChanged();
        /// <summary>
        /// There are no comments for Property ReplenishmentRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReplenishmentRule
        {
            get
            {
                return this._ReplenishmentRule;
            }
            set
            {
                this.OnReplenishmentRuleChanging(value);
                this._ReplenishmentRule = value;
                this.OnReplenishmentRuleChanged();
                this.OnPropertyChanged("ReplenishmentRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReplenishmentRule;
        partial void OnReplenishmentRuleChanging(string value);
        partial void OnReplenishmentRuleChanged();
        /// <summary>
        /// There are no comments for Property ReplenishmentWarehouse in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReplenishmentWarehouse
        {
            get
            {
                return this._ReplenishmentWarehouse;
            }
            set
            {
                this.OnReplenishmentWarehouseChanging(value);
                this._ReplenishmentWarehouse = value;
                this.OnReplenishmentWarehouseChanged();
                this.OnPropertyChanged("ReplenishmentWarehouse");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReplenishmentWarehouse;
        partial void OnReplenishmentWarehouseChanging(string value);
        partial void OnReplenishmentWarehouseChanged();
        /// <summary>
        /// There are no comments for Property Calendar in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Calendar
        {
            get
            {
                return this._Calendar;
            }
            set
            {
                this.OnCalendarChanging(value);
                this._Calendar = value;
                this.OnCalendarChanged();
                this.OnPropertyChanged("Calendar");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Calendar;
        partial void OnCalendarChanging(string value);
        partial void OnCalendarChanged();
        /// <summary>
        /// There are no comments for Property CrossDockingWarehouse in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CrossDockingWarehouse
        {
            get
            {
                return this._CrossDockingWarehouse;
            }
            set
            {
                this.OnCrossDockingWarehouseChanging(value);
                this._CrossDockingWarehouse = value;
                this.OnCrossDockingWarehouseChanged();
                this.OnPropertyChanged("CrossDockingWarehouse");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CrossDockingWarehouse;
        partial void OnCrossDockingWarehouseChanging(string value);
        partial void OnCrossDockingWarehouseChanged();
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
        /// There are no comments for Property LocalDeliveryDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int LocalDeliveryDate
        {
            get
            {
                return this._LocalDeliveryDate;
            }
            set
            {
                this.OnLocalDeliveryDateChanging(value);
                this._LocalDeliveryDate = value;
                this.OnLocalDeliveryDateChanged();
                this.OnPropertyChanged("LocalDeliveryDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _LocalDeliveryDate;
        partial void OnLocalDeliveryDateChanging(int value);
        partial void OnLocalDeliveryDateChanged();
        /// <summary>
        /// There are no comments for Property Warehouse in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Warehouse Warehouse
        {
            get
            {
                return this._Warehouse;
            }
            set
            {
                this.OnWarehouseChanging(value);
                this._Warehouse = value;
                this.OnWarehouseChanged();
                this.OnPropertyChanged("Warehouse");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Warehouse _Warehouse;
        partial void OnWarehouseChanging(global::Microsoft.Dynamics.DataEntities.Warehouse value);
        partial void OnWarehouseChanged();
        /// <summary>
        /// There are no comments for Property RetailReplenishmentRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailReplenishmentRule RetailReplenishmentRule
        {
            get
            {
                return this._RetailReplenishmentRule;
            }
            set
            {
                this.OnRetailReplenishmentRuleChanging(value);
                this._RetailReplenishmentRule = value;
                this.OnRetailReplenishmentRuleChanged();
                this.OnPropertyChanged("RetailReplenishmentRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailReplenishmentRule _RetailReplenishmentRule;
        partial void OnRetailReplenishmentRuleChanging(global::Microsoft.Dynamics.DataEntities.RetailReplenishmentRule value);
        partial void OnRetailReplenishmentRuleChanged();
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
