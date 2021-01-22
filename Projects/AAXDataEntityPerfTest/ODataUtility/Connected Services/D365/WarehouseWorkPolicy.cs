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
        /// There are no comments for WarehouseWorkPolicySingle in the schema.
        /// </summary>
    public partial class WarehouseWorkPolicySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseWorkPolicy>
    {
        /// <summary>
        /// Initialize a new WarehouseWorkPolicySingle object.
        /// </summary>
        public WarehouseWorkPolicySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WarehouseWorkPolicySingle object.
        /// </summary>
        public WarehouseWorkPolicySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WarehouseWorkPolicySingle object.
        /// </summary>
        public WarehouseWorkPolicySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseWorkPolicy> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for WarehouseWorkPolicyProducts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicyProduct> WarehouseWorkPolicyProducts
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WarehouseWorkPolicyProducts == null))
                {
                    this._WarehouseWorkPolicyProducts = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicyProduct>(GetPath("WarehouseWorkPolicyProducts"));
                }
                return this._WarehouseWorkPolicyProducts;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicyProduct> _WarehouseWorkPolicyProducts;
        /// <summary>
        /// There are no comments for WarehouseWorkCreationRulesV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseWorkCreationRuleV2> WarehouseWorkCreationRulesV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WarehouseWorkCreationRulesV2 == null))
                {
                    this._WarehouseWorkCreationRulesV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WarehouseWorkCreationRuleV2>(GetPath("WarehouseWorkCreationRulesV2"));
                }
                return this._WarehouseWorkCreationRulesV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseWorkCreationRuleV2> _WarehouseWorkCreationRulesV2;
        /// <summary>
        /// There are no comments for WarehouseWorkCreationRules in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseWorkCreationRule> WarehouseWorkCreationRules
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WarehouseWorkCreationRules == null))
                {
                    this._WarehouseWorkCreationRules = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WarehouseWorkCreationRule>(GetPath("WarehouseWorkCreationRules"));
                }
                return this._WarehouseWorkCreationRules;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseWorkCreationRule> _WarehouseWorkCreationRules;
        /// <summary>
        /// There are no comments for WarehouseWorkPolicyLocations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicyLocation> WarehouseWorkPolicyLocations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WarehouseWorkPolicyLocations == null))
                {
                    this._WarehouseWorkPolicyLocations = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicyLocation>(GetPath("WarehouseWorkPolicyLocations"));
                }
                return this._WarehouseWorkPolicyLocations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicyLocation> _WarehouseWorkPolicyLocations;
    }
        /// <summary>
        /// There are no comments for WarehouseWorkPolicy in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Name")]
    [global::Microsoft.OData.Client.EntitySet("WarehouseWorkPolicies")]
    public partial class WarehouseWorkPolicy : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WarehouseWorkPolicy object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="name">Initial value of Name.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WarehouseWorkPolicy CreateWarehouseWorkPolicy(string dataAreaId, string name)
        {
            WarehouseWorkPolicy warehouseWorkPolicy = new WarehouseWorkPolicy();
            warehouseWorkPolicy.dataAreaId = dataAreaId;
            warehouseWorkPolicy.Name = name;
            return warehouseWorkPolicy;
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
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property WarehouseWorkPolicyProducts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicyProduct> WarehouseWorkPolicyProducts
        {
            get
            {
                return this._WarehouseWorkPolicyProducts;
            }
            set
            {
                this.OnWarehouseWorkPolicyProductsChanging(value);
                this._WarehouseWorkPolicyProducts = value;
                this.OnWarehouseWorkPolicyProductsChanged();
                this.OnPropertyChanged("WarehouseWorkPolicyProducts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicyProduct> _WarehouseWorkPolicyProducts = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicyProduct>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWarehouseWorkPolicyProductsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicyProduct> value);
        partial void OnWarehouseWorkPolicyProductsChanged();
        /// <summary>
        /// There are no comments for Property WarehouseWorkCreationRulesV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseWorkCreationRuleV2> WarehouseWorkCreationRulesV2
        {
            get
            {
                return this._WarehouseWorkCreationRulesV2;
            }
            set
            {
                this.OnWarehouseWorkCreationRulesV2Changing(value);
                this._WarehouseWorkCreationRulesV2 = value;
                this.OnWarehouseWorkCreationRulesV2Changed();
                this.OnPropertyChanged("WarehouseWorkCreationRulesV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseWorkCreationRuleV2> _WarehouseWorkCreationRulesV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseWorkCreationRuleV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWarehouseWorkCreationRulesV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseWorkCreationRuleV2> value);
        partial void OnWarehouseWorkCreationRulesV2Changed();
        /// <summary>
        /// There are no comments for Property WarehouseWorkCreationRules in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseWorkCreationRule> WarehouseWorkCreationRules
        {
            get
            {
                return this._WarehouseWorkCreationRules;
            }
            set
            {
                this.OnWarehouseWorkCreationRulesChanging(value);
                this._WarehouseWorkCreationRules = value;
                this.OnWarehouseWorkCreationRulesChanged();
                this.OnPropertyChanged("WarehouseWorkCreationRules");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseWorkCreationRule> _WarehouseWorkCreationRules = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseWorkCreationRule>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWarehouseWorkCreationRulesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseWorkCreationRule> value);
        partial void OnWarehouseWorkCreationRulesChanged();
        /// <summary>
        /// There are no comments for Property WarehouseWorkPolicyLocations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicyLocation> WarehouseWorkPolicyLocations
        {
            get
            {
                return this._WarehouseWorkPolicyLocations;
            }
            set
            {
                this.OnWarehouseWorkPolicyLocationsChanging(value);
                this._WarehouseWorkPolicyLocations = value;
                this.OnWarehouseWorkPolicyLocationsChanged();
                this.OnPropertyChanged("WarehouseWorkPolicyLocations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicyLocation> _WarehouseWorkPolicyLocations = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicyLocation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWarehouseWorkPolicyLocationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicyLocation> value);
        partial void OnWarehouseWorkPolicyLocationsChanged();
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
