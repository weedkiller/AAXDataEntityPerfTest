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
    /// There are no comments for RetailKitReleasedSubstituteSingle in the schema.
    /// </summary>
    public partial class RetailKitReleasedSubstituteSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailKitReleasedSubstitute>
    {
        /// <summary>
        /// Initialize a new RetailKitReleasedSubstituteSingle object.
        /// </summary>
        public RetailKitReleasedSubstituteSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailKitReleasedSubstituteSingle object.
        /// </summary>
        public RetailKitReleasedSubstituteSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailKitReleasedSubstituteSingle object.
        /// </summary>
        public RetailKitReleasedSubstituteSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailKitReleasedSubstitute> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailKitComponentSubstitute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailKitComponentSubstituteSingle RetailKitComponentSubstitute
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailKitComponentSubstitute == null))
                {
                    this._RetailKitComponentSubstitute = new global::Microsoft.Dynamics.DataEntities.RetailKitComponentSubstituteSingle(this.Context, GetPath("RetailKitComponentSubstitute"));
                }
                return this._RetailKitComponentSubstitute;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailKitComponentSubstituteSingle _RetailKitComponentSubstitute;
    }
    /// <summary>
    /// There are no comments for RetailKitReleasedSubstitute in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// KitProductNumber
    /// KitComponentLineNumber
    /// SubstituteProductNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "KitProductNumber", "KitComponentLineNumber", "SubstituteProductNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailKitReleasedSubstitutes")]
    public partial class RetailKitReleasedSubstitute : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailKitReleasedSubstitute object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="kitProductNumber">Initial value of KitProductNumber.</param>
        /// <param name="kitComponentLineNumber">Initial value of KitComponentLineNumber.</param>
        /// <param name="substituteProductNumber">Initial value of SubstituteProductNumber.</param>
        /// <param name="substituteCharge">Initial value of SubstituteCharge.</param>
        /// <param name="retailKitComponentSubstitute">Initial value of RetailKitComponentSubstitute.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailKitReleasedSubstitute CreateRetailKitReleasedSubstitute(string dataAreaId, 
                    string kitProductNumber, 
                    decimal kitComponentLineNumber, 
                    string substituteProductNumber, 
                    decimal substituteCharge, 
                    global::Microsoft.Dynamics.DataEntities.RetailKitComponentSubstitute retailKitComponentSubstitute)
        {
            RetailKitReleasedSubstitute retailKitReleasedSubstitute = new RetailKitReleasedSubstitute();
            retailKitReleasedSubstitute.dataAreaId = dataAreaId;
            retailKitReleasedSubstitute.KitProductNumber = kitProductNumber;
            retailKitReleasedSubstitute.KitComponentLineNumber = kitComponentLineNumber;
            retailKitReleasedSubstitute.SubstituteProductNumber = substituteProductNumber;
            retailKitReleasedSubstitute.SubstituteCharge = substituteCharge;
            if ((retailKitComponentSubstitute == null))
            {
                throw new global::System.ArgumentNullException("retailKitComponentSubstitute");
            }
            retailKitReleasedSubstitute.RetailKitComponentSubstitute = retailKitComponentSubstitute;
            return retailKitReleasedSubstitute;
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
        /// There are no comments for Property KitComponentLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal KitComponentLineNumber
        {
            get
            {
                return this._KitComponentLineNumber;
            }
            set
            {
                this.OnKitComponentLineNumberChanging(value);
                this._KitComponentLineNumber = value;
                this.OnKitComponentLineNumberChanged();
                this.OnPropertyChanged("KitComponentLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _KitComponentLineNumber;
        partial void OnKitComponentLineNumberChanging(decimal value);
        partial void OnKitComponentLineNumberChanged();
        /// <summary>
        /// There are no comments for Property SubstituteProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SubstituteProductNumber
        {
            get
            {
                return this._SubstituteProductNumber;
            }
            set
            {
                this.OnSubstituteProductNumberChanging(value);
                this._SubstituteProductNumber = value;
                this.OnSubstituteProductNumberChanged();
                this.OnPropertyChanged("SubstituteProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SubstituteProductNumber;
        partial void OnSubstituteProductNumberChanging(string value);
        partial void OnSubstituteProductNumberChanged();
        /// <summary>
        /// There are no comments for Property SubstituteCharge in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal SubstituteCharge
        {
            get
            {
                return this._SubstituteCharge;
            }
            set
            {
                this.OnSubstituteChargeChanging(value);
                this._SubstituteCharge = value;
                this.OnSubstituteChargeChanged();
                this.OnPropertyChanged("SubstituteCharge");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SubstituteCharge;
        partial void OnSubstituteChargeChanging(decimal value);
        partial void OnSubstituteChargeChanged();
        /// <summary>
        /// There are no comments for Property RetailKitComponentSubstitute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailKitComponentSubstitute RetailKitComponentSubstitute
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
        private global::Microsoft.Dynamics.DataEntities.RetailKitComponentSubstitute _RetailKitComponentSubstitute;
        partial void OnRetailKitComponentSubstituteChanging(global::Microsoft.Dynamics.DataEntities.RetailKitComponentSubstitute value);
        partial void OnRetailKitComponentSubstituteChanged();
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
