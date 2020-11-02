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
    /// There are no comments for WithholdingTaxCodeLimitSingle in the schema.
    /// </summary>
    public partial class WithholdingTaxCodeLimitSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WithholdingTaxCodeLimit>
    {
        /// <summary>
        /// Initialize a new WithholdingTaxCodeLimitSingle object.
        /// </summary>
        public WithholdingTaxCodeLimitSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WithholdingTaxCodeLimitSingle object.
        /// </summary>
        public WithholdingTaxCodeLimitSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WithholdingTaxCodeLimitSingle object.
        /// </summary>
        public WithholdingTaxCodeLimitSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WithholdingTaxCodeLimit> query)
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
    /// There are no comments for WithholdingTaxCodeLimit in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// WithholdingTaxCodeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "WithholdingTaxCodeId")]
    [global::Microsoft.OData.Client.EntitySet("WithholdingTaxCodeLimits")]
    public partial class WithholdingTaxCodeLimit : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WithholdingTaxCodeLimit object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="withholdingTaxCodeId">Initial value of WithholdingTaxCodeId.</param>
        /// <param name="fromDate">Initial value of FromDate.</param>
        /// <param name="minimumWithholdingTax">Initial value of MinimumWithholdingTax.</param>
        /// <param name="toDate">Initial value of ToDate.</param>
        /// <param name="maximumWithholdingTax">Initial value of MaximumWithholdingTax.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WithholdingTaxCodeLimit CreateWithholdingTaxCodeLimit(string dataAreaId, 
                    string withholdingTaxCodeId, 
                    global::System.DateTimeOffset fromDate, 
                    decimal minimumWithholdingTax, 
                    global::System.DateTimeOffset toDate, 
                    decimal maximumWithholdingTax)
        {
            WithholdingTaxCodeLimit withholdingTaxCodeLimit = new WithholdingTaxCodeLimit();
            withholdingTaxCodeLimit.dataAreaId = dataAreaId;
            withholdingTaxCodeLimit.WithholdingTaxCodeId = withholdingTaxCodeId;
            withholdingTaxCodeLimit.FromDate = fromDate;
            withholdingTaxCodeLimit.MinimumWithholdingTax = minimumWithholdingTax;
            withholdingTaxCodeLimit.ToDate = toDate;
            withholdingTaxCodeLimit.MaximumWithholdingTax = maximumWithholdingTax;
            return withholdingTaxCodeLimit;
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
        /// There are no comments for Property WithholdingTaxCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WithholdingTaxCodeId
        {
            get
            {
                return this._WithholdingTaxCodeId;
            }
            set
            {
                this.OnWithholdingTaxCodeIdChanging(value);
                this._WithholdingTaxCodeId = value;
                this.OnWithholdingTaxCodeIdChanged();
                this.OnPropertyChanged("WithholdingTaxCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WithholdingTaxCodeId;
        partial void OnWithholdingTaxCodeIdChanging(string value);
        partial void OnWithholdingTaxCodeIdChanged();
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
        /// There are no comments for Property MinimumWithholdingTax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal MinimumWithholdingTax
        {
            get
            {
                return this._MinimumWithholdingTax;
            }
            set
            {
                this.OnMinimumWithholdingTaxChanging(value);
                this._MinimumWithholdingTax = value;
                this.OnMinimumWithholdingTaxChanged();
                this.OnPropertyChanged("MinimumWithholdingTax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MinimumWithholdingTax;
        partial void OnMinimumWithholdingTaxChanging(decimal value);
        partial void OnMinimumWithholdingTaxChanged();
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
        /// There are no comments for Property MaximumWithholdingTax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal MaximumWithholdingTax
        {
            get
            {
                return this._MaximumWithholdingTax;
            }
            set
            {
                this.OnMaximumWithholdingTaxChanging(value);
                this._MaximumWithholdingTax = value;
                this.OnMaximumWithholdingTaxChanged();
                this.OnPropertyChanged("MaximumWithholdingTax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MaximumWithholdingTax;
        partial void OnMaximumWithholdingTaxChanging(decimal value);
        partial void OnMaximumWithholdingTaxChanged();
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