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
        /// There are no comments for BillOfMaterialsVersionSingle in the schema.
        /// </summary>
    public partial class BillOfMaterialsVersionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BillOfMaterialsVersion>
    {
        /// <summary>
        /// Initialize a new BillOfMaterialsVersionSingle object.
        /// </summary>
        public BillOfMaterialsVersionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BillOfMaterialsVersionSingle object.
        /// </summary>
        public BillOfMaterialsVersionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BillOfMaterialsVersionSingle object.
        /// </summary>
        public BillOfMaterialsVersionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BillOfMaterialsVersion> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ApprovingWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle ApprovingWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ApprovingWorker == null))
                {
                    this._ApprovingWorker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("ApprovingWorker"));
                }
                return this._ApprovingWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _ApprovingWorker;
        /// <summary>
        /// There are no comments for BillOfMaterialsHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BillOfMaterialsHeaderSingle BillOfMaterialsHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BillOfMaterialsHeader == null))
                {
                    this._BillOfMaterialsHeader = new global::Microsoft.Dynamics.DataEntities.BillOfMaterialsHeaderSingle(this.Context, GetPath("BillOfMaterialsHeader"));
                }
                return this._BillOfMaterialsHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BillOfMaterialsHeaderSingle _BillOfMaterialsHeader;
    }
        /// <summary>
        /// There are no comments for BillOfMaterialsVersion in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ManufacturedItemNumber
    /// BOMId
    /// ProductionSiteId
    /// ProductConfigurationId
    /// ProductColorId
    /// ProductSizeId
    /// ProductStyleId
    /// IsActive
    /// ValidFromDate
    /// FromQuantity
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ManufacturedItemNumber", "BOMId", "ProductionSiteId", "ProductConfigurationId", "ProductColorId", "ProductSizeId", "ProductStyleId", "IsActive", "ValidFromDate", "FromQuantity")]
    [global::Microsoft.OData.Client.EntitySet("BillOfMaterialsVersions")]
    public partial class BillOfMaterialsVersion : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BillOfMaterialsVersion object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="manufacturedItemNumber">Initial value of ManufacturedItemNumber.</param>
        /// <param name="bOMId">Initial value of BOMId.</param>
        /// <param name="productionSiteId">Initial value of ProductionSiteId.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="isActive">Initial value of IsActive.</param>
        /// <param name="validFromDate">Initial value of ValidFromDate.</param>
        /// <param name="fromQuantity">Initial value of FromQuantity.</param>
        /// <param name="catchWeightSize">Initial value of CatchWeightSize.</param>
        /// <param name="approverId">Initial value of ApproverId.</param>
        /// <param name="fromCatchWeightQuantity">Initial value of FromCatchWeightQuantity.</param>
        /// <param name="validToDate">Initial value of ValidToDate.</param>
        /// <param name="billOfMaterialsHeader">Initial value of BillOfMaterialsHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BillOfMaterialsVersion CreateBillOfMaterialsVersion(string dataAreaId, 
                    string manufacturedItemNumber, 
                    string bOMId, 
                    string productionSiteId, 
                    string productConfigurationId, 
                    string productColorId, 
                    string productSizeId, 
                    string productStyleId, 
                    int isActive, 
                    global::System.DateTimeOffset validFromDate, 
                    decimal fromQuantity, 
                    decimal catchWeightSize, 
                    long approverId, 
                    decimal fromCatchWeightQuantity, 
                    global::System.DateTimeOffset validToDate, 
                    global::Microsoft.Dynamics.DataEntities.BillOfMaterialsHeader billOfMaterialsHeader)
        {
            BillOfMaterialsVersion billOfMaterialsVersion = new BillOfMaterialsVersion();
            billOfMaterialsVersion.dataAreaId = dataAreaId;
            billOfMaterialsVersion.ManufacturedItemNumber = manufacturedItemNumber;
            billOfMaterialsVersion.BOMId = bOMId;
            billOfMaterialsVersion.ProductionSiteId = productionSiteId;
            billOfMaterialsVersion.ProductConfigurationId = productConfigurationId;
            billOfMaterialsVersion.ProductColorId = productColorId;
            billOfMaterialsVersion.ProductSizeId = productSizeId;
            billOfMaterialsVersion.ProductStyleId = productStyleId;
            billOfMaterialsVersion.IsActive = isActive;
            billOfMaterialsVersion.ValidFromDate = validFromDate;
            billOfMaterialsVersion.FromQuantity = fromQuantity;
            billOfMaterialsVersion.CatchWeightSize = catchWeightSize;
            billOfMaterialsVersion.ApproverId = approverId;
            billOfMaterialsVersion.FromCatchWeightQuantity = fromCatchWeightQuantity;
            billOfMaterialsVersion.ValidToDate = validToDate;
            if ((billOfMaterialsHeader == null))
            {
                throw new global::System.ArgumentNullException("billOfMaterialsHeader");
            }
            billOfMaterialsVersion.BillOfMaterialsHeader = billOfMaterialsHeader;
            return billOfMaterialsVersion;
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
        /// There are no comments for Property ManufacturedItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ManufacturedItemNumber
        {
            get
            {
                return this._ManufacturedItemNumber;
            }
            set
            {
                this.OnManufacturedItemNumberChanging(value);
                this._ManufacturedItemNumber = value;
                this.OnManufacturedItemNumberChanged();
                this.OnPropertyChanged("ManufacturedItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ManufacturedItemNumber;
        partial void OnManufacturedItemNumberChanging(string value);
        partial void OnManufacturedItemNumberChanged();
        /// <summary>
        /// There are no comments for Property BOMId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BOMId
        {
            get
            {
                return this._BOMId;
            }
            set
            {
                this.OnBOMIdChanging(value);
                this._BOMId = value;
                this.OnBOMIdChanged();
                this.OnPropertyChanged("BOMId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BOMId;
        partial void OnBOMIdChanging(string value);
        partial void OnBOMIdChanged();
        /// <summary>
        /// There are no comments for Property ProductionSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductionSiteId
        {
            get
            {
                return this._ProductionSiteId;
            }
            set
            {
                this.OnProductionSiteIdChanging(value);
                this._ProductionSiteId = value;
                this.OnProductionSiteIdChanged();
                this.OnPropertyChanged("ProductionSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductionSiteId;
        partial void OnProductionSiteIdChanging(string value);
        partial void OnProductionSiteIdChanged();
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
        /// There are no comments for Property IsActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int IsActive
        {
            get
            {
                return this._IsActive;
            }
            set
            {
                this.OnIsActiveChanging(value);
                this._IsActive = value;
                this.OnIsActiveChanged();
                this.OnPropertyChanged("IsActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _IsActive;
        partial void OnIsActiveChanging(int value);
        partial void OnIsActiveChanged();
        /// <summary>
        /// There are no comments for Property ValidFromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidFromDate
        {
            get
            {
                return this._ValidFromDate;
            }
            set
            {
                this.OnValidFromDateChanging(value);
                this._ValidFromDate = value;
                this.OnValidFromDateChanged();
                this.OnPropertyChanged("ValidFromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFromDate;
        partial void OnValidFromDateChanging(global::System.DateTimeOffset value);
        partial void OnValidFromDateChanged();
        /// <summary>
        /// There are no comments for Property FromQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal FromQuantity
        {
            get
            {
                return this._FromQuantity;
            }
            set
            {
                this.OnFromQuantityChanging(value);
                this._FromQuantity = value;
                this.OnFromQuantityChanged();
                this.OnPropertyChanged("FromQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FromQuantity;
        partial void OnFromQuantityChanging(decimal value);
        partial void OnFromQuantityChanged();
        /// <summary>
        /// There are no comments for Property CatchWeightSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CatchWeightSize
        {
            get
            {
                return this._CatchWeightSize;
            }
            set
            {
                this.OnCatchWeightSizeChanging(value);
                this._CatchWeightSize = value;
                this.OnCatchWeightSizeChanged();
                this.OnPropertyChanged("CatchWeightSize");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CatchWeightSize;
        partial void OnCatchWeightSizeChanging(decimal value);
        partial void OnCatchWeightSizeChanged();
        /// <summary>
        /// There are no comments for Property ApproverId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long ApproverId
        {
            get
            {
                return this._ApproverId;
            }
            set
            {
                this.OnApproverIdChanging(value);
                this._ApproverId = value;
                this.OnApproverIdChanged();
                this.OnPropertyChanged("ApproverId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _ApproverId;
        partial void OnApproverIdChanging(long value);
        partial void OnApproverIdChanged();
        /// <summary>
        /// There are no comments for Property VersionName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VersionName
        {
            get
            {
                return this._VersionName;
            }
            set
            {
                this.OnVersionNameChanging(value);
                this._VersionName = value;
                this.OnVersionNameChanged();
                this.OnPropertyChanged("VersionName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VersionName;
        partial void OnVersionNameChanging(string value);
        partial void OnVersionNameChanged();
        /// <summary>
        /// There are no comments for Property IsSelectedForDesigner in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsSelectedForDesigner
        {
            get
            {
                return this._IsSelectedForDesigner;
            }
            set
            {
                this.OnIsSelectedForDesignerChanging(value);
                this._IsSelectedForDesigner = value;
                this.OnIsSelectedForDesignerChanged();
                this.OnPropertyChanged("IsSelectedForDesigner");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsSelectedForDesigner;
        partial void OnIsSelectedForDesignerChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsSelectedForDesignerChanged();
        /// <summary>
        /// There are no comments for Property FromCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal FromCatchWeightQuantity
        {
            get
            {
                return this._FromCatchWeightQuantity;
            }
            set
            {
                this.OnFromCatchWeightQuantityChanging(value);
                this._FromCatchWeightQuantity = value;
                this.OnFromCatchWeightQuantityChanged();
                this.OnPropertyChanged("FromCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FromCatchWeightQuantity;
        partial void OnFromCatchWeightQuantityChanging(decimal value);
        partial void OnFromCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property ApproverPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ApproverPersonnelNumber
        {
            get
            {
                return this._ApproverPersonnelNumber;
            }
            set
            {
                this.OnApproverPersonnelNumberChanging(value);
                this._ApproverPersonnelNumber = value;
                this.OnApproverPersonnelNumberChanged();
                this.OnPropertyChanged("ApproverPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ApproverPersonnelNumber;
        partial void OnApproverPersonnelNumberChanging(string value);
        partial void OnApproverPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property IsApproved in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsApproved
        {
            get
            {
                return this._IsApproved;
            }
            set
            {
                this.OnIsApprovedChanging(value);
                this._IsApproved = value;
                this.OnIsApprovedChanged();
                this.OnPropertyChanged("IsApproved");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsApproved;
        partial void OnIsApprovedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsApprovedChanged();
        /// <summary>
        /// There are no comments for Property ValidToDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidToDate
        {
            get
            {
                return this._ValidToDate;
            }
            set
            {
                this.OnValidToDateChanging(value);
                this._ValidToDate = value;
                this.OnValidToDateChanged();
                this.OnPropertyChanged("ValidToDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidToDate;
        partial void OnValidToDateChanging(global::System.DateTimeOffset value);
        partial void OnValidToDateChanged();
        /// <summary>
        /// There are no comments for Property ApprovingWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker ApprovingWorker
        {
            get
            {
                return this._ApprovingWorker;
            }
            set
            {
                this.OnApprovingWorkerChanging(value);
                this._ApprovingWorker = value;
                this.OnApprovingWorkerChanged();
                this.OnPropertyChanged("ApprovingWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _ApprovingWorker;
        partial void OnApprovingWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnApprovingWorkerChanged();
        /// <summary>
        /// There are no comments for Property BillOfMaterialsHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BillOfMaterialsHeader BillOfMaterialsHeader
        {
            get
            {
                return this._BillOfMaterialsHeader;
            }
            set
            {
                this.OnBillOfMaterialsHeaderChanging(value);
                this._BillOfMaterialsHeader = value;
                this.OnBillOfMaterialsHeaderChanged();
                this.OnPropertyChanged("BillOfMaterialsHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BillOfMaterialsHeader _BillOfMaterialsHeader;
        partial void OnBillOfMaterialsHeaderChanging(global::Microsoft.Dynamics.DataEntities.BillOfMaterialsHeader value);
        partial void OnBillOfMaterialsHeaderChanged();
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
