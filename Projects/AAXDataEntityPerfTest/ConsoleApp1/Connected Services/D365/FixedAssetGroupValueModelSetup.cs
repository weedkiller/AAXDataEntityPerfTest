﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:55:10 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for FixedAssetGroupValueModelSetupSingle in the schema.
    /// </summary>
    public partial class FixedAssetGroupValueModelSetupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FixedAssetGroupValueModelSetup>
    {
        /// <summary>
        /// Initialize a new FixedAssetGroupValueModelSetupSingle object.
        /// </summary>
        public FixedAssetGroupValueModelSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FixedAssetGroupValueModelSetupSingle object.
        /// </summary>
        public FixedAssetGroupValueModelSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FixedAssetGroupValueModelSetupSingle object.
        /// </summary>
        public FixedAssetGroupValueModelSetupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FixedAssetGroupValueModelSetup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetDepreciationProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DepreciationProfileSingle AssetDepreciationProfile
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetDepreciationProfile == null))
                {
                    this._AssetDepreciationProfile = new global::Microsoft.Dynamics.DataEntities.DepreciationProfileSingle(this.Context, GetPath("AssetDepreciationProfile"));
                }
                return this._AssetDepreciationProfile;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DepreciationProfileSingle _AssetDepreciationProfile;
        /// <summary>
        /// There are no comments for AssetExtraordinaryDepreciationProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DepreciationProfileSingle AssetExtraordinaryDepreciationProfile
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetExtraordinaryDepreciationProfile == null))
                {
                    this._AssetExtraordinaryDepreciationProfile = new global::Microsoft.Dynamics.DataEntities.DepreciationProfileSingle(this.Context, GetPath("AssetExtraordinaryDepreciationProfile"));
                }
                return this._AssetExtraordinaryDepreciationProfile;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DepreciationProfileSingle _AssetExtraordinaryDepreciationProfile;
        /// <summary>
        /// There are no comments for AssetAlternativeDepreciationProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DepreciationProfileSingle AssetAlternativeDepreciationProfile
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetAlternativeDepreciationProfile == null))
                {
                    this._AssetAlternativeDepreciationProfile = new global::Microsoft.Dynamics.DataEntities.DepreciationProfileSingle(this.Context, GetPath("AssetAlternativeDepreciationProfile"));
                }
                return this._AssetAlternativeDepreciationProfile;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DepreciationProfileSingle _AssetAlternativeDepreciationProfile;
        /// <summary>
        /// There are no comments for AssetAcceleratedDepreciationProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DepreciationProfileSingle AssetAcceleratedDepreciationProfile
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetAcceleratedDepreciationProfile == null))
                {
                    this._AssetAcceleratedDepreciationProfile = new global::Microsoft.Dynamics.DataEntities.DepreciationProfileSingle(this.Context, GetPath("AssetAcceleratedDepreciationProfile"));
                }
                return this._AssetAcceleratedDepreciationProfile;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DepreciationProfileSingle _AssetAcceleratedDepreciationProfile;
        /// <summary>
        /// There are no comments for AssetGroupValueModelSetupValueModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ValueModelSetupSingle AssetGroupValueModelSetupValueModel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetGroupValueModelSetupValueModel == null))
                {
                    this._AssetGroupValueModelSetupValueModel = new global::Microsoft.Dynamics.DataEntities.ValueModelSetupSingle(this.Context, GetPath("AssetGroupValueModelSetupValueModel"));
                }
                return this._AssetGroupValueModelSetupValueModel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ValueModelSetupSingle _AssetGroupValueModelSetupValueModel;
    }
    /// <summary>
    /// There are no comments for FixedAssetGroupValueModelSetup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// FixedAssetGroupId
    /// ValueModelId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FixedAssetGroupId", "ValueModelId")]
    [global::Microsoft.OData.Client.EntitySet("FixedAssetGroupValueModelSetups")]
    public partial class FixedAssetGroupValueModelSetup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FixedAssetGroupValueModelSetup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="fixedAssetGroupId">Initial value of FixedAssetGroupId.</param>
        /// <param name="valueModelId">Initial value of ValueModelId.</param>
        /// <param name="specialDepreciationAllocationPeriods">Initial value of SpecialDepreciationAllocationPeriods.</param>
        /// <param name="serviceLifeMonths">Initial value of ServiceLifeMonths.</param>
        /// <param name="depreciationPeriods">Initial value of DepreciationPeriods.</param>
        /// <param name="serviceLifeYears">Initial value of ServiceLifeYears.</param>
        /// <param name="serviceLife">Initial value of ServiceLife.</param>
        /// <param name="assetGroupValueModelSetupValueModel">Initial value of AssetGroupValueModelSetupValueModel.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FixedAssetGroupValueModelSetup CreateFixedAssetGroupValueModelSetup(string dataAreaId, 
                    string fixedAssetGroupId, 
                    string valueModelId, 
                    int specialDepreciationAllocationPeriods, 
                    int serviceLifeMonths, 
                    int depreciationPeriods, 
                    int serviceLifeYears, 
                    decimal serviceLife, 
                    global::Microsoft.Dynamics.DataEntities.ValueModelSetup assetGroupValueModelSetupValueModel)
        {
            FixedAssetGroupValueModelSetup fixedAssetGroupValueModelSetup = new FixedAssetGroupValueModelSetup();
            fixedAssetGroupValueModelSetup.dataAreaId = dataAreaId;
            fixedAssetGroupValueModelSetup.FixedAssetGroupId = fixedAssetGroupId;
            fixedAssetGroupValueModelSetup.ValueModelId = valueModelId;
            fixedAssetGroupValueModelSetup.SpecialDepreciationAllocationPeriods = specialDepreciationAllocationPeriods;
            fixedAssetGroupValueModelSetup.ServiceLifeMonths = serviceLifeMonths;
            fixedAssetGroupValueModelSetup.DepreciationPeriods = depreciationPeriods;
            fixedAssetGroupValueModelSetup.ServiceLifeYears = serviceLifeYears;
            fixedAssetGroupValueModelSetup.ServiceLife = serviceLife;
            if ((assetGroupValueModelSetupValueModel == null))
            {
                throw new global::System.ArgumentNullException("assetGroupValueModelSetupValueModel");
            }
            fixedAssetGroupValueModelSetup.AssetGroupValueModelSetupValueModel = assetGroupValueModelSetupValueModel;
            return fixedAssetGroupValueModelSetup;
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
        /// There are no comments for Property FixedAssetGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FixedAssetGroupId
        {
            get
            {
                return this._FixedAssetGroupId;
            }
            set
            {
                this.OnFixedAssetGroupIdChanging(value);
                this._FixedAssetGroupId = value;
                this.OnFixedAssetGroupIdChanged();
                this.OnPropertyChanged("FixedAssetGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FixedAssetGroupId;
        partial void OnFixedAssetGroupIdChanging(string value);
        partial void OnFixedAssetGroupIdChanged();
        /// <summary>
        /// There are no comments for Property ValueModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ValueModelId
        {
            get
            {
                return this._ValueModelId;
            }
            set
            {
                this.OnValueModelIdChanging(value);
                this._ValueModelId = value;
                this.OnValueModelIdChanged();
                this.OnPropertyChanged("ValueModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ValueModelId;
        partial void OnValueModelIdChanging(string value);
        partial void OnValueModelIdChanged();
        /// <summary>
        /// There are no comments for Property AlternativeDepreciationProfileId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AlternativeDepreciationProfileId
        {
            get
            {
                return this._AlternativeDepreciationProfileId;
            }
            set
            {
                this.OnAlternativeDepreciationProfileIdChanging(value);
                this._AlternativeDepreciationProfileId = value;
                this.OnAlternativeDepreciationProfileIdChanged();
                this.OnPropertyChanged("AlternativeDepreciationProfileId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AlternativeDepreciationProfileId;
        partial void OnAlternativeDepreciationProfileIdChanging(string value);
        partial void OnAlternativeDepreciationProfileIdChanged();
        /// <summary>
        /// There are no comments for Property SpecialDepreciationAllocationPeriods in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int SpecialDepreciationAllocationPeriods
        {
            get
            {
                return this._SpecialDepreciationAllocationPeriods;
            }
            set
            {
                this.OnSpecialDepreciationAllocationPeriodsChanging(value);
                this._SpecialDepreciationAllocationPeriods = value;
                this.OnSpecialDepreciationAllocationPeriodsChanged();
                this.OnPropertyChanged("SpecialDepreciationAllocationPeriods");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _SpecialDepreciationAllocationPeriods;
        partial void OnSpecialDepreciationAllocationPeriodsChanging(int value);
        partial void OnSpecialDepreciationAllocationPeriodsChanged();
        /// <summary>
        /// There are no comments for Property ExtraordinaryDepreciationProfileId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ExtraordinaryDepreciationProfileId
        {
            get
            {
                return this._ExtraordinaryDepreciationProfileId;
            }
            set
            {
                this.OnExtraordinaryDepreciationProfileIdChanging(value);
                this._ExtraordinaryDepreciationProfileId = value;
                this.OnExtraordinaryDepreciationProfileIdChanged();
                this.OnPropertyChanged("ExtraordinaryDepreciationProfileId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExtraordinaryDepreciationProfileId;
        partial void OnExtraordinaryDepreciationProfileIdChanging(string value);
        partial void OnExtraordinaryDepreciationProfileIdChanged();
        /// <summary>
        /// There are no comments for Property ServiceLifeMonths in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int ServiceLifeMonths
        {
            get
            {
                return this._ServiceLifeMonths;
            }
            set
            {
                this.OnServiceLifeMonthsChanging(value);
                this._ServiceLifeMonths = value;
                this.OnServiceLifeMonthsChanged();
                this.OnPropertyChanged("ServiceLifeMonths");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ServiceLifeMonths;
        partial void OnServiceLifeMonthsChanging(int value);
        partial void OnServiceLifeMonthsChanged();
        /// <summary>
        /// There are no comments for Property SpecialDepreciationAllocationStartConvention in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetSpecialDepAllocationConvention_JP> SpecialDepreciationAllocationStartConvention
        {
            get
            {
                return this._SpecialDepreciationAllocationStartConvention;
            }
            set
            {
                this.OnSpecialDepreciationAllocationStartConventionChanging(value);
                this._SpecialDepreciationAllocationStartConvention = value;
                this.OnSpecialDepreciationAllocationStartConventionChanged();
                this.OnPropertyChanged("SpecialDepreciationAllocationStartConvention");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetSpecialDepAllocationConvention_JP> _SpecialDepreciationAllocationStartConvention;
        partial void OnSpecialDepreciationAllocationStartConventionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetSpecialDepAllocationConvention_JP> value);
        partial void OnSpecialDepreciationAllocationStartConventionChanged();
        /// <summary>
        /// There are no comments for Property SpecialDepreciationAllocationUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetAccrualFiscal> SpecialDepreciationAllocationUnit
        {
            get
            {
                return this._SpecialDepreciationAllocationUnit;
            }
            set
            {
                this.OnSpecialDepreciationAllocationUnitChanging(value);
                this._SpecialDepreciationAllocationUnit = value;
                this.OnSpecialDepreciationAllocationUnitChanged();
                this.OnPropertyChanged("SpecialDepreciationAllocationUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetAccrualFiscal> _SpecialDepreciationAllocationUnit;
        partial void OnSpecialDepreciationAllocationUnitChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetAccrualFiscal> value);
        partial void OnSpecialDepreciationAllocationUnitChanged();
        /// <summary>
        /// There are no comments for Property DepreciationProfileId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DepreciationProfileId
        {
            get
            {
                return this._DepreciationProfileId;
            }
            set
            {
                this.OnDepreciationProfileIdChanging(value);
                this._DepreciationProfileId = value;
                this.OnDepreciationProfileIdChanged();
                this.OnPropertyChanged("DepreciationProfileId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DepreciationProfileId;
        partial void OnDepreciationProfileIdChanging(string value);
        partial void OnDepreciationProfileIdChanged();
        /// <summary>
        /// There are no comments for Property AcceleratedDepreciationProfileId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AcceleratedDepreciationProfileId
        {
            get
            {
                return this._AcceleratedDepreciationProfileId;
            }
            set
            {
                this.OnAcceleratedDepreciationProfileIdChanging(value);
                this._AcceleratedDepreciationProfileId = value;
                this.OnAcceleratedDepreciationProfileIdChanged();
                this.OnPropertyChanged("AcceleratedDepreciationProfileId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AcceleratedDepreciationProfileId;
        partial void OnAcceleratedDepreciationProfileIdChanging(string value);
        partial void OnAcceleratedDepreciationProfileIdChanged();
        /// <summary>
        /// There are no comments for Property DepreciationPeriods in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int DepreciationPeriods
        {
            get
            {
                return this._DepreciationPeriods;
            }
            set
            {
                this.OnDepreciationPeriodsChanging(value);
                this._DepreciationPeriods = value;
                this.OnDepreciationPeriodsChanged();
                this.OnPropertyChanged("DepreciationPeriods");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _DepreciationPeriods;
        partial void OnDepreciationPeriodsChanging(int value);
        partial void OnDepreciationPeriodsChanged();
        /// <summary>
        /// There are no comments for Property DepreciationGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DepreciationGroupId
        {
            get
            {
                return this._DepreciationGroupId;
            }
            set
            {
                this.OnDepreciationGroupIdChanging(value);
                this._DepreciationGroupId = value;
                this.OnDepreciationGroupIdChanged();
                this.OnPropertyChanged("DepreciationGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DepreciationGroupId;
        partial void OnDepreciationGroupIdChanging(string value);
        partial void OnDepreciationGroupIdChanged();
        /// <summary>
        /// There are no comments for Property AllowableLimitForAccumulatedDepreciation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetLimitForAccumulatedDepType_JP> AllowableLimitForAccumulatedDepreciation
        {
            get
            {
                return this._AllowableLimitForAccumulatedDepreciation;
            }
            set
            {
                this.OnAllowableLimitForAccumulatedDepreciationChanging(value);
                this._AllowableLimitForAccumulatedDepreciation = value;
                this.OnAllowableLimitForAccumulatedDepreciationChanged();
                this.OnPropertyChanged("AllowableLimitForAccumulatedDepreciation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetLimitForAccumulatedDepType_JP> _AllowableLimitForAccumulatedDepreciation;
        partial void OnAllowableLimitForAccumulatedDepreciationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetLimitForAccumulatedDepType_JP> value);
        partial void OnAllowableLimitForAccumulatedDepreciationChanged();
        /// <summary>
        /// There are no comments for Property IsAssetGroupDepreciation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsAssetGroupDepreciation
        {
            get
            {
                return this._IsAssetGroupDepreciation;
            }
            set
            {
                this.OnIsAssetGroupDepreciationChanging(value);
                this._IsAssetGroupDepreciation = value;
                this.OnIsAssetGroupDepreciationChanged();
                this.OnPropertyChanged("IsAssetGroupDepreciation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsAssetGroupDepreciation;
        partial void OnIsAssetGroupDepreciationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsAssetGroupDepreciationChanged();
        /// <summary>
        /// There are no comments for Property DepreciationConvention in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetDepreciationConvention> DepreciationConvention
        {
            get
            {
                return this._DepreciationConvention;
            }
            set
            {
                this.OnDepreciationConventionChanging(value);
                this._DepreciationConvention = value;
                this.OnDepreciationConventionChanged();
                this.OnPropertyChanged("DepreciationConvention");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetDepreciationConvention> _DepreciationConvention;
        partial void OnDepreciationConventionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetDepreciationConvention> value);
        partial void OnDepreciationConventionChanged();
        /// <summary>
        /// There are no comments for Property ServiceLifeYears in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int ServiceLifeYears
        {
            get
            {
                return this._ServiceLifeYears;
            }
            set
            {
                this.OnServiceLifeYearsChanging(value);
                this._ServiceLifeYears = value;
                this.OnServiceLifeYearsChanged();
                this.OnPropertyChanged("ServiceLifeYears");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ServiceLifeYears;
        partial void OnServiceLifeYearsChanging(int value);
        partial void OnServiceLifeYearsChanged();
        /// <summary>
        /// There are no comments for Property CalculateDepreciation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CalculateDepreciation
        {
            get
            {
                return this._CalculateDepreciation;
            }
            set
            {
                this.OnCalculateDepreciationChanging(value);
                this._CalculateDepreciation = value;
                this.OnCalculateDepreciationChanged();
                this.OnPropertyChanged("CalculateDepreciation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CalculateDepreciation;
        partial void OnCalculateDepreciationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCalculateDepreciationChanged();
        /// <summary>
        /// There are no comments for Property ServiceLife in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ServiceLife
        {
            get
            {
                return this._ServiceLife;
            }
            set
            {
                this.OnServiceLifeChanging(value);
                this._ServiceLife = value;
                this.OnServiceLifeChanged();
                this.OnPropertyChanged("ServiceLife");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ServiceLife;
        partial void OnServiceLifeChanging(decimal value);
        partial void OnServiceLifeChanged();
        /// <summary>
        /// There are no comments for Property AssetDepreciationProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DepreciationProfile AssetDepreciationProfile
        {
            get
            {
                return this._AssetDepreciationProfile;
            }
            set
            {
                this.OnAssetDepreciationProfileChanging(value);
                this._AssetDepreciationProfile = value;
                this.OnAssetDepreciationProfileChanged();
                this.OnPropertyChanged("AssetDepreciationProfile");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DepreciationProfile _AssetDepreciationProfile;
        partial void OnAssetDepreciationProfileChanging(global::Microsoft.Dynamics.DataEntities.DepreciationProfile value);
        partial void OnAssetDepreciationProfileChanged();
        /// <summary>
        /// There are no comments for Property AssetExtraordinaryDepreciationProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DepreciationProfile AssetExtraordinaryDepreciationProfile
        {
            get
            {
                return this._AssetExtraordinaryDepreciationProfile;
            }
            set
            {
                this.OnAssetExtraordinaryDepreciationProfileChanging(value);
                this._AssetExtraordinaryDepreciationProfile = value;
                this.OnAssetExtraordinaryDepreciationProfileChanged();
                this.OnPropertyChanged("AssetExtraordinaryDepreciationProfile");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DepreciationProfile _AssetExtraordinaryDepreciationProfile;
        partial void OnAssetExtraordinaryDepreciationProfileChanging(global::Microsoft.Dynamics.DataEntities.DepreciationProfile value);
        partial void OnAssetExtraordinaryDepreciationProfileChanged();
        /// <summary>
        /// There are no comments for Property AssetAlternativeDepreciationProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DepreciationProfile AssetAlternativeDepreciationProfile
        {
            get
            {
                return this._AssetAlternativeDepreciationProfile;
            }
            set
            {
                this.OnAssetAlternativeDepreciationProfileChanging(value);
                this._AssetAlternativeDepreciationProfile = value;
                this.OnAssetAlternativeDepreciationProfileChanged();
                this.OnPropertyChanged("AssetAlternativeDepreciationProfile");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DepreciationProfile _AssetAlternativeDepreciationProfile;
        partial void OnAssetAlternativeDepreciationProfileChanging(global::Microsoft.Dynamics.DataEntities.DepreciationProfile value);
        partial void OnAssetAlternativeDepreciationProfileChanged();
        /// <summary>
        /// There are no comments for Property AssetAcceleratedDepreciationProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DepreciationProfile AssetAcceleratedDepreciationProfile
        {
            get
            {
                return this._AssetAcceleratedDepreciationProfile;
            }
            set
            {
                this.OnAssetAcceleratedDepreciationProfileChanging(value);
                this._AssetAcceleratedDepreciationProfile = value;
                this.OnAssetAcceleratedDepreciationProfileChanged();
                this.OnPropertyChanged("AssetAcceleratedDepreciationProfile");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DepreciationProfile _AssetAcceleratedDepreciationProfile;
        partial void OnAssetAcceleratedDepreciationProfileChanging(global::Microsoft.Dynamics.DataEntities.DepreciationProfile value);
        partial void OnAssetAcceleratedDepreciationProfileChanged();
        /// <summary>
        /// There are no comments for Property AssetGroupValueModelSetupValueModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ValueModelSetup AssetGroupValueModelSetupValueModel
        {
            get
            {
                return this._AssetGroupValueModelSetupValueModel;
            }
            set
            {
                this.OnAssetGroupValueModelSetupValueModelChanging(value);
                this._AssetGroupValueModelSetupValueModel = value;
                this.OnAssetGroupValueModelSetupValueModelChanged();
                this.OnPropertyChanged("AssetGroupValueModelSetupValueModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ValueModelSetup _AssetGroupValueModelSetupValueModel;
        partial void OnAssetGroupValueModelSetupValueModelChanging(global::Microsoft.Dynamics.DataEntities.ValueModelSetup value);
        partial void OnAssetGroupValueModelSetupValueModelChanged();
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