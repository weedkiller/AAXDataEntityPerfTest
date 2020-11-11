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
        /// There are no comments for ProjectCategoryEntitySingle in the schema.
        /// </summary>
    public partial class ProjectCategoryEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectCategoryEntity>
    {
        /// <summary>
        /// Initialize a new ProjectCategoryEntitySingle object.
        /// </summary>
        public ProjectCategoryEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjectCategoryEntitySingle object.
        /// </summary>
        public ProjectCategoryEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjectCategoryEntitySingle object.
        /// </summary>
        public ProjectCategoryEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectCategoryEntity> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductsV2 == null))
                {
                    this._ReleasedProductsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(GetPath("ReleasedProductsV2"));
                }
                return this._ReleasedProductsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2;
        /// <summary>
        /// There are no comments for WBS in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProjectWBSDraft> WBS
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WBS == null))
                {
                    this._WBS = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProjectWBSDraft>(GetPath("WBS"));
                }
                return this._WBS;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProjectWBSDraft> _WBS;
        /// <summary>
        /// There are no comments for ProjWBSActivityEstimate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProjWBSActivityEstimate> ProjWBSActivityEstimate
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProjWBSActivityEstimate == null))
                {
                    this._ProjWBSActivityEstimate = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProjWBSActivityEstimate>(GetPath("ProjWBSActivityEstimate"));
                }
                return this._ProjWBSActivityEstimate;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProjWBSActivityEstimate> _ProjWBSActivityEstimate;
        /// <summary>
        /// There are no comments for ProjWBSTemplateTask in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProjWBSTemplateTask> ProjWBSTemplateTask
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProjWBSTemplateTask == null))
                {
                    this._ProjWBSTemplateTask = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProjWBSTemplateTask>(GetPath("ProjWBSTemplateTask"));
                }
                return this._ProjWBSTemplateTask;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProjWBSTemplateTask> _ProjWBSTemplateTask;
        /// <summary>
        /// There are no comments for JournalTrans in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.JournalTransSingle JournalTrans
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JournalTrans == null))
                {
                    this._JournalTrans = new global::Microsoft.Dynamics.DataEntities.JournalTransSingle(this.Context, GetPath("JournalTrans"));
                }
                return this._JournalTrans;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JournalTransSingle _JournalTrans;
        /// <summary>
        /// There are no comments for ProjectQuotationWbsTask in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProjectQuotationWbsTask> ProjectQuotationWbsTask
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProjectQuotationWbsTask == null))
                {
                    this._ProjectQuotationWbsTask = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProjectQuotationWbsTask>(GetPath("ProjectQuotationWbsTask"));
                }
                return this._ProjectQuotationWbsTask;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProjectQuotationWbsTask> _ProjectQuotationWbsTask;
    }
        /// <summary>
        /// There are no comments for ProjectCategoryEntity in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// Category
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Category")]
    [global::Microsoft.OData.Client.EntitySet("ProjectCategoryEntities")]
    public partial class ProjectCategoryEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjectCategoryEntity object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="category">Initial value of Category.</param>
        /// <param name="journalTrans">Initial value of JournalTrans.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjectCategoryEntity CreateProjectCategoryEntity(string dataAreaId, string category, global::Microsoft.Dynamics.DataEntities.JournalTrans journalTrans)
        {
            ProjectCategoryEntity projectCategoryEntity = new ProjectCategoryEntity();
            projectCategoryEntity.dataAreaId = dataAreaId;
            projectCategoryEntity.Category = category;
            if ((journalTrans == null))
            {
                throw new global::System.ArgumentNullException("journalTrans");
            }
            projectCategoryEntity.JournalTrans = journalTrans;
            return projectCategoryEntity;
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
        /// There are no comments for Property Category in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                this.OnCategoryChanging(value);
                this._Category = value;
                this.OnCategoryChanged();
                this.OnPropertyChanged("Category");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Category;
        partial void OnCategoryChanging(string value);
        partial void OnCategoryChanged();
        /// <summary>
        /// There are no comments for Property FiscalInformationServiceCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FiscalInformationServiceCode
        {
            get
            {
                return this._FiscalInformationServiceCode;
            }
            set
            {
                this.OnFiscalInformationServiceCodeChanging(value);
                this._FiscalInformationServiceCode = value;
                this.OnFiscalInformationServiceCodeChanged();
                this.OnPropertyChanged("FiscalInformationServiceCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiscalInformationServiceCode;
        partial void OnFiscalInformationServiceCodeChanging(string value);
        partial void OnFiscalInformationServiceCodeChanged();
        /// <summary>
        /// There are no comments for Property Subscription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Subscription
        {
            get
            {
                return this._Subscription;
            }
            set
            {
                this.OnSubscriptionChanging(value);
                this._Subscription = value;
                this.OnSubscriptionChanged();
                this.OnPropertyChanged("Subscription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Subscription;
        partial void OnSubscriptionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnSubscriptionChanged();
        /// <summary>
        /// There are no comments for Property Absence in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Absence
        {
            get
            {
                return this._Absence;
            }
            set
            {
                this.OnAbsenceChanging(value);
                this._Absence = value;
                this.OnAbsenceChanged();
                this.OnPropertyChanged("Absence");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Absence;
        partial void OnAbsenceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAbsenceChanged();
        /// <summary>
        /// There are no comments for Property CategoryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CategoryName
        {
            get
            {
                return this._CategoryName;
            }
            set
            {
                this.OnCategoryNameChanging(value);
                this._CategoryName = value;
                this.OnCategoryNameChanged();
                this.OnPropertyChanged("CategoryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CategoryName;
        partial void OnCategoryNameChanging(string value);
        partial void OnCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property IndirectCostComponent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IndirectCostComponent
        {
            get
            {
                return this._IndirectCostComponent;
            }
            set
            {
                this.OnIndirectCostComponentChanging(value);
                this._IndirectCostComponent = value;
                this.OnIndirectCostComponentChanged();
                this.OnPropertyChanged("IndirectCostComponent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IndirectCostComponent;
        partial void OnIndirectCostComponentChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIndirectCostComponentChanged();
        /// <summary>
        /// There are no comments for Property Estimate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Estimate
        {
            get
            {
                return this._Estimate;
            }
            set
            {
                this.OnEstimateChanging(value);
                this._Estimate = value;
                this.OnEstimateChanged();
                this.OnPropertyChanged("Estimate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Estimate;
        partial void OnEstimateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnEstimateChanged();
        /// <summary>
        /// There are no comments for Property ItemSalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ItemSalesTaxGroup
        {
            get
            {
                return this._ItemSalesTaxGroup;
            }
            set
            {
                this.OnItemSalesTaxGroupChanging(value);
                this._ItemSalesTaxGroup = value;
                this.OnItemSalesTaxGroupChanged();
                this.OnPropertyChanged("ItemSalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemSalesTaxGroup;
        partial void OnItemSalesTaxGroupChanging(string value);
        partial void OnItemSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property CustomerPaymentRetention in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CustomerPaymentRetention
        {
            get
            {
                return this._CustomerPaymentRetention;
            }
            set
            {
                this.OnCustomerPaymentRetentionChanging(value);
                this._CustomerPaymentRetention = value;
                this.OnCustomerPaymentRetentionChanged();
                this.OnPropertyChanged("CustomerPaymentRetention");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CustomerPaymentRetention;
        partial void OnCustomerPaymentRetentionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCustomerPaymentRetentionChanged();
        /// <summary>
        /// There are no comments for Property ActiveInJournals in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ActiveInJournals
        {
            get
            {
                return this._ActiveInJournals;
            }
            set
            {
                this.OnActiveInJournalsChanging(value);
                this._ActiveInJournals = value;
                this.OnActiveInJournalsChanged();
                this.OnPropertyChanged("ActiveInJournals");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ActiveInJournals;
        partial void OnActiveInJournalsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnActiveInJournalsChanged();
        /// <summary>
        /// There are no comments for Property CategoryGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CategoryGroup
        {
            get
            {
                return this._CategoryGroup;
            }
            set
            {
                this.OnCategoryGroupChanging(value);
                this._CategoryGroup = value;
                this.OnCategoryGroupChanged();
                this.OnPropertyChanged("CategoryGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CategoryGroup;
        partial void OnCategoryGroupChanging(string value);
        partial void OnCategoryGroupChanged();
        /// <summary>
        /// There are no comments for Property TransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjCategoryType> TransactionType
        {
            get
            {
                return this._TransactionType;
            }
            set
            {
                this.OnTransactionTypeChanging(value);
                this._TransactionType = value;
                this.OnTransactionTypeChanged();
                this.OnPropertyChanged("TransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjCategoryType> _TransactionType;
        partial void OnTransactionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjCategoryType> value);
        partial void OnTransactionTypeChanged();
        /// <summary>
        /// There are no comments for Property ItemWithholdingTaxGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ItemWithholdingTaxGroupId
        {
            get
            {
                return this._ItemWithholdingTaxGroupId;
            }
            set
            {
                this.OnItemWithholdingTaxGroupIdChanging(value);
                this._ItemWithholdingTaxGroupId = value;
                this.OnItemWithholdingTaxGroupIdChanged();
                this.OnPropertyChanged("ItemWithholdingTaxGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemWithholdingTaxGroupId;
        partial void OnItemWithholdingTaxGroupIdChanging(string value);
        partial void OnItemWithholdingTaxGroupIdChanged();
        /// <summary>
        /// There are no comments for Property TaxRateTypeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxRateTypeName
        {
            get
            {
                return this._TaxRateTypeName;
            }
            set
            {
                this.OnTaxRateTypeNameChanging(value);
                this._TaxRateTypeName = value;
                this.OnTaxRateTypeNameChanged();
                this.OnPropertyChanged("TaxRateTypeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxRateTypeName;
        partial void OnTaxRateTypeNameChanging(string value);
        partial void OnTaxRateTypeNameChanged();
        /// <summary>
        /// There are no comments for Property Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjCategoryEmplOption> Worker
        {
            get
            {
                return this._Worker;
            }
            set
            {
                this.OnWorkerChanging(value);
                this._Worker = value;
                this.OnWorkerChanged();
                this.OnPropertyChanged("Worker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjCategoryEmplOption> _Worker;
        partial void OnWorkerChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjCategoryEmplOption> value);
        partial void OnWorkerChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                return this._ReleasedProductsV2;
            }
            set
            {
                this.OnReleasedProductsV2Changing(value);
                this._ReleasedProductsV2 = value;
                this.OnReleasedProductsV2Changed();
                this.OnPropertyChanged("ReleasedProductsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedProductsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> value);
        partial void OnReleasedProductsV2Changed();
        /// <summary>
        /// There are no comments for Property WBS in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectWBSDraft> WBS
        {
            get
            {
                return this._WBS;
            }
            set
            {
                this.OnWBSChanging(value);
                this._WBS = value;
                this.OnWBSChanged();
                this.OnPropertyChanged("WBS");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectWBSDraft> _WBS = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectWBSDraft>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWBSChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectWBSDraft> value);
        partial void OnWBSChanged();
        /// <summary>
        /// There are no comments for Property ProjWBSActivityEstimate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjWBSActivityEstimate> ProjWBSActivityEstimate
        {
            get
            {
                return this._ProjWBSActivityEstimate;
            }
            set
            {
                this.OnProjWBSActivityEstimateChanging(value);
                this._ProjWBSActivityEstimate = value;
                this.OnProjWBSActivityEstimateChanged();
                this.OnPropertyChanged("ProjWBSActivityEstimate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjWBSActivityEstimate> _ProjWBSActivityEstimate = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjWBSActivityEstimate>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProjWBSActivityEstimateChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjWBSActivityEstimate> value);
        partial void OnProjWBSActivityEstimateChanged();
        /// <summary>
        /// There are no comments for Property ProjWBSTemplateTask in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjWBSTemplateTask> ProjWBSTemplateTask
        {
            get
            {
                return this._ProjWBSTemplateTask;
            }
            set
            {
                this.OnProjWBSTemplateTaskChanging(value);
                this._ProjWBSTemplateTask = value;
                this.OnProjWBSTemplateTaskChanged();
                this.OnPropertyChanged("ProjWBSTemplateTask");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjWBSTemplateTask> _ProjWBSTemplateTask = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjWBSTemplateTask>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProjWBSTemplateTaskChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjWBSTemplateTask> value);
        partial void OnProjWBSTemplateTaskChanged();
        /// <summary>
        /// There are no comments for Property JournalTrans in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.JournalTrans JournalTrans
        {
            get
            {
                return this._JournalTrans;
            }
            set
            {
                this.OnJournalTransChanging(value);
                this._JournalTrans = value;
                this.OnJournalTransChanged();
                this.OnPropertyChanged("JournalTrans");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JournalTrans _JournalTrans;
        partial void OnJournalTransChanging(global::Microsoft.Dynamics.DataEntities.JournalTrans value);
        partial void OnJournalTransChanged();
        /// <summary>
        /// There are no comments for Property ProjectQuotationWbsTask in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectQuotationWbsTask> ProjectQuotationWbsTask
        {
            get
            {
                return this._ProjectQuotationWbsTask;
            }
            set
            {
                this.OnProjectQuotationWbsTaskChanging(value);
                this._ProjectQuotationWbsTask = value;
                this.OnProjectQuotationWbsTaskChanged();
                this.OnPropertyChanged("ProjectQuotationWbsTask");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectQuotationWbsTask> _ProjectQuotationWbsTask = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectQuotationWbsTask>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProjectQuotationWbsTaskChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectQuotationWbsTask> value);
        partial void OnProjectQuotationWbsTaskChanged();
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