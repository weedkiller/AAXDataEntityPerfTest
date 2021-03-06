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
    /// There are no comments for RetailTransactionAttributeSingle in the schema.
    /// </summary>
    public partial class RetailTransactionAttributeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTransactionAttribute>
    {
        /// <summary>
        /// Initialize a new RetailTransactionAttributeSingle object.
        /// </summary>
        public RetailTransactionAttributeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailTransactionAttributeSingle object.
        /// </summary>
        public RetailTransactionAttributeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailTransactionAttributeSingle object.
        /// </summary>
        public RetailTransactionAttributeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTransactionAttribute> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailTransactionAttribute in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// AttributeName
    /// TransactionNumber
    /// Terminal
    /// OperatingUnitNumber
    /// HeaderOrLineNum
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "AttributeName", "TransactionNumber", "Terminal", "OperatingUnitNumber", "HeaderOrLineNum")]
    [global::Microsoft.OData.Client.EntitySet("RetailTransactionAttributes")]
    public partial class RetailTransactionAttribute : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailTransactionAttribute object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="attributeName">Initial value of AttributeName.</param>
        /// <param name="transactionNumber">Initial value of TransactionNumber.</param>
        /// <param name="terminal">Initial value of Terminal.</param>
        /// <param name="operatingUnitNumber">Initial value of OperatingUnitNumber.</param>
        /// <param name="headerOrLineNum">Initial value of HeaderOrLineNum.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailTransactionAttribute CreateRetailTransactionAttribute(string dataAreaId, 
                    string attributeName, 
                    string transactionNumber, 
                    string terminal, 
                    string operatingUnitNumber, 
                    decimal headerOrLineNum)
        {
            RetailTransactionAttribute retailTransactionAttribute = new RetailTransactionAttribute();
            retailTransactionAttribute.dataAreaId = dataAreaId;
            retailTransactionAttribute.AttributeName = attributeName;
            retailTransactionAttribute.TransactionNumber = transactionNumber;
            retailTransactionAttribute.Terminal = terminal;
            retailTransactionAttribute.OperatingUnitNumber = operatingUnitNumber;
            retailTransactionAttribute.HeaderOrLineNum = headerOrLineNum;
            return retailTransactionAttribute;
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
        /// There are no comments for Property TransactionNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TransactionNumber
        {
            get
            {
                return this._TransactionNumber;
            }
            set
            {
                this.OnTransactionNumberChanging(value);
                this._TransactionNumber = value;
                this.OnTransactionNumberChanged();
                this.OnPropertyChanged("TransactionNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransactionNumber;
        partial void OnTransactionNumberChanging(string value);
        partial void OnTransactionNumberChanged();
        /// <summary>
        /// There are no comments for Property Terminal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Terminal
        {
            get
            {
                return this._Terminal;
            }
            set
            {
                this.OnTerminalChanging(value);
                this._Terminal = value;
                this.OnTerminalChanged();
                this.OnPropertyChanged("Terminal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Terminal;
        partial void OnTerminalChanging(string value);
        partial void OnTerminalChanged();
        /// <summary>
        /// There are no comments for Property OperatingUnitNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OperatingUnitNumber
        {
            get
            {
                return this._OperatingUnitNumber;
            }
            set
            {
                this.OnOperatingUnitNumberChanging(value);
                this._OperatingUnitNumber = value;
                this.OnOperatingUnitNumberChanged();
                this.OnPropertyChanged("OperatingUnitNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OperatingUnitNumber;
        partial void OnOperatingUnitNumberChanging(string value);
        partial void OnOperatingUnitNumberChanged();
        /// <summary>
        /// There are no comments for Property HeaderOrLineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal HeaderOrLineNum
        {
            get
            {
                return this._HeaderOrLineNum;
            }
            set
            {
                this.OnHeaderOrLineNumChanging(value);
                this._HeaderOrLineNum = value;
                this.OnHeaderOrLineNumChanged();
                this.OnPropertyChanged("HeaderOrLineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _HeaderOrLineNum;
        partial void OnHeaderOrLineNumChanging(decimal value);
        partial void OnHeaderOrLineNumChanged();
        /// <summary>
        /// There are no comments for Property AttributeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AttributeValue
        {
            get
            {
                return this._AttributeValue;
            }
            set
            {
                this.OnAttributeValueChanging(value);
                this._AttributeValue = value;
                this.OnAttributeValueChanged();
                this.OnPropertyChanged("AttributeValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeValue;
        partial void OnAttributeValueChanging(string value);
        partial void OnAttributeValueChanged();
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
