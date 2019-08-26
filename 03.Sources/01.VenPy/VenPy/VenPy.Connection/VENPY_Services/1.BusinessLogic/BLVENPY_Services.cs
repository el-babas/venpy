using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;

namespace VenPy.Connection
{
    public partial class BLVENPY_Services : IBLVENPY_Services
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_Services> BLSERVS_ListServices(Int32 p_BUSI_Code, String p_TBLE_TableFAS, String p_TBLE_CodeFAS, String p_SERV_Name)
        {
            try
            {
                return SERVS_ListServices(p_BUSI_Code, p_TBLE_TableFAS, p_TBLE_CodeFAS, p_SERV_Name);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public VENPY_Services BLSERVS_AService(Int32 p_BUSI_Code, Int32 p_SERV_Code)
        {
            try
            {
                return SERVS_AService(p_BUSI_Code, p_SERV_Code);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public String BLSERV_Save(ref VENPY_Services p_Item)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                switch (p_Item.Instance)
                {
                    case InstanceEntity.Insert:
                        l_message = SERVI_AService(ref p_Item);
                        break;
                    case InstanceEntity.Update:
                        l_message = SERVU_AService(ref p_Item);
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
        public String BLSERVD_AService(ref VENPY_Services p_Item)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                l_message = SERVD_AService(ref p_Item);
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
