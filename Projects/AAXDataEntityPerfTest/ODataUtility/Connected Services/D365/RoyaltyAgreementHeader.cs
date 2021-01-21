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
        /// There are no comments for RoyaltyAgreementHeaderSingle in the schema.
        /// </summary>
    public partial class RoyaltyAgreementHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RoyaltyAgreementHeader>
    {
        /// <summary>
        /// Initialize a new RoyaltyAgreementHeaderSingle object.
        /// </summary>
        public RoyaltyAgreementHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RoyaltyAgreementHeaderSingle object.
        /// </summary>
        public RoyaltyAgreementHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RoyaltyAgreementHeaderSingle object.
        /// </summary>
        public RoyaltyAgreementHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RoyaltyAgreementHeader> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RoyaltyAgreementLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLine> RoyaltyAgreementLines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RoyaltyAgreementLines == null))
                {
                    this._RoyaltyAgreementLines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLine>(GetPath("RoyaltyAgreementLines"));
                }
                return this._RoyaltyAgreementLines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLine> _RoyaltyAgreementLines;
        /// <summary>
        /// There are no comments for ExpenseDimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle ExpenseDimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ExpenseDimensionCombination == null))
                {
                    this._ExpenseDimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("ExpenseDimensionCombination"));
                }
                return this._ExpenseDimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _ExpenseDimensionCombination;
        /// <summary>
        /// There are no comments for RoyaltyAgreementHeaderProductSelectionsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderProductSelectionV2> RoyaltyAgreementHeaderProductSelectionsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RoyaltyAgreementHeaderProductSelectionsV2 == null))
                {
                    this._RoyaltyAgreementHeaderProductSelectionsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderProductSelectionV2>(GetPath("RoyaltyAgreementHeaderProductSelectionsV2"));
                }
                return this._RoyaltyAgreementHeaderProductSelectionsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderProductSelectionV2> _RoyaltyAgreementHeaderProductSelectionsV2;
        /// <summary>
        /// There are no comments for RoyaltyAgreementHeaderProductSelections in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderProductSelection> RoyaltyAgreementHeaderProductSelections
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RoyaltyAgreementHeaderProductSelections == null))
                {
                    this._RoyaltyAgreementHeaderProductSelections = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderProductSelection>(GetPath("RoyaltyAgreementHeaderProductSelections"));
                }
                return this._RoyaltyAgreementHeaderProductSelections;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderProductSelection> _RoyaltyAgreementHeaderProductSelections;
    }
        /// <summary>
        /// There are no comments for RoyaltyAgreementHeader in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RoyaltyAgreementId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RoyaltyAgreementId")]
    [global::Microsoft.OData.Client.EntitySet("RoyaltyAgreementHeaders")]
    public partial class RoyaltyAgreementHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RoyaltyAgreementHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="royaltyAgreementId">Initial value of RoyaltyAgreementId.</param>
        /// <param name="defaultEffectiveDate">Initial value of DefaultEffectiveDate.</param>
        /// <param name="defaultExpirationDate">Initial value of DefaultExpirationDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RoyaltyAgreementHeader CreateRoyaltyAgreementHeader(string dataAreaId, string royaltyAgreementId, global::System.DateTimeOffset defaultEffectiveDate, global::System.DateTimeOffset defaultExpirationDate)
        {
            RoyaltyAgreementHeader royaltyAgreementHeader = new RoyaltyAgreementHeader();
            royaltyAgreementHeader.dataAreaId = dataAreaId;
            royaltyAgreementHeader.RoyaltyAgreementId = royaltyAgreementId;
            royaltyAgreementHeader.DefaultEffectiveDate = defaultEffectiveDate;
            royaltyAgreementHeader.DefaultExpirationDate = defaultExpirationDate;
            return royaltyAgreementHeader;
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
        /// There are no comments for Property RoyaltyAgreementId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RoyaltyAgreementId
        {
            get
            {
                return this._RoyaltyAgreementId;
            }
            set
            {
                this.OnRoyaltyAgreementIdChanging(value);
                this._RoyaltyAgreementId = value;
                this.OnRoyaltyAgreementIdChanged();
                this.OnPropertyChanged("RoyaltyAgreementId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RoyaltyAgreementId;
        partial void OnRoyaltyAgreementIdChanging(string value);
        partial void OnRoyaltyAgreementIdChanged();
        /// <summary>
        /// There are no comments for Property LineAmountBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRRoyaltyTakenFrom> LineAmountBasis
        {
            get
            {
                return this._LineAmountBasis;
            }
            set
            {
                this.OnLineAmountBasisChanging(value);
                this._LineAmountBasis = value;
                this.OnLineAmountBasisChanged();
                this.OnPropertyChanged("LineAmountBasis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRRoyaltyTakenFrom> _LineAmountBasis;
        partial void OnLineAmountBasisChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRRoyaltyTakenFrom> value);
        partial void OnLineAmountBasisChanged();
        /// <summary>
        /// There are no comments for Property DefaultVendorAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultVendorAccountNumber
        {
            get
            {
                return this._DefaultVendorAccountNumber;
            }
            set
            {
                this.OnDefaultVendorAccountNumberChanging(value);
                this._DefaultVendorAccountNumber = value;
                this.OnDefaultVendorAccountNumberChanged();
                this.OnPropertyChanged("DefaultVendorAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultVendorAccountNumber;
        partial void OnDefaultVendorAccountNumberChanging(string value);
        partial void OnDefaultVendorAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property RoyaltyExpenseMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RoyaltyExpenseMainAccountIdDisplayValue
        {
            get
            {
                return this._RoyaltyExpenseMainAccountIdDisplayValue;
            }
            set
            {
                this.OnRoyaltyExpenseMainAccountIdDisplayValueChanging(value);
                this._RoyaltyExpenseMainAccountIdDisplayValue = value;
                this.OnRoyaltyExpenseMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("RoyaltyExpenseMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RoyaltyExpenseMainAccountIdDisplayValue;
        partial void OnRoyaltyExpenseMainAccountIdDisplayValueChanging(string value);
        partial void OnRoyaltyExpenseMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property DefaultCurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultCurrencyCode
        {
            get
            {
                return this._DefaultCurrencyCode;
            }
            set
            {
                this.OnDefaultCurrencyCodeChanging(value);
                this._DefaultCurrencyCode = value;
                this.OnDefaultCurrencyCodeChanged();
                this.OnPropertyChanged("DefaultCurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultCurrencyCode;
        partial void OnDefaultCurrencyCodeChanging(string value);
        partial void OnDefaultCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property IsApprovalRequired in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsApprovalRequired
        {
            get
            {
                return this._IsApprovalRequired;
            }
            set
            {
                this.OnIsApprovalRequiredChanging(value);
                this._IsApprovalRequired = value;
                this.OnIsApprovalRequiredChanged();
                this.OnPropertyChanged("IsApprovalRequired");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsApprovalRequired;
        partial void OnIsApprovalRequiredChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsApprovalRequiredChanged();
        /// <summary>
        /// There are no comments for Property DefaultCalculationSearchDateType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRTradeCustCalcDates> DefaultCalculationSearchDateType
        {
            get
            {
                return this._DefaultCalculationSearchDateType;
            }
            set
            {
                this.OnDefaultCalculationSearchDateTypeChanging(value);
                this._DefaultCalculationSearchDateType = value;
                this.OnDefaultCalculationSearchDateTypeChanged();
                this.OnPropertyChanged("DefaultCalculationSearchDateType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRTradeCustCalcDates> _DefaultCalculationSearchDateType;
        partial void OnDefaultCalculationSearchDateTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRTradeCustCalcDates> value);
        partial void OnDefaultCalculationSearchDateTypeChanged();
        /// <summary>
        /// There are no comments for Property SalesCumulationMethodCustomizedPeriodType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesCumulationMethodCustomizedPeriodType
        {
            get
            {
                return this._SalesCumulationMethodCustomizedPeriodType;
            }
            set
            {
                this.OnSalesCumulationMethodCustomizedPeriodTypeChanging(value);
                this._SalesCumulationMethodCustomizedPeriodType = value;
                this.OnSalesCumulationMethodCustomizedPeriodTypeChanged();
                this.OnPropertyChanged("SalesCumulationMethodCustomizedPeriodType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesCumulationMethodCustomizedPeriodType;
        partial void OnSalesCumulationMethodCustomizedPeriodTypeChanging(string value);
        partial void OnSalesCumulationMethodCustomizedPeriodTypeChanged();
        /// <summary>
        /// There are no comments for Property ValidatingWorkerPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ValidatingWorkerPersonnelNumber
        {
            get
            {
                return this._ValidatingWorkerPersonnelNumber;
            }
            set
            {
                this.OnValidatingWorkerPersonnelNumberChanging(value);
                this._ValidatingWorkerPersonnelNumber = value;
                this.OnValidatingWorkerPersonnelNumberChanged();
                this.OnPropertyChanged("ValidatingWorkerPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ValidatingWorkerPersonnelNumber;
        partial void OnValidatingWorkerPersonnelNumberChanging(string value);
        partial void OnValidatingWorkerPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property DefaultEffectiveDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DefaultEffectiveDate
        {
            get
            {
                return this._DefaultEffectiveDate;
            }
            set
            {
                this.OnDefaultEffectiveDateChanging(value);
                this._DefaultEffectiveDate = value;
                this.OnDefaultEffectiveDateChanged();
                this.OnPropertyChanged("DefaultEffectiveDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DefaultEffectiveDate;
        partial void OnDefaultEffectiveDateChanging(global::System.DateTimeOffset value);
        partial void OnDefaultEffectiveDateChanged();
        /// <summary>
        /// There are no comments for Property SalesUnitSymbolOption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRRoyaltyUOMOption> SalesUnitSymbolOption
        {
            get
            {
                return this._SalesUnitSymbolOption;
            }
            set
            {
                this.OnSalesUnitSymbolOptionChanging(value);
                this._SalesUnitSymbolOption = value;
                this.OnSalesUnitSymbolOptionChanged();
                this.OnPropertyChanged("SalesUnitSymbolOption");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRRoyaltyUOMOption> _SalesUnitSymbolOption;
        partial void OnSalesUnitSymbolOptionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRRoyaltyUOMOption> value);
        partial void OnSalesUnitSymbolOptionChanged();
        /// <summary>
        /// There are no comments for Property AgreementDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AgreementDescription
        {
            get
            {
                return this._AgreementDescription;
            }
            set
            {
                this.OnAgreementDescriptionChanging(value);
                this._AgreementDescription = value;
                this.OnAgreementDescriptionChanged();
                this.OnPropertyChanged("AgreementDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AgreementDescription;
        partial void OnAgreementDescriptionChanging(string value);
        partial void OnAgreementDescriptionChanged();
        /// <summary>
        /// There are no comments for Property SalesUnitSymbolType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRRoyaltyUnitType> SalesUnitSymbolType
        {
            get
            {
                return this._SalesUnitSymbolType;
            }
            set
            {
                this.OnSalesUnitSymbolTypeChanging(value);
                this._SalesUnitSymbolType = value;
                this.OnSalesUnitSymbolTypeChanged();
                this.OnPropertyChanged("SalesUnitSymbolType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRRoyaltyUnitType> _SalesUnitSymbolType;
        partial void OnSalesUnitSymbolTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRRoyaltyUnitType> value);
        partial void OnSalesUnitSymbolTypeChanged();
        /// <summary>
        /// There are no comments for Property IsValidated in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsValidated
        {
            get
            {
                return this._IsValidated;
            }
            set
            {
                this.OnIsValidatedChanging(value);
                this._IsValidated = value;
                this.OnIsValidatedChanged();
                this.OnPropertyChanged("IsValidated");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsValidated;
        partial void OnIsValidatedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsValidatedChanged();
        /// <summary>
        /// There are no comments for Property RoyaltyBreakBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRRoyaltyLineBreakType> RoyaltyBreakBasis
        {
            get
            {
                return this._RoyaltyBreakBasis;
            }
            set
            {
                this.OnRoyaltyBreakBasisChanging(value);
                this._RoyaltyBreakBasis = value;
                this.OnRoyaltyBreakBasisChanged();
                this.OnPropertyChanged("RoyaltyBreakBasis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRRoyaltyLineBreakType> _RoyaltyBreakBasis;
        partial void OnRoyaltyBreakBasisChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRRoyaltyLineBreakType> value);
        partial void OnRoyaltyBreakBasisChanged();
        /// <summary>
        /// There are no comments for Property DefaultSalesUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultSalesUnitSymbol
        {
            get
            {
                return this._DefaultSalesUnitSymbol;
            }
            set
            {
                this.OnDefaultSalesUnitSymbolChanging(value);
                this._DefaultSalesUnitSymbol = value;
                this.OnDefaultSalesUnitSymbolChanged();
                this.OnPropertyChanged("DefaultSalesUnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultSalesUnitSymbol;
        partial void OnDefaultSalesUnitSymbolChanging(string value);
        partial void OnDefaultSalesUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property AgreementNote in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AgreementNote
        {
            get
            {
                return this._AgreementNote;
            }
            set
            {
                this.OnAgreementNoteChanging(value);
                this._AgreementNote = value;
                this.OnAgreementNoteChanged();
                this.OnPropertyChanged("AgreementNote");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AgreementNote;
        partial void OnAgreementNoteChanging(string value);
        partial void OnAgreementNoteChanged();
        /// <summary>
        /// There are no comments for Property DefaultExpirationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DefaultExpirationDate
        {
            get
            {
                return this._DefaultExpirationDate;
            }
            set
            {
                this.OnDefaultExpirationDateChanging(value);
                this._DefaultExpirationDate = value;
                this.OnDefaultExpirationDateChanged();
                this.OnPropertyChanged("DefaultExpirationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DefaultExpirationDate;
        partial void OnDefaultExpirationDateChanging(global::System.DateTimeOffset value);
        partial void OnDefaultExpirationDateChanged();
        /// <summary>
        /// There are no comments for Property SalesCumulationMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRRoyaltyCumulationPeriod> SalesCumulationMethod
        {
            get
            {
                return this._SalesCumulationMethod;
            }
            set
            {
                this.OnSalesCumulationMethodChanging(value);
                this._SalesCumulationMethod = value;
                this.OnSalesCumulationMethodChanged();
                this.OnPropertyChanged("SalesCumulationMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRRoyaltyCumulationPeriod> _SalesCumulationMethod;
        partial void OnSalesCumulationMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRRoyaltyCumulationPeriod> value);
        partial void OnSalesCumulationMethodChanged();
        /// <summary>
        /// There are no comments for Property RoyaltyAccrualMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RoyaltyAccrualMainAccountIdDisplayValue
        {
            get
            {
                return this._RoyaltyAccrualMainAccountIdDisplayValue;
            }
            set
            {
                this.OnRoyaltyAccrualMainAccountIdDisplayValueChanging(value);
                this._RoyaltyAccrualMainAccountIdDisplayValue = value;
                this.OnRoyaltyAccrualMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("RoyaltyAccrualMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RoyaltyAccrualMainAccountIdDisplayValue;
        partial void OnRoyaltyAccrualMainAccountIdDisplayValueChanging(string value);
        partial void OnRoyaltyAccrualMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property RoyaltyAgreementLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLine> RoyaltyAgreementLines
        {
            get
            {
                return this._RoyaltyAgreementLines;
            }
            set
            {
                this.OnRoyaltyAgreementLinesChanging(value);
                this._RoyaltyAgreementLines = value;
                this.OnRoyaltyAgreementLinesChanged();
                this.OnPropertyChanged("RoyaltyAgreementLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLine> _RoyaltyAgreementLines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRoyaltyAgreementLinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementLine> value);
        partial void OnRoyaltyAgreementLinesChanged();
        /// <summary>
        /// There are no comments for Property ExpenseDimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination ExpenseDimensionCombination
        {
            get
            {
                return this._ExpenseDimensionCombination;
            }
            set
            {
                this.OnExpenseDimensionCombinationChanging(value);
                this._ExpenseDimensionCombination = value;
                this.OnExpenseDimensionCombinationChanged();
                this.OnPropertyChanged("ExpenseDimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _ExpenseDimensionCombination;
        partial void OnExpenseDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnExpenseDimensionCombinationChanged();
        /// <summary>
        /// There are no comments for Property RoyaltyAgreementHeaderProductSelectionsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderProductSelectionV2> RoyaltyAgreementHeaderProductSelectionsV2
        {
            get
            {
                return this._RoyaltyAgreementHeaderProductSelectionsV2;
            }
            set
            {
                this.OnRoyaltyAgreementHeaderProductSelectionsV2Changing(value);
                this._RoyaltyAgreementHeaderProductSelectionsV2 = value;
                this.OnRoyaltyAgreementHeaderProductSelectionsV2Changed();
                this.OnPropertyChanged("RoyaltyAgreementHeaderProductSelectionsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderProductSelectionV2> _RoyaltyAgreementHeaderProductSelectionsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderProductSelectionV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRoyaltyAgreementHeaderProductSelectionsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderProductSelectionV2> value);
        partial void OnRoyaltyAgreementHeaderProductSelectionsV2Changed();
        /// <summary>
        /// There are no comments for Property RoyaltyAgreementHeaderProductSelections in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderProductSelection> RoyaltyAgreementHeaderProductSelections
        {
            get
            {
                return this._RoyaltyAgreementHeaderProductSelections;
            }
            set
            {
                this.OnRoyaltyAgreementHeaderProductSelectionsChanging(value);
                this._RoyaltyAgreementHeaderProductSelections = value;
                this.OnRoyaltyAgreementHeaderProductSelectionsChanged();
                this.OnPropertyChanged("RoyaltyAgreementHeaderProductSelections");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderProductSelection> _RoyaltyAgreementHeaderProductSelections = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderProductSelection>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRoyaltyAgreementHeaderProductSelectionsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderProductSelection> value);
        partial void OnRoyaltyAgreementHeaderProductSelectionsChanged();
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
