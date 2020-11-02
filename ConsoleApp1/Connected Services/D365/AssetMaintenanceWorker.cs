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
    /// There are no comments for AssetMaintenanceWorkerSingle in the schema.
    /// </summary>
    public partial class AssetMaintenanceWorkerSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWorker>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceWorkerSingle object.
        /// </summary>
        public AssetMaintenanceWorkerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWorkerSingle object.
        /// </summary>
        public AssetMaintenanceWorkerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWorkerSingle object.
        /// </summary>
        public AssetMaintenanceWorkerSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWorker> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceAssetCalendar in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> AssetMaintenanceAssetCalendar
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetCalendar == null))
                {
                    this._AssetMaintenanceAssetCalendar = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar>(GetPath("AssetMaintenanceAssetCalendar"));
                }
                return this._AssetMaintenanceAssetCalendar;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> _AssetMaintenanceAssetCalendar;
        /// <summary>
        /// There are no comments for AssetMaintenanceFunctionalLocationWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationWorker> AssetMaintenanceFunctionalLocationWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFunctionalLocationWorker == null))
                {
                    this._AssetMaintenanceFunctionalLocationWorker = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationWorker>(GetPath("AssetMaintenanceFunctionalLocationWorker"));
                }
                return this._AssetMaintenanceFunctionalLocationWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationWorker> _AssetMaintenanceFunctionalLocationWorker;
        /// <summary>
        /// There are no comments for AssetMaintenanceWorkerResponsible in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerResponsible> AssetMaintenanceWorkerResponsible
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceWorkerResponsible == null))
                {
                    this._AssetMaintenanceWorkerResponsible = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerResponsible>(GetPath("AssetMaintenanceWorkerResponsible"));
                }
                return this._AssetMaintenanceWorkerResponsible;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerResponsible> _AssetMaintenanceWorkerResponsible;
    }
    /// <summary>
    /// There are no comments for AssetMaintenanceWorker in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// WorkerPersonnelNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "WorkerPersonnelNumber")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceWorkers")]
    public partial class AssetMaintenanceWorker : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceWorker object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="workerPersonnelNumber">Initial value of WorkerPersonnelNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceWorker CreateAssetMaintenanceWorker(string dataAreaId, string workerPersonnelNumber)
        {
            AssetMaintenanceWorker assetMaintenanceWorker = new AssetMaintenanceWorker();
            assetMaintenanceWorker.dataAreaId = dataAreaId;
            assetMaintenanceWorker.WorkerPersonnelNumber = workerPersonnelNumber;
            return assetMaintenanceWorker;
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
        /// There are no comments for Property WorkerPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkerPersonnelNumber
        {
            get
            {
                return this._WorkerPersonnelNumber;
            }
            set
            {
                this.OnWorkerPersonnelNumberChanging(value);
                this._WorkerPersonnelNumber = value;
                this.OnWorkerPersonnelNumberChanged();
                this.OnPropertyChanged("WorkerPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkerPersonnelNumber;
        partial void OnWorkerPersonnelNumberChanging(string value);
        partial void OnWorkerPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property WorkerActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WorkerActive
        {
            get
            {
                return this._WorkerActive;
            }
            set
            {
                this.OnWorkerActiveChanging(value);
                this._WorkerActive = value;
                this.OnWorkerActiveChanged();
                this.OnPropertyChanged("WorkerActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WorkerActive;
        partial void OnWorkerActiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWorkerActiveChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetCalendar in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> AssetMaintenanceAssetCalendar
        {
            get
            {
                return this._AssetMaintenanceAssetCalendar;
            }
            set
            {
                this.OnAssetMaintenanceAssetCalendarChanging(value);
                this._AssetMaintenanceAssetCalendar = value;
                this.OnAssetMaintenanceAssetCalendarChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetCalendar");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> _AssetMaintenanceAssetCalendar = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceAssetCalendarChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> value);
        partial void OnAssetMaintenanceAssetCalendarChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceFunctionalLocationWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationWorker> AssetMaintenanceFunctionalLocationWorker
        {
            get
            {
                return this._AssetMaintenanceFunctionalLocationWorker;
            }
            set
            {
                this.OnAssetMaintenanceFunctionalLocationWorkerChanging(value);
                this._AssetMaintenanceFunctionalLocationWorker = value;
                this.OnAssetMaintenanceFunctionalLocationWorkerChanged();
                this.OnPropertyChanged("AssetMaintenanceFunctionalLocationWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationWorker> _AssetMaintenanceFunctionalLocationWorker = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationWorker>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceFunctionalLocationWorkerChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationWorker> value);
        partial void OnAssetMaintenanceFunctionalLocationWorkerChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceWorkerResponsible in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerResponsible> AssetMaintenanceWorkerResponsible
        {
            get
            {
                return this._AssetMaintenanceWorkerResponsible;
            }
            set
            {
                this.OnAssetMaintenanceWorkerResponsibleChanging(value);
                this._AssetMaintenanceWorkerResponsible = value;
                this.OnAssetMaintenanceWorkerResponsibleChanged();
                this.OnPropertyChanged("AssetMaintenanceWorkerResponsible");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerResponsible> _AssetMaintenanceWorkerResponsible = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerResponsible>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceWorkerResponsibleChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerResponsible> value);
        partial void OnAssetMaintenanceWorkerResponsibleChanged();
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
