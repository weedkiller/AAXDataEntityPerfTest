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
        /// There are no comments for AssetMaintenanceAssetBillOfMaterialSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceAssetBillOfMaterialSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetBillOfMaterial>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceAssetBillOfMaterialSingle object.
        /// </summary>
        public AssetMaintenanceAssetBillOfMaterialSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetBillOfMaterialSingle object.
        /// </summary>
        public AssetMaintenanceAssetBillOfMaterialSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetBillOfMaterialSingle object.
        /// </summary>
        public AssetMaintenanceAssetBillOfMaterialSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetBillOfMaterial> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetSingle AssetMaintenanceAsset
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAsset == null))
                {
                    this._AssetMaintenanceAsset = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetSingle(this.Context, GetPath("AssetMaintenanceAsset"));
                }
                return this._AssetMaintenanceAsset;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetSingle _AssetMaintenanceAsset;
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceAssetBillOfMaterial in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// MaintenanceAssetId
    /// LineNumber
    /// ValidFrom
    /// ValidTo
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "MaintenanceAssetId", "LineNumber", "ValidFrom", "ValidTo")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceAssetBillOfMaterials")]
    public partial class AssetMaintenanceAssetBillOfMaterial : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceAssetBillOfMaterial object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="maintenanceAssetId">Initial value of MaintenanceAssetId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="lineNumberReplacedBy">Initial value of LineNumberReplacedBy.</param>
        /// <param name="billOfMaterialQuantity">Initial value of BillOfMaterialQuantity.</param>
        /// <param name="assetMaintenanceAsset">Initial value of AssetMaintenanceAsset.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceAssetBillOfMaterial CreateAssetMaintenanceAssetBillOfMaterial(string dataAreaId, 
                    string maintenanceAssetId, 
                    long lineNumber, 
                    global::System.DateTimeOffset validFrom, 
                    global::System.DateTimeOffset validTo, 
                    long lineNumberReplacedBy, 
                    decimal billOfMaterialQuantity, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset assetMaintenanceAsset)
        {
            AssetMaintenanceAssetBillOfMaterial assetMaintenanceAssetBillOfMaterial = new AssetMaintenanceAssetBillOfMaterial();
            assetMaintenanceAssetBillOfMaterial.dataAreaId = dataAreaId;
            assetMaintenanceAssetBillOfMaterial.MaintenanceAssetId = maintenanceAssetId;
            assetMaintenanceAssetBillOfMaterial.LineNumber = lineNumber;
            assetMaintenanceAssetBillOfMaterial.ValidFrom = validFrom;
            assetMaintenanceAssetBillOfMaterial.ValidTo = validTo;
            assetMaintenanceAssetBillOfMaterial.LineNumberReplacedBy = lineNumberReplacedBy;
            assetMaintenanceAssetBillOfMaterial.BillOfMaterialQuantity = billOfMaterialQuantity;
            if ((assetMaintenanceAsset == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceAsset");
            }
            assetMaintenanceAssetBillOfMaterial.AssetMaintenanceAsset = assetMaintenanceAsset;
            return assetMaintenanceAssetBillOfMaterial;
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
        /// There are no comments for Property MaintenanceAssetId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MaintenanceAssetId
        {
            get
            {
                return this._MaintenanceAssetId;
            }
            set
            {
                this.OnMaintenanceAssetIdChanging(value);
                this._MaintenanceAssetId = value;
                this.OnMaintenanceAssetIdChanged();
                this.OnPropertyChanged("MaintenanceAssetId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaintenanceAssetId;
        partial void OnMaintenanceAssetIdChanging(string value);
        partial void OnMaintenanceAssetIdChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _LineNumber;
        partial void OnLineNumberChanging(long value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTimeOffset value);
        partial void OnValidFromChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidTo;
        partial void OnValidToChanging(global::System.DateTimeOffset value);
        partial void OnValidToChanged();
        /// <summary>
        /// There are no comments for Property InventoryColorId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InventoryColorId
        {
            get
            {
                return this._InventoryColorId;
            }
            set
            {
                this.OnInventoryColorIdChanging(value);
                this._InventoryColorId = value;
                this.OnInventoryColorIdChanged();
                this.OnPropertyChanged("InventoryColorId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventoryColorId;
        partial void OnInventoryColorIdChanging(string value);
        partial void OnInventoryColorIdChanged();
        /// <summary>
        /// There are no comments for Property InventoryConfigId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InventoryConfigId
        {
            get
            {
                return this._InventoryConfigId;
            }
            set
            {
                this.OnInventoryConfigIdChanging(value);
                this._InventoryConfigId = value;
                this.OnInventoryConfigIdChanged();
                this.OnPropertyChanged("InventoryConfigId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventoryConfigId;
        partial void OnInventoryConfigIdChanging(string value);
        partial void OnInventoryConfigIdChanged();
        /// <summary>
        /// There are no comments for Property InventorySerialId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InventorySerialId
        {
            get
            {
                return this._InventorySerialId;
            }
            set
            {
                this.OnInventorySerialIdChanging(value);
                this._InventorySerialId = value;
                this.OnInventorySerialIdChanged();
                this.OnPropertyChanged("InventorySerialId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventorySerialId;
        partial void OnInventorySerialIdChanging(string value);
        partial void OnInventorySerialIdChanged();
        /// <summary>
        /// There are no comments for Property InventoryBatchId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InventoryBatchId
        {
            get
            {
                return this._InventoryBatchId;
            }
            set
            {
                this.OnInventoryBatchIdChanging(value);
                this._InventoryBatchId = value;
                this.OnInventoryBatchIdChanged();
                this.OnPropertyChanged("InventoryBatchId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventoryBatchId;
        partial void OnInventoryBatchIdChanging(string value);
        partial void OnInventoryBatchIdChanged();
        /// <summary>
        /// There are no comments for Property InventoryVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InventoryVersionId
        {
            get
            {
                return this._InventoryVersionId;
            }
            set
            {
                this.OnInventoryVersionIdChanging(value);
                this._InventoryVersionId = value;
                this.OnInventoryVersionIdChanged();
                this.OnPropertyChanged("InventoryVersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventoryVersionId;
        partial void OnInventoryVersionIdChanging(string value);
        partial void OnInventoryVersionIdChanged();
        /// <summary>
        /// There are no comments for Property LineNumberReplacedBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long LineNumberReplacedBy
        {
            get
            {
                return this._LineNumberReplacedBy;
            }
            set
            {
                this.OnLineNumberReplacedByChanging(value);
                this._LineNumberReplacedBy = value;
                this.OnLineNumberReplacedByChanged();
                this.OnPropertyChanged("LineNumberReplacedBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _LineNumberReplacedBy;
        partial void OnLineNumberReplacedByChanging(long value);
        partial void OnLineNumberReplacedByChanged();
        /// <summary>
        /// There are no comments for Property BillOfMaterialQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal BillOfMaterialQuantity
        {
            get
            {
                return this._BillOfMaterialQuantity;
            }
            set
            {
                this.OnBillOfMaterialQuantityChanging(value);
                this._BillOfMaterialQuantity = value;
                this.OnBillOfMaterialQuantityChanged();
                this.OnPropertyChanged("BillOfMaterialQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _BillOfMaterialQuantity;
        partial void OnBillOfMaterialQuantityChanging(decimal value);
        partial void OnBillOfMaterialQuantityChanged();
        /// <summary>
        /// There are no comments for Property InventorySizeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InventorySizeId
        {
            get
            {
                return this._InventorySizeId;
            }
            set
            {
                this.OnInventorySizeIdChanging(value);
                this._InventorySizeId = value;
                this.OnInventorySizeIdChanged();
                this.OnPropertyChanged("InventorySizeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventorySizeId;
        partial void OnInventorySizeIdChanging(string value);
        partial void OnInventorySizeIdChanged();
        /// <summary>
        /// There are no comments for Property InventVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InventVersionId
        {
            get
            {
                return this._InventVersionId;
            }
            set
            {
                this.OnInventVersionIdChanging(value);
                this._InventVersionId = value;
                this.OnInventVersionIdChanged();
                this.OnPropertyChanged("InventVersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventVersionId;
        partial void OnInventVersionIdChanging(string value);
        partial void OnInventVersionIdChanged();
        /// <summary>
        /// There are no comments for Property ItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ItemId
        {
            get
            {
                return this._ItemId;
            }
            set
            {
                this.OnItemIdChanging(value);
                this._ItemId = value;
                this.OnItemIdChanged();
                this.OnPropertyChanged("ItemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemId;
        partial void OnItemIdChanging(string value);
        partial void OnItemIdChanged();
        /// <summary>
        /// There are no comments for Property InventoryStyleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InventoryStyleId
        {
            get
            {
                return this._InventoryStyleId;
            }
            set
            {
                this.OnInventoryStyleIdChanging(value);
                this._InventoryStyleId = value;
                this.OnInventoryStyleIdChanged();
                this.OnPropertyChanged("InventoryStyleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventoryStyleId;
        partial void OnInventoryStyleIdChanging(string value);
        partial void OnInventoryStyleIdChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset AssetMaintenanceAsset
        {
            get
            {
                return this._AssetMaintenanceAsset;
            }
            set
            {
                this.OnAssetMaintenanceAssetChanging(value);
                this._AssetMaintenanceAsset = value;
                this.OnAssetMaintenanceAssetChanged();
                this.OnPropertyChanged("AssetMaintenanceAsset");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset _AssetMaintenanceAsset;
        partial void OnAssetMaintenanceAssetChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset value);
        partial void OnAssetMaintenanceAssetChanged();
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
