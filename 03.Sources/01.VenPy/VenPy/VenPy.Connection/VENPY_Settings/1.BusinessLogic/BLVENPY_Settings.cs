using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Class;
using VenPy.Entities;

namespace VenPy.Connection
{
    public partial class BLVENPY_Settings : IBLVENPY_Settings
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_Settings> BLSETTS_ByBusiness(Int32 p_BUSI_Code)
        {
            try
            {
                return SETTS_ByBusiness(p_BUSI_Code);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public String BLSETT_Save(ref ObservableCollection<VENPY_Settings> p_Items, String p_User)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                string l_key = null;
                for (int i = 0; i < p_Items.Count; i++)
                {
                    var Item = p_Items.ElementAt(i);
                    l_key = Item.SETT_Key;
                    switch (Item.Instance)
                    {
                        case InstanceEntity.Insert:
                            Item.AUDI_CreationUser = p_User;
                            l_message = SETTI_ASetting(ref Item);
                            break;
                        case InstanceEntity.Update:
                            Item.AUDI_ModificationUser = p_User;
                            l_message = SETTU_ASetting(ref Item);
                            break;
                    }
                    if (!string.IsNullOrEmpty(l_message))
                    { break; }
                }
                if (string.IsNullOrEmpty(l_message))
                { DataAccessPersonalSQL.DAP_CommitTransaction(); }
                else
                {
                    l_message = l_key + ": " + l_message;
                    DataAccessPersonalSQL.DAP_RollbackTransaction();
                }
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
