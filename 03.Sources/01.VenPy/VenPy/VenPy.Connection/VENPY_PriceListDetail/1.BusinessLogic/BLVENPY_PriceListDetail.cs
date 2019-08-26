using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;
using System.Data;

namespace VenPy.Connection
{
    public partial class BLVENPY_PriceListDetail : IBLVENPY_PriceListDetail
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_PriceListDetail> BLPLDES_ByPriceList(Int32 p_BUSI_Code, Nullable<Int32> p_PRLI_Code)
        {
            try
            {
                return PLDES_ByPriceList(p_BUSI_Code, p_PRLI_Code);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public String BLPLDE_Save(ref VENPY_PriceListDetail p_Item, Boolean p_Transaction)
        {
            string l_message = null;
            if (p_Transaction)
            {
                DataAccessPersonalSQL.DAP_BeginTransaction();
                try
                {
                    switch (p_Item.Instance)
                    {
                        case InstanceEntity.Insert:
                            l_message = PLDEI_APriceListDetail(ref p_Item);
                            break;
                        case InstanceEntity.Update:
                            l_message = PLDEU_APriceListDetail(ref p_Item);
                            break;
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
            else
            {
                try
                {
                    switch (p_Item.Instance)
                    {
                        case InstanceEntity.Insert:
                            l_message = PLDEI_APriceListDetail(ref p_Item);
                            break;
                        case InstanceEntity.Update:
                            l_message = PLDEU_APriceListDetail(ref p_Item);
                            break;
                    }
                    return l_message;
                }
                catch (Exception ex)
                { throw ex; }
            }
        }
        
        #endregion
    }
}
