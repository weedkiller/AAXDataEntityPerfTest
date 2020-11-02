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
    /// There are no comments for RTax25RegisterParameterSingle in the schema.
    /// </summary>
    public partial class RTax25RegisterParameterSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RTax25RegisterParameter>
    {
        /// <summary>
        /// Initialize a new RTax25RegisterParameterSingle object.
        /// </summary>
        public RTax25RegisterParameterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RTax25RegisterParameterSingle object.
        /// </summary>
        public RTax25RegisterParameterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RTax25RegisterParameterSingle object.
        /// </summary>
        public RTax25RegisterParameterSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RTax25RegisterParameter> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle DimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionCombination == null))
                {
                    this._DimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("DimensionCombination"));
                }
                return this._DimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _DimensionCombination;
    }
    /// <summary>
    /// There are no comments for RTax25RegisterParameter in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RegisterCode
    /// ParameterCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RegisterCode", "ParameterCode")]
    [global::Microsoft.OData.Client.EntitySet("RTax25RegisterParameters")]
    public partial class RTax25RegisterParameter : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RTax25RegisterParameter object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="registerCode">Initial value of RegisterCode.</param>
        /// <param name="parameterCode">Initial value of ParameterCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RTax25RegisterParameter CreateRTax25RegisterParameter(string dataAreaId, string registerCode, int parameterCode)
        {
            RTax25RegisterParameter rTax25RegisterParameter = new RTax25RegisterParameter();
            rTax25RegisterParameter.dataAreaId = dataAreaId;
            rTax25RegisterParameter.RegisterCode = registerCode;
            rTax25RegisterParameter.ParameterCode = parameterCode;
            return rTax25RegisterParameter;
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
        /// There are no comments for Property RegisterCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RegisterCode
        {
            get
            {
                return this._RegisterCode;
            }
            set
            {
                this.OnRegisterCodeChanging(value);
                this._RegisterCode = value;
                this.OnRegisterCodeChanged();
                this.OnPropertyChanged("RegisterCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RegisterCode;
        partial void OnRegisterCodeChanging(string value);
        partial void OnRegisterCodeChanged();
        /// <summary>
        /// There are no comments for Property ParameterCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int ParameterCode
        {
            get
            {
                return this._ParameterCode;
            }
            set
            {
                this.OnParameterCodeChanging(value);
                this._ParameterCode = value;
                this.OnParameterCodeChanged();
                this.OnPropertyChanged("ParameterCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ParameterCode;
        partial void OnParameterCodeChanging(int value);
        partial void OnParameterCodeChanged();
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
        /// <summary>
        /// There are no comments for Property MainAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MainAccountDisplayValue
        {
            get
            {
                return this._MainAccountDisplayValue;
            }
            set
            {
                this.OnMainAccountDisplayValueChanging(value);
                this._MainAccountDisplayValue = value;
                this.OnMainAccountDisplayValueChanged();
                this.OnPropertyChanged("MainAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountDisplayValue;
        partial void OnMainAccountDisplayValueChanging(string value);
        partial void OnMainAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property ParameterName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ParameterName
        {
            get
            {
                return this._ParameterName;
            }
            set
            {
                this.OnParameterNameChanging(value);
                this._ParameterName = value;
                this.OnParameterNameChanged();
                this.OnPropertyChanged("ParameterName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ParameterName;
        partial void OnParameterNameChanging(string value);
        partial void OnParameterNameChanged();
        /// <summary>
        /// There are no comments for Property DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination DimensionCombination
        {
            get
            {
                return this._DimensionCombination;
            }
            set
            {
                this.OnDimensionCombinationChanging(value);
                this._DimensionCombination = value;
                this.OnDimensionCombinationChanged();
                this.OnPropertyChanged("DimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _DimensionCombination;
        partial void OnDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnDimensionCombinationChanged();
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
