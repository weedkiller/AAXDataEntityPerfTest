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
    /// There are no comments for PayPeriodSingle in the schema.
    /// </summary>
    public partial class PayPeriodSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PayPeriod>
    {
        /// <summary>
        /// Initialize a new PayPeriodSingle object.
        /// </summary>
        public PayPeriodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PayPeriodSingle object.
        /// </summary>
        public PayPeriodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PayPeriodSingle object.
        /// </summary>
        public PayPeriodSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PayPeriod> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PayCycle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayCycleSingle PayCycle
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayCycle == null))
                {
                    this._PayCycle = new global::Microsoft.Dynamics.DataEntities.PayCycleSingle(this.Context, GetPath("PayCycle"));
                }
                return this._PayCycle;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayCycleSingle _PayCycle;
        /// <summary>
        /// There are no comments for PayrollEarningStatement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry> PayrollEarningStatement
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayrollEarningStatement == null))
                {
                    this._PayrollEarningStatement = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry>(GetPath("PayrollEarningStatement"));
                }
                return this._PayrollEarningStatement;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry> _PayrollEarningStatement;
        /// <summary>
        /// There are no comments for PayrollCalculationFrequencyPayPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequencyPayPeriod> PayrollCalculationFrequencyPayPeriod
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayrollCalculationFrequencyPayPeriod == null))
                {
                    this._PayrollCalculationFrequencyPayPeriod = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequencyPayPeriod>(GetPath("PayrollCalculationFrequencyPayPeriod"));
                }
                return this._PayrollCalculationFrequencyPayPeriod;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequencyPayPeriod> _PayrollCalculationFrequencyPayPeriod;
    }
    /// <summary>
    /// There are no comments for PayPeriod in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PayCycleId
    /// PeriodStartDate
    /// PeriodEndDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PayCycleId", "PeriodStartDate", "PeriodEndDate")]
    [global::Microsoft.OData.Client.EntitySet("PayPeriods")]
    public partial class PayPeriod : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PayPeriod object.
        /// </summary>
        /// <param name="payCycleId">Initial value of PayCycleId.</param>
        /// <param name="periodStartDate">Initial value of PeriodStartDate.</param>
        /// <param name="periodEndDate">Initial value of PeriodEndDate.</param>
        /// <param name="defaultPaymentDate">Initial value of DefaultPaymentDate.</param>
        /// <param name="payCycle">Initial value of PayCycle.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PayPeriod CreatePayPeriod(string payCycleId, global::System.DateTimeOffset periodStartDate, global::System.DateTimeOffset periodEndDate, global::System.DateTimeOffset defaultPaymentDate, global::Microsoft.Dynamics.DataEntities.PayCycle payCycle)
        {
            PayPeriod payPeriod = new PayPeriod();
            payPeriod.PayCycleId = payCycleId;
            payPeriod.PeriodStartDate = periodStartDate;
            payPeriod.PeriodEndDate = periodEndDate;
            payPeriod.DefaultPaymentDate = defaultPaymentDate;
            if ((payCycle == null))
            {
                throw new global::System.ArgumentNullException("payCycle");
            }
            payPeriod.PayCycle = payCycle;
            return payPeriod;
        }
        /// <summary>
        /// There are no comments for Property PayCycleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PayCycleId
        {
            get
            {
                return this._PayCycleId;
            }
            set
            {
                this.OnPayCycleIdChanging(value);
                this._PayCycleId = value;
                this.OnPayCycleIdChanged();
                this.OnPropertyChanged("PayCycleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PayCycleId;
        partial void OnPayCycleIdChanging(string value);
        partial void OnPayCycleIdChanged();
        /// <summary>
        /// There are no comments for Property PeriodStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset PeriodStartDate
        {
            get
            {
                return this._PeriodStartDate;
            }
            set
            {
                this.OnPeriodStartDateChanging(value);
                this._PeriodStartDate = value;
                this.OnPeriodStartDateChanged();
                this.OnPropertyChanged("PeriodStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PeriodStartDate;
        partial void OnPeriodStartDateChanging(global::System.DateTimeOffset value);
        partial void OnPeriodStartDateChanged();
        /// <summary>
        /// There are no comments for Property PeriodEndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset PeriodEndDate
        {
            get
            {
                return this._PeriodEndDate;
            }
            set
            {
                this.OnPeriodEndDateChanging(value);
                this._PeriodEndDate = value;
                this.OnPeriodEndDateChanged();
                this.OnPropertyChanged("PeriodEndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PeriodEndDate;
        partial void OnPeriodEndDateChanging(global::System.DateTimeOffset value);
        partial void OnPeriodEndDateChanged();
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
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPeriodStatus> Status
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPeriodStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPeriodStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property DefaultPaymentDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DefaultPaymentDate
        {
            get
            {
                return this._DefaultPaymentDate;
            }
            set
            {
                this.OnDefaultPaymentDateChanging(value);
                this._DefaultPaymentDate = value;
                this.OnDefaultPaymentDateChanged();
                this.OnPropertyChanged("DefaultPaymentDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DefaultPaymentDate;
        partial void OnDefaultPaymentDateChanging(global::System.DateTimeOffset value);
        partial void OnDefaultPaymentDateChanged();
        /// <summary>
        /// There are no comments for Property PayCycle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayCycle PayCycle
        {
            get
            {
                return this._PayCycle;
            }
            set
            {
                this.OnPayCycleChanging(value);
                this._PayCycle = value;
                this.OnPayCycleChanged();
                this.OnPropertyChanged("PayCycle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayCycle _PayCycle;
        partial void OnPayCycleChanging(global::Microsoft.Dynamics.DataEntities.PayCycle value);
        partial void OnPayCycleChanged();
        /// <summary>
        /// There are no comments for Property PayrollEarningStatement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry> PayrollEarningStatement
        {
            get
            {
                return this._PayrollEarningStatement;
            }
            set
            {
                this.OnPayrollEarningStatementChanging(value);
                this._PayrollEarningStatement = value;
                this.OnPayrollEarningStatementChanged();
                this.OnPropertyChanged("PayrollEarningStatement");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry> _PayrollEarningStatement = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPayrollEarningStatementChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EarningStatementLineInquiry> value);
        partial void OnPayrollEarningStatementChanged();
        /// <summary>
        /// There are no comments for Property PayrollCalculationFrequencyPayPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequencyPayPeriod> PayrollCalculationFrequencyPayPeriod
        {
            get
            {
                return this._PayrollCalculationFrequencyPayPeriod;
            }
            set
            {
                this.OnPayrollCalculationFrequencyPayPeriodChanging(value);
                this._PayrollCalculationFrequencyPayPeriod = value;
                this.OnPayrollCalculationFrequencyPayPeriodChanged();
                this.OnPropertyChanged("PayrollCalculationFrequencyPayPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequencyPayPeriod> _PayrollCalculationFrequencyPayPeriod = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequencyPayPeriod>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPayrollCalculationFrequencyPayPeriodChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequencyPayPeriod> value);
        partial void OnPayrollCalculationFrequencyPayPeriodChanged();
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
