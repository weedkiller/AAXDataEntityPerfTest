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
        /// There are no comments for WarehouseWorkPolicyProductSingle in the schema.
        /// </summary>
    public partial class WarehouseWorkPolicyProductSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseWorkPolicyProduct>
    {
        /// <summary>
        /// Initialize a new WarehouseWorkPolicyProductSingle object.
        /// </summary>
        public WarehouseWorkPolicyProductSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WarehouseWorkPolicyProductSingle object.
        /// </summary>
        public WarehouseWorkPolicyProductSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WarehouseWorkPolicyProductSingle object.
        /// </summary>
        public WarehouseWorkPolicyProductSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseWorkPolicyProduct> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReleasedProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single ReleasedProduct
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProduct == null))
                {
                    this._ReleasedProduct = new global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single(this.Context, GetPath("ReleasedProduct"));
                }
                return this._ReleasedProduct;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single _ReleasedProduct;
        /// <summary>
        /// There are no comments for WarehouseWorkPolicy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicySingle WarehouseWorkPolicy
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WarehouseWorkPolicy == null))
                {
                    this._WarehouseWorkPolicy = new global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicySingle(this.Context, GetPath("WarehouseWorkPolicy"));
                }
                return this._WarehouseWorkPolicy;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicySingle _WarehouseWorkPolicy;
    }
        /// <summary>
        /// There are no comments for WarehouseWorkPolicyProduct in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// WorkPolicyName
    /// ItemNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "WorkPolicyName", "ItemNumber")]
    [global::Microsoft.OData.Client.EntitySet("WarehouseWorkPolicyProducts")]
    public partial class WarehouseWorkPolicyProduct : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WarehouseWorkPolicyProduct object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="workPolicyName">Initial value of WorkPolicyName.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="releasedProduct">Initial value of ReleasedProduct.</param>
        /// <param name="warehouseWorkPolicy">Initial value of WarehouseWorkPolicy.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WarehouseWorkPolicyProduct CreateWarehouseWorkPolicyProduct(string dataAreaId, string workPolicyName, string itemNumber, global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 releasedProduct, global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicy warehouseWorkPolicy)
        {
            WarehouseWorkPolicyProduct warehouseWorkPolicyProduct = new WarehouseWorkPolicyProduct();
            warehouseWorkPolicyProduct.dataAreaId = dataAreaId;
            warehouseWorkPolicyProduct.WorkPolicyName = workPolicyName;
            warehouseWorkPolicyProduct.ItemNumber = itemNumber;
            if ((releasedProduct == null))
            {
                throw new global::System.ArgumentNullException("releasedProduct");
            }
            warehouseWorkPolicyProduct.ReleasedProduct = releasedProduct;
            if ((warehouseWorkPolicy == null))
            {
                throw new global::System.ArgumentNullException("warehouseWorkPolicy");
            }
            warehouseWorkPolicyProduct.WarehouseWorkPolicy = warehouseWorkPolicy;
            return warehouseWorkPolicyProduct;
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
        /// There are no comments for Property WorkPolicyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkPolicyName
        {
            get
            {
                return this._WorkPolicyName;
            }
            set
            {
                this.OnWorkPolicyNameChanging(value);
                this._WorkPolicyName = value;
                this.OnWorkPolicyNameChanged();
                this.OnPropertyChanged("WorkPolicyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkPolicyName;
        partial void OnWorkPolicyNameChanging(string value);
        partial void OnWorkPolicyNameChanged();
        /// <summary>
        /// There are no comments for Property ItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ItemNumber
        {
            get
            {
                return this._ItemNumber;
            }
            set
            {
                this.OnItemNumberChanging(value);
                this._ItemNumber = value;
                this.OnItemNumberChanged();
                this.OnPropertyChanged("ItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemNumber;
        partial void OnItemNumberChanging(string value);
        partial void OnItemNumberChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 ReleasedProduct
        {
            get
            {
                return this._ReleasedProduct;
            }
            set
            {
                this.OnReleasedProductChanging(value);
                this._ReleasedProduct = value;
                this.OnReleasedProductChanged();
                this.OnPropertyChanged("ReleasedProduct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 _ReleasedProduct;
        partial void OnReleasedProductChanging(global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 value);
        partial void OnReleasedProductChanged();
        /// <summary>
        /// There are no comments for Property WarehouseWorkPolicy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicy WarehouseWorkPolicy
        {
            get
            {
                return this._WarehouseWorkPolicy;
            }
            set
            {
                this.OnWarehouseWorkPolicyChanging(value);
                this._WarehouseWorkPolicy = value;
                this.OnWarehouseWorkPolicyChanged();
                this.OnPropertyChanged("WarehouseWorkPolicy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicy _WarehouseWorkPolicy;
        partial void OnWarehouseWorkPolicyChanging(global::Microsoft.Dynamics.DataEntities.WarehouseWorkPolicy value);
        partial void OnWarehouseWorkPolicyChanged();
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
