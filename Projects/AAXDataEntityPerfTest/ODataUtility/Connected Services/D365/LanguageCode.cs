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
        /// There are no comments for LanguageCodeSingle in the schema.
        /// </summary>
    public partial class LanguageCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LanguageCode>
    {
        /// <summary>
        /// Initialize a new LanguageCodeSingle object.
        /// </summary>
        public LanguageCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LanguageCodeSingle object.
        /// </summary>
        public LanguageCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LanguageCodeSingle object.
        /// </summary>
        public LanguageCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LanguageCode> query)
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
        /// There are no comments for BaseWorkers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BaseWorker> BaseWorkers
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BaseWorkers == null))
                {
                    this._BaseWorkers = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BaseWorker>(GetPath("BaseWorkers"));
                }
                return this._BaseWorkers;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BaseWorker> _BaseWorkers;
    }
        /// <summary>
        /// There are no comments for LanguageCode in the schema.
        /// </summary>
    /// <KeyProperties>
    /// LanguageCodeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LanguageCodeId")]
    [global::Microsoft.OData.Client.EntitySet("LanguageCodes")]
    public partial class LanguageCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LanguageCode object.
        /// </summary>
        /// <param name="languageCodeId">Initial value of LanguageCodeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LanguageCode CreateLanguageCode(string languageCodeId)
        {
            LanguageCode languageCode = new LanguageCode();
            languageCode.LanguageCodeId = languageCodeId;
            return languageCode;
        }
        /// <summary>
        /// There are no comments for Property LanguageCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LanguageCodeId
        {
            get
            {
                return this._LanguageCodeId;
            }
            set
            {
                this.OnLanguageCodeIdChanging(value);
                this._LanguageCodeId = value;
                this.OnLanguageCodeIdChanged();
                this.OnPropertyChanged("LanguageCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LanguageCodeId;
        partial void OnLanguageCodeIdChanging(string value);
        partial void OnLanguageCodeIdChanged();
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
        /// There are no comments for Property BaseWorkers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BaseWorker> BaseWorkers
        {
            get
            {
                return this._BaseWorkers;
            }
            set
            {
                this.OnBaseWorkersChanging(value);
                this._BaseWorkers = value;
                this.OnBaseWorkersChanged();
                this.OnPropertyChanged("BaseWorkers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BaseWorker> _BaseWorkers = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BaseWorker>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBaseWorkersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BaseWorker> value);
        partial void OnBaseWorkersChanged();
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
