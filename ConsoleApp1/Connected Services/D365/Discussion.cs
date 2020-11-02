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
    /// There are no comments for DiscussionSingle in the schema.
    /// </summary>
    public partial class DiscussionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Discussion>
    {
        /// <summary>
        /// Initialize a new DiscussionSingle object.
        /// </summary>
        public DiscussionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DiscussionSingle object.
        /// </summary>
        public DiscussionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DiscussionSingle object.
        /// </summary>
        public DiscussionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Discussion> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PerfPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PerfPeriodSingle PerfPeriod
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PerfPeriod == null))
                {
                    this._PerfPeriod = new global::Microsoft.Dynamics.DataEntities.PerfPeriodSingle(this.Context, GetPath("PerfPeriod"));
                }
                return this._PerfPeriod;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PerfPeriodSingle _PerfPeriod;
        /// <summary>
        /// There are no comments for RatingLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RatingLevelSingle RatingLevel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RatingLevel == null))
                {
                    this._RatingLevel = new global::Microsoft.Dynamics.DataEntities.RatingLevelSingle(this.Context, GetPath("RatingLevel"));
                }
                return this._RatingLevel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RatingLevelSingle _RatingLevel;
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
        /// <summary>
        /// There are no comments for HcmDiscussionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DiscussionTypeSingle HcmDiscussionType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._HcmDiscussionType == null))
                {
                    this._HcmDiscussionType = new global::Microsoft.Dynamics.DataEntities.DiscussionTypeSingle(this.Context, GetPath("HcmDiscussionType"));
                }
                return this._HcmDiscussionType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DiscussionTypeSingle _HcmDiscussionType;
    }
    /// <summary>
    /// There are no comments for Discussion in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Discussion
    /// PersonnelNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Discussion", "PersonnelNumber")]
    [global::Microsoft.OData.Client.EntitySet("Discussions")]
    public partial class Discussion : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Discussion object.
        /// </summary>
        /// <param name="discussion1">Initial value of Discussion1.</param>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="finishedDate">Initial value of FinishedDate.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="endDate">Initial value of EndDate.</param>
        /// <param name="perfPeriod">Initial value of PerfPeriod.</param>
        /// <param name="ratingLevel">Initial value of RatingLevel.</param>
        /// <param name="worker">Initial value of Worker.</param>
        /// <param name="hcmDiscussionType">Initial value of HcmDiscussionType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Discussion CreateDiscussion(string discussion1, 
                    string personnelNumber, 
                    global::System.DateTimeOffset finishedDate, 
                    global::System.DateTimeOffset startDate, 
                    global::System.DateTimeOffset endDate, 
                    global::Microsoft.Dynamics.DataEntities.PerfPeriod perfPeriod, 
                    global::Microsoft.Dynamics.DataEntities.RatingLevel ratingLevel, 
                    global::Microsoft.Dynamics.DataEntities.Worker worker, 
                    global::Microsoft.Dynamics.DataEntities.DiscussionType hcmDiscussionType)
        {
            Discussion discussion = new Discussion();
            discussion.Discussion1 = discussion1;
            discussion.PersonnelNumber = personnelNumber;
            discussion.FinishedDate = finishedDate;
            discussion.StartDate = startDate;
            discussion.EndDate = endDate;
            if ((perfPeriod == null))
            {
                throw new global::System.ArgumentNullException("perfPeriod");
            }
            discussion.PerfPeriod = perfPeriod;
            if ((ratingLevel == null))
            {
                throw new global::System.ArgumentNullException("ratingLevel");
            }
            discussion.RatingLevel = ratingLevel;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            discussion.Worker = worker;
            if ((hcmDiscussionType == null))
            {
                throw new global::System.ArgumentNullException("hcmDiscussionType");
            }
            discussion.HcmDiscussionType = hcmDiscussionType;
            return discussion;
        }
        /// <summary>
        /// There are no comments for Property Discussion1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Discussion")]
        public virtual string Discussion1
        {
            get
            {
                return this._Discussion1;
            }
            set
            {
                this.OnDiscussion1Changing(value);
                this._Discussion1 = value;
                this.OnDiscussion1Changed();
                this.OnPropertyChanged("Discussion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Discussion1;
        partial void OnDiscussion1Changing(string value);
        partial void OnDiscussion1Changed();
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
        /// There are no comments for Property PerformancePeriodId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PerformancePeriodId
        {
            get
            {
                return this._PerformancePeriodId;
            }
            set
            {
                this.OnPerformancePeriodIdChanging(value);
                this._PerformancePeriodId = value;
                this.OnPerformancePeriodIdChanged();
                this.OnPropertyChanged("PerformancePeriodId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PerformancePeriodId;
        partial void OnPerformancePeriodIdChanging(string value);
        partial void OnPerformancePeriodIdChanged();
        /// <summary>
        /// There are no comments for Property Comments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Comments
        {
            get
            {
                return this._Comments;
            }
            set
            {
                this.OnCommentsChanging(value);
                this._Comments = value;
                this.OnCommentsChanged();
                this.OnPropertyChanged("Comments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Comments;
        partial void OnCommentsChanging(string value);
        partial void OnCommentsChanged();
        /// <summary>
        /// There are no comments for Property DiscussionApprovalStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmDiscussionApproveStatus> DiscussionApprovalStatus
        {
            get
            {
                return this._DiscussionApprovalStatus;
            }
            set
            {
                this.OnDiscussionApprovalStatusChanging(value);
                this._DiscussionApprovalStatus = value;
                this.OnDiscussionApprovalStatusChanged();
                this.OnPropertyChanged("DiscussionApprovalStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmDiscussionApproveStatus> _DiscussionApprovalStatus;
        partial void OnDiscussionApprovalStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmDiscussionApproveStatus> value);
        partial void OnDiscussionApprovalStatusChanged();
        /// <summary>
        /// There are no comments for Property FinalEmployeeRatingId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FinalEmployeeRatingId
        {
            get
            {
                return this._FinalEmployeeRatingId;
            }
            set
            {
                this.OnFinalEmployeeRatingIdChanging(value);
                this._FinalEmployeeRatingId = value;
                this.OnFinalEmployeeRatingIdChanged();
                this.OnPropertyChanged("FinalEmployeeRatingId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FinalEmployeeRatingId;
        partial void OnFinalEmployeeRatingIdChanging(string value);
        partial void OnFinalEmployeeRatingIdChanged();
        /// <summary>
        /// There are no comments for Property FinishedDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset FinishedDate
        {
            get
            {
                return this._FinishedDate;
            }
            set
            {
                this.OnFinishedDateChanging(value);
                this._FinishedDate = value;
                this.OnFinishedDateChanged();
                this.OnPropertyChanged("FinishedDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _FinishedDate;
        partial void OnFinishedDateChanging(global::System.DateTimeOffset value);
        partial void OnFinishedDateChanged();
        /// <summary>
        /// There are no comments for Property ReviewTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReviewTypeId
        {
            get
            {
                return this._ReviewTypeId;
            }
            set
            {
                this.OnReviewTypeIdChanging(value);
                this._ReviewTypeId = value;
                this.OnReviewTypeIdChanged();
                this.OnPropertyChanged("ReviewTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReviewTypeId;
        partial void OnReviewTypeIdChanging(string value);
        partial void OnReviewTypeIdChanged();
        /// <summary>
        /// There are no comments for Property WorkflowEnabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WorkflowEnabled
        {
            get
            {
                return this._WorkflowEnabled;
            }
            set
            {
                this.OnWorkflowEnabledChanging(value);
                this._WorkflowEnabled = value;
                this.OnWorkflowEnabledChanged();
                this.OnPropertyChanged("WorkflowEnabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WorkflowEnabled;
        partial void OnWorkflowEnabledChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWorkflowEnabledChanged();
        /// <summary>
        /// There are no comments for Property RatingModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RatingModelId
        {
            get
            {
                return this._RatingModelId;
            }
            set
            {
                this.OnRatingModelIdChanging(value);
                this._RatingModelId = value;
                this.OnRatingModelIdChanged();
                this.OnPropertyChanged("RatingModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RatingModelId;
        partial void OnRatingModelIdChanging(string value);
        partial void OnRatingModelIdChanged();
        /// <summary>
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this.OnStartDateChanging(value);
                this._StartDate = value;
                this.OnStartDateChanged();
                this.OnPropertyChanged("StartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _StartDate;
        partial void OnStartDateChanging(global::System.DateTimeOffset value);
        partial void OnStartDateChanged();
        /// <summary>
        /// There are no comments for Property EndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EndDate
        {
            get
            {
                return this._EndDate;
            }
            set
            {
                this.OnEndDateChanging(value);
                this._EndDate = value;
                this.OnEndDateChanged();
                this.OnPropertyChanged("EndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EndDate;
        partial void OnEndDateChanging(global::System.DateTimeOffset value);
        partial void OnEndDateChanged();
        /// <summary>
        /// There are no comments for Property Overview in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Overview
        {
            get
            {
                return this._Overview;
            }
            set
            {
                this.OnOverviewChanging(value);
                this._Overview = value;
                this.OnOverviewChanged();
                this.OnPropertyChanged("Overview");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Overview;
        partial void OnOverviewChanging(string value);
        partial void OnOverviewChanged();
        /// <summary>
        /// There are no comments for Property PerfPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PerfPeriod PerfPeriod
        {
            get
            {
                return this._PerfPeriod;
            }
            set
            {
                this.OnPerfPeriodChanging(value);
                this._PerfPeriod = value;
                this.OnPerfPeriodChanged();
                this.OnPropertyChanged("PerfPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PerfPeriod _PerfPeriod;
        partial void OnPerfPeriodChanging(global::Microsoft.Dynamics.DataEntities.PerfPeriod value);
        partial void OnPerfPeriodChanged();
        /// <summary>
        /// There are no comments for Property RatingLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RatingLevel RatingLevel
        {
            get
            {
                return this._RatingLevel;
            }
            set
            {
                this.OnRatingLevelChanging(value);
                this._RatingLevel = value;
                this.OnRatingLevelChanged();
                this.OnPropertyChanged("RatingLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RatingLevel _RatingLevel;
        partial void OnRatingLevelChanging(global::Microsoft.Dynamics.DataEntities.RatingLevel value);
        partial void OnRatingLevelChanged();
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
        /// There are no comments for Property HcmDiscussionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DiscussionType HcmDiscussionType
        {
            get
            {
                return this._HcmDiscussionType;
            }
            set
            {
                this.OnHcmDiscussionTypeChanging(value);
                this._HcmDiscussionType = value;
                this.OnHcmDiscussionTypeChanged();
                this.OnPropertyChanged("HcmDiscussionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DiscussionType _HcmDiscussionType;
        partial void OnHcmDiscussionTypeChanging(global::Microsoft.Dynamics.DataEntities.DiscussionType value);
        partial void OnHcmDiscussionTypeChanged();
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
