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
        /// There are no comments for GoalSingle in the schema.
        /// </summary>
    public partial class GoalSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Goal>
    {
        /// <summary>
        /// Initialize a new GoalSingle object.
        /// </summary>
        public GoalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new GoalSingle object.
        /// </summary>
        public GoalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new GoalSingle object.
        /// </summary>
        public GoalSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Goal> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for GoalHeading in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.GoalHeadingSingle GoalHeading
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._GoalHeading == null))
                {
                    this._GoalHeading = new global::Microsoft.Dynamics.DataEntities.GoalHeadingSingle(this.Context, GetPath("GoalHeading"));
                }
                return this._GoalHeading;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.GoalHeadingSingle _GoalHeading;
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
        /// There are no comments for Goal in the schema.
        /// </summary>
    /// <KeyProperties>
    /// Goal
    /// PersonnelNumber
    /// GoalHeadingId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Goal", "PersonnelNumber", "GoalHeadingId")]
    [global::Microsoft.OData.Client.EntitySet("Goals")]
    public partial class Goal : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Goal object.
        /// </summary>
        /// <param name="goal1">Initial value of Goal1.</param>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="goalHeadingId">Initial value of GoalHeadingId.</param>
        /// <param name="dateFinished">Initial value of DateFinished.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="endDate">Initial value of EndDate.</param>
        /// <param name="percentComplete">Initial value of PercentComplete.</param>
        /// <param name="goalHeading">Initial value of GoalHeading.</param>
        /// <param name="worker">Initial value of Worker.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Goal CreateGoal(string goal1, 
                    string personnelNumber, 
                    string goalHeadingId, 
                    global::System.DateTimeOffset dateFinished, 
                    global::System.DateTimeOffset startDate, 
                    global::System.DateTimeOffset endDate, 
                    decimal percentComplete, 
                    global::Microsoft.Dynamics.DataEntities.GoalHeading goalHeading, 
                    global::Microsoft.Dynamics.DataEntities.Worker worker)
        {
            Goal goal = new Goal();
            goal.Goal1 = goal1;
            goal.PersonnelNumber = personnelNumber;
            goal.GoalHeadingId = goalHeadingId;
            goal.DateFinished = dateFinished;
            goal.StartDate = startDate;
            goal.EndDate = endDate;
            goal.PercentComplete = percentComplete;
            if ((goalHeading == null))
            {
                throw new global::System.ArgumentNullException("goalHeading");
            }
            goal.GoalHeading = goalHeading;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            goal.Worker = worker;
            return goal;
        }
        /// <summary>
        /// There are no comments for Property Goal1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Goal")]
        public virtual string Goal1
        {
            get
            {
                return this._Goal1;
            }
            set
            {
                this.OnGoal1Changing(value);
                this._Goal1 = value;
                this.OnGoal1Changed();
                this.OnPropertyChanged("Goal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Goal1;
        partial void OnGoal1Changing(string value);
        partial void OnGoal1Changed();
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
        /// There are no comments for Property GoalHeadingId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GoalHeadingId
        {
            get
            {
                return this._GoalHeadingId;
            }
            set
            {
                this.OnGoalHeadingIdChanging(value);
                this._GoalHeadingId = value;
                this.OnGoalHeadingIdChanged();
                this.OnPropertyChanged("GoalHeadingId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GoalHeadingId;
        partial void OnGoalHeadingIdChanging(string value);
        partial void OnGoalHeadingIdChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmGoalStatus> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmGoalStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmGoalStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property DateFinished in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DateFinished
        {
            get
            {
                return this._DateFinished;
            }
            set
            {
                this.OnDateFinishedChanging(value);
                this._DateFinished = value;
                this.OnDateFinishedChanged();
                this.OnPropertyChanged("DateFinished");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DateFinished;
        partial void OnDateFinishedChanging(global::System.DateTimeOffset value);
        partial void OnDateFinishedChanged();
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
        /// There are no comments for Property PercentComplete in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PercentComplete
        {
            get
            {
                return this._PercentComplete;
            }
            set
            {
                this.OnPercentCompleteChanging(value);
                this._PercentComplete = value;
                this.OnPercentCompleteChanged();
                this.OnPropertyChanged("PercentComplete");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PercentComplete;
        partial void OnPercentCompleteChanging(decimal value);
        partial void OnPercentCompleteChanged();
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
        /// There are no comments for Property GoalLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmGoalLevel> GoalLevel
        {
            get
            {
                return this._GoalLevel;
            }
            set
            {
                this.OnGoalLevelChanging(value);
                this._GoalLevel = value;
                this.OnGoalLevelChanged();
                this.OnPropertyChanged("GoalLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmGoalLevel> _GoalLevel;
        partial void OnGoalLevelChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmGoalLevel> value);
        partial void OnGoalLevelChanged();
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
        /// There are no comments for Property GoalHeading in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.GoalHeading GoalHeading
        {
            get
            {
                return this._GoalHeading;
            }
            set
            {
                this.OnGoalHeadingChanging(value);
                this._GoalHeading = value;
                this.OnGoalHeadingChanged();
                this.OnPropertyChanged("GoalHeading");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.GoalHeading _GoalHeading;
        partial void OnGoalHeadingChanging(global::Microsoft.Dynamics.DataEntities.GoalHeading value);
        partial void OnGoalHeadingChanged();
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
