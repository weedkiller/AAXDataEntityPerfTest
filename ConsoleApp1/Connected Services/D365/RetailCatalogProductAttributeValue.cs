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
    /// There are no comments for RetailCatalogProductAttributeValueSingle in the schema.
    /// </summary>
    public partial class RetailCatalogProductAttributeValueSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailCatalogProductAttributeValue>
    {
        /// <summary>
        /// Initialize a new RetailCatalogProductAttributeValueSingle object.
        /// </summary>
        public RetailCatalogProductAttributeValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailCatalogProductAttributeValueSingle object.
        /// </summary>
        public RetailCatalogProductAttributeValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailCatalogProductAttributeValueSingle object.
        /// </summary>
        public RetailCatalogProductAttributeValueSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailCatalogProductAttributeValue> query)
            : base(query) {}

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
        /// <summary>
        /// There are no comments for RetailCatalog in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCatalogSingle RetailCatalog
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailCatalog == null))
                {
                    this._RetailCatalog = new global::Microsoft.Dynamics.DataEntities.RetailCatalogSingle(this.Context, GetPath("RetailCatalog"));
                }
                return this._RetailCatalog;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCatalogSingle _RetailCatalog;
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
    }
    /// <summary>
    /// There are no comments for RetailCatalogProductAttributeValue in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CatalogNumber
    /// CategoryHierarchyName
    /// CategoryName
    /// DisplayProductNumber
    /// AttributeGroupName
    /// AttributeName
    /// AttributeTypeName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CatalogNumber", "CategoryHierarchyName", "CategoryName", "DisplayProductNumber", "AttributeGroupName", "AttributeName", "AttributeTypeName")]
    [global::Microsoft.OData.Client.EntitySet("RetailCatalogProductAttributeValues")]
    public partial class RetailCatalogProductAttributeValue : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailCatalogProductAttributeValue object.
        /// </summary>
        /// <param name="catalogNumber">Initial value of CatalogNumber.</param>
        /// <param name="categoryHierarchyName">Initial value of CategoryHierarchyName.</param>
        /// <param name="categoryName">Initial value of CategoryName.</param>
        /// <param name="displayProductNumber">Initial value of DisplayProductNumber.</param>
        /// <param name="attributeGroupName">Initial value of AttributeGroupName.</param>
        /// <param name="attributeName">Initial value of AttributeName.</param>
        /// <param name="attributeTypeName">Initial value of AttributeTypeName.</param>
        /// <param name="integerValue">Initial value of IntegerValue.</param>
        /// <param name="decimalValue">Initial value of DecimalValue.</param>
        /// <param name="dateTimeValue">Initial value of DateTimeValue.</param>
        /// <param name="currencyValue">Initial value of CurrencyValue.</param>
        /// <param name="productCategory">Initial value of ProductCategory.</param>
        /// <param name="productCategoryHierarchy">Initial value of ProductCategoryHierarchy.</param>
        /// <param name="retailCatalog">Initial value of RetailCatalog.</param>
        /// <param name="retailCatalogProduct">Initial value of RetailCatalogProduct.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailCatalogProductAttributeValue CreateRetailCatalogProductAttributeValue(string catalogNumber, 
                    string categoryHierarchyName, 
                    string categoryName, 
                    string displayProductNumber, 
                    string attributeGroupName, 
                    string attributeName, 
                    string attributeTypeName, 
                    int integerValue, 
                    decimal decimalValue, 
                    global::System.DateTimeOffset dateTimeValue, 
                    decimal currencyValue, 
                    global::Microsoft.Dynamics.DataEntities.ProductCategory productCategory, 
                    global::Microsoft.Dynamics.DataEntities.ProductCategoryHierarchy productCategoryHierarchy, 
                    global::Microsoft.Dynamics.DataEntities.RetailCatalog retailCatalog, 
                    global::Microsoft.Dynamics.DataEntities.RetailCatalogProduct retailCatalogProduct)
        {
            RetailCatalogProductAttributeValue retailCatalogProductAttributeValue = new RetailCatalogProductAttributeValue();
            retailCatalogProductAttributeValue.CatalogNumber = catalogNumber;
            retailCatalogProductAttributeValue.CategoryHierarchyName = categoryHierarchyName;
            retailCatalogProductAttributeValue.CategoryName = categoryName;
            retailCatalogProductAttributeValue.DisplayProductNumber = displayProductNumber;
            retailCatalogProductAttributeValue.AttributeGroupName = attributeGroupName;
            retailCatalogProductAttributeValue.AttributeName = attributeName;
            retailCatalogProductAttributeValue.AttributeTypeName = attributeTypeName;
            retailCatalogProductAttributeValue.IntegerValue = integerValue;
            retailCatalogProductAttributeValue.DecimalValue = decimalValue;
            retailCatalogProductAttributeValue.DateTimeValue = dateTimeValue;
            retailCatalogProductAttributeValue.CurrencyValue = currencyValue;
            if ((productCategory == null))
            {
                throw new global::System.ArgumentNullException("productCategory");
            }
            retailCatalogProductAttributeValue.ProductCategory = productCategory;
            if ((productCategoryHierarchy == null))
            {
                throw new global::System.ArgumentNullException("productCategoryHierarchy");
            }
            retailCatalogProductAttributeValue.ProductCategoryHierarchy = productCategoryHierarchy;
            if ((retailCatalog == null))
            {
                throw new global::System.ArgumentNullException("retailCatalog");
            }
            retailCatalogProductAttributeValue.RetailCatalog = retailCatalog;
            if ((retailCatalogProduct == null))
            {
                throw new global::System.ArgumentNullException("retailCatalogProduct");
            }
            retailCatalogProductAttributeValue.RetailCatalogProduct = retailCatalogProduct;
            return retailCatalogProductAttributeValue;
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
        /// There are no comments for Property AttributeGroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AttributeGroupName
        {
            get
            {
                return this._AttributeGroupName;
            }
            set
            {
                this.OnAttributeGroupNameChanging(value);
                this._AttributeGroupName = value;
                this.OnAttributeGroupNameChanged();
                this.OnPropertyChanged("AttributeGroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeGroupName;
        partial void OnAttributeGroupNameChanging(string value);
        partial void OnAttributeGroupNameChanged();
        /// <summary>
        /// There are no comments for Property AttributeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AttributeName
        {
            get
            {
                return this._AttributeName;
            }
            set
            {
                this.OnAttributeNameChanging(value);
                this._AttributeName = value;
                this.OnAttributeNameChanged();
                this.OnPropertyChanged("AttributeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeName;
        partial void OnAttributeNameChanging(string value);
        partial void OnAttributeNameChanged();
        /// <summary>
        /// There are no comments for Property AttributeTypeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AttributeTypeName
        {
            get
            {
                return this._AttributeTypeName;
            }
            set
            {
                this.OnAttributeTypeNameChanging(value);
                this._AttributeTypeName = value;
                this.OnAttributeTypeNameChanged();
                this.OnPropertyChanged("AttributeTypeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeTypeName;
        partial void OnAttributeTypeNameChanging(string value);
        partial void OnAttributeTypeNameChanged();
        /// <summary>
        /// There are no comments for Property IntegerValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int IntegerValue
        {
            get
            {
                return this._IntegerValue;
            }
            set
            {
                this.OnIntegerValueChanging(value);
                this._IntegerValue = value;
                this.OnIntegerValueChanged();
                this.OnPropertyChanged("IntegerValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _IntegerValue;
        partial void OnIntegerValueChanging(int value);
        partial void OnIntegerValueChanged();
        /// <summary>
        /// There are no comments for Property BooleanValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> BooleanValue
        {
            get
            {
                return this._BooleanValue;
            }
            set
            {
                this.OnBooleanValueChanging(value);
                this._BooleanValue = value;
                this.OnBooleanValueChanged();
                this.OnPropertyChanged("BooleanValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _BooleanValue;
        partial void OnBooleanValueChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnBooleanValueChanged();
        /// <summary>
        /// There are no comments for Property CurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CurrencyCode
        {
            get
            {
                return this._CurrencyCode;
            }
            set
            {
                this.OnCurrencyCodeChanging(value);
                this._CurrencyCode = value;
                this.OnCurrencyCodeChanged();
                this.OnPropertyChanged("CurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyCode;
        partial void OnCurrencyCodeChanging(string value);
        partial void OnCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property DecimalValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DecimalValue
        {
            get
            {
                return this._DecimalValue;
            }
            set
            {
                this.OnDecimalValueChanging(value);
                this._DecimalValue = value;
                this.OnDecimalValueChanged();
                this.OnPropertyChanged("DecimalValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DecimalValue;
        partial void OnDecimalValueChanging(decimal value);
        partial void OnDecimalValueChanged();
        /// <summary>
        /// There are no comments for Property DateTimeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DateTimeValue
        {
            get
            {
                return this._DateTimeValue;
            }
            set
            {
                this.OnDateTimeValueChanging(value);
                this._DateTimeValue = value;
                this.OnDateTimeValueChanged();
                this.OnPropertyChanged("DateTimeValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DateTimeValue;
        partial void OnDateTimeValueChanging(global::System.DateTimeOffset value);
        partial void OnDateTimeValueChanged();
        /// <summary>
        /// There are no comments for Property CurrencyValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CurrencyValue
        {
            get
            {
                return this._CurrencyValue;
            }
            set
            {
                this.OnCurrencyValueChanging(value);
                this._CurrencyValue = value;
                this.OnCurrencyValueChanged();
                this.OnPropertyChanged("CurrencyValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CurrencyValue;
        partial void OnCurrencyValueChanging(decimal value);
        partial void OnCurrencyValueChanged();
        /// <summary>
        /// There are no comments for Property TextValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TextValue
        {
            get
            {
                return this._TextValue;
            }
            set
            {
                this.OnTextValueChanging(value);
                this._TextValue = value;
                this.OnTextValueChanged();
                this.OnPropertyChanged("TextValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TextValue;
        partial void OnTextValueChanging(string value);
        partial void OnTextValueChanged();
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
        /// There are no comments for Property RetailCatalog in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCatalog RetailCatalog
        {
            get
            {
                return this._RetailCatalog;
            }
            set
            {
                this.OnRetailCatalogChanging(value);
                this._RetailCatalog = value;
                this.OnRetailCatalogChanged();
                this.OnPropertyChanged("RetailCatalog");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCatalog _RetailCatalog;
        partial void OnRetailCatalogChanging(global::Microsoft.Dynamics.DataEntities.RetailCatalog value);
        partial void OnRetailCatalogChanged();
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
