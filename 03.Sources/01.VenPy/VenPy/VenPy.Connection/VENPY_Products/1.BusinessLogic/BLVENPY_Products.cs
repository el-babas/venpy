using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;

namespace VenPy.Connection
{
    public partial class BLVENPY_Products : IBLVENPY_Products
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_Products> BLPRODS_ListProducts(Int32 p_BUSI_Code, String p_TBLE_TableFAP, String p_TBLE_CodeFAP, String p_TBLE_TableMAR, String p_TBLE_CodeMAR, String p_PROD_Name)
        {
            try
            {
                return PRODS_ListProducts(p_BUSI_Code, p_TBLE_TableFAP, p_TBLE_CodeFAP, p_TBLE_TableMAR, p_TBLE_CodeMAR, p_PROD_Name);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public VENPY_Products BLPRODS_AProduct(Int32 p_BUSI_Code, Int32 p_PROD_Code)
        {
            try
            {
                VENPY_Products l_item = new VENPY_Products();
                l_item = PRODS_AProduct(p_BUSI_Code, p_PROD_Code);
                l_item.PROD_MeasurementUnitsProducts = BL_VENPY_MeasurementUnitsProducts.BLMUPRS_ByProduct(p_BUSI_Code, p_PROD_Code);
                return l_item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public String BLPROD_Save(ref VENPY_Products p_Item)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                switch (p_Item.Instance)
                {
                    case InstanceEntity.Insert:
                        l_message = PRODI_AProduct(ref p_Item);
                        break;
                    case InstanceEntity.Update:
                        l_message = PRODU_AProduct(ref p_Item);
                        break;
                }
                if (string.IsNullOrEmpty(l_message))
                {
                    if (!BL_VENPY_MeasurementUnitsProducts.BLMUPRI_ByProduct(p_Item.BUSI_Code, p_Item.PROD_Code, p_Item.UDTT_MeasurementUnitsProducts, p_Item.AUDI_CreationUser, false))
                    { l_message = "No se guardó las Unidades de Medida"; }
                }
                if (string.IsNullOrEmpty(l_message))
                { DataAccessPersonalSQL.DAP_CommitTransaction(); }
                else
                { DataAccessPersonalSQL.DAP_RollbackTransaction(); }
                return l_message;
            }
            catch (Exception ex)
            {
                DataAccessPersonalSQL.DAP_RollbackTransaction();
                throw ex;
            }
        }
        public String BLPRODD_AProduct(ref VENPY_Products p_Item)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                l_message = PRODD_AProduct(ref p_Item);
                if (string.IsNullOrEmpty(l_message))
                { DataAccessPersonalSQL.DAP_CommitTransaction(); }
                else
                { DataAccessPersonalSQL.DAP_RollbackTransaction(); }
                return l_message;
            }
            catch (Exception ex)
            {
                DataAccessPersonalSQL.DAP_RollbackTransaction();
                throw ex;
            }
        }

        #endregion
    }
}
