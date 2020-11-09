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
        /// There are no comments for PaymentScheduleLineSingle in the schema.
        /// </summary>
    public partial class PaymentScheduleLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PaymentScheduleLine>
    {
        /// <summary>
        /// Initialize a new PaymentScheduleLineSingle object.
        /// </summary>
        public PaymentScheduleLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PaymentScheduleLineSingle object.
        /// </summary>
        public PaymentScheduleLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PaymentScheduleLineSingle object.
        /// </summary>
        public PaymentScheduleLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PaymentScheduleLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PaymentSchedule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PaymentScheduleSingle PaymentSchedule
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PaymentSchedule == null))
                {
                    this._PaymentSchedule = new global::Microsoft.Dynamics.DataEntities.PaymentScheduleSingle(this.Context, GetPath("PaymentSchedule"));
                }
                return this._PaymentSchedule;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PaymentScheduleSingle _PaymentSchedule;
    }
        /// <summary>
        /// There are no comments for PaymentScheduleLine in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// PaymentScheduleName
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PaymentScheduleName", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("PaymentScheduleLines")]
    public partial class PaymentScheduleLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PaymentScheduleLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="paymentScheduleName">Initial value of PaymentScheduleName.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="periodsAfterDueDate">Initial value of PeriodsAfterDueDate.</param>
        /// <param name="percentOrAmountValue">Initial value of PercentOrAmountValue.</param>
        /// <param name="paymentSchedule">Initial value of PaymentSchedule.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PaymentScheduleLine CreatePaymentScheduleLine(string dataAreaId, 
                    string paymentScheduleName, 
                    decimal lineNumber, 
                    int periodsAfterDueDate, 
                    decimal percentOrAmountValue, 
                    global::Microsoft.Dynamics.DataEntities.PaymentSchedule paymentSchedule)
        {
            PaymentScheduleLine paymentScheduleLine = new PaymentScheduleLine();
            paymentScheduleLine.dataAreaId = dataAreaId;
            paymentScheduleLine.PaymentScheduleName = paymentScheduleName;
            paymentScheduleLine.LineNumber = lineNumber;
            paymentScheduleLine.PeriodsAfterDueDate = periodsAfterDueDate;
            paymentScheduleLine.PercentOrAmountValue = percentOrAmountValue;
            if ((paymentSchedule == null))
            {
                throw new global::System.ArgumentNullException("paymentSchedule");
            }
            paymentScheduleLine.PaymentSchedule = paymentSchedule;
            return paymentScheduleLine;
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
        /// There are no comments for Property PaymentScheduleName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PaymentScheduleName
        {
            get
            {
                return this._PaymentScheduleName;
            }
            set
            {
                this.OnPaymentScheduleNameChanging(value);
                this._PaymentScheduleName = value;
                this.OnPaymentScheduleNameChanged();
                this.OnPropertyChanged("PaymentScheduleName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentScheduleName;
        partial void OnPaymentScheduleNameChanging(string value);
        partial void OnPaymentScheduleNameChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property PeriodsAfterDueDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int PeriodsAfterDueDate
        {
            get
            {
                return this._PeriodsAfterDueDate;
            }
            set
            {
                this.OnPeriodsAfterDueDateChanging(value);
                this._PeriodsAfterDueDate = value;
                this.OnPeriodsAfterDueDateChanged();
                this.OnPropertyChanged("PeriodsAfterDueDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PeriodsAfterDueDate;
        partial void OnPeriodsAfterDueDateChanging(int value);
        partial void OnPeriodsAfterDueDateChanged();
        /// <summary>
        /// There are no comments for Property PercentOrAmountValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PercentOrAmountValue
        {
            get
            {
                return this._PercentOrAmountValue;
            }
            set
            {
                this.OnPercentOrAmountValueChanging(value);
                this._PercentOrAmountValue = value;
                this.OnPercentOrAmountValueChanged();
                this.OnPropertyChanged("PercentOrAmountValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PercentOrAmountValue;
        partial void OnPercentOrAmountValueChanging(decimal value);
        partial void OnPercentOrAmountValueChanged();
        /// <summary>
        /// There are no comments for Property PercentOrAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PercentAmount> PercentOrAmount
        {
            get
            {
                return this._PercentOrAmount;
            }
            set
            {
                this.OnPercentOrAmountChanging(value);
                this._PercentOrAmount = value;
                this.OnPercentOrAmountChanged();
                this.OnPropertyChanged("PercentOrAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PercentAmount> _PercentOrAmount;
        partial void OnPercentOrAmountChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PercentAmount> value);
        partial void OnPercentOrAmountChanged();
        /// <summary>
        /// There are no comments for Property IsShippingLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsShippingLine
        {
            get
            {
                return this._IsShippingLine;
            }
            set
            {
                this.OnIsShippingLineChanging(value);
                this._IsShippingLine = value;
                this.OnIsShippingLineChanged();
                this.OnPropertyChanged("IsShippingLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsShippingLine;
        partial void OnIsShippingLineChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsShippingLineChanged();
        /// <summary>
        /// There are no comments for Property PaymentSchedule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PaymentSchedule PaymentSchedule
        {
            get
            {
                return this._PaymentSchedule;
            }
            set
            {
                this.OnPaymentScheduleChanging(value);
                this._PaymentSchedule = value;
                this.OnPaymentScheduleChanged();
                this.OnPropertyChanged("PaymentSchedule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PaymentSchedule _PaymentSchedule;
        partial void OnPaymentScheduleChanging(global::Microsoft.Dynamics.DataEntities.PaymentSchedule value);
        partial void OnPaymentScheduleChanged();
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
