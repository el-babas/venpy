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
    public partial class BLVENPY_FunctionsEntities : IBLVENPY_FunctionsEntities
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_FunctionsEntities> BLFENTS_ByEntity(Int32 p_BUSI_Code, Nullable<Int32> p_ENTI_Code)
        {
            try
            {
                return FENTS_ByEntity(p_BUSI_Code, p_ENTI_Code);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public Boolean BLFENTI_ByEntity(Int32 p_BUSI_Code, Int32 p_ENTI_Code, DataTable p_UDTT_FunctionsEntities, String p_AUDI_CreationUser, Boolean p_Transaction)
        {
            bool l_correcto = false;
            if (p_Transaction)
            {
                DataAccessPersonalSQL.DAP_BeginTransaction();
                try
                {
                    l_correcto = FENTI_ByEntity(p_BUSI_Code, p_ENTI_Code, p_UDTT_FunctionsEntities, p_AUDI_CreationUser);
                    if (l_correcto)
                    { DataAccessPersonalSQL.DAP_CommitTransaction(); }
                    else
                    { DataAccessPersonalSQL.DAP_RollbackTransaction(); }
                    return l_correcto;
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
                    l_correcto = FENTI_ByEntity(p_BUSI_Code, p_ENTI_Code, p_UDTT_FunctionsEntities, p_AUDI_CreationUser);
                    return l_correcto;
                }
                catch (Exception ex)
                { throw ex; }
            }
        }

        #endregion
    }
}
