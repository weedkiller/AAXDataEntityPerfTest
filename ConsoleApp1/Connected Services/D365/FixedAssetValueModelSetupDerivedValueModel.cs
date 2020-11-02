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
    /// There are no comments for FixedAssetValueModelSetupDerivedValueModelSingle in the schema.
    /// </summary>
    public partial class FixedAssetValueModelSetupDerivedValueModelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FixedAssetValueModelSetupDerivedValueModel>
    {
        /// <summary>
        /// Initialize a new FixedAssetValueModelSetupDerivedValueModelSingle object.
        /// </summary>
        public FixedAssetValueModelSetupDerivedValueModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FixedAssetValueModelSetupDerivedValueModelSingle object.
        /// </summary>
        public FixedAssetValueModelSetupDerivedValueModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FixedAssetValueModelSetupDerivedValueModelSingle object.
        /// </summary>
        public FixedAssetValueModelSetupDerivedValueModelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FixedAssetValueModelSetupDerivedValueModel> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ValueModelSetupDerivedValueModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ValueModelSetupSingle ValueModelSetupDerivedValueModel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ValueModelSetupDerivedValueModel == null))
                {
                    this._ValueModelSetupDerivedValueModel = new global::Microsoft.Dynamics.DataEntities.ValueModelSetupSingle(this.Context, GetPath("ValueModelSetupDerivedValueModel"));
                }
                return this._ValueModelSetupDerivedValueModel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ValueModelSetupSingle _ValueModelSetupDerivedValueModel;
        /// <summary>
        /// There are no comments for ValueModelSetupValueModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ValueModelSetupSingle ValueModelSetupValueModel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ValueModelSetupValueModel == null))
                {
                    this._ValueModelSetupValueModel = new global::Microsoft.Dynamics.DataEntities.ValueModelSetupSingle(this.Context, GetPath("ValueModelSetupValueModel"));
                }
                return this._ValueModelSetupValueModel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ValueModelSetupSingle _ValueModelSetupValueModel;
    }
    /// <summary>
    /// There are no comments for FixedAssetValueModelSetupDerivedValueModel in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ValueModelId
    /// DerivedValueModelId
    /// TransactionType
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ValueModelId", "DerivedValueModelId", "TransactionType")]
    [global::Microsoft.OData.Client.EntitySet("FixedAssetValueModelSetupDerivedValueModels")]
    public partial class FixedAssetValueModelSetupDerivedValueModel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FixedAssetValueModelSetupDerivedValueModel object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="valueModelId">Initial value of ValueModelId.</param>
        /// <param name="derivedValueModelId">Initial value of DerivedValueModelId.</param>
        /// <param name="valueModelSetupValueModel">Initial value of ValueModelSetupValueModel.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FixedAssetValueModelSetupDerivedValueModel CreateFixedAssetValueModelSetupDerivedValueModel(string dataAreaId, string valueModelId, string derivedValueModelId, global::Microsoft.Dynamics.DataEntities.ValueModelSetup valueModelSetupValueModel)
        {
            FixedAssetValueModelSetupDerivedValueModel fixedAssetValueModelSetupDerivedValueModel = new FixedAssetValueModelSetupDerivedValueModel();
            fixedAssetValueModelSetupDerivedValueModel.dataAreaId = dataAreaId;
            fixedAssetValueModelSetupDerivedValueModel.ValueModelId = valueModelId;
            fixedAssetValueModelSetupDerivedValueModel.DerivedValueModelId = derivedValueModelId;
            if ((valueModelSetupValueModel == null))
            {
                throw new global::System.ArgumentNullException("valueModelSetupValueModel");
            }
            fixedAssetValueModelSetupDerivedValueModel.ValueModelSetupValueModel = valueModelSetupValueModel;
            return fixedAssetValueModelSetupDerivedValueModel;
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
        /// There are no comments for Property DerivedValueModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DerivedValueModelId
        {
            get
            {
                return this._DerivedValueModelId;
            }
            set
            {
                this.OnDerivedValueModelIdChanging(value);
                this._DerivedValueModelId = value;
                this.OnDerivedValueModelIdChanged();
                this.OnPropertyChanged("DerivedValueModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DerivedValueModelId;
        partial void OnDerivedValueModelIdChanging(string value);
        partial void OnDerivedValueModelIdChanged();
        /// <summary>
        /// There are no comments for Property TransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetTransType> TransactionType
        {
            get
            {
                return this._TransactionType;
            }
            set
            {
                this.OnTransactionTypeChanging(value);
                this._TransactionType = value;
                this.OnTransactionTypeChanged();
                this.OnPropertyChanged("TransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetTransType> _TransactionType;
        partial void OnTransactionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetTransType> value);
        partial void OnTransactionTypeChanged();
        /// <summary>
        /// There are no comments for Property ValueModelSetupDerivedValueModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ValueModelSetup ValueModelSetupDerivedValueModel
        {
            get
            {
                return this._ValueModelSetupDerivedValueModel;
            }
            set
            {
                this.OnValueModelSetupDerivedValueModelChanging(value);
                this._ValueModelSetupDerivedValueModel = value;
                this.OnValueModelSetupDerivedValueModelChanged();
                this.OnPropertyChanged("ValueModelSetupDerivedValueModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ValueModelSetup _ValueModelSetupDerivedValueModel;
        partial void OnValueModelSetupDerivedValueModelChanging(global::Microsoft.Dynamics.DataEntities.ValueModelSetup value);
        partial void OnValueModelSetupDerivedValueModelChanged();
        /// <summary>
        /// There are no comments for Property ValueModelSetupValueModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ValueModelSetup ValueModelSetupValueModel
        {
            get
            {
                return this._ValueModelSetupValueModel;
            }
            set
            {
                this.OnValueModelSetupValueModelChanging(value);
                this._ValueModelSetupValueModel = value;
                this.OnValueModelSetupValueModelChanged();
                this.OnPropertyChanged("ValueModelSetupValueModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ValueModelSetup _ValueModelSetupValueModel;
        partial void OnValueModelSetupValueModelChanging(global::Microsoft.Dynamics.DataEntities.ValueModelSetup value);
        partial void OnValueModelSetupValueModelChanged();
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
