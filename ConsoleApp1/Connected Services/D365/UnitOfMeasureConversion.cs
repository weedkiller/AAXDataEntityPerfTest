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
    /// There are no comments for UnitOfMeasureConversionSingle in the schema.
    /// </summary>
    public partial class UnitOfMeasureConversionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<UnitOfMeasureConversion>
    {
        /// <summary>
        /// Initialize a new UnitOfMeasureConversionSingle object.
        /// </summary>
        public UnitOfMeasureConversionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new UnitOfMeasureConversionSingle object.
        /// </summary>
        public UnitOfMeasureConversionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new UnitOfMeasureConversionSingle object.
        /// </summary>
        public UnitOfMeasureConversionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<UnitOfMeasureConversion> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for FromUnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle FromUnitOfMeasure
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FromUnitOfMeasure == null))
                {
                    this._FromUnitOfMeasure = new global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle(this.Context, GetPath("FromUnitOfMeasure"));
                }
                return this._FromUnitOfMeasure;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle _FromUnitOfMeasure;
        /// <summary>
        /// There are no comments for ToUnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle ToUnitOfMeasure
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ToUnitOfMeasure == null))
                {
                    this._ToUnitOfMeasure = new global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle(this.Context, GetPath("ToUnitOfMeasure"));
                }
                return this._ToUnitOfMeasure;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle _ToUnitOfMeasure;
    }
    /// <summary>
    /// There are no comments for UnitOfMeasureConversion in the schema.
    /// </summary>
    /// <KeyProperties>
    /// FromUnitSymbol
    /// ToUnitSymbol
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("FromUnitSymbol", "ToUnitSymbol")]
    [global::Microsoft.OData.Client.EntitySet("UnitOfMeasureConversions")]
    public partial class UnitOfMeasureConversion : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new UnitOfMeasureConversion object.
        /// </summary>
        /// <param name="fromUnitSymbol">Initial value of FromUnitSymbol.</param>
        /// <param name="toUnitSymbol">Initial value of ToUnitSymbol.</param>
        /// <param name="innerOffset">Initial value of InnerOffset.</param>
        /// <param name="outerOffset">Initial value of OuterOffset.</param>
        /// <param name="numerator">Initial value of Numerator.</param>
        /// <param name="factor">Initial value of Factor.</param>
        /// <param name="denominator">Initial value of Denominator.</param>
        /// <param name="fromUnitOfMeasure">Initial value of FromUnitOfMeasure.</param>
        /// <param name="toUnitOfMeasure">Initial value of ToUnitOfMeasure.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static UnitOfMeasureConversion CreateUnitOfMeasureConversion(string fromUnitSymbol, 
                    string toUnitSymbol, 
                    decimal innerOffset, 
                    decimal outerOffset, 
                    int numerator, 
                    decimal factor, 
                    int denominator, 
                    global::Microsoft.Dynamics.DataEntities.UnitOfMeasure fromUnitOfMeasure, 
                    global::Microsoft.Dynamics.DataEntities.UnitOfMeasure toUnitOfMeasure)
        {
            UnitOfMeasureConversion unitOfMeasureConversion = new UnitOfMeasureConversion();
            unitOfMeasureConversion.FromUnitSymbol = fromUnitSymbol;
            unitOfMeasureConversion.ToUnitSymbol = toUnitSymbol;
            unitOfMeasureConversion.InnerOffset = innerOffset;
            unitOfMeasureConversion.OuterOffset = outerOffset;
            unitOfMeasureConversion.Numerator = numerator;
            unitOfMeasureConversion.Factor = factor;
            unitOfMeasureConversion.Denominator = denominator;
            if ((fromUnitOfMeasure == null))
            {
                throw new global::System.ArgumentNullException("fromUnitOfMeasure");
            }
            unitOfMeasureConversion.FromUnitOfMeasure = fromUnitOfMeasure;
            if ((toUnitOfMeasure == null))
            {
                throw new global::System.ArgumentNullException("toUnitOfMeasure");
            }
            unitOfMeasureConversion.ToUnitOfMeasure = toUnitOfMeasure;
            return unitOfMeasureConversion;
        }
        /// <summary>
        /// There are no comments for Property FromUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FromUnitSymbol
        {
            get
            {
                return this._FromUnitSymbol;
            }
            set
            {
                this.OnFromUnitSymbolChanging(value);
                this._FromUnitSymbol = value;
                this.OnFromUnitSymbolChanged();
                this.OnPropertyChanged("FromUnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FromUnitSymbol;
        partial void OnFromUnitSymbolChanging(string value);
        partial void OnFromUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property ToUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ToUnitSymbol
        {
            get
            {
                return this._ToUnitSymbol;
            }
            set
            {
                this.OnToUnitSymbolChanging(value);
                this._ToUnitSymbol = value;
                this.OnToUnitSymbolChanged();
                this.OnPropertyChanged("ToUnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ToUnitSymbol;
        partial void OnToUnitSymbolChanging(string value);
        partial void OnToUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property InnerOffset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal InnerOffset
        {
            get
            {
                return this._InnerOffset;
            }
            set
            {
                this.OnInnerOffsetChanging(value);
                this._InnerOffset = value;
                this.OnInnerOffsetChanged();
                this.OnPropertyChanged("InnerOffset");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _InnerOffset;
        partial void OnInnerOffsetChanging(decimal value);
        partial void OnInnerOffsetChanged();
        /// <summary>
        /// There are no comments for Property Rounding in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.UnitOfMeasureConversionRounding> Rounding
        {
            get
            {
                return this._Rounding;
            }
            set
            {
                this.OnRoundingChanging(value);
                this._Rounding = value;
                this.OnRoundingChanged();
                this.OnPropertyChanged("Rounding");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.UnitOfMeasureConversionRounding> _Rounding;
        partial void OnRoundingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.UnitOfMeasureConversionRounding> value);
        partial void OnRoundingChanged();
        /// <summary>
        /// There are no comments for Property OuterOffset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal OuterOffset
        {
            get
            {
                return this._OuterOffset;
            }
            set
            {
                this.OnOuterOffsetChanging(value);
                this._OuterOffset = value;
                this.OnOuterOffsetChanged();
                this.OnPropertyChanged("OuterOffset");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OuterOffset;
        partial void OnOuterOffsetChanging(decimal value);
        partial void OnOuterOffsetChanged();
        /// <summary>
        /// There are no comments for Property Numerator in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int Numerator
        {
            get
            {
                return this._Numerator;
            }
            set
            {
                this.OnNumeratorChanging(value);
                this._Numerator = value;
                this.OnNumeratorChanged();
                this.OnPropertyChanged("Numerator");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Numerator;
        partial void OnNumeratorChanging(int value);
        partial void OnNumeratorChanged();
        /// <summary>
        /// There are no comments for Property Factor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Factor
        {
            get
            {
                return this._Factor;
            }
            set
            {
                this.OnFactorChanging(value);
                this._Factor = value;
                this.OnFactorChanged();
                this.OnPropertyChanged("Factor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Factor;
        partial void OnFactorChanging(decimal value);
        partial void OnFactorChanged();
        /// <summary>
        /// There are no comments for Property Denominator in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int Denominator
        {
            get
            {
                return this._Denominator;
            }
            set
            {
                this.OnDenominatorChanging(value);
                this._Denominator = value;
                this.OnDenominatorChanged();
                this.OnPropertyChanged("Denominator");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Denominator;
        partial void OnDenominatorChanging(int value);
        partial void OnDenominatorChanged();
        /// <summary>
        /// There are no comments for Property FromUnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasure FromUnitOfMeasure
        {
            get
            {
                return this._FromUnitOfMeasure;
            }
            set
            {
                this.OnFromUnitOfMeasureChanging(value);
                this._FromUnitOfMeasure = value;
                this.OnFromUnitOfMeasureChanged();
                this.OnPropertyChanged("FromUnitOfMeasure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasure _FromUnitOfMeasure;
        partial void OnFromUnitOfMeasureChanging(global::Microsoft.Dynamics.DataEntities.UnitOfMeasure value);
        partial void OnFromUnitOfMeasureChanged();
        /// <summary>
        /// There are no comments for Property ToUnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasure ToUnitOfMeasure
        {
            get
            {
                return this._ToUnitOfMeasure;
            }
            set
            {
                this.OnToUnitOfMeasureChanging(value);
                this._ToUnitOfMeasure = value;
                this.OnToUnitOfMeasureChanged();
                this.OnPropertyChanged("ToUnitOfMeasure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasure _ToUnitOfMeasure;
        partial void OnToUnitOfMeasureChanging(global::Microsoft.Dynamics.DataEntities.UnitOfMeasure value);
        partial void OnToUnitOfMeasureChanged();
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