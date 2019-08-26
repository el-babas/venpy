using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Data;
using VenPy.Class;

namespace VenPy.Entities
{
    public partial class VENPY_Services
    {
        #region [ VARIABLES ]

        private String pv_tble_namefas;
        private String pv_tble_namemnd;
        private String pv_serv_errormessage;

        #endregion

        #region [ PROPERTIES ]

        [DataMember]
        public String TBLE_NameFAS
        {
            get { return pv_tble_namefas; }
            set
            {
                if (pv_tble_namefas != value)
                {
                    pv_tble_namefas = value;
                    OnAttributeChanged("TBLE_NameFAS");
                }
            }
        }
        [DataMember]
        public String TBLE_NameMND
        {
            get { return pv_tble_namemnd; }
            set
            {
                if (pv_tble_namemnd != value)
                {
                    pv_tble_namemnd = value;
                    OnAttributeChanged("TBLE_NameMND");
                }
            }
        }
        [DataMember]
        public String SERV_ErrorMessage
        {
            get { return pv_serv_errormessage; }
        }

        #endregion

        #region [ COPYTO ]

        public void CopyTo(ref VENPY_Services Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_Services(); }
                Item.BUSI_Code = this.BUSI_Code;
                Item.SERV_Code = this.SERV_Code;
                Item.SERV_Active = this.SERV_Active;
                Item.SERV_Name = this.SERV_Name;
                Item.SERV_Description = this.SERV_Description;
                Item.TBLE_TableFAS = this.TBLE_TableFAS;
                Item.TBLE_CodeFAS = this.TBLE_CodeFAS;
                Item.TBLE_TableUNM = this.TBLE_TableUNM;
                Item.TBLE_CodeUNM = this.TBLE_CodeUNM;
                Item.TBLE_TableTAI = this.TBLE_TableTAI;
                Item.TBLE_CodeTAI = this.TBLE_CodeTAI;
                Item.TBLE_TableMND = this.TBLE_TableMND;
                Item.TBLE_CodeMND = this.TBLE_CodeMND;
                Item.SERV_UnitValue = this.SERV_UnitValue;
                Item.SERV_IGV = this.SERV_IGV;
                Item.SERV_UnitPrice = this.SERV_UnitPrice;
                Item.AUDI_CreationUser = this.AUDI_CreationUser;
                Item.AUDI_CreationDate = this.AUDI_CreationDate;
                Item.AUDI_ModificationUser = this.AUDI_ModificationUser;
                Item.AUDI_ModificationDate = this.AUDI_ModificationDate;

                Item.TBLE_NameFAS = this.TBLE_NameFAS;
                Item.TBLE_NameMND = this.TBLE_NameMND;
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
                bool l_correct = true;
                pv_serv_errormessage = null;
                if (BUSI_Code.Equals(0))
                {
                    l_correct = false;
                    pv_serv_errormessage += "* Debe ingresar un Código de Empresa" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(TBLE_TableFAS) || string.IsNullOrEmpty(TBLE_CodeFAS))
                {
                    l_correct = false;
                    pv_serv_errormessage += "* Debe seleccionar una Familia" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(SERV_Name))
                {
                    l_correct = false;
                    pv_serv_errormessage += "* Debe ingresar un Nombre" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(TBLE_TableMND) || string.IsNullOrEmpty(TBLE_CodeMND) || TBLE_CodeMND.Equals("0"))
                {
                    l_correct = false;
                    pv_serv_errormessage += "* Debe seleccionar una Moneda" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(TBLE_TableUNM) || string.IsNullOrEmpty(TBLE_CodeUNM) || TBLE_CodeUNM.Equals("0"))
                {
                    l_correct = false;
                    pv_serv_errormessage += "* Debe seleccionar una Unidad de Medida" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(TBLE_TableTAI) || string.IsNullOrEmpty(TBLE_CodeTAI) || TBLE_CodeTAI.Equals("0"))
                {
                    l_correct = false;
                    pv_serv_errormessage += "* Debe seleccionar un Tipo de Afectación IGV" + Environment.NewLine;
                }
                if (SERV_UnitValue < (decimal)0.00)
                {
                    l_correct = false;
                    pv_serv_errormessage += "* Debe ingresar un Valor Unitario positivo" + Environment.NewLine;
                }
                if (SERV_UnitPrice < (decimal)0.00)
                {
                    l_correct = false;
                    pv_serv_errormessage += "* Debe ingresar un Precio Unitario positivo" + Environment.NewLine;
                }
                if (SERV_IGV < (decimal)0.00)
                {
                    l_correct = false;
                    pv_serv_errormessage += "* Debe ingresar un I.G.V. positivo" + Environment.NewLine;
                }

                return l_correct;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public void CalculateUnitPrice(Int32 p_Decimals, Decimal p_PercentIgv)
        {
            try
            {
                if (TBLE_TableTAI == StaticLists.TBLE_TAI && TBLE_CodeTAI == StaticLists.TAI_Gra)
                { SERV_UnitPrice = Math.Round(((SERV_UnitValue) * ((Decimal)1.00 + (p_PercentIgv / (Decimal)100.00))), p_Decimals); }
                else
                { SERV_UnitPrice = (SERV_UnitValue); }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void CalculateUnitValue(Int32 p_Decimals, Decimal p_PercentIgv, Boolean p_UnitPrice)
        {
            try
            {
                if (p_UnitPrice)
                {
                    if (TBLE_TableTAI == StaticLists.TBLE_TAI && TBLE_CodeTAI == StaticLists.TAI_Gra)
                    { SERV_UnitValue = Math.Round((SERV_UnitPrice / ((Decimal)1.00 + (p_PercentIgv / (Decimal)100.00))), p_Decimals); }
                    else
                    { SERV_UnitValue = SERV_UnitPrice; }
                }
                else
                {
                    if (TBLE_TableTAI == StaticLists.TBLE_TAI && TBLE_CodeTAI == StaticLists.TAI_Gra)
                    { SERV_UnitValue = (Math.Round((Convert.ToDecimal(Convert.ToDouble(SERV_IGV) * (Convert.ToDouble(100.00) / Convert.ToDouble(p_PercentIgv)))), p_Decimals)); }
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void CalculateIgv(Int32 p_Decimals, Decimal p_PercentIgv)
        {
            try
            {
                if (TBLE_TableTAI == StaticLists.TBLE_TAI && TBLE_CodeTAI == StaticLists.TAI_Gra)
                { SERV_IGV = Math.Round((Convert.ToDecimal((Convert.ToDouble(SERV_UnitValue)) * (Convert.ToDouble(p_PercentIgv) / Convert.ToDouble(100.00)))), p_Decimals); }
                else
                { SERV_IGV = (Decimal)0.00; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
