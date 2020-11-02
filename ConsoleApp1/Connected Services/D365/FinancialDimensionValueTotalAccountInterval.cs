﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:55:10 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for FinancialDimensionValueTotalAccountIntervalSingle in the schema.
    /// </summary>
    public partial class FinancialDimensionValueTotalAccountIntervalSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FinancialDimensionValueTotalAccountInterval>
    {
        /// <summary>
        /// Initialize a new FinancialDimensionValueTotalAccountIntervalSingle object.
        /// </summary>
        public FinancialDimensionValueTotalAccountIntervalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FinancialDimensionValueTotalAccountIntervalSingle object.
        /// </summary>
        public FinancialDimensionValueTotalAccountIntervalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FinancialDimensionValueTotalAccountIntervalSingle object.
        /// </summary>
        public FinancialDimensionValueTotalAccountIntervalSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FinancialDimensionValueTotalAccountInterval> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_OfficeAddinLegalEntityEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OfficeAddinLegalEntitySingle FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_OfficeAddinLegalEntityEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_OfficeAddinLegalEntityEntity == null))
                {
                    this._FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_OfficeAddinLegalEntityEntity = new global::Microsoft.Dynamics.DataEntities.OfficeAddinLegalEntitySingle(this.Context, GetPath("FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_OfficeAddinLegalEntityEntity"));
                }
                return this._FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_OfficeAddinLegalEntityEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OfficeAddinLegalEntitySingle _FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_OfficeAddinLegalEntityEntity;
        /// <summary>
        /// There are no comments for FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionAttributeSingle FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity == null))
                {
                    this._FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity = new global::Microsoft.Dynamics.DataEntities.DimensionAttributeSingle(this.Context, GetPath("FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity"));
                }
                return this._FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionAttributeSingle _FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity;
    }
    /// <summary>
    /// There are no comments for FinancialDimensionValueTotalAccountInterval in the schema.
    /// </summary>
    /// <KeyProperties>
    /// FinancialDimension
    /// DimensionValue
    /// FromValue
    /// ToValue
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("FinancialDimension", "DimensionValue", "FromValue", "ToValue")]
    [global::Microsoft.OData.Client.EntitySet("FinancialDimensionValueTotalAccountIntervals")]
    public partial class FinancialDimensionValueTotalAccountInterval : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FinancialDimensionValueTotalAccountInterval object.
        /// </summary>
        /// <param name="financialDimension">Initial value of FinancialDimension.</param>
        /// <param name="dimensionValue">Initial value of DimensionValue.</param>
        /// <param name="fromValue">Initial value of FromValue.</param>
        /// <param name="toValue">Initial value of ToValue.</param>
        /// <param name="financialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity">Initial value of FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FinancialDimensionValueTotalAccountInterval CreateFinancialDimensionValueTotalAccountInterval(string financialDimension, string dimensionValue, string fromValue, string toValue, global::Microsoft.Dynamics.DataEntities.DimensionAttribute financialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity)
        {
            FinancialDimensionValueTotalAccountInterval financialDimensionValueTotalAccountInterval = new FinancialDimensionValueTotalAccountInterval();
            financialDimensionValueTotalAccountInterval.FinancialDimension = financialDimension;
            financialDimensionValueTotalAccountInterval.DimensionValue = dimensionValue;
            financialDimensionValueTotalAccountInterval.FromValue = fromValue;
            financialDimensionValueTotalAccountInterval.ToValue = toValue;
            if ((financialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity == null))
            {
                throw new global::System.ArgumentNullException("financialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity");
            }
            financialDimensionValueTotalAccountInterval.FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity = financialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity;
            return financialDimensionValueTotalAccountInterval;
        }
        /// <summary>
        /// There are no comments for Property FinancialDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FinancialDimension
        {
            get
            {
                return this._FinancialDimension;
            }
            set
            {
                this.OnFinancialDimensionChanging(value);
                this._FinancialDimension = value;
                this.OnFinancialDimensionChanged();
                this.OnPropertyChanged("FinancialDimension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FinancialDimension;
        partial void OnFinancialDimensionChanging(string value);
        partial void OnFinancialDimensionChanged();
        /// <summary>
        /// There are no comments for Property DimensionValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DimensionValue
        {
            get
            {
                return this._DimensionValue;
            }
            set
            {
                this.OnDimensionValueChanging(value);
                this._DimensionValue = value;
                this.OnDimensionValueChanged();
                this.OnPropertyChanged("DimensionValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionValue;
        partial void OnDimensionValueChanging(string value);
        partial void OnDimensionValueChanged();
        /// <summary>
        /// There are no comments for Property FromValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FromValue
        {
            get
            {
                return this._FromValue;
            }
            set
            {
                this.OnFromValueChanging(value);
                this._FromValue = value;
                this.OnFromValueChanged();
                this.OnPropertyChanged("FromValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FromValue;
        partial void OnFromValueChanging(string value);
        partial void OnFromValueChanged();
        /// <summary>
        /// There are no comments for Property ToValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ToValue
        {
            get
            {
                return this._ToValue;
            }
            set
            {
                this.OnToValueChanging(value);
                this._ToValue = value;
                this.OnToValueChanged();
                this.OnPropertyChanged("ToValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ToValue;
        partial void OnToValueChanging(string value);
        partial void OnToValueChanged();
        /// <summary>
        /// There are no comments for Property LegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LegalEntityId
        {
            get
            {
                return this._LegalEntityId;
            }
            set
            {
                this.OnLegalEntityIdChanging(value);
                this._LegalEntityId = value;
                this.OnLegalEntityIdChanged();
                this.OnPropertyChanged("LegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntityId;
        partial void OnLegalEntityIdChanging(string value);
        partial void OnLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property InvertTotalSign in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> InvertTotalSign
        {
            get
            {
                return this._InvertTotalSign;
            }
            set
            {
                this.OnInvertTotalSignChanging(value);
                this._InvertTotalSign = value;
                this.OnInvertTotalSignChanged();
                this.OnPropertyChanged("InvertTotalSign");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _InvertTotalSign;
        partial void OnInvertTotalSignChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnInvertTotalSignChanged();
        /// <summary>
        /// There are no comments for Property FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_OfficeAddinLegalEntityEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OfficeAddinLegalEntity FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_OfficeAddinLegalEntityEntity
        {
            get
            {
                return this._FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_OfficeAddinLegalEntityEntity;
            }
            set
            {
                this.OnFinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_OfficeAddinLegalEntityEntityChanging(value);
                this._FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_OfficeAddinLegalEntityEntity = value;
                this.OnFinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_OfficeAddinLegalEntityEntityChanged();
                this.OnPropertyChanged("FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_OfficeAddinLegalEntityEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OfficeAddinLegalEntity _FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_OfficeAddinLegalEntityEntity;
        partial void OnFinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_OfficeAddinLegalEntityEntityChanging(global::Microsoft.Dynamics.DataEntities.OfficeAddinLegalEntity value);
        partial void OnFinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_OfficeAddinLegalEntityEntityChanged();
        /// <summary>
        /// There are no comments for Property FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionAttribute FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity
        {
            get
            {
                return this._FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity;
            }
            set
            {
                this.OnFinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntityChanging(value);
                this._FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity = value;
                this.OnFinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntityChanged();
                this.OnPropertyChanged("FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionAttribute _FinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntity;
        partial void OnFinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntityChanging(global::Microsoft.Dynamics.DataEntities.DimensionAttribute value);
        partial void OnFinancialDimensionValueTotalAccountIntervalEntity_RelatedRole_DimensionAttributeEntityChanged();
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
