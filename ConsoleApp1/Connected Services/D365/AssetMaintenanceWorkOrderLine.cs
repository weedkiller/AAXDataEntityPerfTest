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
    /// There are no comments for AssetMaintenanceWorkOrderLineSingle in the schema.
    /// </summary>
    public partial class AssetMaintenanceWorkOrderLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWorkOrderLine>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderLineSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderLineSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderLineSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWorkOrderLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceWorkOrderLineNote in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLineNoteSingle AssetMaintenanceWorkOrderLineNote
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceWorkOrderLineNote == null))
                {
                    this._AssetMaintenanceWorkOrderLineNote = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLineNoteSingle(this.Context, GetPath("AssetMaintenanceWorkOrderLineNote"));
                }
                return this._AssetMaintenanceWorkOrderLineNote;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLineNoteSingle _AssetMaintenanceWorkOrderLineNote;
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
        /// <summary>
        /// There are no comments for AssetMaintenanceJobVariant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobVariantSingle AssetMaintenanceJobVariant
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceJobVariant == null))
                {
                    this._AssetMaintenanceJobVariant = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobVariantSingle(this.Context, GetPath("AssetMaintenanceJobVariant"));
                }
                return this._AssetMaintenanceJobVariant;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobVariantSingle _AssetMaintenanceJobVariant;
        /// <summary>
        /// There are no comments for AssetMaintenanceJobTrade in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTradeSingle AssetMaintenanceJobTrade
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceJobTrade == null))
                {
                    this._AssetMaintenanceJobTrade = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTradeSingle(this.Context, GetPath("AssetMaintenanceJobTrade"));
                }
                return this._AssetMaintenanceJobTrade;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTradeSingle _AssetMaintenanceJobTrade;
        /// <summary>
        /// There are no comments for AssetMaintenanceWorkOrderTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderTableSingle AssetMaintenanceWorkOrderTable
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceWorkOrderTable == null))
                {
                    this._AssetMaintenanceWorkOrderTable = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderTableSingle(this.Context, GetPath("AssetMaintenanceWorkOrderTable"));
                }
                return this._AssetMaintenanceWorkOrderTable;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderTableSingle _AssetMaintenanceWorkOrderTable;
        /// <summary>
        /// There are no comments for AssetMaintenanceJobType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTypeSingle AssetMaintenanceJobType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceJobType == null))
                {
                    this._AssetMaintenanceJobType = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTypeSingle(this.Context, GetPath("AssetMaintenanceJobType"));
                }
                return this._AssetMaintenanceJobType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTypeSingle _AssetMaintenanceJobType;
    }
    /// <summary>
    /// There are no comments for AssetMaintenanceWorkOrderLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// WorkOrderId
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "WorkOrderId", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceWorkOrderLines")]
    public partial class AssetMaintenanceWorkOrderLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceWorkOrderLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="workOrderId">Initial value of WorkOrderId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="addressLongitude">Initial value of AddressLongitude.</param>
        /// <param name="forecastHourQty">Initial value of ForecastHourQty.</param>
        /// <param name="addressLatitude">Initial value of AddressLatitude.</param>
        /// <param name="assetMaintenanceWorkOrderLineNote">Initial value of AssetMaintenanceWorkOrderLineNote.</param>
        /// <param name="assetMaintenanceAsset">Initial value of AssetMaintenanceAsset.</param>
        /// <param name="assetMaintenanceWorkOrderTable">Initial value of AssetMaintenanceWorkOrderTable.</param>
        /// <param name="assetMaintenanceJobType">Initial value of AssetMaintenanceJobType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceWorkOrderLine CreateAssetMaintenanceWorkOrderLine(string dataAreaId, 
                    string workOrderId, 
                    long lineNumber, 
                    decimal addressLongitude, 
                    decimal forecastHourQty, 
                    decimal addressLatitude, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLineNote assetMaintenanceWorkOrderLineNote, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset assetMaintenanceAsset, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderTable assetMaintenanceWorkOrderTable, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobType assetMaintenanceJobType)
        {
            AssetMaintenanceWorkOrderLine assetMaintenanceWorkOrderLine = new AssetMaintenanceWorkOrderLine();
            assetMaintenanceWorkOrderLine.dataAreaId = dataAreaId;
            assetMaintenanceWorkOrderLine.WorkOrderId = workOrderId;
            assetMaintenanceWorkOrderLine.LineNumber = lineNumber;
            assetMaintenanceWorkOrderLine.AddressLongitude = addressLongitude;
            assetMaintenanceWorkOrderLine.ForecastHourQty = forecastHourQty;
            assetMaintenanceWorkOrderLine.AddressLatitude = addressLatitude;
            if ((assetMaintenanceWorkOrderLineNote == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceWorkOrderLineNote");
            }
            assetMaintenanceWorkOrderLine.AssetMaintenanceWorkOrderLineNote = assetMaintenanceWorkOrderLineNote;
            if ((assetMaintenanceAsset == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceAsset");
            }
            assetMaintenanceWorkOrderLine.AssetMaintenanceAsset = assetMaintenanceAsset;
            if ((assetMaintenanceWorkOrderTable == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceWorkOrderTable");
            }
            assetMaintenanceWorkOrderLine.AssetMaintenanceWorkOrderTable = assetMaintenanceWorkOrderTable;
            if ((assetMaintenanceJobType == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceJobType");
            }
            assetMaintenanceWorkOrderLine.AssetMaintenanceJobType = assetMaintenanceJobType;
            return assetMaintenanceWorkOrderLine;
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
        /// There are no comments for Property WorkOrderId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkOrderId
        {
            get
            {
                return this._WorkOrderId;
            }
            set
            {
                this.OnWorkOrderIdChanging(value);
                this._WorkOrderId = value;
                this.OnWorkOrderIdChanged();
                this.OnPropertyChanged("WorkOrderId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkOrderId;
        partial void OnWorkOrderIdChanging(string value);
        partial void OnWorkOrderIdChanged();
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
        /// There are no comments for Property NoteInternal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string NoteInternal
        {
            get
            {
                return this._NoteInternal;
            }
            set
            {
                this.OnNoteInternalChanging(value);
                this._NoteInternal = value;
                this.OnNoteInternalChanged();
                this.OnPropertyChanged("NoteInternal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NoteInternal;
        partial void OnNoteInternalChanging(string value);
        partial void OnNoteInternalChanged();
        /// <summary>
        /// There are no comments for Property NoteWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string NoteWorker
        {
            get
            {
                return this._NoteWorker;
            }
            set
            {
                this.OnNoteWorkerChanging(value);
                this._NoteWorker = value;
                this.OnNoteWorkerChanged();
                this.OnPropertyChanged("NoteWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NoteWorker;
        partial void OnNoteWorkerChanging(string value);
        partial void OnNoteWorkerChanged();
        /// <summary>
        /// There are no comments for Property JobVariantId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JobVariantId
        {
            get
            {
                return this._JobVariantId;
            }
            set
            {
                this.OnJobVariantIdChanging(value);
                this._JobVariantId = value;
                this.OnJobVariantIdChanged();
                this.OnPropertyChanged("JobVariantId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobVariantId;
        partial void OnJobVariantIdChanging(string value);
        partial void OnJobVariantIdChanged();
        /// <summary>
        /// There are no comments for Property AddressLongitude in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AddressLongitude
        {
            get
            {
                return this._AddressLongitude;
            }
            set
            {
                this.OnAddressLongitudeChanging(value);
                this._AddressLongitude = value;
                this.OnAddressLongitudeChanged();
                this.OnPropertyChanged("AddressLongitude");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AddressLongitude;
        partial void OnAddressLongitudeChanging(decimal value);
        partial void OnAddressLongitudeChanged();
        /// <summary>
        /// There are no comments for Property ForecastHourQty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ForecastHourQty
        {
            get
            {
                return this._ForecastHourQty;
            }
            set
            {
                this.OnForecastHourQtyChanging(value);
                this._ForecastHourQty = value;
                this.OnForecastHourQtyChanged();
                this.OnPropertyChanged("ForecastHourQty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ForecastHourQty;
        partial void OnForecastHourQtyChanging(decimal value);
        partial void OnForecastHourQtyChanged();
        /// <summary>
        /// There are no comments for Property AddressLatitude in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AddressLatitude
        {
            get
            {
                return this._AddressLatitude;
            }
            set
            {
                this.OnAddressLatitudeChanging(value);
                this._AddressLatitude = value;
                this.OnAddressLatitudeChanged();
                this.OnPropertyChanged("AddressLatitude");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AddressLatitude;
        partial void OnAddressLatitudeChanging(decimal value);
        partial void OnAddressLatitudeChanged();
        /// <summary>
        /// There are no comments for Property JobTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JobTypeId
        {
            get
            {
                return this._JobTypeId;
            }
            set
            {
                this.OnJobTypeIdChanging(value);
                this._JobTypeId = value;
                this.OnJobTypeIdChanged();
                this.OnPropertyChanged("JobTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobTypeId;
        partial void OnJobTypeIdChanging(string value);
        partial void OnJobTypeIdChanged();
        /// <summary>
        /// There are no comments for Property JobTradeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JobTradeId
        {
            get
            {
                return this._JobTradeId;
            }
            set
            {
                this.OnJobTradeIdChanging(value);
                this._JobTradeId = value;
                this.OnJobTradeIdChanged();
                this.OnPropertyChanged("JobTradeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobTradeId;
        partial void OnJobTradeIdChanging(string value);
        partial void OnJobTradeIdChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceWorkOrderLineNote in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLineNote AssetMaintenanceWorkOrderLineNote
        {
            get
            {
                return this._AssetMaintenanceWorkOrderLineNote;
            }
            set
            {
                this.OnAssetMaintenanceWorkOrderLineNoteChanging(value);
                this._AssetMaintenanceWorkOrderLineNote = value;
                this.OnAssetMaintenanceWorkOrderLineNoteChanged();
                this.OnPropertyChanged("AssetMaintenanceWorkOrderLineNote");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLineNote _AssetMaintenanceWorkOrderLineNote;
        partial void OnAssetMaintenanceWorkOrderLineNoteChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLineNote value);
        partial void OnAssetMaintenanceWorkOrderLineNoteChanged();
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
        /// There are no comments for Property AssetMaintenanceJobVariant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobVariant AssetMaintenanceJobVariant
        {
            get
            {
                return this._AssetMaintenanceJobVariant;
            }
            set
            {
                this.OnAssetMaintenanceJobVariantChanging(value);
                this._AssetMaintenanceJobVariant = value;
                this.OnAssetMaintenanceJobVariantChanged();
                this.OnPropertyChanged("AssetMaintenanceJobVariant");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobVariant _AssetMaintenanceJobVariant;
        partial void OnAssetMaintenanceJobVariantChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobVariant value);
        partial void OnAssetMaintenanceJobVariantChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceJobTrade in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTrade AssetMaintenanceJobTrade
        {
            get
            {
                return this._AssetMaintenanceJobTrade;
            }
            set
            {
                this.OnAssetMaintenanceJobTradeChanging(value);
                this._AssetMaintenanceJobTrade = value;
                this.OnAssetMaintenanceJobTradeChanged();
                this.OnPropertyChanged("AssetMaintenanceJobTrade");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTrade _AssetMaintenanceJobTrade;
        partial void OnAssetMaintenanceJobTradeChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobTrade value);
        partial void OnAssetMaintenanceJobTradeChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceWorkOrderTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderTable AssetMaintenanceWorkOrderTable
        {
            get
            {
                return this._AssetMaintenanceWorkOrderTable;
            }
            set
            {
                this.OnAssetMaintenanceWorkOrderTableChanging(value);
                this._AssetMaintenanceWorkOrderTable = value;
                this.OnAssetMaintenanceWorkOrderTableChanged();
                this.OnPropertyChanged("AssetMaintenanceWorkOrderTable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderTable _AssetMaintenanceWorkOrderTable;
        partial void OnAssetMaintenanceWorkOrderTableChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderTable value);
        partial void OnAssetMaintenanceWorkOrderTableChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceJobType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobType AssetMaintenanceJobType
        {
            get
            {
                return this._AssetMaintenanceJobType;
            }
            set
            {
                this.OnAssetMaintenanceJobTypeChanging(value);
                this._AssetMaintenanceJobType = value;
                this.OnAssetMaintenanceJobTypeChanged();
                this.OnPropertyChanged("AssetMaintenanceJobType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobType _AssetMaintenanceJobType;
        partial void OnAssetMaintenanceJobTypeChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceJobType value);
        partial void OnAssetMaintenanceJobTypeChanged();
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
