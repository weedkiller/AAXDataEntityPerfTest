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
        /// There are no comments for RTax25TaxTableAssessedSingle in the schema.
        /// </summary>
    public partial class RTax25TaxTableAssessedSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RTax25TaxTableAssessed>
    {
        /// <summary>
        /// Initialize a new RTax25TaxTableAssessedSingle object.
        /// </summary>
        public RTax25TaxTableAssessedSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RTax25TaxTableAssessedSingle object.
        /// </summary>
        public RTax25TaxTableAssessedSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RTax25TaxTableAssessedSingle object.
        /// </summary>
        public RTax25TaxTableAssessedSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RTax25TaxTableAssessed> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle DimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionCombination == null))
                {
                    this._DimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("DimensionCombination"));
                }
                return this._DimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _DimensionCombination;
    }
        /// <summary>
        /// There are no comments for RTax25TaxTableAssessed in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// Module
    /// Code
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Module", "Code")]
    [global::Microsoft.OData.Client.EntitySet("RTax25TaxTables")]
    public partial class RTax25TaxTableAssessed : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RTax25TaxTableAssessed object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="code">Initial value of Code.</param>
        /// <param name="allowanceByReductionOfRateValue">Initial value of AllowanceByReductionOfRateValue.</param>
        /// <param name="allowanceDecreaseBase387Value">Initial value of AllowanceDecreaseBase387Value.</param>
        /// <param name="allowanceByReductionOfTaxValue">Initial value of AllowanceByReductionOfTaxValue.</param>
        /// <param name="allowanceDecreaseBase391Value">Initial value of AllowanceDecreaseBase391Value.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RTax25TaxTableAssessed CreateRTax25TaxTableAssessed(string dataAreaId, 
                    string code, 
                    decimal allowanceByReductionOfRateValue, 
                    decimal allowanceDecreaseBase387Value, 
                    decimal allowanceByReductionOfTaxValue, 
                    decimal allowanceDecreaseBase391Value)
        {
            RTax25TaxTableAssessed rTax25TaxTableAssessed = new RTax25TaxTableAssessed();
            rTax25TaxTableAssessed.dataAreaId = dataAreaId;
            rTax25TaxTableAssessed.Code = code;
            rTax25TaxTableAssessed.AllowanceByReductionOfRateValue = allowanceByReductionOfRateValue;
            rTax25TaxTableAssessed.AllowanceDecreaseBase387Value = allowanceDecreaseBase387Value;
            rTax25TaxTableAssessed.AllowanceByReductionOfTaxValue = allowanceByReductionOfTaxValue;
            rTax25TaxTableAssessed.AllowanceDecreaseBase391Value = allowanceDecreaseBase391Value;
            return rTax25TaxTableAssessed;
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
        /// There are no comments for Property Module in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RTax25TaxModule> Module
        {
            get
            {
                return this._Module;
            }
            set
            {
                this.OnModuleChanging(value);
                this._Module = value;
                this.OnModuleChanged();
                this.OnPropertyChanged("Module");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RTax25TaxModule> _Module;
        partial void OnModuleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RTax25TaxModule> value);
        partial void OnModuleChanged();
        /// <summary>
        /// There are no comments for Property Code in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Code
        {
            get
            {
                return this._Code;
            }
            set
            {
                this.OnCodeChanging(value);
                this._Code = value;
                this.OnCodeChanged();
                this.OnPropertyChanged("Code");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Code;
        partial void OnCodeChanging(string value);
        partial void OnCodeChanged();
        /// <summary>
        /// There are no comments for Property AllowanceByReductionOfRateValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AllowanceByReductionOfRateValue
        {
            get
            {
                return this._AllowanceByReductionOfRateValue;
            }
            set
            {
                this.OnAllowanceByReductionOfRateValueChanging(value);
                this._AllowanceByReductionOfRateValue = value;
                this.OnAllowanceByReductionOfRateValueChanged();
                this.OnPropertyChanged("AllowanceByReductionOfRateValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AllowanceByReductionOfRateValue;
        partial void OnAllowanceByReductionOfRateValueChanging(decimal value);
        partial void OnAllowanceByReductionOfRateValueChanged();
        /// <summary>
        /// There are no comments for Property MainAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MainAccountDisplayValue
        {
            get
            {
                return this._MainAccountDisplayValue;
            }
            set
            {
                this.OnMainAccountDisplayValueChanging(value);
                this._MainAccountDisplayValue = value;
                this.OnMainAccountDisplayValueChanged();
                this.OnPropertyChanged("MainAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountDisplayValue;
        partial void OnMainAccountDisplayValueChanging(string value);
        partial void OnMainAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property AllowanceDecreaseBase387Value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AllowanceDecreaseBase387Value
        {
            get
            {
                return this._AllowanceDecreaseBase387Value;
            }
            set
            {
                this.OnAllowanceDecreaseBase387ValueChanging(value);
                this._AllowanceDecreaseBase387Value = value;
                this.OnAllowanceDecreaseBase387ValueChanged();
                this.OnPropertyChanged("AllowanceDecreaseBase387Value");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AllowanceDecreaseBase387Value;
        partial void OnAllowanceDecreaseBase387ValueChanging(decimal value);
        partial void OnAllowanceDecreaseBase387ValueChanged();
        /// <summary>
        /// There are no comments for Property AllowanceByReductionOfTaxValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AllowanceByReductionOfTaxValue
        {
            get
            {
                return this._AllowanceByReductionOfTaxValue;
            }
            set
            {
                this.OnAllowanceByReductionOfTaxValueChanging(value);
                this._AllowanceByReductionOfTaxValue = value;
                this.OnAllowanceByReductionOfTaxValueChanged();
                this.OnPropertyChanged("AllowanceByReductionOfTaxValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AllowanceByReductionOfTaxValue;
        partial void OnAllowanceByReductionOfTaxValueChanging(decimal value);
        partial void OnAllowanceByReductionOfTaxValueChanged();
        /// <summary>
        /// There are no comments for Property AllowanceByReductionOfTax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AllowanceByReductionOfTax
        {
            get
            {
                return this._AllowanceByReductionOfTax;
            }
            set
            {
                this.OnAllowanceByReductionOfTaxChanging(value);
                this._AllowanceByReductionOfTax = value;
                this.OnAllowanceByReductionOfTaxChanged();
                this.OnPropertyChanged("AllowanceByReductionOfTax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AllowanceByReductionOfTax;
        partial void OnAllowanceByReductionOfTaxChanging(string value);
        partial void OnAllowanceByReductionOfTaxChanged();
        /// <summary>
        /// There are no comments for Property BudgetRevenueCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BudgetRevenueCode
        {
            get
            {
                return this._BudgetRevenueCode;
            }
            set
            {
                this.OnBudgetRevenueCodeChanging(value);
                this._BudgetRevenueCode = value;
                this.OnBudgetRevenueCodeChanged();
                this.OnPropertyChanged("BudgetRevenueCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetRevenueCode;
        partial void OnBudgetRevenueCodeChanging(string value);
        partial void OnBudgetRevenueCodeChanged();
        /// <summary>
        /// There are no comments for Property AllowanceDecreaseBase387 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AllowanceDecreaseBase387
        {
            get
            {
                return this._AllowanceDecreaseBase387;
            }
            set
            {
                this.OnAllowanceDecreaseBase387Changing(value);
                this._AllowanceDecreaseBase387 = value;
                this.OnAllowanceDecreaseBase387Changed();
                this.OnPropertyChanged("AllowanceDecreaseBase387");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AllowanceDecreaseBase387;
        partial void OnAllowanceDecreaseBase387Changing(string value);
        partial void OnAllowanceDecreaseBase387Changed();
        /// <summary>
        /// There are no comments for Property TypeOfTax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxType_W> TypeOfTax
        {
            get
            {
                return this._TypeOfTax;
            }
            set
            {
                this.OnTypeOfTaxChanging(value);
                this._TypeOfTax = value;
                this.OnTypeOfTaxChanged();
                this.OnPropertyChanged("TypeOfTax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxType_W> _TypeOfTax;
        partial void OnTypeOfTaxChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxType_W> value);
        partial void OnTypeOfTaxChanged();
        /// <summary>
        /// There are no comments for Property AllowanceDecreaseBase391Value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AllowanceDecreaseBase391Value
        {
            get
            {
                return this._AllowanceDecreaseBase391Value;
            }
            set
            {
                this.OnAllowanceDecreaseBase391ValueChanging(value);
                this._AllowanceDecreaseBase391Value = value;
                this.OnAllowanceDecreaseBase391ValueChanged();
                this.OnPropertyChanged("AllowanceDecreaseBase391Value");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AllowanceDecreaseBase391Value;
        partial void OnAllowanceDecreaseBase391ValueChanging(decimal value);
        partial void OnAllowanceDecreaseBase391ValueChanged();
        /// <summary>
        /// There are no comments for Property AllowanceByReductionOfRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AllowanceByReductionOfRate
        {
            get
            {
                return this._AllowanceByReductionOfRate;
            }
            set
            {
                this.OnAllowanceByReductionOfRateChanging(value);
                this._AllowanceByReductionOfRate = value;
                this.OnAllowanceByReductionOfRateChanged();
                this.OnPropertyChanged("AllowanceByReductionOfRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AllowanceByReductionOfRate;
        partial void OnAllowanceByReductionOfRateChanging(string value);
        partial void OnAllowanceByReductionOfRateChanged();
        /// <summary>
        /// There are no comments for Property AllowanceDecreaseBase391 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AllowanceDecreaseBase391
        {
            get
            {
                return this._AllowanceDecreaseBase391;
            }
            set
            {
                this.OnAllowanceDecreaseBase391Changing(value);
                this._AllowanceDecreaseBase391 = value;
                this.OnAllowanceDecreaseBase391Changed();
                this.OnPropertyChanged("AllowanceDecreaseBase391");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AllowanceDecreaseBase391;
        partial void OnAllowanceDecreaseBase391Changing(string value);
        partial void OnAllowanceDecreaseBase391Changed();
        /// <summary>
        /// There are no comments for Property DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination DimensionCombination
        {
            get
            {
                return this._DimensionCombination;
            }
            set
            {
                this.OnDimensionCombinationChanging(value);
                this._DimensionCombination = value;
                this.OnDimensionCombinationChanged();
                this.OnPropertyChanged("DimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _DimensionCombination;
        partial void OnDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnDimensionCombinationChanged();
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
