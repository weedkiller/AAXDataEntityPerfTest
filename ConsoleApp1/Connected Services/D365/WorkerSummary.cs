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
    /// There are no comments for WorkerSummarySingle in the schema.
    /// </summary>
    public partial class WorkerSummarySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerSummary>
    {
        /// <summary>
        /// Initialize a new WorkerSummarySingle object.
        /// </summary>
        public WorkerSummarySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WorkerSummarySingle object.
        /// </summary>
        public WorkerSummarySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WorkerSummarySingle object.
        /// </summary>
        public WorkerSummarySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerSummary> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Title in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TitleSingle Title
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Title == null))
                {
                    this._Title = new global::Microsoft.Dynamics.DataEntities.TitleSingle(this.Context, GetPath("Title"));
                }
                return this._Title;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TitleSingle _Title;
        /// <summary>
        /// There are no comments for Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle Worker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Worker == null))
                {
                    this._Worker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("Worker"));
                }
                return this._Worker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _Worker;
    }
    /// <summary>
    /// There are no comments for WorkerSummary in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonnelNumber
    /// ValidFrom
    /// ValidTo
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PersonnelNumber", "ValidFrom", "ValidTo")]
    [global::Microsoft.OData.Client.EntitySet("WorkerSummaries")]
    public partial class WorkerSummary : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WorkerSummary object.
        /// </summary>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="originalHireDateTime">Initial value of OriginalHireDateTime.</param>
        /// <param name="anniversaryDateTime">Initial value of AnniversaryDateTime.</param>
        /// <param name="seniorityDate">Initial value of SeniorityDate.</param>
        /// <param name="worker">Initial value of Worker.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WorkerSummary CreateWorkerSummary(string personnelNumber, 
                    global::System.DateTimeOffset validFrom, 
                    global::System.DateTimeOffset validTo, 
                    global::System.DateTimeOffset originalHireDateTime, 
                    global::System.DateTimeOffset anniversaryDateTime, 
                    global::System.DateTimeOffset seniorityDate, 
                    global::Microsoft.Dynamics.DataEntities.Worker worker)
        {
            WorkerSummary workerSummary = new WorkerSummary();
            workerSummary.PersonnelNumber = personnelNumber;
            workerSummary.ValidFrom = validFrom;
            workerSummary.ValidTo = validTo;
            workerSummary.OriginalHireDateTime = originalHireDateTime;
            workerSummary.AnniversaryDateTime = anniversaryDateTime;
            workerSummary.SeniorityDate = seniorityDate;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            workerSummary.Worker = worker;
            return workerSummary;
        }
        /// <summary>
        /// There are no comments for Property PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonnelNumber
        {
            get
            {
                return this._PersonnelNumber;
            }
            set
            {
                this.OnPersonnelNumberChanging(value);
                this._PersonnelNumber = value;
                this.OnPersonnelNumberChanged();
                this.OnPropertyChanged("PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonnelNumber;
        partial void OnPersonnelNumberChanging(string value);
        partial void OnPersonnelNumberChanged();
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
        /// There are no comments for Property BuildingAddressId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BuildingAddressId
        {
            get
            {
                return this._BuildingAddressId;
            }
            set
            {
                this.OnBuildingAddressIdChanging(value);
                this._BuildingAddressId = value;
                this.OnBuildingAddressIdChanged();
                this.OnPropertyChanged("BuildingAddressId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BuildingAddressId;
        partial void OnBuildingAddressIdChanging(string value);
        partial void OnBuildingAddressIdChanged();
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
        /// There are no comments for Property WorksFromHome in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WorksFromHome
        {
            get
            {
                return this._WorksFromHome;
            }
            set
            {
                this.OnWorksFromHomeChanging(value);
                this._WorksFromHome = value;
                this.OnWorksFromHomeChanged();
                this.OnPropertyChanged("WorksFromHome");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WorksFromHome;
        partial void OnWorksFromHomeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWorksFromHomeChanged();
        /// <summary>
        /// There are no comments for Property OriginalHireDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset OriginalHireDateTime
        {
            get
            {
                return this._OriginalHireDateTime;
            }
            set
            {
                this.OnOriginalHireDateTimeChanging(value);
                this._OriginalHireDateTime = value;
                this.OnOriginalHireDateTimeChanged();
                this.OnPropertyChanged("OriginalHireDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _OriginalHireDateTime;
        partial void OnOriginalHireDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnOriginalHireDateTimeChanged();
        /// <summary>
        /// There are no comments for Property OfficeLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OfficeLocation
        {
            get
            {
                return this._OfficeLocation;
            }
            set
            {
                this.OnOfficeLocationChanging(value);
                this._OfficeLocation = value;
                this.OnOfficeLocationChanged();
                this.OnPropertyChanged("OfficeLocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OfficeLocation;
        partial void OnOfficeLocationChanging(string value);
        partial void OnOfficeLocationChanged();
        /// <summary>
        /// There are no comments for Property AnniversaryDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset AnniversaryDateTime
        {
            get
            {
                return this._AnniversaryDateTime;
            }
            set
            {
                this.OnAnniversaryDateTimeChanging(value);
                this._AnniversaryDateTime = value;
                this.OnAnniversaryDateTimeChanged();
                this.OnPropertyChanged("AnniversaryDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _AnniversaryDateTime;
        partial void OnAnniversaryDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnAnniversaryDateTimeChanged();
        /// <summary>
        /// There are no comments for Property SeniorityDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset SeniorityDate
        {
            get
            {
                return this._SeniorityDate;
            }
            set
            {
                this.OnSeniorityDateChanging(value);
                this._SeniorityDate = value;
                this.OnSeniorityDateChanged();
                this.OnPropertyChanged("SeniorityDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _SeniorityDate;
        partial void OnSeniorityDateChanging(global::System.DateTimeOffset value);
        partial void OnSeniorityDateChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Title Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Title _Title;
        partial void OnTitleChanging(global::Microsoft.Dynamics.DataEntities.Title value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker Worker
        {
            get
            {
                return this._Worker;
            }
            set
            {
                this.OnWorkerChanging(value);
                this._Worker = value;
                this.OnWorkerChanged();
                this.OnPropertyChanged("Worker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _Worker;
        partial void OnWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnWorkerChanged();
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
