using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;

namespace VenPy.Connection
{
    public partial class BLVENPY_PriceList : IBLVENPY_PriceList
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_PriceList> BLPRLIS_ListPriceList(Int32 p_BUSI_Code, String p_PRLI_Name)
        {
            try
            {
                return PRLIS_ListPriceList(p_BUSI_Code, p_PRLI_Name);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<VENPY_PriceList> BLPRLIS_ByUser(Int32 p_BUSI_Code, Int32 p_USER_Code)
        {
            try
            {
                return PRLIS_ByUser(p_BUSI_Code, p_USER_Code);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public VENPY_PriceList BLPRLIS_APriceList(Int32 p_BUSI_Code, Int32 p_PRLI_Code)
        {
            try
            {
                VENPY_PriceList l_item = new VENPY_PriceList();
                l_item = PRLIS_APriceList(p_BUSI_Code, p_PRLI_Code);
                l_item.PRLI_PriceListDetail = BL_VENPY_PriceListDetail.BLPLDES_ByPriceList(p_BUSI_Code, p_PRLI_Code);
                return l_item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public String BLPRLI_Save(ref VENPY_PriceList p_Item)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                switch (p_Item.Instance)
                {
                    case InstanceEntity.Insert:
                        l_message = PRLII_APriceList(ref p_Item);
                        break;
                    case InstanceEntity.Update:
                        l_message = PRLIU_APriceList(ref p_Item);
                        break;
                }
                if (string.IsNullOrEmpty(l_message))
                {
                    int l_index = 0;
                    foreach (VENPY_PriceListDetail item in p_Item.PRLI_PriceListDetail)
                    {
                        l_index++;
                        VENPY_PriceListDetail l_PriceListDetail = item;
                        if (item.PLDE_Item == 0)
                        { item.Instance = InstanceEntity.Insert; }
                        item.BUSI_Code = p_Item.BUSI_Code;
                        item.PRLI_Code = p_Item.PRLI_Code;
                        item.AUDI_CreationUser = p_Item.AUDI_CreationUser;
                        item.AUDI_ModificationUser = p_Item.AUDI_ModificationUser;
                        l_message = BL_VENPY_PriceListDetail.BLPLDE_Save(ref l_PriceListDetail, false);
                        if (!string.IsNullOrEmpty(l_message))
                        {
                            l_message = string.Format("Item {0} : {1}", l_index, l_message);
                            break;
                        }
                    }
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
        public String BLPRLID_APriceList(ref VENPY_PriceList p_Item)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                l_message = PRLID_APriceList(ref p_Item);
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
