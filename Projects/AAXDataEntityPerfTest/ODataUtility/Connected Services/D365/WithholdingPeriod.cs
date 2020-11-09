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
        /// There are no comments for WithholdingPeriodSingle in the schema.
        /// </summary>
    public partial class WithholdingPeriodSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WithholdingPeriod>
    {
        /// <summary>
        /// Initialize a new WithholdingPeriodSingle object.
        /// </summary>
        public WithholdingPeriodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WithholdingPeriodSingle object.
        /// </summary>
        public WithholdingPeriodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WithholdingPeriodSingle object.
        /// </summary>
        public WithholdingPeriodSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WithholdingPeriod> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for WithholdingTaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCode> WithholdingTaxCode
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WithholdingTaxCode == null))
                {
                    this._WithholdingTaxCode = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCode>(GetPath("WithholdingTaxCode"));
                }
                return this._WithholdingTaxCode;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCode> _WithholdingTaxCode;
    }
        /// <summary>
        /// There are no comments for WithholdingPeriod in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TaxWithholdPeriod
    /// TaxWithholdFromDate
    /// TaxWithholdToDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TaxWithholdPeriod", "TaxWithholdFromDate", "TaxWithholdToDate")]
    [global::Microsoft.OData.Client.EntitySet("WithholdingPeriods")]
    public partial class WithholdingPeriod : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WithholdingPeriod object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="taxWithholdPeriod">Initial value of TaxWithholdPeriod.</param>
        /// <param name="taxWithholdFromDate">Initial value of TaxWithholdFromDate.</param>
        /// <param name="taxWithholdToDate">Initial value of TaxWithholdToDate.</param>
        /// <param name="qtyUnit">Initial value of QtyUnit.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WithholdingPeriod CreateWithholdingPeriod(string dataAreaId, string taxWithholdPeriod, global::System.DateTimeOffset taxWithholdFromDate, global::System.DateTimeOffset taxWithholdToDate, int qtyUnit)
        {
            WithholdingPeriod withholdingPeriod = new WithholdingPeriod();
            withholdingPeriod.dataAreaId = dataAreaId;
            withholdingPeriod.TaxWithholdPeriod = taxWithholdPeriod;
            withholdingPeriod.TaxWithholdFromDate = taxWithholdFromDate;
            withholdingPeriod.TaxWithholdToDate = taxWithholdToDate;
            withholdingPeriod.QtyUnit = qtyUnit;
            return withholdingPeriod;
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
        /// There are no comments for Property TaxWithholdPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxWithholdPeriod
        {
            get
            {
                return this._TaxWithholdPeriod;
            }
            set
            {
                this.OnTaxWithholdPeriodChanging(value);
                this._TaxWithholdPeriod = value;
                this.OnTaxWithholdPeriodChanged();
                this.OnPropertyChanged("TaxWithholdPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxWithholdPeriod;
        partial void OnTaxWithholdPeriodChanging(string value);
        partial void OnTaxWithholdPeriodChanged();
        /// <summary>
        /// There are no comments for Property TaxWithholdFromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset TaxWithholdFromDate
        {
            get
            {
                return this._TaxWithholdFromDate;
            }
            set
            {
                this.OnTaxWithholdFromDateChanging(value);
                this._TaxWithholdFromDate = value;
                this.OnTaxWithholdFromDateChanged();
                this.OnPropertyChanged("TaxWithholdFromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _TaxWithholdFromDate;
        partial void OnTaxWithholdFromDateChanging(global::System.DateTimeOffset value);
        partial void OnTaxWithholdFromDateChanged();
        /// <summary>
        /// There are no comments for Property TaxWithholdToDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset TaxWithholdToDate
        {
            get
            {
                return this._TaxWithholdToDate;
            }
            set
            {
                this.OnTaxWithholdToDateChanging(value);
                this._TaxWithholdToDate = value;
                this.OnTaxWithholdToDateChanged();
                this.OnPropertyChanged("TaxWithholdToDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _TaxWithholdToDate;
        partial void OnTaxWithholdToDateChanging(global::System.DateTimeOffset value);
        partial void OnTaxWithholdToDateChanged();
        /// <summary>
        /// There are no comments for Property TaxAuthority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxAuthority
        {
            get
            {
                return this._TaxAuthority;
            }
            set
            {
                this.OnTaxAuthorityChanging(value);
                this._TaxAuthority = value;
                this.OnTaxAuthorityChanged();
                this.OnPropertyChanged("TaxAuthority");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxAuthority;
        partial void OnTaxAuthorityChanging(string value);
        partial void OnTaxAuthorityChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property PaymentCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PaymentCode
        {
            get
            {
                return this._PaymentCode;
            }
            set
            {
                this.OnPaymentCodeChanging(value);
                this._PaymentCode = value;
                this.OnPaymentCodeChanged();
                this.OnPropertyChanged("PaymentCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentCode;
        partial void OnPaymentCodeChanging(string value);
        partial void OnPaymentCodeChanged();
        /// <summary>
        /// There are no comments for Property PeriodUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PeriodUnit> PeriodUnit
        {
            get
            {
                return this._PeriodUnit;
            }
            set
            {
                this.OnPeriodUnitChanging(value);
                this._PeriodUnit = value;
                this.OnPeriodUnitChanged();
                this.OnPropertyChanged("PeriodUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PeriodUnit> _PeriodUnit;
        partial void OnPeriodUnitChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PeriodUnit> value);
        partial void OnPeriodUnitChanged();
        /// <summary>
        /// There are no comments for Property QtyUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int QtyUnit
        {
            get
            {
                return this._QtyUnit;
            }
            set
            {
                this.OnQtyUnitChanging(value);
                this._QtyUnit = value;
                this.OnQtyUnitChanged();
                this.OnPropertyChanged("QtyUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _QtyUnit;
        partial void OnQtyUnitChanging(int value);
        partial void OnQtyUnitChanged();
        /// <summary>
        /// There are no comments for Property WithholdingTaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCode> WithholdingTaxCode
        {
            get
            {
                return this._WithholdingTaxCode;
            }
            set
            {
                this.OnWithholdingTaxCodeChanging(value);
                this._WithholdingTaxCode = value;
                this.OnWithholdingTaxCodeChanged();
                this.OnPropertyChanged("WithholdingTaxCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCode> _WithholdingTaxCode = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCode>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWithholdingTaxCodeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WithholdingTaxCode> value);
        partial void OnWithholdingTaxCodeChanged();
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
