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
        /// There are no comments for MonthlyCostStatementEntrySingle in the schema.
        /// </summary>
    public partial class MonthlyCostStatementEntrySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<MonthlyCostStatementEntry>
    {
        /// <summary>
        /// Initialize a new MonthlyCostStatementEntrySingle object.
        /// </summary>
        public MonthlyCostStatementEntrySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new MonthlyCostStatementEntrySingle object.
        /// </summary>
        public MonthlyCostStatementEntrySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new MonthlyCostStatementEntrySingle object.
        /// </summary>
        public MonthlyCostStatementEntrySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<MonthlyCostStatementEntry> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for OperationalSite in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle OperationalSite
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OperationalSite == null))
                {
                    this._OperationalSite = new global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle(this.Context, GetPath("OperationalSite"));
                }
                return this._OperationalSite;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle _OperationalSite;
        /// <summary>
        /// There are no comments for ProductColor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductColorSingle ProductColor
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductColor == null))
                {
                    this._ProductColor = new global::Microsoft.Dynamics.DataEntities.ProductColorSingle(this.Context, GetPath("ProductColor"));
                }
                return this._ProductColor;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductColorSingle _ProductColor;
        /// <summary>
        /// There are no comments for ProductStyle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductStyleSingle ProductStyle
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductStyle == null))
                {
                    this._ProductStyle = new global::Microsoft.Dynamics.DataEntities.ProductStyleSingle(this.Context, GetPath("ProductStyle"));
                }
                return this._ProductStyle;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductStyleSingle _ProductStyle;
        /// <summary>
        /// There are no comments for ProductSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductSizeSingle ProductSize
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductSize == null))
                {
                    this._ProductSize = new global::Microsoft.Dynamics.DataEntities.ProductSizeSingle(this.Context, GetPath("ProductSize"));
                }
                return this._ProductSize;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductSizeSingle _ProductSize;
    }
        /// <summary>
        /// There are no comments for MonthlyCostStatementEntry in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// CostStatementType
    /// AccountingMonthStartDate
    /// LevelOneCostStatementLineCategoryName
    /// LevelTwoCostStatementLineCategoryName
    /// LevelThreeCostStatementLineCategoryName
    /// OperationalSiteId
    /// CostResourceType
    /// CostResourceNumber
    /// ProductConfigurationId
    /// ProductColorId
    /// ProductSizeId
    /// ProductStyleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CostStatementType", "AccountingMonthStartDate", "LevelOneCostStatementLineCategoryName", "LevelTwoCostStatementLineCategoryName", "LevelThreeCostStatementLineCategoryName", "OperationalSiteId", "CostResourceType", "CostResourceNumber", "ProductConfigurationId", "ProductColorId", "ProductSizeId", "ProductStyleId")]
    [global::Microsoft.OData.Client.EntitySet("MonthlyCostStatementEntries")]
    public partial class MonthlyCostStatementEntry : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new MonthlyCostStatementEntry object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="accountingMonthStartDate">Initial value of AccountingMonthStartDate.</param>
        /// <param name="operationalSiteId">Initial value of OperationalSiteId.</param>
        /// <param name="costResourceNumber">Initial value of CostResourceNumber.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="costAmount">Initial value of CostAmount.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static MonthlyCostStatementEntry CreateMonthlyCostStatementEntry(string dataAreaId, 
                    global::System.DateTimeOffset accountingMonthStartDate, 
                    string operationalSiteId, 
                    string costResourceNumber, 
                    string productConfigurationId, 
                    string productColorId, 
                    string productSizeId, 
                    string productStyleId, 
                    decimal costAmount, 
                    decimal quantity)
        {
            MonthlyCostStatementEntry monthlyCostStatementEntry = new MonthlyCostStatementEntry();
            monthlyCostStatementEntry.dataAreaId = dataAreaId;
            monthlyCostStatementEntry.AccountingMonthStartDate = accountingMonthStartDate;
            monthlyCostStatementEntry.OperationalSiteId = operationalSiteId;
            monthlyCostStatementEntry.CostResourceNumber = costResourceNumber;
            monthlyCostStatementEntry.ProductConfigurationId = productConfigurationId;
            monthlyCostStatementEntry.ProductColorId = productColorId;
            monthlyCostStatementEntry.ProductSizeId = productSizeId;
            monthlyCostStatementEntry.ProductStyleId = productStyleId;
            monthlyCostStatementEntry.CostAmount = costAmount;
            monthlyCostStatementEntry.Quantity = quantity;
            return monthlyCostStatementEntry;
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
        /// There are no comments for Property CostStatementType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementType> CostStatementType
        {
            get
            {
                return this._CostStatementType;
            }
            set
            {
                this.OnCostStatementTypeChanging(value);
                this._CostStatementType = value;
                this.OnCostStatementTypeChanged();
                this.OnPropertyChanged("CostStatementType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementType> _CostStatementType;
        partial void OnCostStatementTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementType> value);
        partial void OnCostStatementTypeChanged();
        /// <summary>
        /// There are no comments for Property AccountingMonthStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset AccountingMonthStartDate
        {
            get
            {
                return this._AccountingMonthStartDate;
            }
            set
            {
                this.OnAccountingMonthStartDateChanging(value);
                this._AccountingMonthStartDate = value;
                this.OnAccountingMonthStartDateChanged();
                this.OnPropertyChanged("AccountingMonthStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _AccountingMonthStartDate;
        partial void OnAccountingMonthStartDateChanging(global::System.DateTimeOffset value);
        partial void OnAccountingMonthStartDateChanged();
        /// <summary>
        /// There are no comments for Property LevelOneCostStatementLineCategoryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementLineCategoryLevel1> LevelOneCostStatementLineCategoryName
        {
            get
            {
                return this._LevelOneCostStatementLineCategoryName;
            }
            set
            {
                this.OnLevelOneCostStatementLineCategoryNameChanging(value);
                this._LevelOneCostStatementLineCategoryName = value;
                this.OnLevelOneCostStatementLineCategoryNameChanged();
                this.OnPropertyChanged("LevelOneCostStatementLineCategoryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementLineCategoryLevel1> _LevelOneCostStatementLineCategoryName;
        partial void OnLevelOneCostStatementLineCategoryNameChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementLineCategoryLevel1> value);
        partial void OnLevelOneCostStatementLineCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property LevelTwoCostStatementLineCategoryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementLineCategoryLevel2> LevelTwoCostStatementLineCategoryName
        {
            get
            {
                return this._LevelTwoCostStatementLineCategoryName;
            }
            set
            {
                this.OnLevelTwoCostStatementLineCategoryNameChanging(value);
                this._LevelTwoCostStatementLineCategoryName = value;
                this.OnLevelTwoCostStatementLineCategoryNameChanged();
                this.OnPropertyChanged("LevelTwoCostStatementLineCategoryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementLineCategoryLevel2> _LevelTwoCostStatementLineCategoryName;
        partial void OnLevelTwoCostStatementLineCategoryNameChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementLineCategoryLevel2> value);
        partial void OnLevelTwoCostStatementLineCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property LevelThreeCostStatementLineCategoryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementLineCategoryLevel3> LevelThreeCostStatementLineCategoryName
        {
            get
            {
                return this._LevelThreeCostStatementLineCategoryName;
            }
            set
            {
                this.OnLevelThreeCostStatementLineCategoryNameChanging(value);
                this._LevelThreeCostStatementLineCategoryName = value;
                this.OnLevelThreeCostStatementLineCategoryNameChanged();
                this.OnPropertyChanged("LevelThreeCostStatementLineCategoryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementLineCategoryLevel3> _LevelThreeCostStatementLineCategoryName;
        partial void OnLevelThreeCostStatementLineCategoryNameChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementLineCategoryLevel3> value);
        partial void OnLevelThreeCostStatementLineCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property OperationalSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OperationalSiteId
        {
            get
            {
                return this._OperationalSiteId;
            }
            set
            {
                this.OnOperationalSiteIdChanging(value);
                this._OperationalSiteId = value;
                this.OnOperationalSiteIdChanged();
                this.OnPropertyChanged("OperationalSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OperationalSiteId;
        partial void OnOperationalSiteIdChanging(string value);
        partial void OnOperationalSiteIdChanged();
        /// <summary>
        /// There are no comments for Property CostResourceType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventValueReportResourceType> CostResourceType
        {
            get
            {
                return this._CostResourceType;
            }
            set
            {
                this.OnCostResourceTypeChanging(value);
                this._CostResourceType = value;
                this.OnCostResourceTypeChanged();
                this.OnPropertyChanged("CostResourceType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventValueReportResourceType> _CostResourceType;
        partial void OnCostResourceTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventValueReportResourceType> value);
        partial void OnCostResourceTypeChanged();
        /// <summary>
        /// There are no comments for Property CostResourceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CostResourceNumber
        {
            get
            {
                return this._CostResourceNumber;
            }
            set
            {
                this.OnCostResourceNumberChanging(value);
                this._CostResourceNumber = value;
                this.OnCostResourceNumberChanged();
                this.OnPropertyChanged("CostResourceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CostResourceNumber;
        partial void OnCostResourceNumberChanging(string value);
        partial void OnCostResourceNumberChanged();
        /// <summary>
        /// There are no comments for Property ProductConfigurationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductConfigurationId
        {
            get
            {
                return this._ProductConfigurationId;
            }
            set
            {
                this.OnProductConfigurationIdChanging(value);
                this._ProductConfigurationId = value;
                this.OnProductConfigurationIdChanged();
                this.OnPropertyChanged("ProductConfigurationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductConfigurationId;
        partial void OnProductConfigurationIdChanging(string value);
        partial void OnProductConfigurationIdChanged();
        /// <summary>
        /// There are no comments for Property ProductColorId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductColorId
        {
            get
            {
                return this._ProductColorId;
            }
            set
            {
                this.OnProductColorIdChanging(value);
                this._ProductColorId = value;
                this.OnProductColorIdChanged();
                this.OnPropertyChanged("ProductColorId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductColorId;
        partial void OnProductColorIdChanging(string value);
        partial void OnProductColorIdChanged();
        /// <summary>
        /// There are no comments for Property ProductSizeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductSizeId
        {
            get
            {
                return this._ProductSizeId;
            }
            set
            {
                this.OnProductSizeIdChanging(value);
                this._ProductSizeId = value;
                this.OnProductSizeIdChanged();
                this.OnPropertyChanged("ProductSizeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductSizeId;
        partial void OnProductSizeIdChanging(string value);
        partial void OnProductSizeIdChanged();
        /// <summary>
        /// There are no comments for Property ProductStyleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductStyleId
        {
            get
            {
                return this._ProductStyleId;
            }
            set
            {
                this.OnProductStyleIdChanging(value);
                this._ProductStyleId = value;
                this.OnProductStyleIdChanged();
                this.OnPropertyChanged("ProductStyleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductStyleId;
        partial void OnProductStyleIdChanging(string value);
        partial void OnProductStyleIdChanged();
        /// <summary>
        /// There are no comments for Property CostResourceGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CostResourceGroupId
        {
            get
            {
                return this._CostResourceGroupId;
            }
            set
            {
                this.OnCostResourceGroupIdChanging(value);
                this._CostResourceGroupId = value;
                this.OnCostResourceGroupIdChanged();
                this.OnPropertyChanged("CostResourceGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CostResourceGroupId;
        partial void OnCostResourceGroupIdChanging(string value);
        partial void OnCostResourceGroupIdChanged();
        /// <summary>
        /// There are no comments for Property CostAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CostAmount
        {
            get
            {
                return this._CostAmount;
            }
            set
            {
                this.OnCostAmountChanging(value);
                this._CostAmount = value;
                this.OnCostAmountChanged();
                this.OnPropertyChanged("CostAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CostAmount;
        partial void OnCostAmountChanging(decimal value);
        partial void OnCostAmountChanged();
        /// <summary>
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this.OnQuantityChanging(value);
                this._Quantity = value;
                this.OnQuantityChanged();
                this.OnPropertyChanged("Quantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Quantity;
        partial void OnQuantityChanging(decimal value);
        partial void OnQuantityChanged();
        /// <summary>
        /// There are no comments for Property OperationalSite in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperationalSite OperationalSite
        {
            get
            {
                return this._OperationalSite;
            }
            set
            {
                this.OnOperationalSiteChanging(value);
                this._OperationalSite = value;
                this.OnOperationalSiteChanged();
                this.OnPropertyChanged("OperationalSite");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperationalSite _OperationalSite;
        partial void OnOperationalSiteChanging(global::Microsoft.Dynamics.DataEntities.OperationalSite value);
        partial void OnOperationalSiteChanged();
        /// <summary>
        /// There are no comments for Property ProductColor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductColor ProductColor
        {
            get
            {
                return this._ProductColor;
            }
            set
            {
                this.OnProductColorChanging(value);
                this._ProductColor = value;
                this.OnProductColorChanged();
                this.OnPropertyChanged("ProductColor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductColor _ProductColor;
        partial void OnProductColorChanging(global::Microsoft.Dynamics.DataEntities.ProductColor value);
        partial void OnProductColorChanged();
        /// <summary>
        /// There are no comments for Property ProductStyle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductStyle ProductStyle
        {
            get
            {
                return this._ProductStyle;
            }
            set
            {
                this.OnProductStyleChanging(value);
                this._ProductStyle = value;
                this.OnProductStyleChanged();
                this.OnPropertyChanged("ProductStyle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductStyle _ProductStyle;
        partial void OnProductStyleChanging(global::Microsoft.Dynamics.DataEntities.ProductStyle value);
        partial void OnProductStyleChanged();
        /// <summary>
        /// There are no comments for Property ProductSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductSize ProductSize
        {
            get
            {
                return this._ProductSize;
            }
            set
            {
                this.OnProductSizeChanging(value);
                this._ProductSize = value;
                this.OnProductSizeChanged();
                this.OnPropertyChanged("ProductSize");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductSize _ProductSize;
        partial void OnProductSizeChanging(global::Microsoft.Dynamics.DataEntities.ProductSize value);
        partial void OnProductSizeChanged();
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
