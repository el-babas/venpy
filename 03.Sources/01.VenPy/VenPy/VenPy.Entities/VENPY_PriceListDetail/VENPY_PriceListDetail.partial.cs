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
    public partial class VENPY_PriceListDetail
    {
        #region [ VARIABLES ]

        private String pv_tble_nameunm;
        private String pv_prod_name;
        private String pv_plde_errormessage;

        #endregion

        #region [ PROPERTIES ]

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
        public String PROD_Name
        {
            get { return pv_prod_name; }
            set
            {
                if (pv_prod_name != value)
                {
                    pv_prod_name = value;
                    OnAttributeChanged("PROD_Name");
                }
            }
        }
        [DataMember]
        public String PLDE_ErrorMessage
        {
            get { return pv_plde_errormessage; }
        }

        #endregion

        #region [ COPYTO ]

        public void CopyTo(ref VENPY_PriceListDetail Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_PriceListDetail(); }
                Item.BUSI_Code = this.BUSI_Code;
                Item.PRLI_Code = this.PRLI_Code;
                Item.PLDE_Item = this.PLDE_Item;
                Item.PROD_Code = this.PROD_Code;
                Item.TBLE_TableUNM = this.TBLE_TableUNM;
                Item.TBLE_CodeUNM = this.TBLE_CodeUNM;
                Item.TBLE_TableTAI = this.TBLE_TableTAI;
                Item.TBLE_CodeTAI = this.TBLE_CodeTAI;
                Item.PLDE_UnitValue = this.PLDE_UnitValue;
                Item.PLDE_IGV = this.PLDE_IGV;
                Item.PLDE_UnitPrice = this.PLDE_UnitPrice;
                Item.AUDI_CreationUser = this.AUDI_CreationUser;
                Item.AUDI_CreationDate = this.AUDI_CreationDate;
                Item.AUDI_ModificationUser = this.AUDI_ModificationUser;
                Item.AUDI_ModificationDate = this.AUDI_ModificationDate;

                Item.TBLE_NameUNM = this.TBLE_NameUNM;
                Item.PROD_Name = this.PROD_Name;
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
                pv_plde_errormessage = null;
                if (BUSI_Code.Equals(0))
                {
                    l_correct = false;
                    pv_plde_errormessage += "* Debe ingresar un Código de Empresa" + Environment.NewLine;
                }
                if (PROD_Code.Equals(0))
                {
                    l_correct = false;
                    pv_plde_errormessage += "* Debe seleccionar un Producto" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(TBLE_TableUNM) || string.IsNullOrEmpty(TBLE_CodeUNM) || TBLE_CodeUNM.Equals("0"))
                {
                    l_correct = false;
                    pv_plde_errormessage += "* Debe seleccionar una Unidad de Medida Mínima" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(TBLE_TableTAI) || string.IsNullOrEmpty(TBLE_CodeTAI) || TBLE_CodeTAI.Equals("0"))
                {
                    l_correct = false;
                    pv_plde_errormessage += "* Debe seleccionar un Tipo de Afectación IGV" + Environment.NewLine;
                }
                if (PLDE_UnitValue <= (decimal)0.00)
                {
                    l_correct = false;
                    pv_plde_errormessage += "* Debe ingresar un Valor Unitario mayor a Cero" + Environment.NewLine;
                }
                if (PLDE_UnitPrice <= (decimal)0.00)
                {
                    l_correct = false;
                    pv_plde_errormessage += "* Debe ingresar un Precio Unitario mayor a Cero" + Environment.NewLine;
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
                { PLDE_UnitPrice = Math.Round(((PLDE_UnitValue) * ((Decimal)1.00 + (p_PercentIgv / (Decimal)100.00))), p_Decimals); }
                else
                { PLDE_UnitPrice = (PLDE_UnitValue); }
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
                    { PLDE_UnitValue = Math.Round((PLDE_UnitPrice / ((Decimal)1.00 + (p_PercentIgv / (Decimal)100.00))), p_Decimals); }
                    else
                    { PLDE_UnitValue = PLDE_UnitPrice; }
                }
                else
                {
                    if (TBLE_TableTAI == StaticLists.TBLE_TAI && TBLE_CodeTAI == StaticLists.TAI_Gra)
                    { PLDE_UnitValue = (Math.Round((Convert.ToDecimal(Convert.ToDouble(PLDE_IGV) * (Convert.ToDouble(100.00) / Convert.ToDouble(p_PercentIgv)))), p_Decimals)); }
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
                { PLDE_IGV = Math.Round((Convert.ToDecimal((Convert.ToDouble(PLDE_UnitValue)) * (Convert.ToDouble(p_PercentIgv) / Convert.ToDouble(100.00)))), p_Decimals); }
                else
                { PLDE_IGV = (Decimal)0.00; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
