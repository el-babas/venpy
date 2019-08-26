using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;

namespace VenPy.Connection
{
    public partial class BLVENPY_ExchangeRate : IBLVENPY_ExchangeRate
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_ExchangeRate> BLEXRAS_ListExchangeRate(Int32 p_BUSI_Code, String p_EXRA_Year, String p_EXRA_Month)
        {
            try
            {
                return EXRAS_ListExchangeRate(p_BUSI_Code, p_EXRA_Year, p_EXRA_Month);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public String BLEXRA_Save(ref VENPY_ExchangeRate p_Item)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                switch (p_Item.Instance)
                {
                    case InstanceEntity.Insert:
                        l_message = EXRAI_AExchangeRate(ref p_Item);
                        break;
                    case InstanceEntity.Update:
                        l_message = EXRAU_AExchangeRate(ref p_Item);
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

        #endregion
    }
}
