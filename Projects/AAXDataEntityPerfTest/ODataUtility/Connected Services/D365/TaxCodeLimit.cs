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
        /// There are no comments for TaxCodeLimitSingle in the schema.
        /// </summary>
    public partial class TaxCodeLimitSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TaxCodeLimit>
    {
        /// <summary>
        /// Initialize a new TaxCodeLimitSingle object.
        /// </summary>
        public TaxCodeLimitSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TaxCodeLimitSingle object.
        /// </summary>
        public TaxCodeLimitSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TaxCodeLimitSingle object.
        /// </summary>
        public TaxCodeLimitSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TaxCodeLimit> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxCodeSingle TaxCode
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TaxCode == null))
                {
                    this._TaxCode = new global::Microsoft.Dynamics.DataEntities.TaxCodeSingle(this.Context, GetPath("TaxCode"));
                }
                return this._TaxCode;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxCodeSingle _TaxCode;
    }
        /// <summary>
        /// There are no comments for TaxCodeLimit in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TaxCodeId
    /// FromDate
    /// ToDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TaxCodeId", "FromDate", "ToDate")]
    [global::Microsoft.OData.Client.EntitySet("TaxCodeLimits")]
    public partial class TaxCodeLimit : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TaxCodeLimit object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="taxCodeId">Initial value of TaxCodeId.</param>
        /// <param name="fromDate">Initial value of FromDate.</param>
        /// <param name="toDate">Initial value of ToDate.</param>
        /// <param name="maximumSalesTax">Initial value of MaximumSalesTax.</param>
        /// <param name="minimumSalesTax">Initial value of MinimumSalesTax.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TaxCodeLimit CreateTaxCodeLimit(string dataAreaId, 
                    string taxCodeId, 
                    global::System.DateTimeOffset fromDate, 
                    global::System.DateTimeOffset toDate, 
                    decimal maximumSalesTax, 
                    decimal minimumSalesTax)
        {
            TaxCodeLimit taxCodeLimit = new TaxCodeLimit();
            taxCodeLimit.dataAreaId = dataAreaId;
            taxCodeLimit.TaxCodeId = taxCodeId;
            taxCodeLimit.FromDate = fromDate;
            taxCodeLimit.ToDate = toDate;
            taxCodeLimit.MaximumSalesTax = maximumSalesTax;
            taxCodeLimit.MinimumSalesTax = minimumSalesTax;
            return taxCodeLimit;
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
        /// There are no comments for Property TaxCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxCodeId
        {
            get
            {
                return this._TaxCodeId;
            }
            set
            {
                this.OnTaxCodeIdChanging(value);
                this._TaxCodeId = value;
                this.OnTaxCodeIdChanged();
                this.OnPropertyChanged("TaxCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxCodeId;
        partial void OnTaxCodeIdChanging(string value);
        partial void OnTaxCodeIdChanged();
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
        /// There are no comments for Property MaximumSalesTax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal MaximumSalesTax
        {
            get
            {
                return this._MaximumSalesTax;
            }
            set
            {
                this.OnMaximumSalesTaxChanging(value);
                this._MaximumSalesTax = value;
                this.OnMaximumSalesTaxChanged();
                this.OnPropertyChanged("MaximumSalesTax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MaximumSalesTax;
        partial void OnMaximumSalesTaxChanging(decimal value);
        partial void OnMaximumSalesTaxChanged();
        /// <summary>
        /// There are no comments for Property MinimumSalesTax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal MinimumSalesTax
        {
            get
            {
                return this._MinimumSalesTax;
            }
            set
            {
                this.OnMinimumSalesTaxChanging(value);
                this._MinimumSalesTax = value;
                this.OnMinimumSalesTaxChanged();
                this.OnPropertyChanged("MinimumSalesTax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MinimumSalesTax;
        partial void OnMinimumSalesTaxChanging(decimal value);
        partial void OnMinimumSalesTaxChanged();
        /// <summary>
        /// There are no comments for Property TaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxCode TaxCode
        {
            get
            {
                return this._TaxCode;
            }
            set
            {
                this.OnTaxCodeChanging(value);
                this._TaxCode = value;
                this.OnTaxCodeChanged();
                this.OnPropertyChanged("TaxCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxCode _TaxCode;
        partial void OnTaxCodeChanging(global::Microsoft.Dynamics.DataEntities.TaxCode value);
        partial void OnTaxCodeChanged();
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
