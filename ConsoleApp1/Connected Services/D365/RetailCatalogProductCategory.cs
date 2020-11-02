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
    /// There are no comments for RetailCatalogProductCategorySingle in the schema.
    /// </summary>
    public partial class RetailCatalogProductCategorySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailCatalogProductCategory>
    {
        /// <summary>
        /// Initialize a new RetailCatalogProductCategorySingle object.
        /// </summary>
        public RetailCatalogProductCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailCatalogProductCategorySingle object.
        /// </summary>
        public RetailCatalogProductCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailCatalogProductCategorySingle object.
        /// </summary>
        public RetailCatalogProductCategorySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailCatalogProductCategory> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailCatalogProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCatalogProductSingle RetailCatalogProduct
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailCatalogProduct == null))
                {
                    this._RetailCatalogProduct = new global::Microsoft.Dynamics.DataEntities.RetailCatalogProductSingle(this.Context, GetPath("RetailCatalogProduct"));
                }
                return this._RetailCatalogProduct;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCatalogProductSingle _RetailCatalogProduct;
        /// <summary>
        /// There are no comments for ProductCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductCategorySingle ProductCategory
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductCategory == null))
                {
                    this._ProductCategory = new global::Microsoft.Dynamics.DataEntities.ProductCategorySingle(this.Context, GetPath("ProductCategory"));
                }
                return this._ProductCategory;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductCategorySingle _ProductCategory;
    }
    /// <summary>
    /// There are no comments for RetailCatalogProductCategory in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CatalogNumber
    /// DisplayProductNumber
    /// CategoryName
    /// CategoryHierarchyName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CatalogNumber", "DisplayProductNumber", "CategoryName", "CategoryHierarchyName")]
    [global::Microsoft.OData.Client.EntitySet("RetailCatalogProductCategories")]
    public partial class RetailCatalogProductCategory : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailCatalogProductCategory object.
        /// </summary>
        /// <param name="catalogNumber">Initial value of CatalogNumber.</param>
        /// <param name="displayProductNumber">Initial value of DisplayProductNumber.</param>
        /// <param name="categoryName">Initial value of CategoryName.</param>
        /// <param name="categoryHierarchyName">Initial value of CategoryHierarchyName.</param>
        /// <param name="retailCatalogProduct">Initial value of RetailCatalogProduct.</param>
        /// <param name="productCategory">Initial value of ProductCategory.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailCatalogProductCategory CreateRetailCatalogProductCategory(string catalogNumber, 
                    string displayProductNumber, 
                    string categoryName, 
                    string categoryHierarchyName, 
                    global::Microsoft.Dynamics.DataEntities.RetailCatalogProduct retailCatalogProduct, 
                    global::Microsoft.Dynamics.DataEntities.ProductCategory productCategory)
        {
            RetailCatalogProductCategory retailCatalogProductCategory = new RetailCatalogProductCategory();
            retailCatalogProductCategory.CatalogNumber = catalogNumber;
            retailCatalogProductCategory.DisplayProductNumber = displayProductNumber;
            retailCatalogProductCategory.CategoryName = categoryName;
            retailCatalogProductCategory.CategoryHierarchyName = categoryHierarchyName;
            if ((retailCatalogProduct == null))
            {
                throw new global::System.ArgumentNullException("retailCatalogProduct");
            }
            retailCatalogProductCategory.RetailCatalogProduct = retailCatalogProduct;
            if ((productCategory == null))
            {
                throw new global::System.ArgumentNullException("productCategory");
            }
            retailCatalogProductCategory.ProductCategory = productCategory;
            return retailCatalogProductCategory;
        }
        /// <summary>
        /// There are no comments for Property CatalogNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CatalogNumber
        {
            get
            {
                return this._CatalogNumber;
            }
            set
            {
                this.OnCatalogNumberChanging(value);
                this._CatalogNumber = value;
                this.OnCatalogNumberChanged();
                this.OnPropertyChanged("CatalogNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CatalogNumber;
        partial void OnCatalogNumberChanging(string value);
        partial void OnCatalogNumberChanged();
        /// <summary>
        /// There are no comments for Property DisplayProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DisplayProductNumber
        {
            get
            {
                return this._DisplayProductNumber;
            }
            set
            {
                this.OnDisplayProductNumberChanging(value);
                this._DisplayProductNumber = value;
                this.OnDisplayProductNumberChanged();
                this.OnPropertyChanged("DisplayProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DisplayProductNumber;
        partial void OnDisplayProductNumberChanging(string value);
        partial void OnDisplayProductNumberChanged();
        /// <summary>
        /// There are no comments for Property CategoryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CategoryName
        {
            get
            {
                return this._CategoryName;
            }
            set
            {
                this.OnCategoryNameChanging(value);
                this._CategoryName = value;
                this.OnCategoryNameChanged();
                this.OnPropertyChanged("CategoryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CategoryName;
        partial void OnCategoryNameChanging(string value);
        partial void OnCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property CategoryHierarchyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CategoryHierarchyName
        {
            get
            {
                return this._CategoryHierarchyName;
            }
            set
            {
                this.OnCategoryHierarchyNameChanging(value);
                this._CategoryHierarchyName = value;
                this.OnCategoryHierarchyNameChanged();
                this.OnPropertyChanged("CategoryHierarchyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CategoryHierarchyName;
        partial void OnCategoryHierarchyNameChanging(string value);
        partial void OnCategoryHierarchyNameChanged();
        /// <summary>
        /// There are no comments for Property IncludeExcludeType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CatalogProductExcludeIncludeType> IncludeExcludeType
        {
            get
            {
                return this._IncludeExcludeType;
            }
            set
            {
                this.OnIncludeExcludeTypeChanging(value);
                this._IncludeExcludeType = value;
                this.OnIncludeExcludeTypeChanged();
                this.OnPropertyChanged("IncludeExcludeType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CatalogProductExcludeIncludeType> _IncludeExcludeType;
        partial void OnIncludeExcludeTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CatalogProductExcludeIncludeType> value);
        partial void OnIncludeExcludeTypeChanged();
        /// <summary>
        /// There are no comments for Property RetailCatalogProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCatalogProduct RetailCatalogProduct
        {
            get
            {
                return this._RetailCatalogProduct;
            }
            set
            {
                this.OnRetailCatalogProductChanging(value);
                this._RetailCatalogProduct = value;
                this.OnRetailCatalogProductChanged();
                this.OnPropertyChanged("RetailCatalogProduct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCatalogProduct _RetailCatalogProduct;
        partial void OnRetailCatalogProductChanging(global::Microsoft.Dynamics.DataEntities.RetailCatalogProduct value);
        partial void OnRetailCatalogProductChanged();
        /// <summary>
        /// There are no comments for Property ProductCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductCategory ProductCategory
        {
            get
            {
                return this._ProductCategory;
            }
            set
            {
                this.OnProductCategoryChanging(value);
                this._ProductCategory = value;
                this.OnProductCategoryChanged();
                this.OnPropertyChanged("ProductCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductCategory _ProductCategory;
        partial void OnProductCategoryChanging(global::Microsoft.Dynamics.DataEntities.ProductCategory value);
        partial void OnProductCategoryChanged();
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
