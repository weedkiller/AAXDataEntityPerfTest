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
    /// There are no comments for CashControlConfigurationSingle in the schema.
    /// </summary>
    public partial class CashControlConfigurationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CashControlConfiguration>
    {
        /// <summary>
        /// Initialize a new CashControlConfigurationSingle object.
        /// </summary>
        public CashControlConfigurationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CashControlConfigurationSingle object.
        /// </summary>
        public CashControlConfigurationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CashControlConfigurationSingle object.
        /// </summary>
        public CashControlConfigurationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CashControlConfiguration> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for APAccountDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle APAccountDimension
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._APAccountDimension == null))
                {
                    this._APAccountDimension = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("APAccountDimension"));
                }
                return this._APAccountDimension;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _APAccountDimension;
        /// <summary>
        /// There are no comments for CashAccountDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle CashAccountDimension
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CashAccountDimension == null))
                {
                    this._CashAccountDimension = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("CashAccountDimension"));
                }
                return this._CashAccountDimension;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _CashAccountDimension;
    }
    /// <summary>
    /// There are no comments for CashControlConfiguration in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.EntityType()]
    [global::Microsoft.OData.Client.EntitySet("CashControlConfigurations")]
    public partial class CashControlConfiguration : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CashControlConfiguration object.
        /// </summary>
        /// <param name="thresholdAmount">Initial value of ThresholdAmount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CashControlConfiguration CreateCashControlConfiguration(decimal thresholdAmount)
        {
            CashControlConfiguration cashControlConfiguration = new CashControlConfiguration();
            cashControlConfiguration.ThresholdAmount = thresholdAmount;
            return cashControlConfiguration;
        }
        /// <summary>
        /// There are no comments for Property CashAccountLedgerDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CashAccountLedgerDimensionDisplayValue
        {
            get
            {
                return this._CashAccountLedgerDimensionDisplayValue;
            }
            set
            {
                this.OnCashAccountLedgerDimensionDisplayValueChanging(value);
                this._CashAccountLedgerDimensionDisplayValue = value;
                this.OnCashAccountLedgerDimensionDisplayValueChanged();
                this.OnPropertyChanged("CashAccountLedgerDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CashAccountLedgerDimensionDisplayValue;
        partial void OnCashAccountLedgerDimensionDisplayValueChanging(string value);
        partial void OnCashAccountLedgerDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property ParticipateInCashControl in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ParticipateInCashControl
        {
            get
            {
                return this._ParticipateInCashControl;
            }
            set
            {
                this.OnParticipateInCashControlChanging(value);
                this._ParticipateInCashControl = value;
                this.OnParticipateInCashControlChanged();
                this.OnPropertyChanged("ParticipateInCashControl");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ParticipateInCashControl;
        partial void OnParticipateInCashControlChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnParticipateInCashControlChanged();
        /// <summary>
        /// There are no comments for Property AccountsPayableAccountLedgerDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccountsPayableAccountLedgerDimensionDisplayValue
        {
            get
            {
                return this._AccountsPayableAccountLedgerDimensionDisplayValue;
            }
            set
            {
                this.OnAccountsPayableAccountLedgerDimensionDisplayValueChanging(value);
                this._AccountsPayableAccountLedgerDimensionDisplayValue = value;
                this.OnAccountsPayableAccountLedgerDimensionDisplayValueChanged();
                this.OnPropertyChanged("AccountsPayableAccountLedgerDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountsPayableAccountLedgerDimensionDisplayValue;
        partial void OnAccountsPayableAccountLedgerDimensionDisplayValueChanging(string value);
        partial void OnAccountsPayableAccountLedgerDimensionDisplayValueChanged();
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
        /// There are no comments for Property ThresholdAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ThresholdAmount
        {
            get
            {
                return this._ThresholdAmount;
            }
            set
            {
                this.OnThresholdAmountChanging(value);
                this._ThresholdAmount = value;
                this.OnThresholdAmountChanged();
                this.OnPropertyChanged("ThresholdAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ThresholdAmount;
        partial void OnThresholdAmountChanging(decimal value);
        partial void OnThresholdAmountChanged();
        /// <summary>
        /// There are no comments for Property APAccountDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination APAccountDimension
        {
            get
            {
                return this._APAccountDimension;
            }
            set
            {
                this.OnAPAccountDimensionChanging(value);
                this._APAccountDimension = value;
                this.OnAPAccountDimensionChanged();
                this.OnPropertyChanged("APAccountDimension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _APAccountDimension;
        partial void OnAPAccountDimensionChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnAPAccountDimensionChanged();
        /// <summary>
        /// There are no comments for Property CashAccountDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination CashAccountDimension
        {
            get
            {
                return this._CashAccountDimension;
            }
            set
            {
                this.OnCashAccountDimensionChanging(value);
                this._CashAccountDimension = value;
                this.OnCashAccountDimensionChanged();
                this.OnPropertyChanged("CashAccountDimension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _CashAccountDimension;
        partial void OnCashAccountDimensionChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnCashAccountDimensionChanged();
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
