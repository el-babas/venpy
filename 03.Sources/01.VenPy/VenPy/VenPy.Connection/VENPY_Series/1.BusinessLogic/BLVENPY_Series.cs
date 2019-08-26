using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;

namespace VenPy.Connection
{
    public partial class BLVENPY_Series : IBLVENPY_Series
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_Series> BLSERIS_ListSeries(Int32 p_BUSI_Code, String p_TBLE_TableTDO, String p_TBLE_CodeTDO)
        {
            try
            {
                return SERIS_ListSeries(p_BUSI_Code, p_TBLE_TableTDO, p_TBLE_CodeTDO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public String BLSERI_Save(ref ObservableCollection<VENPY_Series> p_Items, String p_User)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                string l_serie = null;
                for (int i = 0; i < p_Items.Count; i++)
                {
                    var Item = p_Items.ElementAt(i);
                    l_serie = Item.SERI_Serie;
                    switch (Item.Instance)
                    {
                        case InstanceEntity.Insert:
                            Item.AUDI_CreationUser = p_User;
                            l_message = SERII_ASerie(ref Item);
                            break;
                        case InstanceEntity.Update:
                            Item.AUDI_ModificationUser = p_User;
                            l_message = SERIU_ASerie(ref Item);
                            break;
                    }
                    if (!string.IsNullOrEmpty(l_message))
                    { break; }
                }
                if (string.IsNullOrEmpty(l_message))
                { DataAccessPersonalSQL.DAP_CommitTransaction(); }
                else
                {
                    l_message = l_serie + ": " + l_message;
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
        public String BLSERID_ASerie(ref ObservableCollection<VENPY_Series> p_Items)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                string l_serie = null;
                for (int i = 0; i < p_Items.Count; i++)
                {
                    var Item = p_Items.ElementAt(i);
                    l_serie = Item.SERI_Serie;
                    l_message = SERID_ASerie(ref Item);
                    if (!string.IsNullOrEmpty(l_message))
                    { break; }
                }
                if (string.IsNullOrEmpty(l_message))
                { DataAccessPersonalSQL.DAP_CommitTransaction(); }
                else
                {
                    l_message = l_serie + ": " + l_message;
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
