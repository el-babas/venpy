using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;

namespace VenPy.Connection
{
    public partial class BLVENPY_Tables : IBLVENPY_Tables
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_Tables> BLTBLES_All(Int32 p_BUSI_Code)
        {
            try
            {
                return TBLES_All(p_BUSI_Code);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<VENPY_Tables> BLTBLES_ListTables(Int32 p_BUSI_Code, String p_TBLE_Table)
        {
            try
            {
                return TBLES_ListTables(p_BUSI_Code, p_TBLE_Table);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public VENPY_Tables BLTBLES_ATable(Int32 p_BUSI_Code, String p_TBLE_Table, String p_TBLE_Code)
        {
            try
            {
                return TBLES_ATable(p_BUSI_Code, p_TBLE_Table, p_TBLE_Code);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public String BLTBLE_Save(ref VENPY_Tables p_Item)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                switch (p_Item.Instance)
                {
                    case InstanceEntity.Insert:
                        l_message = TBLEI_ATable(ref p_Item);
                        break;
                    case InstanceEntity.Update:
                        l_message = TBLEU_ATable(ref p_Item);
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
        public String BLTBLED_ATable(ref VENPY_Tables p_Item)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                l_message = TBLED_ATable(ref p_Item);
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
