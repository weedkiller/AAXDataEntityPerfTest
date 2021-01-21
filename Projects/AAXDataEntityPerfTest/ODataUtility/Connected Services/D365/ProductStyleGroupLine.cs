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
        /// There are no comments for ProductStyleGroupLineSingle in the schema.
        /// </summary>
    public partial class ProductStyleGroupLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductStyleGroupLine>
    {
        /// <summary>
        /// Initialize a new ProductStyleGroupLineSingle object.
        /// </summary>
        public ProductStyleGroupLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductStyleGroupLineSingle object.
        /// </summary>
        public ProductStyleGroupLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductStyleGroupLineSingle object.
        /// </summary>
        public ProductStyleGroupLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductStyleGroupLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductStyle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductStyleSingle ProductStyle
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductStyle == null))
                {
                    this._ProductStyle = new global::Microsoft.Dynamics.DataEntities.ProductStyleSingle(this.Context, GetPath("ProductStyle"));
                }
                return this._ProductStyle;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductStyleSingle _ProductStyle;
        /// <summary>
        /// There are no comments for ProductStyleGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductStyleGroupSingle ProductStyleGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductStyleGroup == null))
                {
                    this._ProductStyleGroup = new global::Microsoft.Dynamics.DataEntities.ProductStyleGroupSingle(this.Context, GetPath("ProductStyleGroup"));
                }
                return this._ProductStyleGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductStyleGroupSingle _ProductStyleGroup;
        /// <summary>
        /// There are no comments for ProductStyleGroupLineTranslations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductStyleGroupLineTranslation> ProductStyleGroupLineTranslations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductStyleGroupLineTranslations == null))
                {
                    this._ProductStyleGroupLineTranslations = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductStyleGroupLineTranslation>(GetPath("ProductStyleGroupLineTranslations"));
                }
                return this._ProductStyleGroupLineTranslations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductStyleGroupLineTranslation> _ProductStyleGroupLineTranslations;
    }
        /// <summary>
        /// There are no comments for ProductStyleGroupLine in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ProductStyleGroupId
    /// ProductStyleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductStyleGroupId", "ProductStyleId")]
    [global::Microsoft.OData.Client.EntitySet("ProductStyleGroupLines")]
    public partial class ProductStyleGroupLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductStyleGroupLine object.
        /// </summary>
        /// <param name="productStyleGroupId">Initial value of ProductStyleGroupId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="displayOrder">Initial value of DisplayOrder.</param>
        /// <param name="replenishmentWeight">Initial value of ReplenishmentWeight.</param>
        /// <param name="productStyle">Initial value of ProductStyle.</param>
        /// <param name="productStyleGroup">Initial value of ProductStyleGroup.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductStyleGroupLine CreateProductStyleGroupLine(string productStyleGroupId, 
                    string productStyleId, 
                    decimal displayOrder, 
                    int replenishmentWeight, 
                    global::Microsoft.Dynamics.DataEntities.ProductStyle productStyle, 
                    global::Microsoft.Dynamics.DataEntities.ProductStyleGroup productStyleGroup)
        {
            ProductStyleGroupLine productStyleGroupLine = new ProductStyleGroupLine();
            productStyleGroupLine.ProductStyleGroupId = productStyleGroupId;
            productStyleGroupLine.ProductStyleId = productStyleId;
            productStyleGroupLine.DisplayOrder = displayOrder;
            productStyleGroupLine.ReplenishmentWeight = replenishmentWeight;
            if ((productStyle == null))
            {
                throw new global::System.ArgumentNullException("productStyle");
            }
            productStyleGroupLine.ProductStyle = productStyle;
            if ((productStyleGroup == null))
            {
                throw new global::System.ArgumentNullException("productStyleGroup");
            }
            productStyleGroupLine.ProductStyleGroup = productStyleGroup;
            return productStyleGroupLine;
        }
        /// <summary>
        /// There are no comments for Property ProductStyleGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductStyleGroupId
        {
            get
            {
                return this._ProductStyleGroupId;
            }
            set
            {
                this.OnProductStyleGroupIdChanging(value);
                this._ProductStyleGroupId = value;
                this.OnProductStyleGroupIdChanged();
                this.OnPropertyChanged("ProductStyleGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductStyleGroupId;
        partial void OnProductStyleGroupIdChanging(string value);
        partial void OnProductStyleGroupIdChanged();
        /// <summary>
        /// There are no comments for Property ProductStyleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductStyleId
        {
            get
            {
                return this._ProductStyleId;
            }
            set
            {
                this.OnProductStyleIdChanging(value);
                this._ProductStyleId = value;
                this.OnProductStyleIdChanged();
                this.OnPropertyChanged("ProductStyleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductStyleId;
        partial void OnProductStyleIdChanging(string value);
        partial void OnProductStyleIdChanged();
        /// <summary>
        /// There are no comments for Property DisplayOrder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DisplayOrder
        {
            get
            {
                return this._DisplayOrder;
            }
            set
            {
                this.OnDisplayOrderChanging(value);
                this._DisplayOrder = value;
                this.OnDisplayOrderChanged();
                this.OnPropertyChanged("DisplayOrder");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DisplayOrder;
        partial void OnDisplayOrderChanging(decimal value);
        partial void OnDisplayOrderChanged();
        /// <summary>
        /// There are no comments for Property StyleDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string StyleDescription
        {
            get
            {
                return this._StyleDescription;
            }
            set
            {
                this.OnStyleDescriptionChanging(value);
                this._StyleDescription = value;
                this.OnStyleDescriptionChanged();
                this.OnPropertyChanged("StyleDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StyleDescription;
        partial void OnStyleDescriptionChanging(string value);
        partial void OnStyleDescriptionChanged();
        /// <summary>
        /// There are no comments for Property ReplenishmentWeight in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int ReplenishmentWeight
        {
            get
            {
                return this._ReplenishmentWeight;
            }
            set
            {
                this.OnReplenishmentWeightChanging(value);
                this._ReplenishmentWeight = value;
                this.OnReplenishmentWeightChanged();
                this.OnPropertyChanged("ReplenishmentWeight");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ReplenishmentWeight;
        partial void OnReplenishmentWeightChanging(int value);
        partial void OnReplenishmentWeightChanged();
        /// <summary>
        /// There are no comments for Property BarcodeNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BarcodeNumber
        {
            get
            {
                return this._BarcodeNumber;
            }
            set
            {
                this.OnBarcodeNumberChanging(value);
                this._BarcodeNumber = value;
                this.OnBarcodeNumberChanged();
                this.OnPropertyChanged("BarcodeNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BarcodeNumber;
        partial void OnBarcodeNumberChanging(string value);
        partial void OnBarcodeNumberChanged();
        /// <summary>
        /// There are no comments for Property StyleName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string StyleName
        {
            get
            {
                return this._StyleName;
            }
            set
            {
                this.OnStyleNameChanging(value);
                this._StyleName = value;
                this.OnStyleNameChanged();
                this.OnPropertyChanged("StyleName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StyleName;
        partial void OnStyleNameChanging(string value);
        partial void OnStyleNameChanged();
        /// <summary>
        /// There are no comments for Property ProductStyle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductStyle ProductStyle
        {
            get
            {
                return this._ProductStyle;
            }
            set
            {
                this.OnProductStyleChanging(value);
                this._ProductStyle = value;
                this.OnProductStyleChanged();
                this.OnPropertyChanged("ProductStyle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductStyle _ProductStyle;
        partial void OnProductStyleChanging(global::Microsoft.Dynamics.DataEntities.ProductStyle value);
        partial void OnProductStyleChanged();
        /// <summary>
        /// There are no comments for Property ProductStyleGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductStyleGroup ProductStyleGroup
        {
            get
            {
                return this._ProductStyleGroup;
            }
            set
            {
                this.OnProductStyleGroupChanging(value);
                this._ProductStyleGroup = value;
                this.OnProductStyleGroupChanged();
                this.OnPropertyChanged("ProductStyleGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductStyleGroup _ProductStyleGroup;
        partial void OnProductStyleGroupChanging(global::Microsoft.Dynamics.DataEntities.ProductStyleGroup value);
        partial void OnProductStyleGroupChanged();
        /// <summary>
        /// There are no comments for Property ProductStyleGroupLineTranslations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductStyleGroupLineTranslation> ProductStyleGroupLineTranslations
        {
            get
            {
                return this._ProductStyleGroupLineTranslations;
            }
            set
            {
                this.OnProductStyleGroupLineTranslationsChanging(value);
                this._ProductStyleGroupLineTranslations = value;
                this.OnProductStyleGroupLineTranslationsChanged();
                this.OnPropertyChanged("ProductStyleGroupLineTranslations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductStyleGroupLineTranslation> _ProductStyleGroupLineTranslations = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductStyleGroupLineTranslation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductStyleGroupLineTranslationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductStyleGroupLineTranslation> value);
        partial void OnProductStyleGroupLineTranslationsChanged();
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
