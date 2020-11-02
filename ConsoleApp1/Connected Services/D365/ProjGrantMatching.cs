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
    /// There are no comments for ProjGrantMatchingSingle in the schema.
    /// </summary>
    public partial class ProjGrantMatchingSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjGrantMatching>
    {
        /// <summary>
        /// Initialize a new ProjGrantMatchingSingle object.
        /// </summary>
        public ProjGrantMatchingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjGrantMatchingSingle object.
        /// </summary>
        public ProjGrantMatchingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjGrantMatchingSingle object.
        /// </summary>
        public ProjGrantMatchingSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjGrantMatching> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ProjGrantMatching in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// MatchingType
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "MatchingType")]
    [global::Microsoft.OData.Client.EntitySet("ProjGrantMatchings")]
    public partial class ProjGrantMatching : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjGrantMatching object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="matchingType">Initial value of MatchingType.</param>
        /// <param name="matchingPercentage">Initial value of MatchingPercentage.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjGrantMatching CreateProjGrantMatching(string dataAreaId, string matchingType, decimal matchingPercentage)
        {
            ProjGrantMatching projGrantMatching = new ProjGrantMatching();
            projGrantMatching.dataAreaId = dataAreaId;
            projGrantMatching.MatchingType = matchingType;
            projGrantMatching.MatchingPercentage = matchingPercentage;
            return projGrantMatching;
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
        /// There are no comments for Property MatchingType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MatchingType
        {
            get
            {
                return this._MatchingType;
            }
            set
            {
                this.OnMatchingTypeChanging(value);
                this._MatchingType = value;
                this.OnMatchingTypeChanged();
                this.OnPropertyChanged("MatchingType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MatchingType;
        partial void OnMatchingTypeChanging(string value);
        partial void OnMatchingTypeChanged();
        /// <summary>
        /// There are no comments for Property Comments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Comments
        {
            get
            {
                return this._Comments;
            }
            set
            {
                this.OnCommentsChanging(value);
                this._Comments = value;
                this.OnCommentsChanged();
                this.OnPropertyChanged("Comments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Comments;
        partial void OnCommentsChanging(string value);
        partial void OnCommentsChanged();
        /// <summary>
        /// There are no comments for Property MatchingPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal MatchingPercentage
        {
            get
            {
                return this._MatchingPercentage;
            }
            set
            {
                this.OnMatchingPercentageChanging(value);
                this._MatchingPercentage = value;
                this.OnMatchingPercentageChanged();
                this.OnPropertyChanged("MatchingPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MatchingPercentage;
        partial void OnMatchingPercentageChanging(decimal value);
        partial void OnMatchingPercentageChanged();
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