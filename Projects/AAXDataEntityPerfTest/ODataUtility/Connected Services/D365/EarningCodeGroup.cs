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
        /// There are no comments for EarningCodeGroupSingle in the schema.
        /// </summary>
    public partial class EarningCodeGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EarningCodeGroup>
    {
        /// <summary>
        /// Initialize a new EarningCodeGroupSingle object.
        /// </summary>
        public EarningCodeGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EarningCodeGroupSingle object.
        /// </summary>
        public EarningCodeGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EarningCodeGroupSingle object.
        /// </summary>
        public EarningCodeGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EarningCodeGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TotalCompStatementSectionEarning in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionEarning> TotalCompStatementSectionEarning
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TotalCompStatementSectionEarning == null))
                {
                    this._TotalCompStatementSectionEarning = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionEarning>(GetPath("TotalCompStatementSectionEarning"));
                }
                return this._TotalCompStatementSectionEarning;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionEarning> _TotalCompStatementSectionEarning;
        /// <summary>
        /// There are no comments for AccrualBasisEarningCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AccrualBasisEarningCode> AccrualBasisEarningCodes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AccrualBasisEarningCodes == null))
                {
                    this._AccrualBasisEarningCodes = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AccrualBasisEarningCode>(GetPath("AccrualBasisEarningCodes"));
                }
                return this._AccrualBasisEarningCodes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AccrualBasisEarningCode> _AccrualBasisEarningCodes;
    }
        /// <summary>
        /// There are no comments for EarningCodeGroup in the schema.
        /// </summary>
    /// <KeyProperties>
    /// EarningCodeGroup
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("EarningCodeGroup")]
    [global::Microsoft.OData.Client.EntitySet("EarningCodeGroups")]
    public partial class EarningCodeGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EarningCodeGroup object.
        /// </summary>
        /// <param name="earningCodeGroup1">Initial value of EarningCodeGroup1.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EarningCodeGroup CreateEarningCodeGroup(string earningCodeGroup1)
        {
            EarningCodeGroup earningCodeGroup = new EarningCodeGroup();
            earningCodeGroup.EarningCodeGroup1 = earningCodeGroup1;
            return earningCodeGroup;
        }
        /// <summary>
        /// There are no comments for Property EarningCodeGroup1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EarningCodeGroup")]
        public virtual string EarningCodeGroup1
        {
            get
            {
                return this._EarningCodeGroup1;
            }
            set
            {
                this.OnEarningCodeGroup1Changing(value);
                this._EarningCodeGroup1 = value;
                this.OnEarningCodeGroup1Changed();
                this.OnPropertyChanged("EarningCodeGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EarningCodeGroup1;
        partial void OnEarningCodeGroup1Changing(string value);
        partial void OnEarningCodeGroup1Changed();
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
        /// There are no comments for Property TotalCompStatementSectionEarning in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionEarning> TotalCompStatementSectionEarning
        {
            get
            {
                return this._TotalCompStatementSectionEarning;
            }
            set
            {
                this.OnTotalCompStatementSectionEarningChanging(value);
                this._TotalCompStatementSectionEarning = value;
                this.OnTotalCompStatementSectionEarningChanged();
                this.OnPropertyChanged("TotalCompStatementSectionEarning");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionEarning> _TotalCompStatementSectionEarning = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionEarning>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTotalCompStatementSectionEarningChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionEarning> value);
        partial void OnTotalCompStatementSectionEarningChanged();
        /// <summary>
        /// There are no comments for Property AccrualBasisEarningCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccrualBasisEarningCode> AccrualBasisEarningCodes
        {
            get
            {
                return this._AccrualBasisEarningCodes;
            }
            set
            {
                this.OnAccrualBasisEarningCodesChanging(value);
                this._AccrualBasisEarningCodes = value;
                this.OnAccrualBasisEarningCodesChanged();
                this.OnPropertyChanged("AccrualBasisEarningCodes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccrualBasisEarningCode> _AccrualBasisEarningCodes = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccrualBasisEarningCode>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAccrualBasisEarningCodesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AccrualBasisEarningCode> value);
        partial void OnAccrualBasisEarningCodesChanged();
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
