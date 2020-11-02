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
    /// There are no comments for WithholdingTaxCodeValueSingle in the schema.
    /// </summary>
    public partial class WithholdingTaxCodeValueSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WithholdingTaxCodeValue>
    {
        /// <summary>
        /// Initialize a new WithholdingTaxCodeValueSingle object.
        /// </summary>
        public WithholdingTaxCodeValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WithholdingTaxCodeValueSingle object.
        /// </summary>
        public WithholdingTaxCodeValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WithholdingTaxCodeValueSingle object.
        /// </summary>
        public WithholdingTaxCodeValueSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WithholdingTaxCodeValue> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for WithholdingTaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WithholdingTaxCodeSingle WithholdingTaxCode
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WithholdingTaxCode == null))
                {
                    this._WithholdingTaxCode = new global::Microsoft.Dynamics.DataEntities.WithholdingTaxCodeSingle(this.Context, GetPath("WithholdingTaxCode"));
                }
                return this._WithholdingTaxCode;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WithholdingTaxCodeSingle _WithholdingTaxCode;
    }
    /// <summary>
    /// There are no comments for WithholdingTaxCodeValue in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TaxWithholdCodeId
    /// FromDate
    /// ToDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TaxWithholdCodeId", "FromDate", "ToDate")]
    [global::Microsoft.OData.Client.EntitySet("WithholdingTaxCodeValues")]
    public partial class WithholdingTaxCodeValue : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WithholdingTaxCodeValue object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="taxWithholdCodeId">Initial value of TaxWithholdCodeId.</param>
        /// <param name="fromDate">Initial value of FromDate.</param>
        /// <param name="toDate">Initial value of ToDate.</param>
        /// <param name="value">Initial value of Value.</param>
        /// <param name="maximumLimit">Initial value of MaximumLimit.</param>
        /// <param name="minimumLimit">Initial value of MinimumLimit.</param>
        /// <param name="excludePercentage">Initial value of ExcludePercentage.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WithholdingTaxCodeValue CreateWithholdingTaxCodeValue(string dataAreaId, 
                    string taxWithholdCodeId, 
                    global::System.DateTimeOffset fromDate, 
                    global::System.DateTimeOffset toDate, 
                    decimal value, 
                    decimal maximumLimit, 
                    decimal minimumLimit, 
                    decimal excludePercentage)
        {
            WithholdingTaxCodeValue withholdingTaxCodeValue = new WithholdingTaxCodeValue();
            withholdingTaxCodeValue.dataAreaId = dataAreaId;
            withholdingTaxCodeValue.TaxWithholdCodeId = taxWithholdCodeId;
            withholdingTaxCodeValue.FromDate = fromDate;
            withholdingTaxCodeValue.ToDate = toDate;
            withholdingTaxCodeValue.Value = value;
            withholdingTaxCodeValue.MaximumLimit = maximumLimit;
            withholdingTaxCodeValue.MinimumLimit = minimumLimit;
            withholdingTaxCodeValue.ExcludePercentage = excludePercentage;
            return withholdingTaxCodeValue;
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
        /// There are no comments for Property TaxWithholdCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxWithholdCodeId
        {
            get
            {
                return this._TaxWithholdCodeId;
            }
            set
            {
                this.OnTaxWithholdCodeIdChanging(value);
                this._TaxWithholdCodeId = value;
                this.OnTaxWithholdCodeIdChanged();
                this.OnPropertyChanged("TaxWithholdCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxWithholdCodeId;
        partial void OnTaxWithholdCodeIdChanging(string value);
        partial void OnTaxWithholdCodeIdChanged();
        /// <summary>
        /// There are no comments for Property FromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset FromDate
        {
            get
            {
                return this._FromDate;
            }
            set
            {
                this.OnFromDateChanging(value);
                this._FromDate = value;
                this.OnFromDateChanged();
                this.OnPropertyChanged("FromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _FromDate;
        partial void OnFromDateChanging(global::System.DateTimeOffset value);
        partial void OnFromDateChanged();
        /// <summary>
        /// There are no comments for Property ToDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ToDate
        {
            get
            {
                return this._ToDate;
            }
            set
            {
                this.OnToDateChanging(value);
                this._ToDate = value;
                this.OnToDateChanged();
                this.OnPropertyChanged("ToDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ToDate;
        partial void OnToDateChanging(global::System.DateTimeOffset value);
        partial void OnToDateChanged();
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Value;
        partial void OnValueChanging(decimal value);
        partial void OnValueChanged();
        /// <summary>
        /// There are no comments for Property MaximumLimit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal MaximumLimit
        {
            get
            {
                return this._MaximumLimit;
            }
            set
            {
                this.OnMaximumLimitChanging(value);
                this._MaximumLimit = value;
                this.OnMaximumLimitChanged();
                this.OnPropertyChanged("MaximumLimit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MaximumLimit;
        partial void OnMaximumLimitChanging(decimal value);
        partial void OnMaximumLimitChanged();
        /// <summary>
        /// There are no comments for Property MinimumLimit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal MinimumLimit
        {
            get
            {
                return this._MinimumLimit;
            }
            set
            {
                this.OnMinimumLimitChanging(value);
                this._MinimumLimit = value;
                this.OnMinimumLimitChanged();
                this.OnPropertyChanged("MinimumLimit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MinimumLimit;
        partial void OnMinimumLimitChanging(decimal value);
        partial void OnMinimumLimitChanged();
        /// <summary>
        /// There are no comments for Property ExcludePercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ExcludePercentage
        {
            get
            {
                return this._ExcludePercentage;
            }
            set
            {
                this.OnExcludePercentageChanging(value);
                this._ExcludePercentage = value;
                this.OnExcludePercentageChanged();
                this.OnPropertyChanged("ExcludePercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ExcludePercentage;
        partial void OnExcludePercentageChanging(decimal value);
        partial void OnExcludePercentageChanged();
        /// <summary>
        /// There are no comments for Property WithholdingTaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WithholdingTaxCode WithholdingTaxCode
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
        private global::Microsoft.Dynamics.DataEntities.WithholdingTaxCode _WithholdingTaxCode;
        partial void OnWithholdingTaxCodeChanging(global::Microsoft.Dynamics.DataEntities.WithholdingTaxCode value);
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
