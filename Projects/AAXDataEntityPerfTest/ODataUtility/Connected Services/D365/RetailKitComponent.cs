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
        /// There are no comments for RetailKitComponentSingle in the schema.
        /// </summary>
    public partial class RetailKitComponentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailKitComponent>
    {
        /// <summary>
        /// Initialize a new RetailKitComponentSingle object.
        /// </summary>
        public RetailKitComponentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailKitComponentSingle object.
        /// </summary>
        public RetailKitComponentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailKitComponentSingle object.
        /// </summary>
        public RetailKitComponentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailKitComponent> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailKitComponentSubstitute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailKitComponentSubstitute> RetailKitComponentSubstitute
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailKitComponentSubstitute == null))
                {
                    this._RetailKitComponentSubstitute = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailKitComponentSubstitute>(GetPath("RetailKitComponentSubstitute"));
                }
                return this._RetailKitComponentSubstitute;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailKitComponentSubstitute> _RetailKitComponentSubstitute;
        /// <summary>
        /// There are no comments for RetailKitReleasedComponent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailKitReleasedComponent> RetailKitReleasedComponent
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailKitReleasedComponent == null))
                {
                    this._RetailKitReleasedComponent = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailKitReleasedComponent>(GetPath("RetailKitReleasedComponent"));
                }
                return this._RetailKitReleasedComponent;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailKitReleasedComponent> _RetailKitReleasedComponent;
        /// <summary>
        /// There are no comments for ProductVariant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductVariantSingle ProductVariant
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductVariant == null))
                {
                    this._ProductVariant = new global::Microsoft.Dynamics.DataEntities.ProductVariantSingle(this.Context, GetPath("ProductVariant"));
                }
                return this._ProductVariant;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductVariantSingle _ProductVariant;
        /// <summary>
        /// There are no comments for RetailKit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailKitSingle RetailKit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailKit == null))
                {
                    this._RetailKit = new global::Microsoft.Dynamics.DataEntities.RetailKitSingle(this.Context, GetPath("RetailKit"));
                }
                return this._RetailKit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailKitSingle _RetailKit;
    }
        /// <summary>
        /// There are no comments for RetailKitComponent in the schema.
        /// </summary>
    /// <KeyProperties>
    /// KitProductNumber
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("KitProductNumber", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailKitComponents")]
    public partial class RetailKitComponent : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailKitComponent object.
        /// </summary>
        /// <param name="kitProductNumber">Initial value of KitProductNumber.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="retailKit">Initial value of RetailKit.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailKitComponent CreateRetailKitComponent(string kitProductNumber, decimal lineNumber, decimal quantity, global::Microsoft.Dynamics.DataEntities.RetailKit retailKit)
        {
            RetailKitComponent retailKitComponent = new RetailKitComponent();
            retailKitComponent.KitProductNumber = kitProductNumber;
            retailKitComponent.LineNumber = lineNumber;
            retailKitComponent.Quantity = quantity;
            if ((retailKit == null))
            {
                throw new global::System.ArgumentNullException("retailKit");
            }
            retailKitComponent.RetailKit = retailKit;
            return retailKitComponent;
        }
        /// <summary>
        /// There are no comments for Property KitProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string KitProductNumber
        {
            get
            {
                return this._KitProductNumber;
            }
            set
            {
                this.OnKitProductNumberChanging(value);
                this._KitProductNumber = value;
                this.OnKitProductNumberChanged();
                this.OnPropertyChanged("KitProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _KitProductNumber;
        partial void OnKitProductNumberChanging(string value);
        partial void OnKitProductNumberChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property UnitOfMeasureSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UnitOfMeasureSymbol
        {
            get
            {
                return this._UnitOfMeasureSymbol;
            }
            set
            {
                this.OnUnitOfMeasureSymbolChanging(value);
                this._UnitOfMeasureSymbol = value;
                this.OnUnitOfMeasureSymbolChanged();
                this.OnPropertyChanged("UnitOfMeasureSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitOfMeasureSymbol;
        partial void OnUnitOfMeasureSymbolChanging(string value);
        partial void OnUnitOfMeasureSymbolChanged();
        /// <summary>
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this.OnQuantityChanging(value);
                this._Quantity = value;
                this.OnQuantityChanged();
                this.OnPropertyChanged("Quantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Quantity;
        partial void OnQuantityChanging(decimal value);
        partial void OnQuantityChanged();
        /// <summary>
        /// There are no comments for Property ComponentProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ComponentProductNumber
        {
            get
            {
                return this._ComponentProductNumber;
            }
            set
            {
                this.OnComponentProductNumberChanging(value);
                this._ComponentProductNumber = value;
                this.OnComponentProductNumberChanged();
                this.OnPropertyChanged("ComponentProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ComponentProductNumber;
        partial void OnComponentProductNumberChanging(string value);
        partial void OnComponentProductNumberChanged();
        /// <summary>
        /// There are no comments for Property DoNotShowAtRegister in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DoNotShowAtRegister
        {
            get
            {
                return this._DoNotShowAtRegister;
            }
            set
            {
                this.OnDoNotShowAtRegisterChanging(value);
                this._DoNotShowAtRegister = value;
                this.OnDoNotShowAtRegisterChanged();
                this.OnPropertyChanged("DoNotShowAtRegister");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DoNotShowAtRegister;
        partial void OnDoNotShowAtRegisterChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDoNotShowAtRegisterChanged();
        /// <summary>
        /// There are no comments for Property RetailKitComponentSubstitute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailKitComponentSubstitute> RetailKitComponentSubstitute
        {
            get
            {
                return this._RetailKitComponentSubstitute;
            }
            set
            {
                this.OnRetailKitComponentSubstituteChanging(value);
                this._RetailKitComponentSubstitute = value;
                this.OnRetailKitComponentSubstituteChanged();
                this.OnPropertyChanged("RetailKitComponentSubstitute");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailKitComponentSubstitute> _RetailKitComponentSubstitute = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailKitComponentSubstitute>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailKitComponentSubstituteChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailKitComponentSubstitute> value);
        partial void OnRetailKitComponentSubstituteChanged();
        /// <summary>
        /// There are no comments for Property RetailKitReleasedComponent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailKitReleasedComponent> RetailKitReleasedComponent
        {
            get
            {
                return this._RetailKitReleasedComponent;
            }
            set
            {
                this.OnRetailKitReleasedComponentChanging(value);
                this._RetailKitReleasedComponent = value;
                this.OnRetailKitReleasedComponentChanged();
                this.OnPropertyChanged("RetailKitReleasedComponent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailKitReleasedComponent> _RetailKitReleasedComponent = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailKitReleasedComponent>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailKitReleasedComponentChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailKitReleasedComponent> value);
        partial void OnRetailKitReleasedComponentChanged();
        /// <summary>
        /// There are no comments for Property ProductVariant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductVariant ProductVariant
        {
            get
            {
                return this._ProductVariant;
            }
            set
            {
                this.OnProductVariantChanging(value);
                this._ProductVariant = value;
                this.OnProductVariantChanged();
                this.OnPropertyChanged("ProductVariant");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductVariant _ProductVariant;
        partial void OnProductVariantChanging(global::Microsoft.Dynamics.DataEntities.ProductVariant value);
        partial void OnProductVariantChanged();
        /// <summary>
        /// There are no comments for Property RetailKit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailKit RetailKit
        {
            get
            {
                return this._RetailKit;
            }
            set
            {
                this.OnRetailKitChanging(value);
                this._RetailKit = value;
                this.OnRetailKitChanged();
                this.OnPropertyChanged("RetailKit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailKit _RetailKit;
        partial void OnRetailKitChanging(global::Microsoft.Dynamics.DataEntities.RetailKit value);
        partial void OnRetailKitChanged();
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
