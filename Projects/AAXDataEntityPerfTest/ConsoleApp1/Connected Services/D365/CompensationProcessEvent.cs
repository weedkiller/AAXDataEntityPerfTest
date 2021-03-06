﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 9/11/2020 3:24:26 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for CompensationProcessEventSingle in the schema.
    /// </summary>
    public partial class CompensationProcessEventSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationProcessEvent>
    {
        /// <summary>
        /// Initialize a new CompensationProcessEventSingle object.
        /// </summary>
        public CompensationProcessEventSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CompensationProcessEventSingle object.
        /// </summary>
        public CompensationProcessEventSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CompensationProcessEventSingle object.
        /// </summary>
        public CompensationProcessEventSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationProcessEvent> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CompensationProcessEvent in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// Process
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Process")]
    [global::Microsoft.OData.Client.EntitySet("CompensationProcessEvents")]
    public partial class CompensationProcessEvent : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CompensationProcessEvent object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="process">Initial value of Process.</param>
        /// <param name="fixedPayProRatedHireDate">Initial value of FixedPayProRatedHireDate.</param>
        /// <param name="reviewDeadline">Initial value of ReviewDeadline.</param>
        /// <param name="transactionActiveDate">Initial value of TransactionActiveDate.</param>
        /// <param name="pointInTimeDate">Initial value of PointInTimeDate.</param>
        /// <param name="cycleEnd">Initial value of CycleEnd.</param>
        /// <param name="cycleStart">Initial value of CycleStart.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CompensationProcessEvent CreateCompensationProcessEvent(string dataAreaId, 
                    string process, 
                    global::System.DateTimeOffset fixedPayProRatedHireDate, 
                    global::System.DateTimeOffset reviewDeadline, 
                    global::System.DateTimeOffset transactionActiveDate, 
                    global::System.DateTimeOffset pointInTimeDate, 
                    global::System.DateTimeOffset cycleEnd, 
                    global::System.DateTimeOffset cycleStart)
        {
            CompensationProcessEvent compensationProcessEvent = new CompensationProcessEvent();
            compensationProcessEvent.dataAreaId = dataAreaId;
            compensationProcessEvent.Process = process;
            compensationProcessEvent.FixedPayProRatedHireDate = fixedPayProRatedHireDate;
            compensationProcessEvent.ReviewDeadline = reviewDeadline;
            compensationProcessEvent.TransactionActiveDate = transactionActiveDate;
            compensationProcessEvent.PointInTimeDate = pointInTimeDate;
            compensationProcessEvent.CycleEnd = cycleEnd;
            compensationProcessEvent.CycleStart = cycleStart;
            return compensationProcessEvent;
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
        /// There are no comments for Property Process in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Process
        {
            get
            {
                return this._Process;
            }
            set
            {
                this.OnProcessChanging(value);
                this._Process = value;
                this.OnProcessChanged();
                this.OnPropertyChanged("Process");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Process;
        partial void OnProcessChanging(string value);
        partial void OnProcessChanged();
        /// <summary>
        /// There are no comments for Property FixedPayProRatedHireDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset FixedPayProRatedHireDate
        {
            get
            {
                return this._FixedPayProRatedHireDate;
            }
            set
            {
                this.OnFixedPayProRatedHireDateChanging(value);
                this._FixedPayProRatedHireDate = value;
                this.OnFixedPayProRatedHireDateChanged();
                this.OnPropertyChanged("FixedPayProRatedHireDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _FixedPayProRatedHireDate;
        partial void OnFixedPayProRatedHireDateChanging(global::System.DateTimeOffset value);
        partial void OnFixedPayProRatedHireDateChanged();
        /// <summary>
        /// There are no comments for Property ReviewDeadline in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ReviewDeadline
        {
            get
            {
                return this._ReviewDeadline;
            }
            set
            {
                this.OnReviewDeadlineChanging(value);
                this._ReviewDeadline = value;
                this.OnReviewDeadlineChanged();
                this.OnPropertyChanged("ReviewDeadline");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ReviewDeadline;
        partial void OnReviewDeadlineChanging(global::System.DateTimeOffset value);
        partial void OnReviewDeadlineChanged();
        /// <summary>
        /// There are no comments for Property ProcessType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompProcessType> ProcessType
        {
            get
            {
                return this._ProcessType;
            }
            set
            {
                this.OnProcessTypeChanging(value);
                this._ProcessType = value;
                this.OnProcessTypeChanged();
                this.OnPropertyChanged("ProcessType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompProcessType> _ProcessType;
        partial void OnProcessTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompProcessType> value);
        partial void OnProcessTypeChanged();
        /// <summary>
        /// There are no comments for Property TransactionActiveDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset TransactionActiveDate
        {
            get
            {
                return this._TransactionActiveDate;
            }
            set
            {
                this.OnTransactionActiveDateChanging(value);
                this._TransactionActiveDate = value;
                this.OnTransactionActiveDateChanged();
                this.OnPropertyChanged("TransactionActiveDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _TransactionActiveDate;
        partial void OnTransactionActiveDateChanging(global::System.DateTimeOffset value);
        partial void OnTransactionActiveDateChanged();
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
        /// There are no comments for Property PointInTimeDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset PointInTimeDate
        {
            get
            {
                return this._PointInTimeDate;
            }
            set
            {
                this.OnPointInTimeDateChanging(value);
                this._PointInTimeDate = value;
                this.OnPointInTimeDateChanged();
                this.OnPropertyChanged("PointInTimeDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PointInTimeDate;
        partial void OnPointInTimeDateChanging(global::System.DateTimeOffset value);
        partial void OnPointInTimeDateChanged();
        /// <summary>
        /// There are no comments for Property CycleEnd in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset CycleEnd
        {
            get
            {
                return this._CycleEnd;
            }
            set
            {
                this.OnCycleEndChanging(value);
                this._CycleEnd = value;
                this.OnCycleEndChanged();
                this.OnPropertyChanged("CycleEnd");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CycleEnd;
        partial void OnCycleEndChanging(global::System.DateTimeOffset value);
        partial void OnCycleEndChanged();
        /// <summary>
        /// There are no comments for Property CycleStart in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset CycleStart
        {
            get
            {
                return this._CycleStart;
            }
            set
            {
                this.OnCycleStartChanging(value);
                this._CycleStart = value;
                this.OnCycleStartChanged();
                this.OnPropertyChanged("CycleStart");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CycleStart;
        partial void OnCycleStartChanging(global::System.DateTimeOffset value);
        partial void OnCycleStartChanged();
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
