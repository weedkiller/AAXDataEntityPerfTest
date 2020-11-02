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
    /// There are no comments for RouteHeaderSingle in the schema.
    /// </summary>
    public partial class RouteHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RouteHeader>
    {
        /// <summary>
        /// Initialize a new RouteHeaderSingle object.
        /// </summary>
        public RouteHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RouteHeaderSingle object.
        /// </summary>
        public RouteHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RouteHeaderSingle object.
        /// </summary>
        public RouteHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RouteHeader> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RouteOperations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RouteOperation> RouteOperations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RouteOperations == null))
                {
                    this._RouteOperations = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RouteOperation>(GetPath("RouteOperations"));
                }
                return this._RouteOperations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RouteOperation> _RouteOperations;
        /// <summary>
        /// There are no comments for BillOfMaterialsLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLine> BillOfMaterialsLines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BillOfMaterialsLines == null))
                {
                    this._BillOfMaterialsLines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLine>(GetPath("BillOfMaterialsLines"));
                }
                return this._BillOfMaterialsLines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLine> _BillOfMaterialsLines;
        /// <summary>
        /// There are no comments for RouteVersionsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RouteVersionV2> RouteVersionsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RouteVersionsV2 == null))
                {
                    this._RouteVersionsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RouteVersionV2>(GetPath("RouteVersionsV2"));
                }
                return this._RouteVersionsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RouteVersionV2> _RouteVersionsV2;
        /// <summary>
        /// There are no comments for RouteVersions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RouteVersion> RouteVersions
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RouteVersions == null))
                {
                    this._RouteVersions = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RouteVersion>(GetPath("RouteVersions"));
                }
                return this._RouteVersions;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RouteVersion> _RouteVersions;
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
        /// <summary>
        /// There are no comments for QualityOrderHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.QualityOrderHeader> QualityOrderHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._QualityOrderHeaders == null))
                {
                    this._QualityOrderHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.QualityOrderHeader>(GetPath("QualityOrderHeaders"));
                }
                return this._QualityOrderHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.QualityOrderHeader> _QualityOrderHeaders;
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
        /// There are no comments for BillOfMaterialsLines3 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLineV3> BillOfMaterialsLines3
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BillOfMaterialsLines3 == null))
                {
                    this._BillOfMaterialsLines3 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLineV3>(GetPath("BillOfMaterialsLines3"));
                }
                return this._BillOfMaterialsLines3;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLineV3> _BillOfMaterialsLines3;
    }
    /// <summary>
    /// There are no comments for RouteHeader in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RouteId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RouteId")]
    [global::Microsoft.OData.Client.EntitySet("RouteHeaders")]
    public partial class RouteHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RouteHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="routeId">Initial value of RouteId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RouteHeader CreateRouteHeader(string dataAreaId, string routeId)
        {
            RouteHeader routeHeader = new RouteHeader();
            routeHeader.dataAreaId = dataAreaId;
            routeHeader.RouteId = routeId;
            return routeHeader;
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
        /// There are no comments for Property RouteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RouteId
        {
            get
            {
                return this._RouteId;
            }
            set
            {
                this.OnRouteIdChanging(value);
                this._RouteId = value;
                this.OnRouteIdChanged();
                this.OnPropertyChanged("RouteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RouteId;
        partial void OnRouteIdChanging(string value);
        partial void OnRouteIdChanged();
        /// <summary>
        /// There are no comments for Property ProductGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductGroupId
        {
            get
            {
                return this._ProductGroupId;
            }
            set
            {
                this.OnProductGroupIdChanging(value);
                this._ProductGroupId = value;
                this.OnProductGroupIdChanged();
                this.OnPropertyChanged("ProductGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductGroupId;
        partial void OnProductGroupIdChanging(string value);
        partial void OnProductGroupIdChanged();
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
        /// There are no comments for Property RouteName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RouteName
        {
            get
            {
                return this._RouteName;
            }
            set
            {
                this.OnRouteNameChanging(value);
                this._RouteName = value;
                this.OnRouteNameChanged();
                this.OnPropertyChanged("RouteName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RouteName;
        partial void OnRouteNameChanging(string value);
        partial void OnRouteNameChanged();
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
        /// There are no comments for Property RouteOperations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteOperation> RouteOperations
        {
            get
            {
                return this._RouteOperations;
            }
            set
            {
                this.OnRouteOperationsChanging(value);
                this._RouteOperations = value;
                this.OnRouteOperationsChanged();
                this.OnPropertyChanged("RouteOperations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteOperation> _RouteOperations = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteOperation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRouteOperationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteOperation> value);
        partial void OnRouteOperationsChanged();
        /// <summary>
        /// There are no comments for Property BillOfMaterialsLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLine> BillOfMaterialsLines
        {
            get
            {
                return this._BillOfMaterialsLines;
            }
            set
            {
                this.OnBillOfMaterialsLinesChanging(value);
                this._BillOfMaterialsLines = value;
                this.OnBillOfMaterialsLinesChanged();
                this.OnPropertyChanged("BillOfMaterialsLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLine> _BillOfMaterialsLines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBillOfMaterialsLinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLine> value);
        partial void OnBillOfMaterialsLinesChanged();
        /// <summary>
        /// There are no comments for Property RouteVersionsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteVersionV2> RouteVersionsV2
        {
            get
            {
                return this._RouteVersionsV2;
            }
            set
            {
                this.OnRouteVersionsV2Changing(value);
                this._RouteVersionsV2 = value;
                this.OnRouteVersionsV2Changed();
                this.OnPropertyChanged("RouteVersionsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteVersionV2> _RouteVersionsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteVersionV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRouteVersionsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteVersionV2> value);
        partial void OnRouteVersionsV2Changed();
        /// <summary>
        /// There are no comments for Property RouteVersions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteVersion> RouteVersions
        {
            get
            {
                return this._RouteVersions;
            }
            set
            {
                this.OnRouteVersionsChanging(value);
                this._RouteVersions = value;
                this.OnRouteVersionsChanged();
                this.OnPropertyChanged("RouteVersions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteVersion> _RouteVersions = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteVersion>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRouteVersionsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RouteVersion> value);
        partial void OnRouteVersionsChanged();
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
        /// There are no comments for Property QualityOrderHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.QualityOrderHeader> QualityOrderHeaders
        {
            get
            {
                return this._QualityOrderHeaders;
            }
            set
            {
                this.OnQualityOrderHeadersChanging(value);
                this._QualityOrderHeaders = value;
                this.OnQualityOrderHeadersChanged();
                this.OnPropertyChanged("QualityOrderHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.QualityOrderHeader> _QualityOrderHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.QualityOrderHeader>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnQualityOrderHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.QualityOrderHeader> value);
        partial void OnQualityOrderHeadersChanged();
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
        /// There are no comments for Property BillOfMaterialsLines3 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLineV3> BillOfMaterialsLines3
        {
            get
            {
                return this._BillOfMaterialsLines3;
            }
            set
            {
                this.OnBillOfMaterialsLines3Changing(value);
                this._BillOfMaterialsLines3 = value;
                this.OnBillOfMaterialsLines3Changed();
                this.OnPropertyChanged("BillOfMaterialsLines3");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLineV3> _BillOfMaterialsLines3 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLineV3>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBillOfMaterialsLines3Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLineV3> value);
        partial void OnBillOfMaterialsLines3Changed();
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
        /// <summary>
        /// There are no comments for RemoveApproval in the schema.
        /// </summary>
        public virtual global::Microsoft.OData.Client.DataServiceActionQuery RemoveApproval()
        {
            global::Microsoft.OData.Client.EntityDescriptor resource = Context.EntityTracker.TryGetEntityDescriptor(this);
            if (resource == null)
            {
                throw new global::System.Exception("cannot find entity");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuery(this.Context, resource.EditLink.OriginalString.Trim('/') + "/Microsoft.Dynamics.DataEntities.RemoveApproval");
        }
        /// <summary>
        /// There are no comments for Approve in the schema.
        /// </summary>
        public virtual global::Microsoft.OData.Client.DataServiceActionQuery Approve(string _approverPersonnelNumber)
        {
            global::Microsoft.OData.Client.EntityDescriptor resource = Context.EntityTracker.TryGetEntityDescriptor(this);
            if (resource == null)
            {
                throw new global::System.Exception("cannot find entity");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuery(this.Context, resource.EditLink.OriginalString.Trim('/') + "/Microsoft.Dynamics.DataEntities.Approve", new global::Microsoft.OData.Client.BodyOperationParameter("_approverPersonnelNumber", _approverPersonnelNumber));
        }
    }
}
