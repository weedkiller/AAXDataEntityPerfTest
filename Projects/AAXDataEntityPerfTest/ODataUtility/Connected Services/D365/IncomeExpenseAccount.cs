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
        /// There are no comments for IncomeExpenseAccountSingle in the schema.
        /// </summary>
    public partial class IncomeExpenseAccountSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<IncomeExpenseAccount>
    {
        /// <summary>
        /// Initialize a new IncomeExpenseAccountSingle object.
        /// </summary>
        public IncomeExpenseAccountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new IncomeExpenseAccountSingle object.
        /// </summary>
        public IncomeExpenseAccountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new IncomeExpenseAccountSingle object.
        /// </summary>
        public IncomeExpenseAccountSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<IncomeExpenseAccount> query)
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
        /// There are no comments for IncomeExpenseAccount in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// StoreNumber
    /// AccountNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "StoreNumber", "AccountNumber")]
    [global::Microsoft.OData.Client.EntitySet("IncomeExpenseAccounts")]
    public partial class IncomeExpenseAccount : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new IncomeExpenseAccount object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="storeNumber">Initial value of StoreNumber.</param>
        /// <param name="accountNumber">Initial value of AccountNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static IncomeExpenseAccount CreateIncomeExpenseAccount(string dataAreaId, string storeNumber, string accountNumber)
        {
            IncomeExpenseAccount incomeExpenseAccount = new IncomeExpenseAccount();
            incomeExpenseAccount.dataAreaId = dataAreaId;
            incomeExpenseAccount.StoreNumber = storeNumber;
            incomeExpenseAccount.AccountNumber = accountNumber;
            return incomeExpenseAccount;
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
        /// There are no comments for Property StoreNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string StoreNumber
        {
            get
            {
                return this._StoreNumber;
            }
            set
            {
                this.OnStoreNumberChanging(value);
                this._StoreNumber = value;
                this.OnStoreNumberChanged();
                this.OnPropertyChanged("StoreNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StoreNumber;
        partial void OnStoreNumberChanging(string value);
        partial void OnStoreNumberChanged();
        /// <summary>
        /// There are no comments for Property AccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccountNumber
        {
            get
            {
                return this._AccountNumber;
            }
            set
            {
                this.OnAccountNumberChanging(value);
                this._AccountNumber = value;
                this.OnAccountNumberChanged();
                this.OnPropertyChanged("AccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountNumber;
        partial void OnAccountNumberChanging(string value);
        partial void OnAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property MessageLine2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MessageLine2
        {
            get
            {
                return this._MessageLine2;
            }
            set
            {
                this.OnMessageLine2Changing(value);
                this._MessageLine2 = value;
                this.OnMessageLine2Changed();
                this.OnPropertyChanged("MessageLine2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MessageLine2;
        partial void OnMessageLine2Changing(string value);
        partial void OnMessageLine2Changed();
        /// <summary>
        /// There are no comments for Property SlipText2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SlipText2
        {
            get
            {
                return this._SlipText2;
            }
            set
            {
                this.OnSlipText2Changing(value);
                this._SlipText2 = value;
                this.OnSlipText2Changed();
                this.OnPropertyChanged("SlipText2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SlipText2;
        partial void OnSlipText2Changing(string value);
        partial void OnSlipText2Changed();
        /// <summary>
        /// There are no comments for Property SlipText1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SlipText1
        {
            get
            {
                return this._SlipText1;
            }
            set
            {
                this.OnSlipText1Changing(value);
                this._SlipText1 = value;
                this.OnSlipText1Changed();
                this.OnPropertyChanged("SlipText1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SlipText1;
        partial void OnSlipText1Changing(string value);
        partial void OnSlipText1Changed();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property AccountType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailIncomeExpense> AccountType
        {
            get
            {
                return this._AccountType;
            }
            set
            {
                this.OnAccountTypeChanging(value);
                this._AccountType = value;
                this.OnAccountTypeChanged();
                this.OnPropertyChanged("AccountType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailIncomeExpense> _AccountType;
        partial void OnAccountTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailIncomeExpense> value);
        partial void OnAccountTypeChanged();
        /// <summary>
        /// There are no comments for Property MessageLine1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MessageLine1
        {
            get
            {
                return this._MessageLine1;
            }
            set
            {
                this.OnMessageLine1Changing(value);
                this._MessageLine1 = value;
                this.OnMessageLine1Changed();
                this.OnPropertyChanged("MessageLine1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MessageLine1;
        partial void OnMessageLine1Changing(string value);
        partial void OnMessageLine1Changed();
        /// <summary>
        /// There are no comments for Property LedgerAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LedgerAccountDisplayValue
        {
            get
            {
                return this._LedgerAccountDisplayValue;
            }
            set
            {
                this.OnLedgerAccountDisplayValueChanging(value);
                this._LedgerAccountDisplayValue = value;
                this.OnLedgerAccountDisplayValueChanged();
                this.OnPropertyChanged("LedgerAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LedgerAccountDisplayValue;
        partial void OnLedgerAccountDisplayValueChanging(string value);
        partial void OnLedgerAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property SearchName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SearchName
        {
            get
            {
                return this._SearchName;
            }
            set
            {
                this.OnSearchNameChanging(value);
                this._SearchName = value;
                this.OnSearchNameChanged();
                this.OnPropertyChanged("SearchName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SearchName;
        partial void OnSearchNameChanging(string value);
        partial void OnSearchNameChanged();
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
