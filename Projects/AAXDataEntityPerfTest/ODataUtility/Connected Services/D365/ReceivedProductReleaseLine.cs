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
        /// There are no comments for ReceivedProductReleaseLineSingle in the schema.
        /// </summary>
    public partial class ReceivedProductReleaseLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ReceivedProductReleaseLine>
    {
        /// <summary>
        /// Initialize a new ReceivedProductReleaseLineSingle object.
        /// </summary>
        public ReceivedProductReleaseLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ReceivedProductReleaseLineSingle object.
        /// </summary>
        public ReceivedProductReleaseLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ReceivedProductReleaseLineSingle object.
        /// </summary>
        public ReceivedProductReleaseLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ReceivedProductReleaseLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReceivedProductReleaseHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseHeaderSingle ReceivedProductReleaseHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReceivedProductReleaseHeader == null))
                {
                    this._ReceivedProductReleaseHeader = new global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseHeaderSingle(this.Context, GetPath("ReceivedProductReleaseHeader"));
                }
                return this._ReceivedProductReleaseHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseHeaderSingle _ReceivedProductReleaseHeader;
        /// <summary>
        /// There are no comments for BOMBillOfMaterialsHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLineV3Single BOMBillOfMaterialsHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BOMBillOfMaterialsHeader == null))
                {
                    this._BOMBillOfMaterialsHeader = new global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLineV3Single(this.Context, GetPath("BOMBillOfMaterialsHeader"));
                }
                return this._BOMBillOfMaterialsHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLineV3Single _BOMBillOfMaterialsHeader;
        /// <summary>
        /// There are no comments for RouteHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RouteHeaderSingle RouteHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RouteHeader == null))
                {
                    this._RouteHeader = new global::Microsoft.Dynamics.DataEntities.RouteHeaderSingle(this.Context, GetPath("RouteHeader"));
                }
                return this._RouteHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RouteHeaderSingle _RouteHeader;
        /// <summary>
        /// There are no comments for ProductReleaseProductDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductReleaseProductDetailSingle ProductReleaseProductDetails
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductReleaseProductDetails == null))
                {
                    this._ProductReleaseProductDetails = new global::Microsoft.Dynamics.DataEntities.ProductReleaseProductDetailSingle(this.Context, GetPath("ProductReleaseProductDetails"));
                }
                return this._ProductReleaseProductDetails;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductReleaseProductDetailSingle _ProductReleaseProductDetails;
        /// <summary>
        /// There are no comments for ParentReceivedProductReleaseLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLineSingle ParentReceivedProductReleaseLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ParentReceivedProductReleaseLine == null))
                {
                    this._ParentReceivedProductReleaseLine = new global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLineSingle(this.Context, GetPath("ParentReceivedProductReleaseLine"));
                }
                return this._ParentReceivedProductReleaseLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLineSingle _ParentReceivedProductReleaseLine;
        /// <summary>
        /// There are no comments for ReceivedProductReleaseLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine> ReceivedProductReleaseLines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReceivedProductReleaseLines == null))
                {
                    this._ReceivedProductReleaseLines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine>(GetPath("ReceivedProductReleaseLines"));
                }
                return this._ReceivedProductReleaseLines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine> _ReceivedProductReleaseLines;
    }
        /// <summary>
        /// There are no comments for ReceivedProductReleaseLine in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// HeaderProductNumber
    /// HeaderProductVersionId
    /// LineNumber
    /// ReleasingLegalEntityId
    /// ReleaseStatus
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "HeaderProductNumber", "HeaderProductVersionId", "LineNumber", "ReleasingLegalEntityId", "ReleaseStatus")]
    [global::Microsoft.OData.Client.EntitySet("ReceivedProductReleaseLines")]
    public partial class ReceivedProductReleaseLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ReceivedProductReleaseLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="headerProductNumber">Initial value of HeaderProductNumber.</param>
        /// <param name="headerProductVersionId">Initial value of HeaderProductVersionId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="releasingLegalEntityId">Initial value of ReleasingLegalEntityId.</param>
        /// <param name="billOfMaterialsLineCreationSequenceNumber">Initial value of BillOfMaterialsLineCreationSequenceNumber.</param>
        /// <param name="parentLineNumber">Initial value of ParentLineNumber.</param>
        /// <param name="receivedProductReleaseHeader">Initial value of ReceivedProductReleaseHeader.</param>
        /// <param name="bOMBillOfMaterialsHeader">Initial value of BOMBillOfMaterialsHeader.</param>
        /// <param name="productReleaseProductDetails">Initial value of ProductReleaseProductDetails.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ReceivedProductReleaseLine CreateReceivedProductReleaseLine(string dataAreaId, 
                    string headerProductNumber, 
                    string headerProductVersionId, 
                    decimal lineNumber, 
                    string releasingLegalEntityId, 
                    int billOfMaterialsLineCreationSequenceNumber, 
                    decimal parentLineNumber, 
                    global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseHeader receivedProductReleaseHeader, 
                    global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLineV3 bOMBillOfMaterialsHeader, 
                    global::Microsoft.Dynamics.DataEntities.ProductReleaseProductDetail productReleaseProductDetails)
        {
            ReceivedProductReleaseLine receivedProductReleaseLine = new ReceivedProductReleaseLine();
            receivedProductReleaseLine.dataAreaId = dataAreaId;
            receivedProductReleaseLine.HeaderProductNumber = headerProductNumber;
            receivedProductReleaseLine.HeaderProductVersionId = headerProductVersionId;
            receivedProductReleaseLine.LineNumber = lineNumber;
            receivedProductReleaseLine.ReleasingLegalEntityId = releasingLegalEntityId;
            receivedProductReleaseLine.BillOfMaterialsLineCreationSequenceNumber = billOfMaterialsLineCreationSequenceNumber;
            receivedProductReleaseLine.ParentLineNumber = parentLineNumber;
            if ((receivedProductReleaseHeader == null))
            {
                throw new global::System.ArgumentNullException("receivedProductReleaseHeader");
            }
            receivedProductReleaseLine.ReceivedProductReleaseHeader = receivedProductReleaseHeader;
            if ((bOMBillOfMaterialsHeader == null))
            {
                throw new global::System.ArgumentNullException("bOMBillOfMaterialsHeader");
            }
            receivedProductReleaseLine.BOMBillOfMaterialsHeader = bOMBillOfMaterialsHeader;
            if ((productReleaseProductDetails == null))
            {
                throw new global::System.ArgumentNullException("productReleaseProductDetails");
            }
            receivedProductReleaseLine.ProductReleaseProductDetails = productReleaseProductDetails;
            return receivedProductReleaseLine;
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
        /// There are no comments for Property HeaderProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string HeaderProductNumber
        {
            get
            {
                return this._HeaderProductNumber;
            }
            set
            {
                this.OnHeaderProductNumberChanging(value);
                this._HeaderProductNumber = value;
                this.OnHeaderProductNumberChanged();
                this.OnPropertyChanged("HeaderProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HeaderProductNumber;
        partial void OnHeaderProductNumberChanging(string value);
        partial void OnHeaderProductNumberChanged();
        /// <summary>
        /// There are no comments for Property HeaderProductVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string HeaderProductVersionId
        {
            get
            {
                return this._HeaderProductVersionId;
            }
            set
            {
                this.OnHeaderProductVersionIdChanging(value);
                this._HeaderProductVersionId = value;
                this.OnHeaderProductVersionIdChanged();
                this.OnPropertyChanged("HeaderProductVersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HeaderProductVersionId;
        partial void OnHeaderProductVersionIdChanging(string value);
        partial void OnHeaderProductVersionIdChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property ReleasingLegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReleasingLegalEntityId
        {
            get
            {
                return this._ReleasingLegalEntityId;
            }
            set
            {
                this.OnReleasingLegalEntityIdChanging(value);
                this._ReleasingLegalEntityId = value;
                this.OnReleasingLegalEntityIdChanged();
                this.OnPropertyChanged("ReleasingLegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReleasingLegalEntityId;
        partial void OnReleasingLegalEntityIdChanging(string value);
        partial void OnReleasingLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property ReleaseStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgReleaseStatus> ReleaseStatus
        {
            get
            {
                return this._ReleaseStatus;
            }
            set
            {
                this.OnReleaseStatusChanging(value);
                this._ReleaseStatus = value;
                this.OnReleaseStatusChanged();
                this.OnPropertyChanged("ReleaseStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgReleaseStatus> _ReleaseStatus;
        partial void OnReleaseStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgReleaseStatus> value);
        partial void OnReleaseStatusChanged();
        /// <summary>
        /// There are no comments for Property HasSetupErrors in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> HasSetupErrors
        {
            get
            {
                return this._HasSetupErrors;
            }
            set
            {
                this.OnHasSetupErrorsChanging(value);
                this._HasSetupErrors = value;
                this.OnHasSetupErrorsChanged();
                this.OnPropertyChanged("HasSetupErrors");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _HasSetupErrors;
        partial void OnHasSetupErrorsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnHasSetupErrorsChanged();
        /// <summary>
        /// There are no comments for Property WillProductReleaseIncludeLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillProductReleaseIncludeLine
        {
            get
            {
                return this._WillProductReleaseIncludeLine;
            }
            set
            {
                this.OnWillProductReleaseIncludeLineChanging(value);
                this._WillProductReleaseIncludeLine = value;
                this.OnWillProductReleaseIncludeLineChanged();
                this.OnPropertyChanged("WillProductReleaseIncludeLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillProductReleaseIncludeLine;
        partial void OnWillProductReleaseIncludeLineChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillProductReleaseIncludeLineChanged();
        /// <summary>
        /// There are no comments for Property LineProductVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LineProductVersionId
        {
            get
            {
                return this._LineProductVersionId;
            }
            set
            {
                this.OnLineProductVersionIdChanging(value);
                this._LineProductVersionId = value;
                this.OnLineProductVersionIdChanged();
                this.OnPropertyChanged("LineProductVersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LineProductVersionId;
        partial void OnLineProductVersionIdChanging(string value);
        partial void OnLineProductVersionIdChanged();
        /// <summary>
        /// There are no comments for Property BillOfMaterialsLineCreationSequenceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int BillOfMaterialsLineCreationSequenceNumber
        {
            get
            {
                return this._BillOfMaterialsLineCreationSequenceNumber;
            }
            set
            {
                this.OnBillOfMaterialsLineCreationSequenceNumberChanging(value);
                this._BillOfMaterialsLineCreationSequenceNumber = value;
                this.OnBillOfMaterialsLineCreationSequenceNumberChanged();
                this.OnPropertyChanged("BillOfMaterialsLineCreationSequenceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _BillOfMaterialsLineCreationSequenceNumber;
        partial void OnBillOfMaterialsLineCreationSequenceNumberChanging(int value);
        partial void OnBillOfMaterialsLineCreationSequenceNumberChanged();
        /// <summary>
        /// There are no comments for Property ActiveRouteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ActiveRouteId
        {
            get
            {
                return this._ActiveRouteId;
            }
            set
            {
                this.OnActiveRouteIdChanging(value);
                this._ActiveRouteId = value;
                this.OnActiveRouteIdChanged();
                this.OnPropertyChanged("ActiveRouteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ActiveRouteId;
        partial void OnActiveRouteIdChanging(string value);
        partial void OnActiveRouteIdChanged();
        /// <summary>
        /// There are no comments for Property ParentLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ParentLineNumber
        {
            get
            {
                return this._ParentLineNumber;
            }
            set
            {
                this.OnParentLineNumberChanging(value);
                this._ParentLineNumber = value;
                this.OnParentLineNumberChanged();
                this.OnPropertyChanged("ParentLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ParentLineNumber;
        partial void OnParentLineNumberChanging(decimal value);
        partial void OnParentLineNumberChanged();
        /// <summary>
        /// There are no comments for Property ActiveBOMId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ActiveBOMId
        {
            get
            {
                return this._ActiveBOMId;
            }
            set
            {
                this.OnActiveBOMIdChanging(value);
                this._ActiveBOMId = value;
                this.OnActiveBOMIdChanged();
                this.OnPropertyChanged("ActiveBOMId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ActiveBOMId;
        partial void OnActiveBOMIdChanging(string value);
        partial void OnActiveBOMIdChanged();
        /// <summary>
        /// There are no comments for Property LineProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LineProductNumber
        {
            get
            {
                return this._LineProductNumber;
            }
            set
            {
                this.OnLineProductNumberChanging(value);
                this._LineProductNumber = value;
                this.OnLineProductNumberChanged();
                this.OnPropertyChanged("LineProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LineProductNumber;
        partial void OnLineProductNumberChanging(string value);
        partial void OnLineProductNumberChanged();
        /// <summary>
        /// There are no comments for Property ReceivedProductReleaseHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseHeader ReceivedProductReleaseHeader
        {
            get
            {
                return this._ReceivedProductReleaseHeader;
            }
            set
            {
                this.OnReceivedProductReleaseHeaderChanging(value);
                this._ReceivedProductReleaseHeader = value;
                this.OnReceivedProductReleaseHeaderChanged();
                this.OnPropertyChanged("ReceivedProductReleaseHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseHeader _ReceivedProductReleaseHeader;
        partial void OnReceivedProductReleaseHeaderChanging(global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseHeader value);
        partial void OnReceivedProductReleaseHeaderChanged();
        /// <summary>
        /// There are no comments for Property BOMBillOfMaterialsHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLineV3 BOMBillOfMaterialsHeader
        {
            get
            {
                return this._BOMBillOfMaterialsHeader;
            }
            set
            {
                this.OnBOMBillOfMaterialsHeaderChanging(value);
                this._BOMBillOfMaterialsHeader = value;
                this.OnBOMBillOfMaterialsHeaderChanged();
                this.OnPropertyChanged("BOMBillOfMaterialsHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLineV3 _BOMBillOfMaterialsHeader;
        partial void OnBOMBillOfMaterialsHeaderChanging(global::Microsoft.Dynamics.DataEntities.BillOfMaterialsLineV3 value);
        partial void OnBOMBillOfMaterialsHeaderChanged();
        /// <summary>
        /// There are no comments for Property RouteHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RouteHeader RouteHeader
        {
            get
            {
                return this._RouteHeader;
            }
            set
            {
                this.OnRouteHeaderChanging(value);
                this._RouteHeader = value;
                this.OnRouteHeaderChanged();
                this.OnPropertyChanged("RouteHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RouteHeader _RouteHeader;
        partial void OnRouteHeaderChanging(global::Microsoft.Dynamics.DataEntities.RouteHeader value);
        partial void OnRouteHeaderChanged();
        /// <summary>
        /// There are no comments for Property ProductReleaseProductDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductReleaseProductDetail ProductReleaseProductDetails
        {
            get
            {
                return this._ProductReleaseProductDetails;
            }
            set
            {
                this.OnProductReleaseProductDetailsChanging(value);
                this._ProductReleaseProductDetails = value;
                this.OnProductReleaseProductDetailsChanged();
                this.OnPropertyChanged("ProductReleaseProductDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductReleaseProductDetail _ProductReleaseProductDetails;
        partial void OnProductReleaseProductDetailsChanging(global::Microsoft.Dynamics.DataEntities.ProductReleaseProductDetail value);
        partial void OnProductReleaseProductDetailsChanged();
        /// <summary>
        /// There are no comments for Property ParentReceivedProductReleaseLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine ParentReceivedProductReleaseLine
        {
            get
            {
                return this._ParentReceivedProductReleaseLine;
            }
            set
            {
                this.OnParentReceivedProductReleaseLineChanging(value);
                this._ParentReceivedProductReleaseLine = value;
                this.OnParentReceivedProductReleaseLineChanged();
                this.OnPropertyChanged("ParentReceivedProductReleaseLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine _ParentReceivedProductReleaseLine;
        partial void OnParentReceivedProductReleaseLineChanging(global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine value);
        partial void OnParentReceivedProductReleaseLineChanged();
        /// <summary>
        /// There are no comments for Property ReceivedProductReleaseLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine> ReceivedProductReleaseLines
        {
            get
            {
                return this._ReceivedProductReleaseLines;
            }
            set
            {
                this.OnReceivedProductReleaseLinesChanging(value);
                this._ReceivedProductReleaseLines = value;
                this.OnReceivedProductReleaseLinesChanged();
                this.OnPropertyChanged("ReceivedProductReleaseLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine> _ReceivedProductReleaseLines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReceivedProductReleaseLinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine> value);
        partial void OnReceivedProductReleaseLinesChanged();
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