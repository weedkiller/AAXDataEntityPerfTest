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
    /// There are no comments for AssetSpecialDepreciationAllowanceSingle in the schema.
    /// </summary>
    public partial class AssetSpecialDepreciationAllowanceSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetSpecialDepreciationAllowance>
    {
        /// <summary>
        /// Initialize a new AssetSpecialDepreciationAllowanceSingle object.
        /// </summary>
        public AssetSpecialDepreciationAllowanceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetSpecialDepreciationAllowanceSingle object.
        /// </summary>
        public AssetSpecialDepreciationAllowanceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetSpecialDepreciationAllowanceSingle object.
        /// </summary>
        public AssetSpecialDepreciationAllowanceSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetSpecialDepreciationAllowance> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for FixedAssetGroupBookSpecialDepreciationAllowance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetGroupBookSpecialDepreciationAllowance> FixedAssetGroupBookSpecialDepreciationAllowance
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FixedAssetGroupBookSpecialDepreciationAllowance == null))
                {
                    this._FixedAssetGroupBookSpecialDepreciationAllowance = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetGroupBookSpecialDepreciationAllowance>(GetPath("FixedAssetGroupBookSpecialDepreciationAllowance"));
                }
                return this._FixedAssetGroupBookSpecialDepreciationAllowance;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetGroupBookSpecialDepreciationAllowance> _FixedAssetGroupBookSpecialDepreciationAllowance;
        /// <summary>
        /// There are no comments for FixedAssetBookSpecialDepreciationAllowance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetBookSpecialDepreciationAllowance> FixedAssetBookSpecialDepreciationAllowance
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FixedAssetBookSpecialDepreciationAllowance == null))
                {
                    this._FixedAssetBookSpecialDepreciationAllowance = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetBookSpecialDepreciationAllowance>(GetPath("FixedAssetBookSpecialDepreciationAllowance"));
                }
                return this._FixedAssetBookSpecialDepreciationAllowance;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FixedAssetBookSpecialDepreciationAllowance> _FixedAssetBookSpecialDepreciationAllowance;
    }
    /// <summary>
    /// There are no comments for AssetSpecialDepreciationAllowance in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// SpecialDepreciationAllowanceId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "SpecialDepreciationAllowanceId")]
    [global::Microsoft.OData.Client.EntitySet("AssetSpecialDepreciationAllowances")]
    public partial class AssetSpecialDepreciationAllowance : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetSpecialDepreciationAllowance object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="specialDepreciationAllowanceId">Initial value of SpecialDepreciationAllowanceId.</param>
        /// <param name="percentage">Initial value of Percentage.</param>
        /// <param name="amount">Initial value of Amount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetSpecialDepreciationAllowance CreateAssetSpecialDepreciationAllowance(string dataAreaId, string specialDepreciationAllowanceId, decimal percentage, decimal amount)
        {
            AssetSpecialDepreciationAllowance assetSpecialDepreciationAllowance = new AssetSpecialDepreciationAllowance();
            assetSpecialDepreciationAllowance.dataAreaId = dataAreaId;
            assetSpecialDepreciationAllowance.SpecialDepreciationAllowanceId = specialDepreciationAllowanceId;
            assetSpecialDepreciationAllowance.Percentage = percentage;
            assetSpecialDepreciationAllowance.Amount = amount;
            return assetSpecialDepreciationAllowance;
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
        /// There are no comments for Property SpecialDepreciationAllowanceId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SpecialDepreciationAllowanceId
        {
            get
            {
                return this._SpecialDepreciationAllowanceId;
            }
            set
            {
                this.OnSpecialDepreciationAllowanceIdChanging(value);
                this._SpecialDepreciationAllowanceId = value;
                this.OnSpecialDepreciationAllowanceIdChanged();
                this.OnPropertyChanged("SpecialDepreciationAllowanceId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SpecialDepreciationAllowanceId;
        partial void OnSpecialDepreciationAllowanceIdChanging(string value);
        partial void OnSpecialDepreciationAllowanceIdChanged();
        /// <summary>
        /// There are no comments for Property Percentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Percentage
        {
            get
            {
                return this._Percentage;
            }
            set
            {
                this.OnPercentageChanging(value);
                this._Percentage = value;
                this.OnPercentageChanged();
                this.OnPropertyChanged("Percentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Percentage;
        partial void OnPercentageChanging(decimal value);
        partial void OnPercentageChanged();
        /// <summary>
        /// There are no comments for Property Amount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this.OnAmountChanging(value);
                this._Amount = value;
                this.OnAmountChanged();
                this.OnPropertyChanged("Amount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Amount;
        partial void OnAmountChanging(decimal value);
        partial void OnAmountChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property FixedAssetGroupBookSpecialDepreciationAllowance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetGroupBookSpecialDepreciationAllowance> FixedAssetGroupBookSpecialDepreciationAllowance
        {
            get
            {
                return this._FixedAssetGroupBookSpecialDepreciationAllowance;
            }
            set
            {
                this.OnFixedAssetGroupBookSpecialDepreciationAllowanceChanging(value);
                this._FixedAssetGroupBookSpecialDepreciationAllowance = value;
                this.OnFixedAssetGroupBookSpecialDepreciationAllowanceChanged();
                this.OnPropertyChanged("FixedAssetGroupBookSpecialDepreciationAllowance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetGroupBookSpecialDepreciationAllowance> _FixedAssetGroupBookSpecialDepreciationAllowance = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetGroupBookSpecialDepreciationAllowance>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnFixedAssetGroupBookSpecialDepreciationAllowanceChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetGroupBookSpecialDepreciationAllowance> value);
        partial void OnFixedAssetGroupBookSpecialDepreciationAllowanceChanged();
        /// <summary>
        /// There are no comments for Property FixedAssetBookSpecialDepreciationAllowance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetBookSpecialDepreciationAllowance> FixedAssetBookSpecialDepreciationAllowance
        {
            get
            {
                return this._FixedAssetBookSpecialDepreciationAllowance;
            }
            set
            {
                this.OnFixedAssetBookSpecialDepreciationAllowanceChanging(value);
                this._FixedAssetBookSpecialDepreciationAllowance = value;
                this.OnFixedAssetBookSpecialDepreciationAllowanceChanged();
                this.OnPropertyChanged("FixedAssetBookSpecialDepreciationAllowance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetBookSpecialDepreciationAllowance> _FixedAssetBookSpecialDepreciationAllowance = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetBookSpecialDepreciationAllowance>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnFixedAssetBookSpecialDepreciationAllowanceChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FixedAssetBookSpecialDepreciationAllowance> value);
        partial void OnFixedAssetBookSpecialDepreciationAllowanceChanged();
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
