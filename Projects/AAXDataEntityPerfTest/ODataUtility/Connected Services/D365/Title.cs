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
        /// There are no comments for TitleSingle in the schema.
        /// </summary>
    public partial class TitleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Title>
    {
        /// <summary>
        /// Initialize a new TitleSingle object.
        /// </summary>
        public TitleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TitleSingle object.
        /// </summary>
        public TitleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TitleSingle object.
        /// </summary>
        public TitleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Title> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Contractors in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Contractor> Contractors
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Contractors == null))
                {
                    this._Contractors = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Contractor>(GetPath("Contractors"));
                }
                return this._Contractors;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Contractor> _Contractors;
        /// <summary>
        /// There are no comments for Positions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Position> Positions
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Positions == null))
                {
                    this._Positions = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Position>(GetPath("Positions"));
                }
                return this._Positions;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Position> _Positions;
        /// <summary>
        /// There are no comments for WorkerTitles in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerSummary> WorkerTitles
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WorkerTitles == null))
                {
                    this._WorkerTitles = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WorkerSummary>(GetPath("WorkerTitles"));
                }
                return this._WorkerTitles;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerSummary> _WorkerTitles;
        /// <summary>
        /// There are no comments for Workers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Worker> Workers
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Workers == null))
                {
                    this._Workers = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Worker>(GetPath("Workers"));
                }
                return this._Workers;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Worker> _Workers;
        /// <summary>
        /// There are no comments for Employees in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Employee> Employees
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Employees == null))
                {
                    this._Employees = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Employee>(GetPath("Employees"));
                }
                return this._Employees;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Employee> _Employees;
        /// <summary>
        /// There are no comments for Jobs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Job> Jobs
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Jobs == null))
                {
                    this._Jobs = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Job>(GetPath("Jobs"));
                }
                return this._Jobs;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Job> _Jobs;
    }
        /// <summary>
        /// There are no comments for Title in the schema.
        /// </summary>
    /// <KeyProperties>
    /// TitleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TitleId")]
    [global::Microsoft.OData.Client.EntitySet("Titles")]
    public partial class Title : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Title object.
        /// </summary>
        /// <param name="titleId">Initial value of TitleId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Title CreateTitle(string titleId)
        {
            Title title = new Title();
            title.TitleId = titleId;
            return title;
        }
        /// <summary>
        /// There are no comments for Property TitleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TitleId
        {
            get
            {
                return this._TitleId;
            }
            set
            {
                this.OnTitleIdChanging(value);
                this._TitleId = value;
                this.OnTitleIdChanged();
                this.OnPropertyChanged("TitleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TitleId;
        partial void OnTitleIdChanging(string value);
        partial void OnTitleIdChanged();
        /// <summary>
        /// There are no comments for Property Contractors in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Contractor> Contractors
        {
            get
            {
                return this._Contractors;
            }
            set
            {
                this.OnContractorsChanging(value);
                this._Contractors = value;
                this.OnContractorsChanged();
                this.OnPropertyChanged("Contractors");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Contractor> _Contractors = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Contractor>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnContractorsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Contractor> value);
        partial void OnContractorsChanged();
        /// <summary>
        /// There are no comments for Property Positions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Position> Positions
        {
            get
            {
                return this._Positions;
            }
            set
            {
                this.OnPositionsChanging(value);
                this._Positions = value;
                this.OnPositionsChanged();
                this.OnPropertyChanged("Positions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Position> _Positions = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Position>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPositionsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Position> value);
        partial void OnPositionsChanged();
        /// <summary>
        /// There are no comments for Property WorkerTitles in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerSummary> WorkerTitles
        {
            get
            {
                return this._WorkerTitles;
            }
            set
            {
                this.OnWorkerTitlesChanging(value);
                this._WorkerTitles = value;
                this.OnWorkerTitlesChanged();
                this.OnPropertyChanged("WorkerTitles");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerSummary> _WorkerTitles = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerSummary>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWorkerTitlesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerSummary> value);
        partial void OnWorkerTitlesChanged();
        /// <summary>
        /// There are no comments for Property Workers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Worker> Workers
        {
            get
            {
                return this._Workers;
            }
            set
            {
                this.OnWorkersChanging(value);
                this._Workers = value;
                this.OnWorkersChanged();
                this.OnPropertyChanged("Workers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Worker> _Workers = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Worker>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWorkersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Worker> value);
        partial void OnWorkersChanged();
        /// <summary>
        /// There are no comments for Property Employees in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Employee> Employees
        {
            get
            {
                return this._Employees;
            }
            set
            {
                this.OnEmployeesChanging(value);
                this._Employees = value;
                this.OnEmployeesChanged();
                this.OnPropertyChanged("Employees");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Employee> _Employees = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Employee>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEmployeesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Employee> value);
        partial void OnEmployeesChanged();
        /// <summary>
        /// There are no comments for Property Jobs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Job> Jobs
        {
            get
            {
                return this._Jobs;
            }
            set
            {
                this.OnJobsChanging(value);
                this._Jobs = value;
                this.OnJobsChanged();
                this.OnPropertyChanged("Jobs");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Job> _Jobs = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Job>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Job> value);
        partial void OnJobsChanged();
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
