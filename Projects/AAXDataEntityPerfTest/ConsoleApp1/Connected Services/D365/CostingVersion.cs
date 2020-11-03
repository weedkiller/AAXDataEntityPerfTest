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
    /// There are no comments for CostingVersionSingle in the schema.
    /// </summary>
    public partial class CostingVersionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CostingVersion>
    {
        /// <summary>
        /// Initialize a new CostingVersionSingle object.
        /// </summary>
        public CostingVersionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CostingVersionSingle object.
        /// </summary>
        public CostingVersionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CostingVersionSingle object.
        /// </summary>
        public CostingVersionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CostingVersion> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PendingRouteCostCategoryUnitCosts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RoutePendingRouteCostCategoryUnitCost> PendingRouteCostCategoryUnitCosts
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PendingRouteCostCategoryUnitCosts == null))
                {
                    this._PendingRouteCostCategoryUnitCosts = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RoutePendingRouteCostCategoryUnitCost>(GetPath("PendingRouteCostCategoryUnitCosts"));
                }
                return this._PendingRouteCostCategoryUnitCosts;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RoutePendingRouteCostCategoryUnitCost> _PendingRouteCostCategoryUnitCosts;
    }
    /// <summary>
    /// There are no comments for CostingVersion in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// VersionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "VersionId")]
    [global::Microsoft.OData.Client.EntitySet("CostingVersions")]
    public partial class CostingVersion : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CostingVersion object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="versionId">Initial value of VersionId.</param>
        /// <param name="lastUpdateDate">Initial value of LastUpdateDate.</param>
        /// <param name="defaultFromDate">Initial value of DefaultFromDate.</param>
        /// <param name="lastActivationDate">Initial value of LastActivationDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CostingVersion CreateCostingVersion(string dataAreaId, string versionId, global::System.DateTimeOffset lastUpdateDate, global::System.DateTimeOffset defaultFromDate, global::System.DateTimeOffset lastActivationDate)
        {
            CostingVersion costingVersion = new CostingVersion();
            costingVersion.dataAreaId = dataAreaId;
            costingVersion.VersionId = versionId;
            costingVersion.LastUpdateDate = lastUpdateDate;
            costingVersion.DefaultFromDate = defaultFromDate;
            costingVersion.LastActivationDate = lastActivationDate;
            return costingVersion;
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
        /// There are no comments for Property VersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VersionId
        {
            get
            {
                return this._VersionId;
            }
            set
            {
                this.OnVersionIdChanging(value);
                this._VersionId = value;
                this.OnVersionIdChanged();
                this.OnPropertyChanged("VersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VersionId;
        partial void OnVersionIdChanging(string value);
        partial void OnVersionIdChanged();
        /// <summary>
        /// There are no comments for Property ArePriceCalculationsUsingPurchaseProcurementModeAllowed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ArePriceCalculationsUsingPurchaseProcurementModeAllowed
        {
            get
            {
                return this._ArePriceCalculationsUsingPurchaseProcurementModeAllowed;
            }
            set
            {
                this.OnArePriceCalculationsUsingPurchaseProcurementModeAllowedChanging(value);
                this._ArePriceCalculationsUsingPurchaseProcurementModeAllowed = value;
                this.OnArePriceCalculationsUsingPurchaseProcurementModeAllowedChanged();
                this.OnPropertyChanged("ArePriceCalculationsUsingPurchaseProcurementModeAllowed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ArePriceCalculationsUsingPurchaseProcurementModeAllowed;
        partial void OnArePriceCalculationsUsingPurchaseProcurementModeAllowedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnArePriceCalculationsUsingPurchaseProcurementModeAllowedChanged();
        /// <summary>
        /// There are no comments for Property ExplosionMode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMCalcExplosionMode> ExplosionMode
        {
            get
            {
                return this._ExplosionMode;
            }
            set
            {
                this.OnExplosionModeChanging(value);
                this._ExplosionMode = value;
                this.OnExplosionModeChanged();
                this.OnPropertyChanged("ExplosionMode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMCalcExplosionMode> _ExplosionMode;
        partial void OnExplosionModeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMCalcExplosionMode> value);
        partial void OnExplosionModeChanged();
        /// <summary>
        /// There are no comments for Property LastUpdateDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset LastUpdateDate
        {
            get
            {
                return this._LastUpdateDate;
            }
            set
            {
                this.OnLastUpdateDateChanging(value);
                this._LastUpdateDate = value;
                this.OnLastUpdateDateChanged();
                this.OnPropertyChanged("LastUpdateDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _LastUpdateDate;
        partial void OnLastUpdateDateChanging(global::System.DateTimeOffset value);
        partial void OnLastUpdateDateChanged();
        /// <summary>
        /// There are no comments for Property AreSalesPricesAllowed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AreSalesPricesAllowed
        {
            get
            {
                return this._AreSalesPricesAllowed;
            }
            set
            {
                this.OnAreSalesPricesAllowedChanging(value);
                this._AreSalesPricesAllowed = value;
                this.OnAreSalesPricesAllowedChanged();
                this.OnPropertyChanged("AreSalesPricesAllowed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AreSalesPricesAllowed;
        partial void OnAreSalesPricesAllowedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAreSalesPricesAllowedChanged();
        /// <summary>
        /// There are no comments for Property ArePurchasePricesAllowed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ArePurchasePricesAllowed
        {
            get
            {
                return this._ArePurchasePricesAllowed;
            }
            set
            {
                this.OnArePurchasePricesAllowedChanging(value);
                this._ArePurchasePricesAllowed = value;
                this.OnArePurchasePricesAllowedChanged();
                this.OnPropertyChanged("ArePurchasePricesAllowed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ArePurchasePricesAllowed;
        partial void OnArePurchasePricesAllowedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnArePurchasePricesAllowedChanged();
        /// <summary>
        /// There are no comments for Property IsActivationBlocked in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYesCombo> IsActivationBlocked
        {
            get
            {
                return this._IsActivationBlocked;
            }
            set
            {
                this.OnIsActivationBlockedChanging(value);
                this._IsActivationBlocked = value;
                this.OnIsActivationBlockedChanged();
                this.OnPropertyChanged("IsActivationBlocked");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYesCombo> _IsActivationBlocked;
        partial void OnIsActivationBlockedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYesCombo> value);
        partial void OnIsActivationBlockedChanged();
        /// <summary>
        /// There are no comments for Property IsProductionProcurementModePriceCalculationAllowed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsProductionProcurementModePriceCalculationAllowed
        {
            get
            {
                return this._IsProductionProcurementModePriceCalculationAllowed;
            }
            set
            {
                this.OnIsProductionProcurementModePriceCalculationAllowedChanging(value);
                this._IsProductionProcurementModePriceCalculationAllowed = value;
                this.OnIsProductionProcurementModePriceCalculationAllowedChanged();
                this.OnPropertyChanged("IsProductionProcurementModePriceCalculationAllowed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsProductionProcurementModePriceCalculationAllowed;
        partial void OnIsProductionProcurementModePriceCalculationAllowedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsProductionProcurementModePriceCalculationAllowedChanged();
        /// <summary>
        /// There are no comments for Property FallbackCostingVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FallbackCostingVersionId
        {
            get
            {
                return this._FallbackCostingVersionId;
            }
            set
            {
                this.OnFallbackCostingVersionIdChanging(value);
                this._FallbackCostingVersionId = value;
                this.OnFallbackCostingVersionIdChanged();
                this.OnPropertyChanged("FallbackCostingVersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FallbackCostingVersionId;
        partial void OnFallbackCostingVersionIdChanging(string value);
        partial void OnFallbackCostingVersionIdChanged();
        /// <summary>
        /// There are no comments for Property PurchasePriceModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PurchPriceModel> PurchasePriceModel
        {
            get
            {
                return this._PurchasePriceModel;
            }
            set
            {
                this.OnPurchasePriceModelChanging(value);
                this._PurchasePriceModel = value;
                this.OnPurchasePriceModelChanged();
                this.OnPropertyChanged("PurchasePriceModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PurchPriceModel> _PurchasePriceModel;
        partial void OnPurchasePriceModelChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PurchPriceModel> value);
        partial void OnPurchasePriceModelChanged();
        /// <summary>
        /// There are no comments for Property ProfitSetting in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostProfitSet> ProfitSetting
        {
            get
            {
                return this._ProfitSetting;
            }
            set
            {
                this.OnProfitSettingChanging(value);
                this._ProfitSetting = value;
                this.OnProfitSettingChanged();
                this.OnPropertyChanged("ProfitSetting");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostProfitSet> _ProfitSetting;
        partial void OnProfitSettingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostProfitSet> value);
        partial void OnProfitSettingChanged();
        /// <summary>
        /// There are no comments for Property FallbackPrinciple in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMCalcFallBack> FallbackPrinciple
        {
            get
            {
                return this._FallbackPrinciple;
            }
            set
            {
                this.OnFallbackPrincipleChanging(value);
                this._FallbackPrinciple = value;
                this.OnFallbackPrincipleChanged();
                this.OnPropertyChanged("FallbackPrinciple");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMCalcFallBack> _FallbackPrinciple;
        partial void OnFallbackPrincipleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMCalcFallBack> value);
        partial void OnFallbackPrincipleChanged();
        /// <summary>
        /// There are no comments for Property IsUnitPriceIncludingCharge in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsUnitPriceIncludingCharge
        {
            get
            {
                return this._IsUnitPriceIncludingCharge;
            }
            set
            {
                this.OnIsUnitPriceIncludingChargeChanging(value);
                this._IsUnitPriceIncludingCharge = value;
                this.OnIsUnitPriceIncludingChargeChanged();
                this.OnPropertyChanged("IsUnitPriceIncludingCharge");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsUnitPriceIncludingCharge;
        partial void OnIsUnitPriceIncludingChargeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsUnitPriceIncludingChargeChanged();
        /// <summary>
        /// There are no comments for Property RecordingRestriction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> RecordingRestriction
        {
            get
            {
                return this._RecordingRestriction;
            }
            set
            {
                this.OnRecordingRestrictionChanging(value);
                this._RecordingRestriction = value;
                this.OnRecordingRestrictionChanged();
                this.OnPropertyChanged("RecordingRestriction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _RecordingRestriction;
        partial void OnRecordingRestrictionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnRecordingRestrictionChanged();
        /// <summary>
        /// There are no comments for Property RestrictingPriceSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RestrictingPriceSiteId
        {
            get
            {
                return this._RestrictingPriceSiteId;
            }
            set
            {
                this.OnRestrictingPriceSiteIdChanging(value);
                this._RestrictingPriceSiteId = value;
                this.OnRestrictingPriceSiteIdChanged();
                this.OnPropertyChanged("RestrictingPriceSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RestrictingPriceSiteId;
        partial void OnRestrictingPriceSiteIdChanging(string value);
        partial void OnRestrictingPriceSiteIdChanged();
        /// <summary>
        /// There are no comments for Property IsVersionBlocked in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYesCombo> IsVersionBlocked
        {
            get
            {
                return this._IsVersionBlocked;
            }
            set
            {
                this.OnIsVersionBlockedChanging(value);
                this._IsVersionBlocked = value;
                this.OnIsVersionBlockedChanged();
                this.OnPropertyChanged("IsVersionBlocked");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYesCombo> _IsVersionBlocked;
        partial void OnIsVersionBlockedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYesCombo> value);
        partial void OnIsVersionBlockedChanged();
        /// <summary>
        /// There are no comments for Property DefaultFromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DefaultFromDate
        {
            get
            {
                return this._DefaultFromDate;
            }
            set
            {
                this.OnDefaultFromDateChanging(value);
                this._DefaultFromDate = value;
                this.OnDefaultFromDateChanged();
                this.OnPropertyChanged("DefaultFromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DefaultFromDate;
        partial void OnDefaultFromDateChanging(global::System.DateTimeOffset value);
        partial void OnDefaultFromDateChanged();
        /// <summary>
        /// There are no comments for Property LastActivationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset LastActivationDate
        {
            get
            {
                return this._LastActivationDate;
            }
            set
            {
                this.OnLastActivationDateChanging(value);
                this._LastActivationDate = value;
                this.OnLastActivationDateChanged();
                this.OnPropertyChanged("LastActivationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _LastActivationDate;
        partial void OnLastActivationDateChanging(global::System.DateTimeOffset value);
        partial void OnLastActivationDateChanged();
        /// <summary>
        /// There are no comments for Property CostingType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostingVersionCostingType> CostingType
        {
            get
            {
                return this._CostingType;
            }
            set
            {
                this.OnCostingTypeChanging(value);
                this._CostingType = value;
                this.OnCostingTypeChanged();
                this.OnPropertyChanged("CostingType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostingVersionCostingType> _CostingType;
        partial void OnCostingTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostingVersionCostingType> value);
        partial void OnCostingTypeChanged();
        /// <summary>
        /// There are no comments for Property VersionName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VersionName
        {
            get
            {
                return this._VersionName;
            }
            set
            {
                this.OnVersionNameChanging(value);
                this._VersionName = value;
                this.OnVersionNameChanged();
                this.OnPropertyChanged("VersionName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VersionName;
        partial void OnVersionNameChanging(string value);
        partial void OnVersionNameChanged();
        /// <summary>
        /// There are no comments for Property AreCostPricesAllowed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AreCostPricesAllowed
        {
            get
            {
                return this._AreCostPricesAllowed;
            }
            set
            {
                this.OnAreCostPricesAllowedChanging(value);
                this._AreCostPricesAllowed = value;
                this.OnAreCostPricesAllowedChanged();
                this.OnPropertyChanged("AreCostPricesAllowed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AreCostPricesAllowed;
        partial void OnAreCostPricesAllowedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAreCostPricesAllowedChanged();
        /// <summary>
        /// There are no comments for Property CostPriceModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMCostPriceModel> CostPriceModel
        {
            get
            {
                return this._CostPriceModel;
            }
            set
            {
                this.OnCostPriceModelChanging(value);
                this._CostPriceModel = value;
                this.OnCostPriceModelChanged();
                this.OnPropertyChanged("CostPriceModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMCostPriceModel> _CostPriceModel;
        partial void OnCostPriceModelChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMCostPriceModel> value);
        partial void OnCostPriceModelChanged();
        /// <summary>
        /// There are no comments for Property RestrictCalculation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> RestrictCalculation
        {
            get
            {
                return this._RestrictCalculation;
            }
            set
            {
                this.OnRestrictCalculationChanging(value);
                this._RestrictCalculation = value;
                this.OnRestrictCalculationChanged();
                this.OnPropertyChanged("RestrictCalculation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _RestrictCalculation;
        partial void OnRestrictCalculationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnRestrictCalculationChanged();
        /// <summary>
        /// There are no comments for Property RoundOffCalculation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> RoundOffCalculation
        {
            get
            {
                return this._RoundOffCalculation;
            }
            set
            {
                this.OnRoundOffCalculationChanging(value);
                this._RoundOffCalculation = value;
                this.OnRoundOffCalculationChanged();
                this.OnPropertyChanged("RoundOffCalculation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _RoundOffCalculation;
        partial void OnRoundOffCalculationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnRoundOffCalculationChanged();
        /// <summary>
        /// There are no comments for Property PendingRouteCostCategoryUnitCosts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoutePendingRouteCostCategoryUnitCost> PendingRouteCostCategoryUnitCosts
        {
            get
            {
                return this._PendingRouteCostCategoryUnitCosts;
            }
            set
            {
                this.OnPendingRouteCostCategoryUnitCostsChanging(value);
                this._PendingRouteCostCategoryUnitCosts = value;
                this.OnPendingRouteCostCategoryUnitCostsChanged();
                this.OnPropertyChanged("PendingRouteCostCategoryUnitCosts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoutePendingRouteCostCategoryUnitCost> _PendingRouteCostCategoryUnitCosts = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoutePendingRouteCostCategoryUnitCost>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPendingRouteCostCategoryUnitCostsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RoutePendingRouteCostCategoryUnitCost> value);
        partial void OnPendingRouteCostCategoryUnitCostsChanged();
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