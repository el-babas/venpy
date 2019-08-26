using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;

namespace VenPy.Connection
{
    public partial class BLVENPY_EntityTypes : IBLVENPY_EntityTypes
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_EntityTypes> BLETYPS_ListEntityTypes(Int32 p_BUSI_Code, String p_ETYP_Name)
        {
            try
            {
                return ETYPS_ListEntityTypes(p_BUSI_Code, p_ETYP_Name);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public VENPY_EntityTypes BLETYPS_AEntityType(Int32 p_BUSI_Code, Int32 p_ETYP_Code)
        {
            try
            {
                return ETYPS_AEntityType(p_BUSI_Code, p_ETYP_Code);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public String BLETYP_Save(ref VENPY_EntityTypes p_Item)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                switch (p_Item.Instance)
                {
                    case InstanceEntity.Insert:
                        l_message = ETYPI_AEntityType(ref p_Item);
                        break;
                    case InstanceEntity.Update:
                        l_message = ETYPU_AEntityType(ref p_Item);
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
        public String BLETYPD_AEntityType(ref VENPY_EntityTypes p_Item)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                l_message = ETYPD_AEntityType(ref p_Item);
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
