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
    /// There are no comments for ProductDocumentAttachmentSingle in the schema.
    /// </summary>
    public partial class ProductDocumentAttachmentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductDocumentAttachment>
    {
        /// <summary>
        /// Initialize a new ProductDocumentAttachmentSingle object.
        /// </summary>
        public ProductDocumentAttachmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductDocumentAttachmentSingle object.
        /// </summary>
        public ProductDocumentAttachmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductDocumentAttachmentSingle object.
        /// </summary>
        public ProductDocumentAttachmentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductDocumentAttachment> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductV2Single ProductV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductV2 == null))
                {
                    this._ProductV2 = new global::Microsoft.Dynamics.DataEntities.ProductV2Single(this.Context, GetPath("ProductV2"));
                }
                return this._ProductV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductV2Single _ProductV2;
        /// <summary>
        /// There are no comments for DocumentAttachmentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DocumentTypeSingle DocumentAttachmentType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DocumentAttachmentType == null))
                {
                    this._DocumentAttachmentType = new global::Microsoft.Dynamics.DataEntities.DocumentTypeSingle(this.Context, GetPath("DocumentAttachmentType"));
                }
                return this._DocumentAttachmentType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DocumentTypeSingle _DocumentAttachmentType;
    }
    /// <summary>
    /// There are no comments for ProductDocumentAttachment in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProductNumber
    /// DocumentAttachmentTypeCode
    /// AttachmentDescription
    /// AttachedDateTime
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductNumber", "DocumentAttachmentTypeCode", "AttachmentDescription", "AttachedDateTime")]
    [global::Microsoft.OData.Client.EntitySet("ProductDocumentAttachments")]
    public partial class ProductDocumentAttachment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductDocumentAttachment object.
        /// </summary>
        /// <param name="productNumber">Initial value of ProductNumber.</param>
        /// <param name="documentAttachmentTypeCode">Initial value of DocumentAttachmentTypeCode.</param>
        /// <param name="attachmentDescription">Initial value of AttachmentDescription.</param>
        /// <param name="attachedDateTime">Initial value of AttachedDateTime.</param>
        /// <param name="productV2">Initial value of ProductV2.</param>
        /// <param name="documentAttachmentType">Initial value of DocumentAttachmentType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductDocumentAttachment CreateProductDocumentAttachment(string productNumber, 
                    string documentAttachmentTypeCode, 
                    string attachmentDescription, 
                    global::System.DateTimeOffset attachedDateTime, 
                    global::Microsoft.Dynamics.DataEntities.ProductV2 productV2, 
                    global::Microsoft.Dynamics.DataEntities.DocumentType documentAttachmentType)
        {
            ProductDocumentAttachment productDocumentAttachment = new ProductDocumentAttachment();
            productDocumentAttachment.ProductNumber = productNumber;
            productDocumentAttachment.DocumentAttachmentTypeCode = documentAttachmentTypeCode;
            productDocumentAttachment.AttachmentDescription = attachmentDescription;
            productDocumentAttachment.AttachedDateTime = attachedDateTime;
            if ((productV2 == null))
            {
                throw new global::System.ArgumentNullException("productV2");
            }
            productDocumentAttachment.ProductV2 = productV2;
            if ((documentAttachmentType == null))
            {
                throw new global::System.ArgumentNullException("documentAttachmentType");
            }
            productDocumentAttachment.DocumentAttachmentType = documentAttachmentType;
            return productDocumentAttachment;
        }
        /// <summary>
        /// There are no comments for Property ProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductNumber
        {
            get
            {
                return this._ProductNumber;
            }
            set
            {
                this.OnProductNumberChanging(value);
                this._ProductNumber = value;
                this.OnProductNumberChanged();
                this.OnPropertyChanged("ProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductNumber;
        partial void OnProductNumberChanging(string value);
        partial void OnProductNumberChanged();
        /// <summary>
        /// There are no comments for Property DocumentAttachmentTypeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DocumentAttachmentTypeCode
        {
            get
            {
                return this._DocumentAttachmentTypeCode;
            }
            set
            {
                this.OnDocumentAttachmentTypeCodeChanging(value);
                this._DocumentAttachmentTypeCode = value;
                this.OnDocumentAttachmentTypeCodeChanged();
                this.OnPropertyChanged("DocumentAttachmentTypeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentAttachmentTypeCode;
        partial void OnDocumentAttachmentTypeCodeChanging(string value);
        partial void OnDocumentAttachmentTypeCodeChanged();
        /// <summary>
        /// There are no comments for Property AttachmentDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AttachmentDescription
        {
            get
            {
                return this._AttachmentDescription;
            }
            set
            {
                this.OnAttachmentDescriptionChanging(value);
                this._AttachmentDescription = value;
                this.OnAttachmentDescriptionChanged();
                this.OnPropertyChanged("AttachmentDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttachmentDescription;
        partial void OnAttachmentDescriptionChanging(string value);
        partial void OnAttachmentDescriptionChanged();
        /// <summary>
        /// There are no comments for Property AttachedDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset AttachedDateTime
        {
            get
            {
                return this._AttachedDateTime;
            }
            set
            {
                this.OnAttachedDateTimeChanging(value);
                this._AttachedDateTime = value;
                this.OnAttachedDateTimeChanged();
                this.OnPropertyChanged("AttachedDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _AttachedDateTime;
        partial void OnAttachedDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnAttachedDateTimeChanged();
        /// <summary>
        /// There are no comments for Property AttachingUserId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AttachingUserId
        {
            get
            {
                return this._AttachingUserId;
            }
            set
            {
                this.OnAttachingUserIdChanging(value);
                this._AttachingUserId = value;
                this.OnAttachingUserIdChanged();
                this.OnPropertyChanged("AttachingUserId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttachingUserId;
        partial void OnAttachingUserIdChanging(string value);
        partial void OnAttachingUserIdChanged();
        /// <summary>
        /// There are no comments for Property OriginalFileName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OriginalFileName
        {
            get
            {
                return this._OriginalFileName;
            }
            set
            {
                this.OnOriginalFileNameChanging(value);
                this._OriginalFileName = value;
                this.OnOriginalFileNameChanged();
                this.OnPropertyChanged("OriginalFileName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OriginalFileName;
        partial void OnOriginalFileNameChanging(string value);
        partial void OnOriginalFileNameChanged();
        /// <summary>
        /// There are no comments for Property FileType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FileType
        {
            get
            {
                return this._FileType;
            }
            set
            {
                this.OnFileTypeChanging(value);
                this._FileType = value;
                this.OnFileTypeChanged();
                this.OnPropertyChanged("FileType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FileType;
        partial void OnFileTypeChanging(string value);
        partial void OnFileTypeChanged();
        /// <summary>
        /// There are no comments for Property ProductImageUsage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EcoResProductImageUsage> ProductImageUsage
        {
            get
            {
                return this._ProductImageUsage;
            }
            set
            {
                this.OnProductImageUsageChanging(value);
                this._ProductImageUsage = value;
                this.OnProductImageUsageChanged();
                this.OnPropertyChanged("ProductImageUsage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EcoResProductImageUsage> _ProductImageUsage;
        partial void OnProductImageUsageChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EcoResProductImageUsage> value);
        partial void OnProductImageUsageChanged();
        /// <summary>
        /// There are no comments for Property DocumentAttachmentTypeLegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DocumentAttachmentTypeLegalEntityId
        {
            get
            {
                return this._DocumentAttachmentTypeLegalEntityId;
            }
            set
            {
                this.OnDocumentAttachmentTypeLegalEntityIdChanging(value);
                this._DocumentAttachmentTypeLegalEntityId = value;
                this.OnDocumentAttachmentTypeLegalEntityIdChanged();
                this.OnPropertyChanged("DocumentAttachmentTypeLegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentAttachmentTypeLegalEntityId;
        partial void OnDocumentAttachmentTypeLegalEntityIdChanging(string value);
        partial void OnDocumentAttachmentTypeLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property IsDefaultProductImage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDefaultProductImage
        {
            get
            {
                return this._IsDefaultProductImage;
            }
            set
            {
                this.OnIsDefaultProductImageChanging(value);
                this._IsDefaultProductImage = value;
                this.OnIsDefaultProductImageChanged();
                this.OnPropertyChanged("IsDefaultProductImage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDefaultProductImage;
        partial void OnIsDefaultProductImageChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDefaultProductImageChanged();
        /// <summary>
        /// There are no comments for Property AccessRestriction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRestriction> AccessRestriction
        {
            get
            {
                return this._AccessRestriction;
            }
            set
            {
                this.OnAccessRestrictionChanging(value);
                this._AccessRestriction = value;
                this.OnAccessRestrictionChanged();
                this.OnPropertyChanged("AccessRestriction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRestriction> _AccessRestriction;
        partial void OnAccessRestrictionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRestriction> value);
        partial void OnAccessRestrictionChanged();
        /// <summary>
        /// There are no comments for Property Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                this.OnNotesChanging(value);
                this._Notes = value;
                this.OnNotesChanged();
                this.OnPropertyChanged("Notes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Notes;
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
        /// <summary>
        /// There are no comments for Property FileLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FileLocation
        {
            get
            {
                return this._FileLocation;
            }
            set
            {
                this.OnFileLocationChanging(value);
                this._FileLocation = value;
                this.OnFileLocationChanged();
                this.OnPropertyChanged("FileLocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FileLocation;
        partial void OnFileLocationChanging(string value);
        partial void OnFileLocationChanged();
        /// <summary>
        /// There are no comments for Property IsProductImage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsProductImage
        {
            get
            {
                return this._IsProductImage;
            }
            set
            {
                this.OnIsProductImageChanging(value);
                this._IsProductImage = value;
                this.OnIsProductImageChanged();
                this.OnPropertyChanged("IsProductImage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsProductImage;
        partial void OnIsProductImageChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsProductImageChanged();
        /// <summary>
        /// There are no comments for Property Attachment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual byte[] Attachment
        {
            get
            {
                return this._Attachment;
            }
            set
            {
                this.OnAttachmentChanging(value);
                this._Attachment = value;
                this.OnAttachmentChanged();
                this.OnPropertyChanged("Attachment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private byte[] _Attachment;
        partial void OnAttachmentChanging(byte[] value);
        partial void OnAttachmentChanged();
        /// <summary>
        /// There are no comments for Property ProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductV2 ProductV2
        {
            get
            {
                return this._ProductV2;
            }
            set
            {
                this.OnProductV2Changing(value);
                this._ProductV2 = value;
                this.OnProductV2Changed();
                this.OnPropertyChanged("ProductV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductV2 _ProductV2;
        partial void OnProductV2Changing(global::Microsoft.Dynamics.DataEntities.ProductV2 value);
        partial void OnProductV2Changed();
        /// <summary>
        /// There are no comments for Property DocumentAttachmentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DocumentType DocumentAttachmentType
        {
            get
            {
                return this._DocumentAttachmentType;
            }
            set
            {
                this.OnDocumentAttachmentTypeChanging(value);
                this._DocumentAttachmentType = value;
                this.OnDocumentAttachmentTypeChanged();
                this.OnPropertyChanged("DocumentAttachmentType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DocumentType _DocumentAttachmentType;
        partial void OnDocumentAttachmentTypeChanging(global::Microsoft.Dynamics.DataEntities.DocumentType value);
        partial void OnDocumentAttachmentTypeChanged();
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
