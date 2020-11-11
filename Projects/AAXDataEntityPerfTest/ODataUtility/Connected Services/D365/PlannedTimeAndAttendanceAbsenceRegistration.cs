﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/8/2020 8:07:52 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for PlannedTimeAndAttendanceAbsenceRegistrationSingle in the schema.
        /// </summary>
    public partial class PlannedTimeAndAttendanceAbsenceRegistrationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PlannedTimeAndAttendanceAbsenceRegistration>
    {
        /// <summary>
        /// Initialize a new PlannedTimeAndAttendanceAbsenceRegistrationSingle object.
        /// </summary>
        public PlannedTimeAndAttendanceAbsenceRegistrationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PlannedTimeAndAttendanceAbsenceRegistrationSingle object.
        /// </summary>
        public PlannedTimeAndAttendanceAbsenceRegistrationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PlannedTimeAndAttendanceAbsenceRegistrationSingle object.
        /// </summary>
        public PlannedTimeAndAttendanceAbsenceRegistrationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PlannedTimeAndAttendanceAbsenceRegistration> query)
            : base(query) {}

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
        /// There are no comments for PlannedTimeAndAttendanceAbsenceRegistration in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// WorkerPersonnelNumber
    /// PlannedAbsenceRegistrationEntryNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "WorkerPersonnelNumber", "PlannedAbsenceRegistrationEntryNumber")]
    [global::Microsoft.OData.Client.EntitySet("PlannedTimeAndAttendanceAbsenceRegistrations")]
    public partial class PlannedTimeAndAttendanceAbsenceRegistration : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PlannedTimeAndAttendanceAbsenceRegistration object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="workerPersonnelNumber">Initial value of WorkerPersonnelNumber.</param>
        /// <param name="plannedAbsenceRegistrationEntryNumber">Initial value of PlannedAbsenceRegistrationEntryNumber.</param>
        /// <param name="startDateTime">Initial value of StartDateTime.</param>
        /// <param name="endDateTime">Initial value of EndDateTime.</param>
        /// <param name="calculatedTimeSeconds">Initial value of CalculatedTimeSeconds.</param>
        /// <param name="worker">Initial value of Worker.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PlannedTimeAndAttendanceAbsenceRegistration CreatePlannedTimeAndAttendanceAbsenceRegistration(string dataAreaId, 
                    string workerPersonnelNumber, 
                    long plannedAbsenceRegistrationEntryNumber, 
                    global::System.DateTimeOffset startDateTime, 
                    global::System.DateTimeOffset endDateTime, 
                    int calculatedTimeSeconds, 
                    global::Microsoft.Dynamics.DataEntities.Worker worker)
        {
            PlannedTimeAndAttendanceAbsenceRegistration plannedTimeAndAttendanceAbsenceRegistration = new PlannedTimeAndAttendanceAbsenceRegistration();
            plannedTimeAndAttendanceAbsenceRegistration.dataAreaId = dataAreaId;
            plannedTimeAndAttendanceAbsenceRegistration.WorkerPersonnelNumber = workerPersonnelNumber;
            plannedTimeAndAttendanceAbsenceRegistration.PlannedAbsenceRegistrationEntryNumber = plannedAbsenceRegistrationEntryNumber;
            plannedTimeAndAttendanceAbsenceRegistration.StartDateTime = startDateTime;
            plannedTimeAndAttendanceAbsenceRegistration.EndDateTime = endDateTime;
            plannedTimeAndAttendanceAbsenceRegistration.CalculatedTimeSeconds = calculatedTimeSeconds;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            plannedTimeAndAttendanceAbsenceRegistration.Worker = worker;
            return plannedTimeAndAttendanceAbsenceRegistration;
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
        /// There are no comments for Property PlannedAbsenceRegistrationEntryNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long PlannedAbsenceRegistrationEntryNumber
        {
            get
            {
                return this._PlannedAbsenceRegistrationEntryNumber;
            }
            set
            {
                this.OnPlannedAbsenceRegistrationEntryNumberChanging(value);
                this._PlannedAbsenceRegistrationEntryNumber = value;
                this.OnPlannedAbsenceRegistrationEntryNumberChanged();
                this.OnPropertyChanged("PlannedAbsenceRegistrationEntryNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _PlannedAbsenceRegistrationEntryNumber;
        partial void OnPlannedAbsenceRegistrationEntryNumberChanging(long value);
        partial void OnPlannedAbsenceRegistrationEntryNumberChanged();
        /// <summary>
        /// There are no comments for Property StartDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset StartDateTime
        {
            get
            {
                return this._StartDateTime;
            }
            set
            {
                this.OnStartDateTimeChanging(value);
                this._StartDateTime = value;
                this.OnStartDateTimeChanged();
                this.OnPropertyChanged("StartDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _StartDateTime;
        partial void OnStartDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnStartDateTimeChanged();
        /// <summary>
        /// There are no comments for Property IsPlannedAbsenceInterrupted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPlannedAbsenceInterrupted
        {
            get
            {
                return this._IsPlannedAbsenceInterrupted;
            }
            set
            {
                this.OnIsPlannedAbsenceInterruptedChanging(value);
                this._IsPlannedAbsenceInterrupted = value;
                this.OnIsPlannedAbsenceInterruptedChanged();
                this.OnPropertyChanged("IsPlannedAbsenceInterrupted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPlannedAbsenceInterrupted;
        partial void OnIsPlannedAbsenceInterruptedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPlannedAbsenceInterruptedChanged();
        /// <summary>
        /// There are no comments for Property EndDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EndDateTime
        {
            get
            {
                return this._EndDateTime;
            }
            set
            {
                this.OnEndDateTimeChanging(value);
                this._EndDateTime = value;
                this.OnEndDateTimeChanged();
                this.OnPropertyChanged("EndDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EndDateTime;
        partial void OnEndDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnEndDateTimeChanged();
        /// <summary>
        /// There are no comments for Property IsTimeAndAttendanceActivityRegistration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsTimeAndAttendanceActivityRegistration
        {
            get
            {
                return this._IsTimeAndAttendanceActivityRegistration;
            }
            set
            {
                this.OnIsTimeAndAttendanceActivityRegistrationChanging(value);
                this._IsTimeAndAttendanceActivityRegistration = value;
                this.OnIsTimeAndAttendanceActivityRegistrationChanged();
                this.OnPropertyChanged("IsTimeAndAttendanceActivityRegistration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsTimeAndAttendanceActivityRegistration;
        partial void OnIsTimeAndAttendanceActivityRegistrationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsTimeAndAttendanceActivityRegistrationChanged();
        /// <summary>
        /// There are no comments for Property CalculatedTimeSeconds in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int CalculatedTimeSeconds
        {
            get
            {
                return this._CalculatedTimeSeconds;
            }
            set
            {
                this.OnCalculatedTimeSecondsChanging(value);
                this._CalculatedTimeSeconds = value;
                this.OnCalculatedTimeSecondsChanged();
                this.OnPropertyChanged("CalculatedTimeSeconds");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _CalculatedTimeSeconds;
        partial void OnCalculatedTimeSecondsChanging(int value);
        partial void OnCalculatedTimeSecondsChanged();
        /// <summary>
        /// There are no comments for Property TimeAndAttendanceJobId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TimeAndAttendanceJobId
        {
            get
            {
                return this._TimeAndAttendanceJobId;
            }
            set
            {
                this.OnTimeAndAttendanceJobIdChanging(value);
                this._TimeAndAttendanceJobId = value;
                this.OnTimeAndAttendanceJobIdChanged();
                this.OnPropertyChanged("TimeAndAttendanceJobId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TimeAndAttendanceJobId;
        partial void OnTimeAndAttendanceJobIdChanging(string value);
        partial void OnTimeAndAttendanceJobIdChanged();
        /// <summary>
        /// There are no comments for Property IsPlannedAbsenceInterruptionAllowed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPlannedAbsenceInterruptionAllowed
        {
            get
            {
                return this._IsPlannedAbsenceInterruptionAllowed;
            }
            set
            {
                this.OnIsPlannedAbsenceInterruptionAllowedChanging(value);
                this._IsPlannedAbsenceInterruptionAllowed = value;
                this.OnIsPlannedAbsenceInterruptionAllowedChanged();
                this.OnPropertyChanged("IsPlannedAbsenceInterruptionAllowed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPlannedAbsenceInterruptionAllowed;
        partial void OnIsPlannedAbsenceInterruptionAllowedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPlannedAbsenceInterruptionAllowedChanged();
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