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
        /// There are no comments for ProductCategoryHierarchyRoleSingle in the schema.
        /// </summary>
    public partial class ProductCategoryHierarchyRoleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductCategoryHierarchyRole>
    {
        /// <summary>
        /// Initialize a new ProductCategoryHierarchyRoleSingle object.
        /// </summary>
        public ProductCategoryHierarchyRoleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductCategoryHierarchyRoleSingle object.
        /// </summary>
        public ProductCategoryHierarchyRoleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductCategoryHierarchyRoleSingle object.
        /// </summary>
        public ProductCategoryHierarchyRoleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductCategoryHierarchyRole> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductCategoryHierarchy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductCategoryHierarchySingle ProductCategoryHierarchy
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductCategoryHierarchy == null))
                {
                    this._ProductCategoryHierarchy = new global::Microsoft.Dynamics.DataEntities.ProductCategoryHierarchySingle(this.Context, GetPath("ProductCategoryHierarchy"));
                }
                return this._ProductCategoryHierarchy;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductCategoryHierarchySingle _ProductCategoryHierarchy;
    }
        /// <summary>
        /// There are no comments for ProductCategoryHierarchyRole in the schema.
        /// </summary>
    /// <KeyProperties>
    /// HierarchyRole
    /// ProductCategoryHierarchyName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("HierarchyRole", "ProductCategoryHierarchyName")]
    [global::Microsoft.OData.Client.EntitySet("ProductCategoryHierarchyRoles")]
    public partial class ProductCategoryHierarchyRole : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductCategoryHierarchyRole object.
        /// </summary>
        /// <param name="productCategoryHierarchyName">Initial value of ProductCategoryHierarchyName.</param>
        /// <param name="productCategoryHierarchy">Initial value of ProductCategoryHierarchy.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductCategoryHierarchyRole CreateProductCategoryHierarchyRole(string productCategoryHierarchyName, global::Microsoft.Dynamics.DataEntities.ProductCategoryHierarchy productCategoryHierarchy)
        {
            ProductCategoryHierarchyRole productCategoryHierarchyRole = new ProductCategoryHierarchyRole();
            productCategoryHierarchyRole.ProductCategoryHierarchyName = productCategoryHierarchyName;
            if ((productCategoryHierarchy == null))
            {
                throw new global::System.ArgumentNullException("productCategoryHierarchy");
            }
            productCategoryHierarchyRole.ProductCategoryHierarchy = productCategoryHierarchy;
            return productCategoryHierarchyRole;
        }
        /// <summary>
        /// There are no comments for Property HierarchyRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EcoResCategoryNamedHierarchyRole> HierarchyRole
        {
            get
            {
                return this._HierarchyRole;
            }
            set
            {
                this.OnHierarchyRoleChanging(value);
                this._HierarchyRole = value;
                this.OnHierarchyRoleChanged();
                this.OnPropertyChanged("HierarchyRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EcoResCategoryNamedHierarchyRole> _HierarchyRole;
        partial void OnHierarchyRoleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EcoResCategoryNamedHierarchyRole> value);
        partial void OnHierarchyRoleChanged();
        /// <summary>
        /// There are no comments for Property ProductCategoryHierarchyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductCategoryHierarchyName
        {
            get
            {
                return this._ProductCategoryHierarchyName;
            }
            set
            {
                this.OnProductCategoryHierarchyNameChanging(value);
                this._ProductCategoryHierarchyName = value;
                this.OnProductCategoryHierarchyNameChanged();
                this.OnPropertyChanged("ProductCategoryHierarchyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductCategoryHierarchyName;
        partial void OnProductCategoryHierarchyNameChanging(string value);
        partial void OnProductCategoryHierarchyNameChanged();
        /// <summary>
        /// There are no comments for Property ProductCategoryHierarchy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductCategoryHierarchy ProductCategoryHierarchy
        {
            get
            {
                return this._ProductCategoryHierarchy;
            }
            set
            {
                this.OnProductCategoryHierarchyChanging(value);
                this._ProductCategoryHierarchy = value;
                this.OnProductCategoryHierarchyChanged();
                this.OnPropertyChanged("ProductCategoryHierarchy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductCategoryHierarchy _ProductCategoryHierarchy;
        partial void OnProductCategoryHierarchyChanging(global::Microsoft.Dynamics.DataEntities.ProductCategoryHierarchy value);
        partial void OnProductCategoryHierarchyChanged();
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
