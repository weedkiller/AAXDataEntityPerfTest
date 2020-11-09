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
        /// There are no comments for WarehouseInventoryStatusOnHandIncludingCatchWeightItemSingle in the schema.
        /// </summary>
    public partial class WarehouseInventoryStatusOnHandIncludingCatchWeightItemSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseInventoryStatusOnHandIncludingCatchWeightItem>
    {
        /// <summary>
        /// Initialize a new WarehouseInventoryStatusOnHandIncludingCatchWeightItemSingle object.
        /// </summary>
        public WarehouseInventoryStatusOnHandIncludingCatchWeightItemSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WarehouseInventoryStatusOnHandIncludingCatchWeightItemSingle object.
        /// </summary>
        public WarehouseInventoryStatusOnHandIncludingCatchWeightItemSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WarehouseInventoryStatusOnHandIncludingCatchWeightItemSingle object.
        /// </summary>
        public WarehouseInventoryStatusOnHandIncludingCatchWeightItemSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseInventoryStatusOnHandIncludingCatchWeightItem> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for WarehouseInventoryStatusOnHandIncludingCatchWeightItem in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ItemNumber
    /// ProductColorId
    /// ProductConfigurationId
    /// ProductSizeId
    /// ProductStyleId
    /// ProductVersionId
    /// InventorySiteId
    /// InventoryWarehouseId
    /// InventoryStatusId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ItemNumber", "ProductColorId", "ProductConfigurationId", "ProductSizeId", "ProductStyleId", "ProductVersionId", "InventorySiteId", "InventoryWarehouseId", "InventoryStatusId")]
    [global::Microsoft.OData.Client.EntitySet("WarehouseInventoryStatusOnHandIncludingCatchWeightItems")]
    public partial class WarehouseInventoryStatusOnHandIncludingCatchWeightItem : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WarehouseInventoryStatusOnHandIncludingCatchWeightItem object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="productVersionId">Initial value of ProductVersionId.</param>
        /// <param name="inventorySiteId">Initial value of InventorySiteId.</param>
        /// <param name="inventoryWarehouseId">Initial value of InventoryWarehouseId.</param>
        /// <param name="inventoryStatusId">Initial value of InventoryStatusId.</param>
        /// <param name="availableOnHandQuantity">Initial value of AvailableOnHandQuantity.</param>
        /// <param name="availableOnHandCatchWeightQuantity">Initial value of AvailableOnHandCatchWeightQuantity.</param>
        /// <param name="onHandCatchWeightQuantity">Initial value of OnHandCatchWeightQuantity.</param>
        /// <param name="reservedOnHandQuantity">Initial value of ReservedOnHandQuantity.</param>
        /// <param name="availableOrderedQuantity">Initial value of AvailableOrderedQuantity.</param>
        /// <param name="availableOrderedCatchWeightQuantity">Initial value of AvailableOrderedCatchWeightQuantity.</param>
        /// <param name="onOrderCatchWeightQuantity">Initial value of OnOrderCatchWeightQuantity.</param>
        /// <param name="orderedCatchWeightQuantity">Initial value of OrderedCatchWeightQuantity.</param>
        /// <param name="reservedOrderedQuantity">Initial value of ReservedOrderedQuantity.</param>
        /// <param name="reservedOrderedCatchWeightQuantity">Initial value of ReservedOrderedCatchWeightQuantity.</param>
        /// <param name="onHandQuantity">Initial value of OnHandQuantity.</param>
        /// <param name="reservedOnHandCatchWeightQuantity">Initial value of ReservedOnHandCatchWeightQuantity.</param>
        /// <param name="orderedQuantity">Initial value of OrderedQuantity.</param>
        /// <param name="totalAvailableCatchWeightQuantity">Initial value of TotalAvailableCatchWeightQuantity.</param>
        /// <param name="onOrderQuantity">Initial value of OnOrderQuantity.</param>
        /// <param name="totalAvailableQuantity">Initial value of TotalAvailableQuantity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WarehouseInventoryStatusOnHandIncludingCatchWeightItem CreateWarehouseInventoryStatusOnHandIncludingCatchWeightItem(string dataAreaId, 
                    string itemNumber, 
                    string productColorId, 
                    string productConfigurationId, 
                    string productSizeId, 
                    string productStyleId, 
                    string productVersionId, 
                    string inventorySiteId, 
                    string inventoryWarehouseId, 
                    string inventoryStatusId, 
                    decimal availableOnHandQuantity, 
                    decimal availableOnHandCatchWeightQuantity, 
                    decimal onHandCatchWeightQuantity, 
                    decimal reservedOnHandQuantity, 
                    decimal availableOrderedQuantity, 
                    decimal availableOrderedCatchWeightQuantity, 
                    decimal onOrderCatchWeightQuantity, 
                    decimal orderedCatchWeightQuantity, 
                    decimal reservedOrderedQuantity, 
                    decimal reservedOrderedCatchWeightQuantity, 
                    decimal onHandQuantity, 
                    decimal reservedOnHandCatchWeightQuantity, 
                    decimal orderedQuantity, 
                    decimal totalAvailableCatchWeightQuantity, 
                    decimal onOrderQuantity, 
                    decimal totalAvailableQuantity)
        {
            WarehouseInventoryStatusOnHandIncludingCatchWeightItem warehouseInventoryStatusOnHandIncludingCatchWeightItem = new WarehouseInventoryStatusOnHandIncludingCatchWeightItem();
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.dataAreaId = dataAreaId;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.ItemNumber = itemNumber;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.ProductColorId = productColorId;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.ProductConfigurationId = productConfigurationId;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.ProductSizeId = productSizeId;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.ProductStyleId = productStyleId;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.ProductVersionId = productVersionId;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.InventorySiteId = inventorySiteId;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.InventoryWarehouseId = inventoryWarehouseId;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.InventoryStatusId = inventoryStatusId;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.AvailableOnHandQuantity = availableOnHandQuantity;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.AvailableOnHandCatchWeightQuantity = availableOnHandCatchWeightQuantity;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.OnHandCatchWeightQuantity = onHandCatchWeightQuantity;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.ReservedOnHandQuantity = reservedOnHandQuantity;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.AvailableOrderedQuantity = availableOrderedQuantity;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.AvailableOrderedCatchWeightQuantity = availableOrderedCatchWeightQuantity;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.OnOrderCatchWeightQuantity = onOrderCatchWeightQuantity;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.OrderedCatchWeightQuantity = orderedCatchWeightQuantity;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.ReservedOrderedQuantity = reservedOrderedQuantity;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.ReservedOrderedCatchWeightQuantity = reservedOrderedCatchWeightQuantity;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.OnHandQuantity = onHandQuantity;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.ReservedOnHandCatchWeightQuantity = reservedOnHandCatchWeightQuantity;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.OrderedQuantity = orderedQuantity;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.TotalAvailableCatchWeightQuantity = totalAvailableCatchWeightQuantity;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.OnOrderQuantity = onOrderQuantity;
            warehouseInventoryStatusOnHandIncludingCatchWeightItem.TotalAvailableQuantity = totalAvailableQuantity;
            return warehouseInventoryStatusOnHandIncludingCatchWeightItem;
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
        /// There are no comments for Property ItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ItemNumber
        {
            get
            {
                return this._ItemNumber;
            }
            set
            {
                this.OnItemNumberChanging(value);
                this._ItemNumber = value;
                this.OnItemNumberChanged();
                this.OnPropertyChanged("ItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemNumber;
        partial void OnItemNumberChanging(string value);
        partial void OnItemNumberChanged();
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
        /// There are no comments for Property ProductVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductVersionId
        {
            get
            {
                return this._ProductVersionId;
            }
            set
            {
                this.OnProductVersionIdChanging(value);
                this._ProductVersionId = value;
                this.OnProductVersionIdChanged();
                this.OnPropertyChanged("ProductVersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductVersionId;
        partial void OnProductVersionIdChanging(string value);
        partial void OnProductVersionIdChanged();
        /// <summary>
        /// There are no comments for Property InventorySiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InventorySiteId
        {
            get
            {
                return this._InventorySiteId;
            }
            set
            {
                this.OnInventorySiteIdChanging(value);
                this._InventorySiteId = value;
                this.OnInventorySiteIdChanged();
                this.OnPropertyChanged("InventorySiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventorySiteId;
        partial void OnInventorySiteIdChanging(string value);
        partial void OnInventorySiteIdChanged();
        /// <summary>
        /// There are no comments for Property InventoryWarehouseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InventoryWarehouseId
        {
            get
            {
                return this._InventoryWarehouseId;
            }
            set
            {
                this.OnInventoryWarehouseIdChanging(value);
                this._InventoryWarehouseId = value;
                this.OnInventoryWarehouseIdChanged();
                this.OnPropertyChanged("InventoryWarehouseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventoryWarehouseId;
        partial void OnInventoryWarehouseIdChanging(string value);
        partial void OnInventoryWarehouseIdChanged();
        /// <summary>
        /// There are no comments for Property InventoryStatusId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InventoryStatusId
        {
            get
            {
                return this._InventoryStatusId;
            }
            set
            {
                this.OnInventoryStatusIdChanging(value);
                this._InventoryStatusId = value;
                this.OnInventoryStatusIdChanged();
                this.OnPropertyChanged("InventoryStatusId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventoryStatusId;
        partial void OnInventoryStatusIdChanging(string value);
        partial void OnInventoryStatusIdChanged();
        /// <summary>
        /// There are no comments for Property AvailableOnHandQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AvailableOnHandQuantity
        {
            get
            {
                return this._AvailableOnHandQuantity;
            }
            set
            {
                this.OnAvailableOnHandQuantityChanging(value);
                this._AvailableOnHandQuantity = value;
                this.OnAvailableOnHandQuantityChanged();
                this.OnPropertyChanged("AvailableOnHandQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AvailableOnHandQuantity;
        partial void OnAvailableOnHandQuantityChanging(decimal value);
        partial void OnAvailableOnHandQuantityChanged();
        /// <summary>
        /// There are no comments for Property AvailableOnHandCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AvailableOnHandCatchWeightQuantity
        {
            get
            {
                return this._AvailableOnHandCatchWeightQuantity;
            }
            set
            {
                this.OnAvailableOnHandCatchWeightQuantityChanging(value);
                this._AvailableOnHandCatchWeightQuantity = value;
                this.OnAvailableOnHandCatchWeightQuantityChanged();
                this.OnPropertyChanged("AvailableOnHandCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AvailableOnHandCatchWeightQuantity;
        partial void OnAvailableOnHandCatchWeightQuantityChanging(decimal value);
        partial void OnAvailableOnHandCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property OnHandCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal OnHandCatchWeightQuantity
        {
            get
            {
                return this._OnHandCatchWeightQuantity;
            }
            set
            {
                this.OnOnHandCatchWeightQuantityChanging(value);
                this._OnHandCatchWeightQuantity = value;
                this.OnOnHandCatchWeightQuantityChanged();
                this.OnPropertyChanged("OnHandCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OnHandCatchWeightQuantity;
        partial void OnOnHandCatchWeightQuantityChanging(decimal value);
        partial void OnOnHandCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property ReservedOnHandQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ReservedOnHandQuantity
        {
            get
            {
                return this._ReservedOnHandQuantity;
            }
            set
            {
                this.OnReservedOnHandQuantityChanging(value);
                this._ReservedOnHandQuantity = value;
                this.OnReservedOnHandQuantityChanged();
                this.OnPropertyChanged("ReservedOnHandQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReservedOnHandQuantity;
        partial void OnReservedOnHandQuantityChanging(decimal value);
        partial void OnReservedOnHandQuantityChanged();
        /// <summary>
        /// There are no comments for Property AvailableOrderedQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AvailableOrderedQuantity
        {
            get
            {
                return this._AvailableOrderedQuantity;
            }
            set
            {
                this.OnAvailableOrderedQuantityChanging(value);
                this._AvailableOrderedQuantity = value;
                this.OnAvailableOrderedQuantityChanged();
                this.OnPropertyChanged("AvailableOrderedQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AvailableOrderedQuantity;
        partial void OnAvailableOrderedQuantityChanging(decimal value);
        partial void OnAvailableOrderedQuantityChanged();
        /// <summary>
        /// There are no comments for Property ProductName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductName
        {
            get
            {
                return this._ProductName;
            }
            set
            {
                this.OnProductNameChanging(value);
                this._ProductName = value;
                this.OnProductNameChanged();
                this.OnPropertyChanged("ProductName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductName;
        partial void OnProductNameChanging(string value);
        partial void OnProductNameChanged();
        /// <summary>
        /// There are no comments for Property AvailableOrderedCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AvailableOrderedCatchWeightQuantity
        {
            get
            {
                return this._AvailableOrderedCatchWeightQuantity;
            }
            set
            {
                this.OnAvailableOrderedCatchWeightQuantityChanging(value);
                this._AvailableOrderedCatchWeightQuantity = value;
                this.OnAvailableOrderedCatchWeightQuantityChanged();
                this.OnPropertyChanged("AvailableOrderedCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AvailableOrderedCatchWeightQuantity;
        partial void OnAvailableOrderedCatchWeightQuantityChanging(decimal value);
        partial void OnAvailableOrderedCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property OnOrderCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal OnOrderCatchWeightQuantity
        {
            get
            {
                return this._OnOrderCatchWeightQuantity;
            }
            set
            {
                this.OnOnOrderCatchWeightQuantityChanging(value);
                this._OnOrderCatchWeightQuantity = value;
                this.OnOnOrderCatchWeightQuantityChanged();
                this.OnPropertyChanged("OnOrderCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OnOrderCatchWeightQuantity;
        partial void OnOnOrderCatchWeightQuantityChanging(decimal value);
        partial void OnOnOrderCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property OrderedCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal OrderedCatchWeightQuantity
        {
            get
            {
                return this._OrderedCatchWeightQuantity;
            }
            set
            {
                this.OnOrderedCatchWeightQuantityChanging(value);
                this._OrderedCatchWeightQuantity = value;
                this.OnOrderedCatchWeightQuantityChanged();
                this.OnPropertyChanged("OrderedCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OrderedCatchWeightQuantity;
        partial void OnOrderedCatchWeightQuantityChanging(decimal value);
        partial void OnOrderedCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property ReservedOrderedQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ReservedOrderedQuantity
        {
            get
            {
                return this._ReservedOrderedQuantity;
            }
            set
            {
                this.OnReservedOrderedQuantityChanging(value);
                this._ReservedOrderedQuantity = value;
                this.OnReservedOrderedQuantityChanged();
                this.OnPropertyChanged("ReservedOrderedQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReservedOrderedQuantity;
        partial void OnReservedOrderedQuantityChanging(decimal value);
        partial void OnReservedOrderedQuantityChanged();
        /// <summary>
        /// There are no comments for Property ReservedOrderedCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ReservedOrderedCatchWeightQuantity
        {
            get
            {
                return this._ReservedOrderedCatchWeightQuantity;
            }
            set
            {
                this.OnReservedOrderedCatchWeightQuantityChanging(value);
                this._ReservedOrderedCatchWeightQuantity = value;
                this.OnReservedOrderedCatchWeightQuantityChanged();
                this.OnPropertyChanged("ReservedOrderedCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReservedOrderedCatchWeightQuantity;
        partial void OnReservedOrderedCatchWeightQuantityChanging(decimal value);
        partial void OnReservedOrderedCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property OnHandQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal OnHandQuantity
        {
            get
            {
                return this._OnHandQuantity;
            }
            set
            {
                this.OnOnHandQuantityChanging(value);
                this._OnHandQuantity = value;
                this.OnOnHandQuantityChanged();
                this.OnPropertyChanged("OnHandQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OnHandQuantity;
        partial void OnOnHandQuantityChanging(decimal value);
        partial void OnOnHandQuantityChanged();
        /// <summary>
        /// There are no comments for Property ReservedOnHandCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ReservedOnHandCatchWeightQuantity
        {
            get
            {
                return this._ReservedOnHandCatchWeightQuantity;
            }
            set
            {
                this.OnReservedOnHandCatchWeightQuantityChanging(value);
                this._ReservedOnHandCatchWeightQuantity = value;
                this.OnReservedOnHandCatchWeightQuantityChanged();
                this.OnPropertyChanged("ReservedOnHandCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReservedOnHandCatchWeightQuantity;
        partial void OnReservedOnHandCatchWeightQuantityChanging(decimal value);
        partial void OnReservedOnHandCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property AreWarehouseManagementProcessesUsed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AreWarehouseManagementProcessesUsed
        {
            get
            {
                return this._AreWarehouseManagementProcessesUsed;
            }
            set
            {
                this.OnAreWarehouseManagementProcessesUsedChanging(value);
                this._AreWarehouseManagementProcessesUsed = value;
                this.OnAreWarehouseManagementProcessesUsedChanged();
                this.OnPropertyChanged("AreWarehouseManagementProcessesUsed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AreWarehouseManagementProcessesUsed;
        partial void OnAreWarehouseManagementProcessesUsedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAreWarehouseManagementProcessesUsedChanged();
        /// <summary>
        /// There are no comments for Property OrderedQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal OrderedQuantity
        {
            get
            {
                return this._OrderedQuantity;
            }
            set
            {
                this.OnOrderedQuantityChanging(value);
                this._OrderedQuantity = value;
                this.OnOrderedQuantityChanged();
                this.OnPropertyChanged("OrderedQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OrderedQuantity;
        partial void OnOrderedQuantityChanging(decimal value);
        partial void OnOrderedQuantityChanged();
        /// <summary>
        /// There are no comments for Property TotalAvailableCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal TotalAvailableCatchWeightQuantity
        {
            get
            {
                return this._TotalAvailableCatchWeightQuantity;
            }
            set
            {
                this.OnTotalAvailableCatchWeightQuantityChanging(value);
                this._TotalAvailableCatchWeightQuantity = value;
                this.OnTotalAvailableCatchWeightQuantityChanged();
                this.OnPropertyChanged("TotalAvailableCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TotalAvailableCatchWeightQuantity;
        partial void OnTotalAvailableCatchWeightQuantityChanging(decimal value);
        partial void OnTotalAvailableCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property OnOrderQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal OnOrderQuantity
        {
            get
            {
                return this._OnOrderQuantity;
            }
            set
            {
                this.OnOnOrderQuantityChanging(value);
                this._OnOrderQuantity = value;
                this.OnOnOrderQuantityChanged();
                this.OnPropertyChanged("OnOrderQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OnOrderQuantity;
        partial void OnOnOrderQuantityChanging(decimal value);
        partial void OnOnOrderQuantityChanged();
        /// <summary>
        /// There are no comments for Property TotalAvailableQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal TotalAvailableQuantity
        {
            get
            {
                return this._TotalAvailableQuantity;
            }
            set
            {
                this.OnTotalAvailableQuantityChanging(value);
                this._TotalAvailableQuantity = value;
                this.OnTotalAvailableQuantityChanged();
                this.OnPropertyChanged("TotalAvailableQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TotalAvailableQuantity;
        partial void OnTotalAvailableQuantityChanging(decimal value);
        partial void OnTotalAvailableQuantityChanged();
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
