﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 9/11/2020 3:24:26 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for RetailRoundingMethodSingle in the schema.
    /// </summary>
    public partial class RetailRoundingMethodSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailRoundingMethod>
    {
        /// <summary>
        /// Initialize a new RetailRoundingMethodSingle object.
        /// </summary>
        public RetailRoundingMethodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailRoundingMethodSingle object.
        /// </summary>
        public RetailRoundingMethodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailRoundingMethodSingle object.
        /// </summary>
        public RetailRoundingMethodSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailRoundingMethod> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailRoundingMethod in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RoundingMethodId
    /// Minimum
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RoundingMethodId", "Minimum")]
    [global::Microsoft.OData.Client.EntitySet("RetailRoundingMethods")]
    public partial class RetailRoundingMethod : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailRoundingMethod object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="roundingMethodId">Initial value of RoundingMethodId.</param>
        /// <param name="minimum">Initial value of Minimum.</param>
        /// <param name="amountAddedAfter">Initial value of AmountAddedAfter.</param>
        /// <param name="precision">Initial value of Precision.</param>
        /// <param name="amountAddedBefore">Initial value of AmountAddedBefore.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailRoundingMethod CreateRetailRoundingMethod(string dataAreaId, 
                    string roundingMethodId, 
                    decimal minimum, 
                    decimal amountAddedAfter, 
                    decimal precision, 
                    decimal amountAddedBefore)
        {
            RetailRoundingMethod retailRoundingMethod = new RetailRoundingMethod();
            retailRoundingMethod.dataAreaId = dataAreaId;
            retailRoundingMethod.RoundingMethodId = roundingMethodId;
            retailRoundingMethod.Minimum = minimum;
            retailRoundingMethod.AmountAddedAfter = amountAddedAfter;
            retailRoundingMethod.Precision = precision;
            retailRoundingMethod.AmountAddedBefore = amountAddedBefore;
            return retailRoundingMethod;
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
        /// There are no comments for Property RoundingMethodId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RoundingMethodId
        {
            get
            {
                return this._RoundingMethodId;
            }
            set
            {
                this.OnRoundingMethodIdChanging(value);
                this._RoundingMethodId = value;
                this.OnRoundingMethodIdChanged();
                this.OnPropertyChanged("RoundingMethodId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RoundingMethodId;
        partial void OnRoundingMethodIdChanging(string value);
        partial void OnRoundingMethodIdChanged();
        /// <summary>
        /// There are no comments for Property Minimum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Minimum
        {
            get
            {
                return this._Minimum;
            }
            set
            {
                this.OnMinimumChanging(value);
                this._Minimum = value;
                this.OnMinimumChanged();
                this.OnPropertyChanged("Minimum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Minimum;
        partial void OnMinimumChanging(decimal value);
        partial void OnMinimumChanged();
        /// <summary>
        /// There are no comments for Property AmountAddedAfter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AmountAddedAfter
        {
            get
            {
                return this._AmountAddedAfter;
            }
            set
            {
                this.OnAmountAddedAfterChanging(value);
                this._AmountAddedAfter = value;
                this.OnAmountAddedAfterChanged();
                this.OnPropertyChanged("AmountAddedAfter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AmountAddedAfter;
        partial void OnAmountAddedAfterChanging(decimal value);
        partial void OnAmountAddedAfterChanged();
        /// <summary>
        /// There are no comments for Property RoundingType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailRoundingTypeBase> RoundingType
        {
            get
            {
                return this._RoundingType;
            }
            set
            {
                this.OnRoundingTypeChanging(value);
                this._RoundingType = value;
                this.OnRoundingTypeChanged();
                this.OnPropertyChanged("RoundingType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailRoundingTypeBase> _RoundingType;
        partial void OnRoundingTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailRoundingTypeBase> value);
        partial void OnRoundingTypeChanged();
        /// <summary>
        /// There are no comments for Property Precision in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Precision
        {
            get
            {
                return this._Precision;
            }
            set
            {
                this.OnPrecisionChanging(value);
                this._Precision = value;
                this.OnPrecisionChanged();
                this.OnPropertyChanged("Precision");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Precision;
        partial void OnPrecisionChanging(decimal value);
        partial void OnPrecisionChanged();
        /// <summary>
        /// There are no comments for Property AmountAddedBefore in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AmountAddedBefore
        {
            get
            {
                return this._AmountAddedBefore;
            }
            set
            {
                this.OnAmountAddedBeforeChanging(value);
                this._AmountAddedBefore = value;
                this.OnAmountAddedBeforeChanged();
                this.OnPropertyChanged("AmountAddedBefore");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AmountAddedBefore;
        partial void OnAmountAddedBeforeChanging(decimal value);
        partial void OnAmountAddedBeforeChanged();
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
