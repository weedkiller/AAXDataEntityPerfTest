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
        /// There are no comments for AdjustmentParametersSingle in the schema.
        /// </summary>
    public partial class AdjustmentParametersSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AdjustmentParameters>
    {
        /// <summary>
        /// Initialize a new AdjustmentParametersSingle object.
        /// </summary>
        public AdjustmentParametersSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AdjustmentParametersSingle object.
        /// </summary>
        public AdjustmentParametersSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AdjustmentParametersSingle object.
        /// </summary>
        public AdjustmentParametersSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AdjustmentParameters> query)
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
        /// There are no comments for AdjustmentParameters in the schema.
        /// </summary>
    /// <KeyProperties>
    /// LedgerName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LedgerName")]
    [global::Microsoft.OData.Client.EntitySet("AdjustmentParameters")]
    public partial class AdjustmentParameters : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AdjustmentParameters object.
        /// </summary>
        /// <param name="ledgerName">Initial value of LedgerName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AdjustmentParameters CreateAdjustmentParameters(string ledgerName)
        {
            AdjustmentParameters adjustmentParameters = new AdjustmentParameters();
            adjustmentParameters.LedgerName = ledgerName;
            return adjustmentParameters;
        }
        /// <summary>
        /// There are no comments for Property LedgerName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LedgerName
        {
            get
            {
                return this._LedgerName;
            }
            set
            {
                this.OnLedgerNameChanging(value);
                this._LedgerName = value;
                this.OnLedgerNameChanged();
                this.OnPropertyChanged("LedgerName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LedgerName;
        partial void OnLedgerNameChanging(string value);
        partial void OnLedgerNameChanged();
        /// <summary>
        /// There are no comments for Property AdvanceHolderTaxDimensionExpenseCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AdvanceHolderTaxDimensionExpenseCode
        {
            get
            {
                return this._AdvanceHolderTaxDimensionExpenseCode;
            }
            set
            {
                this.OnAdvanceHolderTaxDimensionExpenseCodeChanging(value);
                this._AdvanceHolderTaxDimensionExpenseCode = value;
                this.OnAdvanceHolderTaxDimensionExpenseCodeChanged();
                this.OnPropertyChanged("AdvanceHolderTaxDimensionExpenseCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdvanceHolderTaxDimensionExpenseCode;
        partial void OnAdvanceHolderTaxDimensionExpenseCodeChanging(string value);
        partial void OnAdvanceHolderTaxDimensionExpenseCodeChanged();
        /// <summary>
        /// There are no comments for Property CustomerTaxDimensionExpenseCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CustomerTaxDimensionExpenseCode
        {
            get
            {
                return this._CustomerTaxDimensionExpenseCode;
            }
            set
            {
                this.OnCustomerTaxDimensionExpenseCodeChanging(value);
                this._CustomerTaxDimensionExpenseCode = value;
                this.OnCustomerTaxDimensionExpenseCodeChanged();
                this.OnPropertyChanged("CustomerTaxDimensionExpenseCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerTaxDimensionExpenseCode;
        partial void OnCustomerTaxDimensionExpenseCodeChanging(string value);
        partial void OnCustomerTaxDimensionExpenseCodeChanged();
        /// <summary>
        /// There are no comments for Property AdvanceHolderAdvanceAdjustmentOffsetAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AdvanceHolderAdvanceAdjustmentOffsetAccount
        {
            get
            {
                return this._AdvanceHolderAdvanceAdjustmentOffsetAccount;
            }
            set
            {
                this.OnAdvanceHolderAdvanceAdjustmentOffsetAccountChanging(value);
                this._AdvanceHolderAdvanceAdjustmentOffsetAccount = value;
                this.OnAdvanceHolderAdvanceAdjustmentOffsetAccountChanged();
                this.OnPropertyChanged("AdvanceHolderAdvanceAdjustmentOffsetAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdvanceHolderAdvanceAdjustmentOffsetAccount;
        partial void OnAdvanceHolderAdvanceAdjustmentOffsetAccountChanging(string value);
        partial void OnAdvanceHolderAdvanceAdjustmentOffsetAccountChanged();
        /// <summary>
        /// There are no comments for Property VendorTaxDimensionRevenueCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorTaxDimensionRevenueCode
        {
            get
            {
                return this._VendorTaxDimensionRevenueCode;
            }
            set
            {
                this.OnVendorTaxDimensionRevenueCodeChanging(value);
                this._VendorTaxDimensionRevenueCode = value;
                this.OnVendorTaxDimensionRevenueCodeChanged();
                this.OnPropertyChanged("VendorTaxDimensionRevenueCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorTaxDimensionRevenueCode;
        partial void OnVendorTaxDimensionRevenueCodeChanging(string value);
        partial void OnVendorTaxDimensionRevenueCodeChanged();
        /// <summary>
        /// There are no comments for Property CustomerTaxDimensionRevenueCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CustomerTaxDimensionRevenueCode
        {
            get
            {
                return this._CustomerTaxDimensionRevenueCode;
            }
            set
            {
                this.OnCustomerTaxDimensionRevenueCodeChanging(value);
                this._CustomerTaxDimensionRevenueCode = value;
                this.OnCustomerTaxDimensionRevenueCodeChanged();
                this.OnPropertyChanged("CustomerTaxDimensionRevenueCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerTaxDimensionRevenueCode;
        partial void OnCustomerTaxDimensionRevenueCodeChanging(string value);
        partial void OnCustomerTaxDimensionRevenueCodeChanged();
        /// <summary>
        /// There are no comments for Property CustomerRealizedLoss in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CustomerRealizedLoss
        {
            get
            {
                return this._CustomerRealizedLoss;
            }
            set
            {
                this.OnCustomerRealizedLossChanging(value);
                this._CustomerRealizedLoss = value;
                this.OnCustomerRealizedLossChanged();
                this.OnPropertyChanged("CustomerRealizedLoss");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerRealizedLoss;
        partial void OnCustomerRealizedLossChanging(string value);
        partial void OnCustomerRealizedLossChanged();
        /// <summary>
        /// There are no comments for Property CustomerVATAdjustmentRealizedLoss in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CustomerVATAdjustmentRealizedLoss
        {
            get
            {
                return this._CustomerVATAdjustmentRealizedLoss;
            }
            set
            {
                this.OnCustomerVATAdjustmentRealizedLossChanging(value);
                this._CustomerVATAdjustmentRealizedLoss = value;
                this.OnCustomerVATAdjustmentRealizedLossChanged();
                this.OnPropertyChanged("CustomerVATAdjustmentRealizedLoss");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerVATAdjustmentRealizedLoss;
        partial void OnCustomerVATAdjustmentRealizedLossChanging(string value);
        partial void OnCustomerVATAdjustmentRealizedLossChanged();
        /// <summary>
        /// There are no comments for Property AdvanceHolderTaxAccountingAdvanceAdjustmentLoss in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AdvanceHolderTaxAccountingAdvanceAdjustmentLoss
        {
            get
            {
                return this._AdvanceHolderTaxAccountingAdvanceAdjustmentLoss;
            }
            set
            {
                this.OnAdvanceHolderTaxAccountingAdvanceAdjustmentLossChanging(value);
                this._AdvanceHolderTaxAccountingAdvanceAdjustmentLoss = value;
                this.OnAdvanceHolderTaxAccountingAdvanceAdjustmentLossChanged();
                this.OnPropertyChanged("AdvanceHolderTaxAccountingAdvanceAdjustmentLoss");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdvanceHolderTaxAccountingAdvanceAdjustmentLoss;
        partial void OnAdvanceHolderTaxAccountingAdvanceAdjustmentLossChanging(string value);
        partial void OnAdvanceHolderTaxAccountingAdvanceAdjustmentLossChanged();
        /// <summary>
        /// There are no comments for Property CustomerAdvanceAdjustmentOffsetAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CustomerAdvanceAdjustmentOffsetAccount
        {
            get
            {
                return this._CustomerAdvanceAdjustmentOffsetAccount;
            }
            set
            {
                this.OnCustomerAdvanceAdjustmentOffsetAccountChanging(value);
                this._CustomerAdvanceAdjustmentOffsetAccount = value;
                this.OnCustomerAdvanceAdjustmentOffsetAccountChanged();
                this.OnPropertyChanged("CustomerAdvanceAdjustmentOffsetAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerAdvanceAdjustmentOffsetAccount;
        partial void OnCustomerAdvanceAdjustmentOffsetAccountChanging(string value);
        partial void OnCustomerAdvanceAdjustmentOffsetAccountChanged();
        /// <summary>
        /// There are no comments for Property VendorRealizedGain in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorRealizedGain
        {
            get
            {
                return this._VendorRealizedGain;
            }
            set
            {
                this.OnVendorRealizedGainChanging(value);
                this._VendorRealizedGain = value;
                this.OnVendorRealizedGainChanged();
                this.OnPropertyChanged("VendorRealizedGain");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorRealizedGain;
        partial void OnVendorRealizedGainChanging(string value);
        partial void OnVendorRealizedGainChanged();
        /// <summary>
        /// There are no comments for Property AdvanceHolderTaxDimensionRevenueCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AdvanceHolderTaxDimensionRevenueCode
        {
            get
            {
                return this._AdvanceHolderTaxDimensionRevenueCode;
            }
            set
            {
                this.OnAdvanceHolderTaxDimensionRevenueCodeChanging(value);
                this._AdvanceHolderTaxDimensionRevenueCode = value;
                this.OnAdvanceHolderTaxDimensionRevenueCodeChanged();
                this.OnPropertyChanged("AdvanceHolderTaxDimensionRevenueCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdvanceHolderTaxDimensionRevenueCode;
        partial void OnAdvanceHolderTaxDimensionRevenueCodeChanging(string value);
        partial void OnAdvanceHolderTaxDimensionRevenueCodeChanged();
        /// <summary>
        /// There are no comments for Property VendorAdvanceAdjustmentOffsetAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorAdvanceAdjustmentOffsetAccount
        {
            get
            {
                return this._VendorAdvanceAdjustmentOffsetAccount;
            }
            set
            {
                this.OnVendorAdvanceAdjustmentOffsetAccountChanging(value);
                this._VendorAdvanceAdjustmentOffsetAccount = value;
                this.OnVendorAdvanceAdjustmentOffsetAccountChanged();
                this.OnPropertyChanged("VendorAdvanceAdjustmentOffsetAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorAdvanceAdjustmentOffsetAccount;
        partial void OnVendorAdvanceAdjustmentOffsetAccountChanging(string value);
        partial void OnVendorAdvanceAdjustmentOffsetAccountChanged();
        /// <summary>
        /// There are no comments for Property AdvanceHolderRealizedGain in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AdvanceHolderRealizedGain
        {
            get
            {
                return this._AdvanceHolderRealizedGain;
            }
            set
            {
                this.OnAdvanceHolderRealizedGainChanging(value);
                this._AdvanceHolderRealizedGain = value;
                this.OnAdvanceHolderRealizedGainChanged();
                this.OnPropertyChanged("AdvanceHolderRealizedGain");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdvanceHolderRealizedGain;
        partial void OnAdvanceHolderRealizedGainChanging(string value);
        partial void OnAdvanceHolderRealizedGainChanged();
        /// <summary>
        /// There are no comments for Property AdvanceHolderTaxAccountingAdvanceAdjustmentProfit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AdvanceHolderTaxAccountingAdvanceAdjustmentProfit
        {
            get
            {
                return this._AdvanceHolderTaxAccountingAdvanceAdjustmentProfit;
            }
            set
            {
                this.OnAdvanceHolderTaxAccountingAdvanceAdjustmentProfitChanging(value);
                this._AdvanceHolderTaxAccountingAdvanceAdjustmentProfit = value;
                this.OnAdvanceHolderTaxAccountingAdvanceAdjustmentProfitChanged();
                this.OnPropertyChanged("AdvanceHolderTaxAccountingAdvanceAdjustmentProfit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdvanceHolderTaxAccountingAdvanceAdjustmentProfit;
        partial void OnAdvanceHolderTaxAccountingAdvanceAdjustmentProfitChanging(string value);
        partial void OnAdvanceHolderTaxAccountingAdvanceAdjustmentProfitChanged();
        /// <summary>
        /// There are no comments for Property LedgerPostingMode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendAmountDiffPostingMode_RU> LedgerPostingMode
        {
            get
            {
                return this._LedgerPostingMode;
            }
            set
            {
                this.OnLedgerPostingModeChanging(value);
                this._LedgerPostingMode = value;
                this.OnLedgerPostingModeChanged();
                this.OnPropertyChanged("LedgerPostingMode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendAmountDiffPostingMode_RU> _LedgerPostingMode;
        partial void OnLedgerPostingModeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendAmountDiffPostingMode_RU> value);
        partial void OnLedgerPostingModeChanged();
        /// <summary>
        /// There are no comments for Property VendorTaxDimensionExpenseCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorTaxDimensionExpenseCode
        {
            get
            {
                return this._VendorTaxDimensionExpenseCode;
            }
            set
            {
                this.OnVendorTaxDimensionExpenseCodeChanging(value);
                this._VendorTaxDimensionExpenseCode = value;
                this.OnVendorTaxDimensionExpenseCodeChanged();
                this.OnPropertyChanged("VendorTaxDimensionExpenseCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorTaxDimensionExpenseCode;
        partial void OnVendorTaxDimensionExpenseCodeChanging(string value);
        partial void OnVendorTaxDimensionExpenseCodeChanged();
        /// <summary>
        /// There are no comments for Property LedgerPostingCust in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendAmountDiffPostingMode_RU> LedgerPostingCust
        {
            get
            {
                return this._LedgerPostingCust;
            }
            set
            {
                this.OnLedgerPostingCustChanging(value);
                this._LedgerPostingCust = value;
                this.OnLedgerPostingCustChanged();
                this.OnPropertyChanged("LedgerPostingCust");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendAmountDiffPostingMode_RU> _LedgerPostingCust;
        partial void OnLedgerPostingCustChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendAmountDiffPostingMode_RU> value);
        partial void OnLedgerPostingCustChanged();
        /// <summary>
        /// There are no comments for Property VATAdjustmentCust in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> VATAdjustmentCust
        {
            get
            {
                return this._VATAdjustmentCust;
            }
            set
            {
                this.OnVATAdjustmentCustChanging(value);
                this._VATAdjustmentCust = value;
                this.OnVATAdjustmentCustChanged();
                this.OnPropertyChanged("VATAdjustmentCust");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _VATAdjustmentCust;
        partial void OnVATAdjustmentCustChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnVATAdjustmentCustChanged();
        /// <summary>
        /// There are no comments for Property CustomerAdvanceAdjustmentProfit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CustomerAdvanceAdjustmentProfit
        {
            get
            {
                return this._CustomerAdvanceAdjustmentProfit;
            }
            set
            {
                this.OnCustomerAdvanceAdjustmentProfitChanging(value);
                this._CustomerAdvanceAdjustmentProfit = value;
                this.OnCustomerAdvanceAdjustmentProfitChanged();
                this.OnPropertyChanged("CustomerAdvanceAdjustmentProfit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerAdvanceAdjustmentProfit;
        partial void OnCustomerAdvanceAdjustmentProfitChanging(string value);
        partial void OnCustomerAdvanceAdjustmentProfitChanged();
        /// <summary>
        /// There are no comments for Property VendorTaxAccountingAdvanceAdjustmentProfit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorTaxAccountingAdvanceAdjustmentProfit
        {
            get
            {
                return this._VendorTaxAccountingAdvanceAdjustmentProfit;
            }
            set
            {
                this.OnVendorTaxAccountingAdvanceAdjustmentProfitChanging(value);
                this._VendorTaxAccountingAdvanceAdjustmentProfit = value;
                this.OnVendorTaxAccountingAdvanceAdjustmentProfitChanged();
                this.OnPropertyChanged("VendorTaxAccountingAdvanceAdjustmentProfit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorTaxAccountingAdvanceAdjustmentProfit;
        partial void OnVendorTaxAccountingAdvanceAdjustmentProfitChanging(string value);
        partial void OnVendorTaxAccountingAdvanceAdjustmentProfitChanged();
        /// <summary>
        /// There are no comments for Property VendPostingMode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendAmountDiffPostingMode_RU> VendPostingMode
        {
            get
            {
                return this._VendPostingMode;
            }
            set
            {
                this.OnVendPostingModeChanging(value);
                this._VendPostingMode = value;
                this.OnVendPostingModeChanged();
                this.OnPropertyChanged("VendPostingMode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendAmountDiffPostingMode_RU> _VendPostingMode;
        partial void OnVendPostingModeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendAmountDiffPostingMode_RU> value);
        partial void OnVendPostingModeChanged();
        /// <summary>
        /// There are no comments for Property CustomerVATAdjustmentRealizedGain in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CustomerVATAdjustmentRealizedGain
        {
            get
            {
                return this._CustomerVATAdjustmentRealizedGain;
            }
            set
            {
                this.OnCustomerVATAdjustmentRealizedGainChanging(value);
                this._CustomerVATAdjustmentRealizedGain = value;
                this.OnCustomerVATAdjustmentRealizedGainChanged();
                this.OnPropertyChanged("CustomerVATAdjustmentRealizedGain");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerVATAdjustmentRealizedGain;
        partial void OnCustomerVATAdjustmentRealizedGainChanging(string value);
        partial void OnCustomerVATAdjustmentRealizedGainChanged();
        /// <summary>
        /// There are no comments for Property CustomerRealizedGain in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CustomerRealizedGain
        {
            get
            {
                return this._CustomerRealizedGain;
            }
            set
            {
                this.OnCustomerRealizedGainChanging(value);
                this._CustomerRealizedGain = value;
                this.OnCustomerRealizedGainChanged();
                this.OnPropertyChanged("CustomerRealizedGain");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerRealizedGain;
        partial void OnCustomerRealizedGainChanging(string value);
        partial void OnCustomerRealizedGainChanged();
        /// <summary>
        /// There are no comments for Property VendorTaxAccountingAdvanceAdjustmentLoss in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorTaxAccountingAdvanceAdjustmentLoss
        {
            get
            {
                return this._VendorTaxAccountingAdvanceAdjustmentLoss;
            }
            set
            {
                this.OnVendorTaxAccountingAdvanceAdjustmentLossChanging(value);
                this._VendorTaxAccountingAdvanceAdjustmentLoss = value;
                this.OnVendorTaxAccountingAdvanceAdjustmentLossChanged();
                this.OnPropertyChanged("VendorTaxAccountingAdvanceAdjustmentLoss");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorTaxAccountingAdvanceAdjustmentLoss;
        partial void OnVendorTaxAccountingAdvanceAdjustmentLossChanging(string value);
        partial void OnVendorTaxAccountingAdvanceAdjustmentLossChanged();
        /// <summary>
        /// There are no comments for Property AdvanceHolderRealizedLoss in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AdvanceHolderRealizedLoss
        {
            get
            {
                return this._AdvanceHolderRealizedLoss;
            }
            set
            {
                this.OnAdvanceHolderRealizedLossChanging(value);
                this._AdvanceHolderRealizedLoss = value;
                this.OnAdvanceHolderRealizedLossChanged();
                this.OnPropertyChanged("AdvanceHolderRealizedLoss");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdvanceHolderRealizedLoss;
        partial void OnAdvanceHolderRealizedLossChanging(string value);
        partial void OnAdvanceHolderRealizedLossChanged();
        /// <summary>
        /// There are no comments for Property VendorRealizedLoss in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VendorRealizedLoss
        {
            get
            {
                return this._VendorRealizedLoss;
            }
            set
            {
                this.OnVendorRealizedLossChanging(value);
                this._VendorRealizedLoss = value;
                this.OnVendorRealizedLossChanged();
                this.OnPropertyChanged("VendorRealizedLoss");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorRealizedLoss;
        partial void OnVendorRealizedLossChanging(string value);
        partial void OnVendorRealizedLossChanged();
        /// <summary>
        /// There are no comments for Property CustomerAdvanceAdjustmentLoss in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CustomerAdvanceAdjustmentLoss
        {
            get
            {
                return this._CustomerAdvanceAdjustmentLoss;
            }
            set
            {
                this.OnCustomerAdvanceAdjustmentLossChanging(value);
                this._CustomerAdvanceAdjustmentLoss = value;
                this.OnCustomerAdvanceAdjustmentLossChanged();
                this.OnPropertyChanged("CustomerAdvanceAdjustmentLoss");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerAdvanceAdjustmentLoss;
        partial void OnCustomerAdvanceAdjustmentLossChanging(string value);
        partial void OnCustomerAdvanceAdjustmentLossChanged();
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
