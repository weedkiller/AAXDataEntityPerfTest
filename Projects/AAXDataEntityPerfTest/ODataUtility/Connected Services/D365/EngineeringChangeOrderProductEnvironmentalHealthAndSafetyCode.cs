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
        /// There are no comments for EngineeringChangeOrderProductEnvironmentalHealthAndSafetyCodeSingle in the schema.
        /// </summary>
    public partial class EngineeringChangeOrderProductEnvironmentalHealthAndSafetyCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductEnvironmentalHealthAndSafetyCode>
    {
        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductEnvironmentalHealthAndSafetyCodeSingle object.
        /// </summary>
        public EngineeringChangeOrderProductEnvironmentalHealthAndSafetyCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductEnvironmentalHealthAndSafetyCodeSingle object.
        /// </summary>
        public EngineeringChangeOrderProductEnvironmentalHealthAndSafetyCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductEnvironmentalHealthAndSafetyCodeSingle object.
        /// </summary>
        public EngineeringChangeOrderProductEnvironmentalHealthAndSafetyCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductEnvironmentalHealthAndSafetyCode> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EngineeringChangeOrderProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductSingle EngineeringChangeOrderProduct
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderProduct == null))
                {
                    this._EngineeringChangeOrderProduct = new global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductSingle(this.Context, GetPath("EngineeringChangeOrderProduct"));
                }
                return this._EngineeringChangeOrderProduct;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductSingle _EngineeringChangeOrderProduct;
    }
        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductEnvironmentalHealthAndSafetyCode in the schema.
        /// </summary>
    /// <KeyProperties>
    /// EngineeringChangeOrderNumber
    /// EngineeringChangeOrderProductLineNumber
    /// EnvironmentalHealthAndSafetyCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("EngineeringChangeOrderNumber", "EngineeringChangeOrderProductLineNumber", "EnvironmentalHealthAndSafetyCode")]
    [global::Microsoft.OData.Client.EntitySet("EngineeringChangeOrderProductEnvironmentalHealthAndSafetyCodes")]
    public partial class EngineeringChangeOrderProductEnvironmentalHealthAndSafetyCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineeringChangeOrderProductEnvironmentalHealthAndSafetyCode object.
        /// </summary>
        /// <param name="engineeringChangeOrderNumber">Initial value of EngineeringChangeOrderNumber.</param>
        /// <param name="engineeringChangeOrderProductLineNumber">Initial value of EngineeringChangeOrderProductLineNumber.</param>
        /// <param name="environmentalHealthAndSafetyCode">Initial value of EnvironmentalHealthAndSafetyCode.</param>
        /// <param name="engineeringChangeOrderProduct">Initial value of EngineeringChangeOrderProduct.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EngineeringChangeOrderProductEnvironmentalHealthAndSafetyCode CreateEngineeringChangeOrderProductEnvironmentalHealthAndSafetyCode(string engineeringChangeOrderNumber, decimal engineeringChangeOrderProductLineNumber, string environmentalHealthAndSafetyCode, global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct engineeringChangeOrderProduct)
        {
            EngineeringChangeOrderProductEnvironmentalHealthAndSafetyCode engineeringChangeOrderProductEnvironmentalHealthAndSafetyCode = new EngineeringChangeOrderProductEnvironmentalHealthAndSafetyCode();
            engineeringChangeOrderProductEnvironmentalHealthAndSafetyCode.EngineeringChangeOrderNumber = engineeringChangeOrderNumber;
            engineeringChangeOrderProductEnvironmentalHealthAndSafetyCode.EngineeringChangeOrderProductLineNumber = engineeringChangeOrderProductLineNumber;
            engineeringChangeOrderProductEnvironmentalHealthAndSafetyCode.EnvironmentalHealthAndSafetyCode = environmentalHealthAndSafetyCode;
            if ((engineeringChangeOrderProduct == null))
            {
                throw new global::System.ArgumentNullException("engineeringChangeOrderProduct");
            }
            engineeringChangeOrderProductEnvironmentalHealthAndSafetyCode.EngineeringChangeOrderProduct = engineeringChangeOrderProduct;
            return engineeringChangeOrderProductEnvironmentalHealthAndSafetyCode;
        }
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeOrderNumber
        {
            get
            {
                return this._EngineeringChangeOrderNumber;
            }
            set
            {
                this.OnEngineeringChangeOrderNumberChanging(value);
                this._EngineeringChangeOrderNumber = value;
                this.OnEngineeringChangeOrderNumberChanged();
                this.OnPropertyChanged("EngineeringChangeOrderNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderNumber;
        partial void OnEngineeringChangeOrderNumberChanging(string value);
        partial void OnEngineeringChangeOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal EngineeringChangeOrderProductLineNumber
        {
            get
            {
                return this._EngineeringChangeOrderProductLineNumber;
            }
            set
            {
                this.OnEngineeringChangeOrderProductLineNumberChanging(value);
                this._EngineeringChangeOrderProductLineNumber = value;
                this.OnEngineeringChangeOrderProductLineNumberChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _EngineeringChangeOrderProductLineNumber;
        partial void OnEngineeringChangeOrderProductLineNumberChanging(decimal value);
        partial void OnEngineeringChangeOrderProductLineNumberChanged();
        /// <summary>
        /// There are no comments for Property EnvironmentalHealthAndSafetyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EnvironmentalHealthAndSafetyCode
        {
            get
            {
                return this._EnvironmentalHealthAndSafetyCode;
            }
            set
            {
                this.OnEnvironmentalHealthAndSafetyCodeChanging(value);
                this._EnvironmentalHealthAndSafetyCode = value;
                this.OnEnvironmentalHealthAndSafetyCodeChanged();
                this.OnPropertyChanged("EnvironmentalHealthAndSafetyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EnvironmentalHealthAndSafetyCode;
        partial void OnEnvironmentalHealthAndSafetyCodeChanging(string value);
        partial void OnEnvironmentalHealthAndSafetyCodeChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct EngineeringChangeOrderProduct
        {
            get
            {
                return this._EngineeringChangeOrderProduct;
            }
            set
            {
                this.OnEngineeringChangeOrderProductChanging(value);
                this._EngineeringChangeOrderProduct = value;
                this.OnEngineeringChangeOrderProductChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProduct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct _EngineeringChangeOrderProduct;
        partial void OnEngineeringChangeOrderProductChanging(global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct value);
        partial void OnEngineeringChangeOrderProductChanged();
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