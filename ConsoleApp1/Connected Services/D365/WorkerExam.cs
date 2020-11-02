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
    /// There are no comments for WorkerExamSingle in the schema.
    /// </summary>
    public partial class WorkerExamSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerExam>
    {
        /// <summary>
        /// Initialize a new WorkerExamSingle object.
        /// </summary>
        public WorkerExamSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WorkerExamSingle object.
        /// </summary>
        public WorkerExamSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WorkerExamSingle object.
        /// </summary>
        public WorkerExamSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerExam> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TestType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TestTypeSingle TestType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TestType == null))
                {
                    this._TestType = new global::Microsoft.Dynamics.DataEntities.TestTypeSingle(this.Context, GetPath("TestType"));
                }
                return this._TestType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TestTypeSingle _TestType;
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
    /// There are no comments for WorkerExam in the schema.
    /// </summary>
    /// <KeyProperties>
    /// RequiredBy
    /// PersonnelNumber
    /// TestId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RequiredBy", "PersonnelNumber", "TestId")]
    [global::Microsoft.OData.Client.EntitySet("WorkerExams")]
    public partial class WorkerExam : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WorkerExam object.
        /// </summary>
        /// <param name="requiredBy">Initial value of RequiredBy.</param>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="testId">Initial value of TestId.</param>
        /// <param name="score">Initial value of Score.</param>
        /// <param name="completedOn">Initial value of CompletedOn.</param>
        /// <param name="testType">Initial value of TestType.</param>
        /// <param name="worker">Initial value of Worker.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WorkerExam CreateWorkerExam(global::System.DateTimeOffset requiredBy, 
                    string personnelNumber, 
                    string testId, 
                    int score, 
                    global::System.DateTimeOffset completedOn, 
                    global::Microsoft.Dynamics.DataEntities.TestType testType, 
                    global::Microsoft.Dynamics.DataEntities.Worker worker)
        {
            WorkerExam workerExam = new WorkerExam();
            workerExam.RequiredBy = requiredBy;
            workerExam.PersonnelNumber = personnelNumber;
            workerExam.TestId = testId;
            workerExam.Score = score;
            workerExam.CompletedOn = completedOn;
            if ((testType == null))
            {
                throw new global::System.ArgumentNullException("testType");
            }
            workerExam.TestType = testType;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            workerExam.Worker = worker;
            return workerExam;
        }
        /// <summary>
        /// There are no comments for Property RequiredBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset RequiredBy
        {
            get
            {
                return this._RequiredBy;
            }
            set
            {
                this.OnRequiredByChanging(value);
                this._RequiredBy = value;
                this.OnRequiredByChanged();
                this.OnPropertyChanged("RequiredBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _RequiredBy;
        partial void OnRequiredByChanging(global::System.DateTimeOffset value);
        partial void OnRequiredByChanged();
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
        /// There are no comments for Property TestId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TestId
        {
            get
            {
                return this._TestId;
            }
            set
            {
                this.OnTestIdChanging(value);
                this._TestId = value;
                this.OnTestIdChanged();
                this.OnPropertyChanged("TestId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TestId;
        partial void OnTestIdChanging(string value);
        partial void OnTestIdChanged();
        /// <summary>
        /// There are no comments for Property Score in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int Score
        {
            get
            {
                return this._Score;
            }
            set
            {
                this.OnScoreChanging(value);
                this._Score = value;
                this.OnScoreChanged();
                this.OnPropertyChanged("Score");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Score;
        partial void OnScoreChanging(int value);
        partial void OnScoreChanged();
        /// <summary>
        /// There are no comments for Property CompletedOn in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset CompletedOn
        {
            get
            {
                return this._CompletedOn;
            }
            set
            {
                this.OnCompletedOnChanging(value);
                this._CompletedOn = value;
                this.OnCompletedOnChanged();
                this.OnPropertyChanged("CompletedOn");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CompletedOn;
        partial void OnCompletedOnChanging(global::System.DateTimeOffset value);
        partial void OnCompletedOnChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmCompletionStatus> Status
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmCompletionStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmCompletionStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                this.OnNotesChanging(value);
                this._Notes = value;
                this.OnNotesChanged();
                this.OnPropertyChanged("Notes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Notes;
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
        /// <summary>
        /// There are no comments for Property TestType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TestType TestType
        {
            get
            {
                return this._TestType;
            }
            set
            {
                this.OnTestTypeChanging(value);
                this._TestType = value;
                this.OnTestTypeChanged();
                this.OnPropertyChanged("TestType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TestType _TestType;
        partial void OnTestTypeChanging(global::Microsoft.Dynamics.DataEntities.TestType value);
        partial void OnTestTypeChanged();
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
