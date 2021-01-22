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
        /// There are no comments for ImportModeSingle in the schema.
        /// </summary>
    public partial class ImportModeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ImportMode>
    {
        /// <summary>
        /// Initialize a new ImportModeSingle object.
        /// </summary>
        public ImportModeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ImportModeSingle object.
        /// </summary>
        public ImportModeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ImportModeSingle object.
        /// </summary>
        public ImportModeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ImportMode> query)
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
        /// There are no comments for ImportMode in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// MethodOfImport
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "MethodOfImport")]
    [global::Microsoft.OData.Client.EntitySet("ImportModes")]
    public partial class ImportMode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ImportMode object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="methodOfImport">Initial value of MethodOfImport.</param>
        /// <param name="classID">Initial value of ClassID.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ImportMode CreateImportMode(string dataAreaId, string methodOfImport, int classID)
        {
            ImportMode importMode = new ImportMode();
            importMode.dataAreaId = dataAreaId;
            importMode.MethodOfImport = methodOfImport;
            importMode.ClassID = classID;
            return importMode;
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
        /// There are no comments for Property MethodOfImport in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MethodOfImport
        {
            get
            {
                return this._MethodOfImport;
            }
            set
            {
                this.OnMethodOfImportChanging(value);
                this._MethodOfImport = value;
                this.OnMethodOfImportChanged();
                this.OnPropertyChanged("MethodOfImport");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MethodOfImport;
        partial void OnMethodOfImportChanging(string value);
        partial void OnMethodOfImportChanged();
        /// <summary>
        /// There are no comments for Property ClassID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int ClassID
        {
            get
            {
                return this._ClassID;
            }
            set
            {
                this.OnClassIDChanging(value);
                this._ClassID = value;
                this.OnClassIDChanged();
                this.OnPropertyChanged("ClassID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ClassID;
        partial void OnClassIDChanging(int value);
        partial void OnClassIDChanged();
        /// <summary>
        /// There are no comments for Property BankAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BankAccount
        {
            get
            {
                return this._BankAccount;
            }
            set
            {
                this.OnBankAccountChanging(value);
                this._BankAccount = value;
                this.OnBankAccountChanged();
                this.OnPropertyChanged("BankAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BankAccount;
        partial void OnBankAccountChanging(string value);
        partial void OnBankAccountChanged();
        /// <summary>
        /// There are no comments for Property BridgingAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BridgingAccountDisplayValue
        {
            get
            {
                return this._BridgingAccountDisplayValue;
            }
            set
            {
                this.OnBridgingAccountDisplayValueChanging(value);
                this._BridgingAccountDisplayValue = value;
                this.OnBridgingAccountDisplayValueChanged();
                this.OnPropertyChanged("BridgingAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BridgingAccountDisplayValue;
        partial void OnBridgingAccountDisplayValueChanging(string value);
        partial void OnBridgingAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property ClassName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ClassName
        {
            get
            {
                return this._ClassName;
            }
            set
            {
                this.OnClassNameChanging(value);
                this._ClassName = value;
                this.OnClassNameChanged();
                this.OnPropertyChanged("ClassName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ClassName;
        partial void OnClassNameChanging(string value);
        partial void OnClassNameChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
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
