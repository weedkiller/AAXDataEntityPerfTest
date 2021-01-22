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
        /// There are no comments for SalesAgreementLinesFulfillmentSingle in the schema.
        /// </summary>
    public partial class SalesAgreementLinesFulfillmentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SalesAgreementLinesFulfillment>
    {
        /// <summary>
        /// Initialize a new SalesAgreementLinesFulfillmentSingle object.
        /// </summary>
        public SalesAgreementLinesFulfillmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SalesAgreementLinesFulfillmentSingle object.
        /// </summary>
        public SalesAgreementLinesFulfillmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SalesAgreementLinesFulfillmentSingle object.
        /// </summary>
        public SalesAgreementLinesFulfillmentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SalesAgreementLinesFulfillment> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for SalesAgreementLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.SalesAgreementLineSingle SalesAgreementLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SalesAgreementLine == null))
                {
                    this._SalesAgreementLine = new global::Microsoft.Dynamics.DataEntities.SalesAgreementLineSingle(this.Context, GetPath("SalesAgreementLine"));
                }
                return this._SalesAgreementLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SalesAgreementLineSingle _SalesAgreementLine;
    }
        /// <summary>
        /// There are no comments for SalesAgreementLinesFulfillment in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// SalesAgreementId
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "SalesAgreementId", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("SalesAgreementLineFulfillment")]
    public partial class SalesAgreementLinesFulfillment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SalesAgreementLinesFulfillment object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="salesAgreementId">Initial value of SalesAgreementId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="releasedCatchWeightQuantity">Initial value of ReleasedCatchWeightQuantity.</param>
        /// <param name="remainingAmount">Initial value of RemainingAmount.</param>
        /// <param name="invoicedAmount">Initial value of InvoicedAmount.</param>
        /// <param name="committedQuantity">Initial value of CommittedQuantity.</param>
        /// <param name="deliveredAmount">Initial value of DeliveredAmount.</param>
        /// <param name="remainingQuantity">Initial value of RemainingQuantity.</param>
        /// <param name="invoicedCatchWeightQuantity">Initial value of InvoicedCatchWeightQuantity.</param>
        /// <param name="deliveredQuantity">Initial value of DeliveredQuantity.</param>
        /// <param name="remainingCatchWeightQuantity">Initial value of RemainingCatchWeightQuantity.</param>
        /// <param name="releasedQuantity">Initial value of ReleasedQuantity.</param>
        /// <param name="releasedAmount">Initial value of ReleasedAmount.</param>
        /// <param name="deliveredCatchWeightQuantity">Initial value of DeliveredCatchWeightQuantity.</param>
        /// <param name="committedCatchWeightQuantity">Initial value of CommittedCatchWeightQuantity.</param>
        /// <param name="invoicedQuantity">Initial value of InvoicedQuantity.</param>
        /// <param name="committedAmount">Initial value of CommittedAmount.</param>
        /// <param name="salesAgreementLine">Initial value of SalesAgreementLine.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SalesAgreementLinesFulfillment CreateSalesAgreementLinesFulfillment(string dataAreaId, 
                    string salesAgreementId, 
                    decimal lineNumber, 
                    decimal releasedCatchWeightQuantity, 
                    decimal remainingAmount, 
                    decimal invoicedAmount, 
                    decimal committedQuantity, 
                    decimal deliveredAmount, 
                    decimal remainingQuantity, 
                    decimal invoicedCatchWeightQuantity, 
                    decimal deliveredQuantity, 
                    decimal remainingCatchWeightQuantity, 
                    decimal releasedQuantity, 
                    decimal releasedAmount, 
                    decimal deliveredCatchWeightQuantity, 
                    decimal committedCatchWeightQuantity, 
                    decimal invoicedQuantity, 
                    decimal committedAmount, 
                    global::Microsoft.Dynamics.DataEntities.SalesAgreementLine salesAgreementLine)
        {
            SalesAgreementLinesFulfillment salesAgreementLinesFulfillment = new SalesAgreementLinesFulfillment();
            salesAgreementLinesFulfillment.dataAreaId = dataAreaId;
            salesAgreementLinesFulfillment.SalesAgreementId = salesAgreementId;
            salesAgreementLinesFulfillment.LineNumber = lineNumber;
            salesAgreementLinesFulfillment.ReleasedCatchWeightQuantity = releasedCatchWeightQuantity;
            salesAgreementLinesFulfillment.RemainingAmount = remainingAmount;
            salesAgreementLinesFulfillment.InvoicedAmount = invoicedAmount;
            salesAgreementLinesFulfillment.CommittedQuantity = committedQuantity;
            salesAgreementLinesFulfillment.DeliveredAmount = deliveredAmount;
            salesAgreementLinesFulfillment.RemainingQuantity = remainingQuantity;
            salesAgreementLinesFulfillment.InvoicedCatchWeightQuantity = invoicedCatchWeightQuantity;
            salesAgreementLinesFulfillment.DeliveredQuantity = deliveredQuantity;
            salesAgreementLinesFulfillment.RemainingCatchWeightQuantity = remainingCatchWeightQuantity;
            salesAgreementLinesFulfillment.ReleasedQuantity = releasedQuantity;
            salesAgreementLinesFulfillment.ReleasedAmount = releasedAmount;
            salesAgreementLinesFulfillment.DeliveredCatchWeightQuantity = deliveredCatchWeightQuantity;
            salesAgreementLinesFulfillment.CommittedCatchWeightQuantity = committedCatchWeightQuantity;
            salesAgreementLinesFulfillment.InvoicedQuantity = invoicedQuantity;
            salesAgreementLinesFulfillment.CommittedAmount = committedAmount;
            if ((salesAgreementLine == null))
            {
                throw new global::System.ArgumentNullException("salesAgreementLine");
            }
            salesAgreementLinesFulfillment.SalesAgreementLine = salesAgreementLine;
            return salesAgreementLinesFulfillment;
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
        /// There are no comments for Property SalesAgreementId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesAgreementId
        {
            get
            {
                return this._SalesAgreementId;
            }
            set
            {
                this.OnSalesAgreementIdChanging(value);
                this._SalesAgreementId = value;
                this.OnSalesAgreementIdChanged();
                this.OnPropertyChanged("SalesAgreementId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesAgreementId;
        partial void OnSalesAgreementIdChanging(string value);
        partial void OnSalesAgreementIdChanged();
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
        /// There are no comments for Property ReleasedCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ReleasedCatchWeightQuantity
        {
            get
            {
                return this._ReleasedCatchWeightQuantity;
            }
            set
            {
                this.OnReleasedCatchWeightQuantityChanging(value);
                this._ReleasedCatchWeightQuantity = value;
                this.OnReleasedCatchWeightQuantityChanged();
                this.OnPropertyChanged("ReleasedCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReleasedCatchWeightQuantity;
        partial void OnReleasedCatchWeightQuantityChanging(decimal value);
        partial void OnReleasedCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property RemainingAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal RemainingAmount
        {
            get
            {
                return this._RemainingAmount;
            }
            set
            {
                this.OnRemainingAmountChanging(value);
                this._RemainingAmount = value;
                this.OnRemainingAmountChanged();
                this.OnPropertyChanged("RemainingAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RemainingAmount;
        partial void OnRemainingAmountChanging(decimal value);
        partial void OnRemainingAmountChanged();
        /// <summary>
        /// There are no comments for Property InvoicedAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal InvoicedAmount
        {
            get
            {
                return this._InvoicedAmount;
            }
            set
            {
                this.OnInvoicedAmountChanging(value);
                this._InvoicedAmount = value;
                this.OnInvoicedAmountChanged();
                this.OnPropertyChanged("InvoicedAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _InvoicedAmount;
        partial void OnInvoicedAmountChanging(decimal value);
        partial void OnInvoicedAmountChanged();
        /// <summary>
        /// There are no comments for Property CommittedQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CommittedQuantity
        {
            get
            {
                return this._CommittedQuantity;
            }
            set
            {
                this.OnCommittedQuantityChanging(value);
                this._CommittedQuantity = value;
                this.OnCommittedQuantityChanged();
                this.OnPropertyChanged("CommittedQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CommittedQuantity;
        partial void OnCommittedQuantityChanging(decimal value);
        partial void OnCommittedQuantityChanged();
        /// <summary>
        /// There are no comments for Property DeliveredAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DeliveredAmount
        {
            get
            {
                return this._DeliveredAmount;
            }
            set
            {
                this.OnDeliveredAmountChanging(value);
                this._DeliveredAmount = value;
                this.OnDeliveredAmountChanged();
                this.OnPropertyChanged("DeliveredAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DeliveredAmount;
        partial void OnDeliveredAmountChanging(decimal value);
        partial void OnDeliveredAmountChanged();
        /// <summary>
        /// There are no comments for Property RemainingQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal RemainingQuantity
        {
            get
            {
                return this._RemainingQuantity;
            }
            set
            {
                this.OnRemainingQuantityChanging(value);
                this._RemainingQuantity = value;
                this.OnRemainingQuantityChanged();
                this.OnPropertyChanged("RemainingQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RemainingQuantity;
        partial void OnRemainingQuantityChanging(decimal value);
        partial void OnRemainingQuantityChanged();
        /// <summary>
        /// There are no comments for Property InvoicedCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal InvoicedCatchWeightQuantity
        {
            get
            {
                return this._InvoicedCatchWeightQuantity;
            }
            set
            {
                this.OnInvoicedCatchWeightQuantityChanging(value);
                this._InvoicedCatchWeightQuantity = value;
                this.OnInvoicedCatchWeightQuantityChanged();
                this.OnPropertyChanged("InvoicedCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _InvoicedCatchWeightQuantity;
        partial void OnInvoicedCatchWeightQuantityChanging(decimal value);
        partial void OnInvoicedCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property DeliveredQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DeliveredQuantity
        {
            get
            {
                return this._DeliveredQuantity;
            }
            set
            {
                this.OnDeliveredQuantityChanging(value);
                this._DeliveredQuantity = value;
                this.OnDeliveredQuantityChanged();
                this.OnPropertyChanged("DeliveredQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DeliveredQuantity;
        partial void OnDeliveredQuantityChanging(decimal value);
        partial void OnDeliveredQuantityChanged();
        /// <summary>
        /// There are no comments for Property RemainingCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal RemainingCatchWeightQuantity
        {
            get
            {
                return this._RemainingCatchWeightQuantity;
            }
            set
            {
                this.OnRemainingCatchWeightQuantityChanging(value);
                this._RemainingCatchWeightQuantity = value;
                this.OnRemainingCatchWeightQuantityChanged();
                this.OnPropertyChanged("RemainingCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RemainingCatchWeightQuantity;
        partial void OnRemainingCatchWeightQuantityChanging(decimal value);
        partial void OnRemainingCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property ReleasedQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ReleasedQuantity
        {
            get
            {
                return this._ReleasedQuantity;
            }
            set
            {
                this.OnReleasedQuantityChanging(value);
                this._ReleasedQuantity = value;
                this.OnReleasedQuantityChanged();
                this.OnPropertyChanged("ReleasedQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReleasedQuantity;
        partial void OnReleasedQuantityChanging(decimal value);
        partial void OnReleasedQuantityChanged();
        /// <summary>
        /// There are no comments for Property ReleasedAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ReleasedAmount
        {
            get
            {
                return this._ReleasedAmount;
            }
            set
            {
                this.OnReleasedAmountChanging(value);
                this._ReleasedAmount = value;
                this.OnReleasedAmountChanged();
                this.OnPropertyChanged("ReleasedAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReleasedAmount;
        partial void OnReleasedAmountChanging(decimal value);
        partial void OnReleasedAmountChanged();
        /// <summary>
        /// There are no comments for Property DeliveredCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DeliveredCatchWeightQuantity
        {
            get
            {
                return this._DeliveredCatchWeightQuantity;
            }
            set
            {
                this.OnDeliveredCatchWeightQuantityChanging(value);
                this._DeliveredCatchWeightQuantity = value;
                this.OnDeliveredCatchWeightQuantityChanged();
                this.OnPropertyChanged("DeliveredCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DeliveredCatchWeightQuantity;
        partial void OnDeliveredCatchWeightQuantityChanging(decimal value);
        partial void OnDeliveredCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property UnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UnitSymbol
        {
            get
            {
                return this._UnitSymbol;
            }
            set
            {
                this.OnUnitSymbolChanging(value);
                this._UnitSymbol = value;
                this.OnUnitSymbolChanged();
                this.OnPropertyChanged("UnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitSymbol;
        partial void OnUnitSymbolChanging(string value);
        partial void OnUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property SalesAgreementLegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesAgreementLegalEntityId
        {
            get
            {
                return this._SalesAgreementLegalEntityId;
            }
            set
            {
                this.OnSalesAgreementLegalEntityIdChanging(value);
                this._SalesAgreementLegalEntityId = value;
                this.OnSalesAgreementLegalEntityIdChanged();
                this.OnPropertyChanged("SalesAgreementLegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesAgreementLegalEntityId;
        partial void OnSalesAgreementLegalEntityIdChanging(string value);
        partial void OnSalesAgreementLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property CommittedCatchWeightQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CommittedCatchWeightQuantity
        {
            get
            {
                return this._CommittedCatchWeightQuantity;
            }
            set
            {
                this.OnCommittedCatchWeightQuantityChanging(value);
                this._CommittedCatchWeightQuantity = value;
                this.OnCommittedCatchWeightQuantityChanged();
                this.OnPropertyChanged("CommittedCatchWeightQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CommittedCatchWeightQuantity;
        partial void OnCommittedCatchWeightQuantityChanging(decimal value);
        partial void OnCommittedCatchWeightQuantityChanged();
        /// <summary>
        /// There are no comments for Property InvoicedQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal InvoicedQuantity
        {
            get
            {
                return this._InvoicedQuantity;
            }
            set
            {
                this.OnInvoicedQuantityChanging(value);
                this._InvoicedQuantity = value;
                this.OnInvoicedQuantityChanged();
                this.OnPropertyChanged("InvoicedQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _InvoicedQuantity;
        partial void OnInvoicedQuantityChanging(decimal value);
        partial void OnInvoicedQuantityChanged();
        /// <summary>
        /// There are no comments for Property CommittedAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CommittedAmount
        {
            get
            {
                return this._CommittedAmount;
            }
            set
            {
                this.OnCommittedAmountChanging(value);
                this._CommittedAmount = value;
                this.OnCommittedAmountChanged();
                this.OnPropertyChanged("CommittedAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CommittedAmount;
        partial void OnCommittedAmountChanging(decimal value);
        partial void OnCommittedAmountChanged();
        /// <summary>
        /// There are no comments for Property SalesAgreementLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.SalesAgreementLine SalesAgreementLine
        {
            get
            {
                return this._SalesAgreementLine;
            }
            set
            {
                this.OnSalesAgreementLineChanging(value);
                this._SalesAgreementLine = value;
                this.OnSalesAgreementLineChanged();
                this.OnPropertyChanged("SalesAgreementLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SalesAgreementLine _SalesAgreementLine;
        partial void OnSalesAgreementLineChanging(global::Microsoft.Dynamics.DataEntities.SalesAgreementLine value);
        partial void OnSalesAgreementLineChanged();
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
