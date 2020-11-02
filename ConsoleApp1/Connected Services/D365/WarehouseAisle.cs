﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:55:10 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for WarehouseAisleSingle in the schema.
    /// </summary>
    public partial class WarehouseAisleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseAisle>
    {
        /// <summary>
        /// Initialize a new WarehouseAisleSingle object.
        /// </summary>
        public WarehouseAisleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WarehouseAisleSingle object.
        /// </summary>
        public WarehouseAisleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WarehouseAisleSingle object.
        /// </summary>
        public WarehouseAisleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseAisle> query)
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
        /// There are no comments for WarehouseLocations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> WarehouseLocations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WarehouseLocations == null))
                {
                    this._WarehouseLocations = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WarehouseLocation>(GetPath("WarehouseLocations"));
                }
                return this._WarehouseLocations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> _WarehouseLocations;
    }
    /// <summary>
    /// There are no comments for WarehouseAisle in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// WarehouseId
    /// AisleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "WarehouseId", "AisleId")]
    [global::Microsoft.OData.Client.EntitySet("WarehouseAisles")]
    public partial class WarehouseAisle : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WarehouseAisle object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="warehouseId">Initial value of WarehouseId.</param>
        /// <param name="aisleId">Initial value of AisleId.</param>
        /// <param name="manualStartingSortOrderCode">Initial value of ManualStartingSortOrderCode.</param>
        /// <param name="aisleNumber">Initial value of AisleNumber.</param>
        /// <param name="warehouse">Initial value of Warehouse.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WarehouseAisle CreateWarehouseAisle(string dataAreaId, 
                    string warehouseId, 
                    string aisleId, 
                    int manualStartingSortOrderCode, 
                    int aisleNumber, 
                    global::Microsoft.Dynamics.DataEntities.Warehouse warehouse)
        {
            WarehouseAisle warehouseAisle = new WarehouseAisle();
            warehouseAisle.dataAreaId = dataAreaId;
            warehouseAisle.WarehouseId = warehouseId;
            warehouseAisle.AisleId = aisleId;
            warehouseAisle.ManualStartingSortOrderCode = manualStartingSortOrderCode;
            warehouseAisle.AisleNumber = aisleNumber;
            if ((warehouse == null))
            {
                throw new global::System.ArgumentNullException("warehouse");
            }
            warehouseAisle.Warehouse = warehouse;
            return warehouseAisle;
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
        /// There are no comments for Property WarehouseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WarehouseId
        {
            get
            {
                return this._WarehouseId;
            }
            set
            {
                this.OnWarehouseIdChanging(value);
                this._WarehouseId = value;
                this.OnWarehouseIdChanged();
                this.OnPropertyChanged("WarehouseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WarehouseId;
        partial void OnWarehouseIdChanging(string value);
        partial void OnWarehouseIdChanged();
        /// <summary>
        /// There are no comments for Property AisleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AisleId
        {
            get
            {
                return this._AisleId;
            }
            set
            {
                this.OnAisleIdChanging(value);
                this._AisleId = value;
                this.OnAisleIdChanged();
                this.OnPropertyChanged("AisleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AisleId;
        partial void OnAisleIdChanging(string value);
        partial void OnAisleIdChanged();
        /// <summary>
        /// There are no comments for Property IsSortOrderCodeAssignedDescending in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsSortOrderCodeAssignedDescending
        {
            get
            {
                return this._IsSortOrderCodeAssignedDescending;
            }
            set
            {
                this.OnIsSortOrderCodeAssignedDescendingChanging(value);
                this._IsSortOrderCodeAssignedDescending = value;
                this.OnIsSortOrderCodeAssignedDescendingChanged();
                this.OnPropertyChanged("IsSortOrderCodeAssignedDescending");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsSortOrderCodeAssignedDescending;
        partial void OnIsSortOrderCodeAssignedDescendingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsSortOrderCodeAssignedDescendingChanged();
        /// <summary>
        /// There are no comments for Property ManualStartingSortOrderCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int ManualStartingSortOrderCode
        {
            get
            {
                return this._ManualStartingSortOrderCode;
            }
            set
            {
                this.OnManualStartingSortOrderCodeChanging(value);
                this._ManualStartingSortOrderCode = value;
                this.OnManualStartingSortOrderCodeChanged();
                this.OnPropertyChanged("ManualStartingSortOrderCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ManualStartingSortOrderCode;
        partial void OnManualStartingSortOrderCodeChanging(int value);
        partial void OnManualStartingSortOrderCodeChanged();
        /// <summary>
        /// There are no comments for Property AisleName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AisleName
        {
            get
            {
                return this._AisleName;
            }
            set
            {
                this.OnAisleNameChanging(value);
                this._AisleName = value;
                this.OnAisleNameChanged();
                this.OnPropertyChanged("AisleName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AisleName;
        partial void OnAisleNameChanging(string value);
        partial void OnAisleNameChanged();
        /// <summary>
        /// There are no comments for Property AisleNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int AisleNumber
        {
            get
            {
                return this._AisleNumber;
            }
            set
            {
                this.OnAisleNumberChanging(value);
                this._AisleNumber = value;
                this.OnAisleNumberChanged();
                this.OnPropertyChanged("AisleNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _AisleNumber;
        partial void OnAisleNumberChanging(int value);
        partial void OnAisleNumberChanged();
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
        /// There are no comments for Property WarehouseLocations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> WarehouseLocations
        {
            get
            {
                return this._WarehouseLocations;
            }
            set
            {
                this.OnWarehouseLocationsChanging(value);
                this._WarehouseLocations = value;
                this.OnWarehouseLocationsChanged();
                this.OnPropertyChanged("WarehouseLocations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> _WarehouseLocations = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWarehouseLocationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> value);
        partial void OnWarehouseLocationsChanged();
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
