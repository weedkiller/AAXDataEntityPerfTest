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
        /// There are no comments for MaterialSingle in the schema.
        /// </summary>
    public partial class MaterialSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Material>
    {
        /// <summary>
        /// Initialize a new MaterialSingle object.
        /// </summary>
        public MaterialSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new MaterialSingle object.
        /// </summary>
        public MaterialSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new MaterialSingle object.
        /// </summary>
        public MaterialSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Material> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for Material in the schema.
        /// </summary>
    /// <KeyProperties>
    /// MaterialCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("MaterialCode")]
    [global::Microsoft.OData.Client.EntitySet("Materials")]
    public partial class Material : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Material object.
        /// </summary>
        /// <param name="materialCode">Initial value of MaterialCode.</param>
        /// <param name="multiplier">Initial value of Multiplier.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Material CreateMaterial(string materialCode, decimal multiplier)
        {
            Material material = new Material();
            material.MaterialCode = materialCode;
            material.Multiplier = multiplier;
            return material;
        }
        /// <summary>
        /// There are no comments for Property MaterialCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MaterialCode
        {
            get
            {
                return this._MaterialCode;
            }
            set
            {
                this.OnMaterialCodeChanging(value);
                this._MaterialCode = value;
                this.OnMaterialCodeChanged();
                this.OnPropertyChanged("MaterialCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaterialCode;
        partial void OnMaterialCodeChanging(string value);
        partial void OnMaterialCodeChanged();
        /// <summary>
        /// There are no comments for Property MaterialDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MaterialDescription
        {
            get
            {
                return this._MaterialDescription;
            }
            set
            {
                this.OnMaterialDescriptionChanging(value);
                this._MaterialDescription = value;
                this.OnMaterialDescriptionChanged();
                this.OnPropertyChanged("MaterialDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaterialDescription;
        partial void OnMaterialDescriptionChanging(string value);
        partial void OnMaterialDescriptionChanged();
        /// <summary>
        /// There are no comments for Property ClassCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ClassCode
        {
            get
            {
                return this._ClassCode;
            }
            set
            {
                this.OnClassCodeChanging(value);
                this._ClassCode = value;
                this.OnClassCodeChanged();
                this.OnPropertyChanged("ClassCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ClassCode;
        partial void OnClassCodeChanging(string value);
        partial void OnClassCodeChanged();
        /// <summary>
        /// There are no comments for Property LabelCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LabelCode
        {
            get
            {
                return this._LabelCode;
            }
            set
            {
                this.OnLabelCodeChanging(value);
                this._LabelCode = value;
                this.OnLabelCodeChanged();
                this.OnPropertyChanged("LabelCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LabelCode;
        partial void OnLabelCodeChanging(string value);
        partial void OnLabelCodeChanged();
        /// <summary>
        /// There are no comments for Property LimitedQty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> LimitedQty
        {
            get
            {
                return this._LimitedQty;
            }
            set
            {
                this.OnLimitedQtyChanging(value);
                this._LimitedQty = value;
                this.OnLimitedQtyChanged();
                this.OnPropertyChanged("LimitedQty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _LimitedQty;
        partial void OnLimitedQtyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnLimitedQtyChanged();
        /// <summary>
        /// There are no comments for Property StowageCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string StowageCode
        {
            get
            {
                return this._StowageCode;
            }
            set
            {
                this.OnStowageCodeChanging(value);
                this._StowageCode = value;
                this.OnStowageCodeChanged();
                this.OnPropertyChanged("StowageCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StowageCode;
        partial void OnStowageCodeChanging(string value);
        partial void OnStowageCodeChanged();
        /// <summary>
        /// There are no comments for Property PackInstCodePassenger in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PackInstCodePassenger
        {
            get
            {
                return this._PackInstCodePassenger;
            }
            set
            {
                this.OnPackInstCodePassengerChanging(value);
                this._PackInstCodePassenger = value;
                this.OnPackInstCodePassengerChanged();
                this.OnPropertyChanged("PackInstCodePassenger");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PackInstCodePassenger;
        partial void OnPackInstCodePassengerChanging(string value);
        partial void OnPackInstCodePassengerChanged();
        /// <summary>
        /// There are no comments for Property EMSCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EMSCode
        {
            get
            {
                return this._EMSCode;
            }
            set
            {
                this.OnEMSCodeChanging(value);
                this._EMSCode = value;
                this.OnEMSCodeChanged();
                this.OnPropertyChanged("EMSCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EMSCode;
        partial void OnEMSCodeChanging(string value);
        partial void OnEMSCodeChanged();
        /// <summary>
        /// There are no comments for Property PackInstCodeCargo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PackInstCodeCargo
        {
            get
            {
                return this._PackInstCodeCargo;
            }
            set
            {
                this.OnPackInstCodeCargoChanging(value);
                this._PackInstCodeCargo = value;
                this.OnPackInstCodeCargoChanged();
                this.OnPropertyChanged("PackInstCodeCargo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PackInstCodeCargo;
        partial void OnPackInstCodeCargoChanging(string value);
        partial void OnPackInstCodeCargoChanged();
        /// <summary>
        /// There are no comments for Property Multiplier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Multiplier
        {
            get
            {
                return this._Multiplier;
            }
            set
            {
                this.OnMultiplierChanging(value);
                this._Multiplier = value;
                this.OnMultiplierChanged();
                this.OnPropertyChanged("Multiplier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Multiplier;
        partial void OnMultiplierChanging(decimal value);
        partial void OnMultiplierChanged();
        /// <summary>
        /// There are no comments for Property EnviroDangerous in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> EnviroDangerous
        {
            get
            {
                return this._EnviroDangerous;
            }
            set
            {
                this.OnEnviroDangerousChanging(value);
                this._EnviroDangerous = value;
                this.OnEnviroDangerousChanged();
                this.OnPropertyChanged("EnviroDangerous");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _EnviroDangerous;
        partial void OnEnviroDangerousChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnEnviroDangerousChanged();
        /// <summary>
        /// There are no comments for Property UnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UnitOfMeasure
        {
            get
            {
                return this._UnitOfMeasure;
            }
            set
            {
                this.OnUnitOfMeasureChanging(value);
                this._UnitOfMeasure = value;
                this.OnUnitOfMeasureChanged();
                this.OnPropertyChanged("UnitOfMeasure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitOfMeasure;
        partial void OnUnitOfMeasureChanging(string value);
        partial void OnUnitOfMeasureChanged();
        /// <summary>
        /// There are no comments for Property TechnicalNameCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TechnicalNameCode
        {
            get
            {
                return this._TechnicalNameCode;
            }
            set
            {
                this.OnTechnicalNameCodeChanging(value);
                this._TechnicalNameCode = value;
                this.OnTechnicalNameCodeChanged();
                this.OnPropertyChanged("TechnicalNameCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TechnicalNameCode;
        partial void OnTechnicalNameCodeChanging(string value);
        partial void OnTechnicalNameCodeChanged();
        /// <summary>
        /// There are no comments for Property TransportCategoryCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TransportCategoryCode
        {
            get
            {
                return this._TransportCategoryCode;
            }
            set
            {
                this.OnTransportCategoryCodeChanging(value);
                this._TransportCategoryCode = value;
                this.OnTransportCategoryCodeChanged();
                this.OnPropertyChanged("TransportCategoryCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransportCategoryCode;
        partial void OnTransportCategoryCodeChanging(string value);
        partial void OnTransportCategoryCodeChanged();
        /// <summary>
        /// There are no comments for Property IdentificationCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string IdentificationCode
        {
            get
            {
                return this._IdentificationCode;
            }
            set
            {
                this.OnIdentificationCodeChanging(value);
                this._IdentificationCode = value;
                this.OnIdentificationCodeChanged();
                this.OnPropertyChanged("IdentificationCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IdentificationCode;
        partial void OnIdentificationCodeChanging(string value);
        partial void OnIdentificationCodeChanged();
        /// <summary>
        /// There are no comments for Property MarinePollutant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> MarinePollutant
        {
            get
            {
                return this._MarinePollutant;
            }
            set
            {
                this.OnMarinePollutantChanging(value);
                this._MarinePollutant = value;
                this.OnMarinePollutantChanged();
                this.OnPropertyChanged("MarinePollutant");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _MarinePollutant;
        partial void OnMarinePollutantChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnMarinePollutantChanged();
        /// <summary>
        /// There are no comments for Property AirType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HMIMAirType> AirType
        {
            get
            {
                return this._AirType;
            }
            set
            {
                this.OnAirTypeChanging(value);
                this._AirType = value;
                this.OnAirTypeChanged();
                this.OnPropertyChanged("AirType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HMIMAirType> _AirType;
        partial void OnAirTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HMIMAirType> value);
        partial void OnAirTypeChanged();
        /// <summary>
        /// There are no comments for Property RegCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RegCode
        {
            get
            {
                return this._RegCode;
            }
            set
            {
                this.OnRegCodeChanging(value);
                this._RegCode = value;
                this.OnRegCodeChanged();
                this.OnPropertyChanged("RegCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RegCode;
        partial void OnRegCodeChanging(string value);
        partial void OnRegCodeChanged();
        /// <summary>
        /// There are no comments for Property IATAStar in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IATAStar
        {
            get
            {
                return this._IATAStar;
            }
            set
            {
                this.OnIATAStarChanging(value);
                this._IATAStar = value;
                this.OnIATAStarChanged();
                this.OnPropertyChanged("IATAStar");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IATAStar;
        partial void OnIATAStarChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIATAStarChanged();
        /// <summary>
        /// There are no comments for Property NOS in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> NOS
        {
            get
            {
                return this._NOS;
            }
            set
            {
                this.OnNOSChanging(value);
                this._NOS = value;
                this.OnNOSChanged();
                this.OnPropertyChanged("NOS");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _NOS;
        partial void OnNOSChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnNOSChanged();
        /// <summary>
        /// There are no comments for Property PackingGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PackingGroupCode
        {
            get
            {
                return this._PackingGroupCode;
            }
            set
            {
                this.OnPackingGroupCodeChanging(value);
                this._PackingGroupCode = value;
                this.OnPackingGroupCodeChanged();
                this.OnPropertyChanged("PackingGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PackingGroupCode;
        partial void OnPackingGroupCodeChanging(string value);
        partial void OnPackingGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property DivisionCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DivisionCode
        {
            get
            {
                return this._DivisionCode;
            }
            set
            {
                this.OnDivisionCodeChanging(value);
                this._DivisionCode = value;
                this.OnDivisionCodeChanged();
                this.OnPropertyChanged("DivisionCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DivisionCode;
        partial void OnDivisionCodeChanging(string value);
        partial void OnDivisionCodeChanged();
        /// <summary>
        /// There are no comments for Property TunnelCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TunnelCode
        {
            get
            {
                return this._TunnelCode;
            }
            set
            {
                this.OnTunnelCodeChanging(value);
                this._TunnelCode = value;
                this.OnTunnelCodeChanged();
                this.OnPropertyChanged("TunnelCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TunnelCode;
        partial void OnTunnelCodeChanging(string value);
        partial void OnTunnelCodeChanged();
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
