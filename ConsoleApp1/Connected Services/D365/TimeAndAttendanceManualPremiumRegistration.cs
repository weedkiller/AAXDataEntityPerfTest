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
    /// There are no comments for TimeAndAttendanceManualPremiumRegistrationSingle in the schema.
    /// </summary>
    public partial class TimeAndAttendanceManualPremiumRegistrationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TimeAndAttendanceManualPremiumRegistration>
    {
        /// <summary>
        /// Initialize a new TimeAndAttendanceManualPremiumRegistrationSingle object.
        /// </summary>
        public TimeAndAttendanceManualPremiumRegistrationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TimeAndAttendanceManualPremiumRegistrationSingle object.
        /// </summary>
        public TimeAndAttendanceManualPremiumRegistrationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TimeAndAttendanceManualPremiumRegistrationSingle object.
        /// </summary>
        public TimeAndAttendanceManualPremiumRegistrationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TimeAndAttendanceManualPremiumRegistration> query)
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
    /// There are no comments for TimeAndAttendanceManualPremiumRegistration in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TimeProfileDate
    /// ManualPremiumRegistrationEntryNumber
    /// WorkerPersonnelNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TimeProfileDate", "ManualPremiumRegistrationEntryNumber", "WorkerPersonnelNumber")]
    [global::Microsoft.OData.Client.EntitySet("TimeAndAttendanceManualPremiumRegistrations")]
    public partial class TimeAndAttendanceManualPremiumRegistration : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TimeAndAttendanceManualPremiumRegistration object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="timeProfileDate">Initial value of TimeProfileDate.</param>
        /// <param name="manualPremiumRegistrationEntryNumber">Initial value of ManualPremiumRegistrationEntryNumber.</param>
        /// <param name="workerPersonnelNumber">Initial value of WorkerPersonnelNumber.</param>
        /// <param name="unitPrice">Initial value of UnitPrice.</param>
        /// <param name="unitQuantity">Initial value of UnitQuantity.</param>
        /// <param name="worker">Initial value of Worker.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TimeAndAttendanceManualPremiumRegistration CreateTimeAndAttendanceManualPremiumRegistration(string dataAreaId, 
                    global::System.DateTimeOffset timeProfileDate, 
                    long manualPremiumRegistrationEntryNumber, 
                    string workerPersonnelNumber, 
                    decimal unitPrice, 
                    decimal unitQuantity, 
                    global::Microsoft.Dynamics.DataEntities.Worker worker)
        {
            TimeAndAttendanceManualPremiumRegistration timeAndAttendanceManualPremiumRegistration = new TimeAndAttendanceManualPremiumRegistration();
            timeAndAttendanceManualPremiumRegistration.dataAreaId = dataAreaId;
            timeAndAttendanceManualPremiumRegistration.TimeProfileDate = timeProfileDate;
            timeAndAttendanceManualPremiumRegistration.ManualPremiumRegistrationEntryNumber = manualPremiumRegistrationEntryNumber;
            timeAndAttendanceManualPremiumRegistration.WorkerPersonnelNumber = workerPersonnelNumber;
            timeAndAttendanceManualPremiumRegistration.UnitPrice = unitPrice;
            timeAndAttendanceManualPremiumRegistration.UnitQuantity = unitQuantity;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            timeAndAttendanceManualPremiumRegistration.Worker = worker;
            return timeAndAttendanceManualPremiumRegistration;
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
        /// There are no comments for Property TimeProfileDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset TimeProfileDate
        {
            get
            {
                return this._TimeProfileDate;
            }
            set
            {
                this.OnTimeProfileDateChanging(value);
                this._TimeProfileDate = value;
                this.OnTimeProfileDateChanged();
                this.OnPropertyChanged("TimeProfileDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _TimeProfileDate;
        partial void OnTimeProfileDateChanging(global::System.DateTimeOffset value);
        partial void OnTimeProfileDateChanged();
        /// <summary>
        /// There are no comments for Property ManualPremiumRegistrationEntryNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long ManualPremiumRegistrationEntryNumber
        {
            get
            {
                return this._ManualPremiumRegistrationEntryNumber;
            }
            set
            {
                this.OnManualPremiumRegistrationEntryNumberChanging(value);
                this._ManualPremiumRegistrationEntryNumber = value;
                this.OnManualPremiumRegistrationEntryNumberChanged();
                this.OnPropertyChanged("ManualPremiumRegistrationEntryNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _ManualPremiumRegistrationEntryNumber;
        partial void OnManualPremiumRegistrationEntryNumberChanging(long value);
        partial void OnManualPremiumRegistrationEntryNumberChanged();
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
        /// There are no comments for Property UnitPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal UnitPrice
        {
            get
            {
                return this._UnitPrice;
            }
            set
            {
                this.OnUnitPriceChanging(value);
                this._UnitPrice = value;
                this.OnUnitPriceChanged();
                this.OnPropertyChanged("UnitPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _UnitPrice;
        partial void OnUnitPriceChanging(decimal value);
        partial void OnUnitPriceChanged();
        /// <summary>
        /// There are no comments for Property ActivityRegistrationTransactionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ActivityRegistrationTransactionId
        {
            get
            {
                return this._ActivityRegistrationTransactionId;
            }
            set
            {
                this.OnActivityRegistrationTransactionIdChanging(value);
                this._ActivityRegistrationTransactionId = value;
                this.OnActivityRegistrationTransactionIdChanged();
                this.OnPropertyChanged("ActivityRegistrationTransactionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ActivityRegistrationTransactionId;
        partial void OnActivityRegistrationTransactionIdChanging(string value);
        partial void OnActivityRegistrationTransactionIdChanged();
        /// <summary>
        /// There are no comments for Property UnitQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal UnitQuantity
        {
            get
            {
                return this._UnitQuantity;
            }
            set
            {
                this.OnUnitQuantityChanging(value);
                this._UnitQuantity = value;
                this.OnUnitQuantityChanged();
                this.OnPropertyChanged("UnitQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _UnitQuantity;
        partial void OnUnitQuantityChanging(decimal value);
        partial void OnUnitQuantityChanged();
        /// <summary>
        /// There are no comments for Property TimeAndAttendanceManualPremiumId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TimeAndAttendanceManualPremiumId
        {
            get
            {
                return this._TimeAndAttendanceManualPremiumId;
            }
            set
            {
                this.OnTimeAndAttendanceManualPremiumIdChanging(value);
                this._TimeAndAttendanceManualPremiumId = value;
                this.OnTimeAndAttendanceManualPremiumIdChanged();
                this.OnPropertyChanged("TimeAndAttendanceManualPremiumId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TimeAndAttendanceManualPremiumId;
        partial void OnTimeAndAttendanceManualPremiumIdChanging(string value);
        partial void OnTimeAndAttendanceManualPremiumIdChanged();
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
