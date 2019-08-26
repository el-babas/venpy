using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace VenPy.Entities
{
    public partial class VENPY_MeasurementUnitsProducts
    {
        #region [ VARIABLES ]

        private Boolean pv_mupr_minimumunit;
        private String pv_tble_nameunm;
        private String pv_mupr_errormessage;

        #endregion

        #region [ PROPERTIES ]

        [DataMember]
        public Boolean MUPR_MinimumUnit
        {
            get { return pv_mupr_minimumunit; }
            set
            {
                if (pv_mupr_minimumunit != value)
                {
                    pv_mupr_minimumunit = value;
                    OnAttributeChanged("MUPR_MinimumUnit");
                }
            }
        }
        [DataMember]
        public String TBLE_NameUNM
        {
            get { return pv_tble_nameunm; }
            set
            {
                if (pv_tble_nameunm != value)
                {
                    pv_tble_nameunm = value;
                    OnAttributeChanged("TBLE_NameUNM");
                }
            }
        }
        [DataMember]
        public String MUPR_ErrorMessage
        {
            get { return pv_mupr_errormessage; }
        }

        #endregion

        #region [ COPYTO ]

        public void CopyTo(ref VENPY_MeasurementUnitsProducts Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_MeasurementUnitsProducts(); }
                Item.BUSI_Code = this.BUSI_Code;
                Item.PROD_Code = this.PROD_Code;
                Item.TBLE_TableUNM = this.TBLE_TableUNM;
                Item.TBLE_CodeUNM = this.TBLE_CodeUNM;
                Item.MUPR_ConversionFactor = this.MUPR_ConversionFactor;
                Item.AUDI_CreationUser = this.AUDI_CreationUser;
                Item.AUDI_CreationDate = this.AUDI_CreationDate;
                Item.AUDI_ModificationUser = this.AUDI_ModificationUser;
                Item.AUDI_ModificationDate = this.AUDI_ModificationDate;

                Item.MUPR_MinimumUnit = this.MUPR_MinimumUnit;
                Item.TBLE_NameUNM = this.TBLE_NameUNM;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ CHECK ]

        public bool Check()
        {
            try
            {
                bool l_correcto = true;
                pv_mupr_errormessage = null;
                if (BUSI_Code.Equals(0))
                {
                    l_correcto = false;
                    pv_mupr_errormessage += "* Debe ingresar un Código de Empresa" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(TBLE_TableUNM) || string.IsNullOrEmpty(TBLE_CodeUNM) || TBLE_CodeUNM.Equals("0"))
                {
                    l_correcto = false;
                    pv_mupr_errormessage += "* Debe seleccionar una Unidad de Medida Mínima" + Environment.NewLine;
                }
                if (MUPR_ConversionFactor <= (Decimal)0.00)
                {
                    l_correcto = false;
                    pv_mupr_errormessage += "* Debe ingresar un Factor de Conversión mayor a Cero" + Environment.NewLine;
                }

                return l_correcto;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}

