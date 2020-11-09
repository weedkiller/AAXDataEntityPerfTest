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
        /// There are no comments for AccountStructureActivationSingle in the schema.
        /// </summary>
    public partial class AccountStructureActivationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AccountStructureActivation>
    {
        /// <summary>
        /// Initialize a new AccountStructureActivationSingle object.
        /// </summary>
        public AccountStructureActivationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AccountStructureActivationSingle object.
        /// </summary>
        public AccountStructureActivationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AccountStructureActivationSingle object.
        /// </summary>
        public AccountStructureActivationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AccountStructureActivation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LedgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AccountStructureSingle LedgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity == null))
                {
                    this._LedgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity = new global::Microsoft.Dynamics.DataEntities.AccountStructureSingle(this.Context, GetPath("LedgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity"));
                }
                return this._LedgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AccountStructureSingle _LedgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity;
    }
        /// <summary>
        /// There are no comments for AccountStructureActivation in the schema.
        /// </summary>
    /// <KeyProperties>
    /// AccountStructure
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AccountStructure")]
    [global::Microsoft.OData.Client.EntitySet("AccountStructureActivations")]
    public partial class AccountStructureActivation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AccountStructureActivation object.
        /// </summary>
        /// <param name="accountStructure">Initial value of AccountStructure.</param>
        /// <param name="ledgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity">Initial value of LedgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AccountStructureActivation CreateAccountStructureActivation(string accountStructure, global::Microsoft.Dynamics.DataEntities.AccountStructure ledgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity)
        {
            AccountStructureActivation accountStructureActivation = new AccountStructureActivation();
            accountStructureActivation.AccountStructure = accountStructure;
            if ((ledgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity == null))
            {
                throw new global::System.ArgumentNullException("ledgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity");
            }
            accountStructureActivation.LedgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity = ledgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity;
            return accountStructureActivation;
        }
        /// <summary>
        /// There are no comments for Property AccountStructure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccountStructure
        {
            get
            {
                return this._AccountStructure;
            }
            set
            {
                this.OnAccountStructureChanging(value);
                this._AccountStructure = value;
                this.OnAccountStructureChanged();
                this.OnPropertyChanged("AccountStructure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountStructure;
        partial void OnAccountStructureChanging(string value);
        partial void OnAccountStructureChanged();
        /// <summary>
        /// There are no comments for Property DoActivate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DoActivate
        {
            get
            {
                return this._DoActivate;
            }
            set
            {
                this.OnDoActivateChanging(value);
                this._DoActivate = value;
                this.OnDoActivateChanged();
                this.OnPropertyChanged("DoActivate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DoActivate;
        partial void OnDoActivateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDoActivateChanged();
        /// <summary>
        /// There are no comments for Property LedgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AccountStructure LedgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity
        {
            get
            {
                return this._LedgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity;
            }
            set
            {
                this.OnLedgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntityChanging(value);
                this._LedgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity = value;
                this.OnLedgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntityChanged();
                this.OnPropertyChanged("LedgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AccountStructure _LedgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntity;
        partial void OnLedgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntityChanging(global::Microsoft.Dynamics.DataEntities.AccountStructure value);
        partial void OnLedgerAccountStructureActivationEntity_RelatedRole_LedgerAccountStructureEntityChanged();
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
