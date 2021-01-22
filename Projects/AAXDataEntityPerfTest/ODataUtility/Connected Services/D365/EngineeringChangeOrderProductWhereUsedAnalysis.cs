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
        /// There are no comments for EngineeringChangeOrderProductWhereUsedAnalysisSingle in the schema.
        /// </summary>
    public partial class EngineeringChangeOrderProductWhereUsedAnalysisSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductWhereUsedAnalysis>
    {
        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductWhereUsedAnalysisSingle object.
        /// </summary>
        public EngineeringChangeOrderProductWhereUsedAnalysisSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductWhereUsedAnalysisSingle object.
        /// </summary>
        public EngineeringChangeOrderProductWhereUsedAnalysisSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductWhereUsedAnalysisSingle object.
        /// </summary>
        public EngineeringChangeOrderProductWhereUsedAnalysisSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductWhereUsedAnalysis> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for UsedInProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductV2Single UsedInProduct
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._UsedInProduct == null))
                {
                    this._UsedInProduct = new global::Microsoft.Dynamics.DataEntities.ProductV2Single(this.Context, GetPath("UsedInProduct"));
                }
                return this._UsedInProduct;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductV2Single _UsedInProduct;
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
        /// <summary>
        /// There are no comments for ReviewerWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle ReviewerWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReviewerWorker == null))
                {
                    this._ReviewerWorker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("ReviewerWorker"));
                }
                return this._ReviewerWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _ReviewerWorker;
    }
        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductWhereUsedAnalysis in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// EngineeringChangeOrderProductLineNumber
    /// UsedInProductNumber
    /// EngineeringChangeOrderNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "EngineeringChangeOrderProductLineNumber", "UsedInProductNumber", "EngineeringChangeOrderNumber")]
    [global::Microsoft.OData.Client.EntitySet("EngineeringChangeOrderProductWhereUsedAnalyses")]
    public partial class EngineeringChangeOrderProductWhereUsedAnalysis : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineeringChangeOrderProductWhereUsedAnalysis object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="engineeringChangeOrderProductLineNumber">Initial value of EngineeringChangeOrderProductLineNumber.</param>
        /// <param name="usedInProductNumber">Initial value of UsedInProductNumber.</param>
        /// <param name="engineeringChangeOrderNumber">Initial value of EngineeringChangeOrderNumber.</param>
        /// <param name="usedInProduct">Initial value of UsedInProduct.</param>
        /// <param name="engineeringChangeOrderProduct">Initial value of EngineeringChangeOrderProduct.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EngineeringChangeOrderProductWhereUsedAnalysis CreateEngineeringChangeOrderProductWhereUsedAnalysis(string dataAreaId, 
                    decimal engineeringChangeOrderProductLineNumber, 
                    string usedInProductNumber, 
                    string engineeringChangeOrderNumber, 
                    global::Microsoft.Dynamics.DataEntities.ProductV2 usedInProduct, 
                    global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct engineeringChangeOrderProduct)
        {
            EngineeringChangeOrderProductWhereUsedAnalysis engineeringChangeOrderProductWhereUsedAnalysis = new EngineeringChangeOrderProductWhereUsedAnalysis();
            engineeringChangeOrderProductWhereUsedAnalysis.dataAreaId = dataAreaId;
            engineeringChangeOrderProductWhereUsedAnalysis.EngineeringChangeOrderProductLineNumber = engineeringChangeOrderProductLineNumber;
            engineeringChangeOrderProductWhereUsedAnalysis.UsedInProductNumber = usedInProductNumber;
            engineeringChangeOrderProductWhereUsedAnalysis.EngineeringChangeOrderNumber = engineeringChangeOrderNumber;
            if ((usedInProduct == null))
            {
                throw new global::System.ArgumentNullException("usedInProduct");
            }
            engineeringChangeOrderProductWhereUsedAnalysis.UsedInProduct = usedInProduct;
            if ((engineeringChangeOrderProduct == null))
            {
                throw new global::System.ArgumentNullException("engineeringChangeOrderProduct");
            }
            engineeringChangeOrderProductWhereUsedAnalysis.EngineeringChangeOrderProduct = engineeringChangeOrderProduct;
            return engineeringChangeOrderProductWhereUsedAnalysis;
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
        /// There are no comments for Property UsedInProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UsedInProductNumber
        {
            get
            {
                return this._UsedInProductNumber;
            }
            set
            {
                this.OnUsedInProductNumberChanging(value);
                this._UsedInProductNumber = value;
                this.OnUsedInProductNumberChanged();
                this.OnPropertyChanged("UsedInProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UsedInProductNumber;
        partial void OnUsedInProductNumberChanging(string value);
        partial void OnUsedInProductNumberChanged();
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
        /// There are no comments for Property UsedProductAnalysisStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgEcmWhereUsedStatusType> UsedProductAnalysisStatus
        {
            get
            {
                return this._UsedProductAnalysisStatus;
            }
            set
            {
                this.OnUsedProductAnalysisStatusChanging(value);
                this._UsedProductAnalysisStatus = value;
                this.OnUsedProductAnalysisStatusChanged();
                this.OnPropertyChanged("UsedProductAnalysisStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgEcmWhereUsedStatusType> _UsedProductAnalysisStatus;
        partial void OnUsedProductAnalysisStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgEcmWhereUsedStatusType> value);
        partial void OnUsedProductAnalysisStatusChanged();
        /// <summary>
        /// There are no comments for Property ReviewerPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReviewerPersonnelNumber
        {
            get
            {
                return this._ReviewerPersonnelNumber;
            }
            set
            {
                this.OnReviewerPersonnelNumberChanging(value);
                this._ReviewerPersonnelNumber = value;
                this.OnReviewerPersonnelNumberChanged();
                this.OnPropertyChanged("ReviewerPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReviewerPersonnelNumber;
        partial void OnReviewerPersonnelNumberChanging(string value);
        partial void OnReviewerPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property UsedInProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductV2 UsedInProduct
        {
            get
            {
                return this._UsedInProduct;
            }
            set
            {
                this.OnUsedInProductChanging(value);
                this._UsedInProduct = value;
                this.OnUsedInProductChanged();
                this.OnPropertyChanged("UsedInProduct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductV2 _UsedInProduct;
        partial void OnUsedInProductChanging(global::Microsoft.Dynamics.DataEntities.ProductV2 value);
        partial void OnUsedInProductChanged();
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
        /// There are no comments for Property ReviewerWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker ReviewerWorker
        {
            get
            {
                return this._ReviewerWorker;
            }
            set
            {
                this.OnReviewerWorkerChanging(value);
                this._ReviewerWorker = value;
                this.OnReviewerWorkerChanged();
                this.OnPropertyChanged("ReviewerWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _ReviewerWorker;
        partial void OnReviewerWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnReviewerWorkerChanged();
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
