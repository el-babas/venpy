using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;

namespace VenPy.Connection
{
    public partial class BLVENPY_Ubigeos : IBLVENPY_Ubigeos
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_Ubigeos> BLUBIGS_All()
        {
            try
            {
                return UBIGS_All();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public VENPY_Ubigeos BLUBIGS_AUbigeo(String p_UBIG_Code)
        {
            try
            {
                return UBIGS_AUbigeo(p_UBIG_Code);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public String BLUBIG_Save(ref VENPY_Ubigeos p_Item)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_mensaje = null;
                switch (p_Item.Instance)
                {
                    case InstanceEntity.Insert:
                        l_mensaje = UBIGI_AUbigeo(ref p_Item);
                        break;
                    case InstanceEntity.Update:
                        l_mensaje = UBIGU_AUbigeo(ref p_Item);
                        break;
                }
                if (string.IsNullOrEmpty(l_mensaje))
                { DataAccessPersonalSQL.DAP_CommitTransaction(); }
                else
                { DataAccessPersonalSQL.DAP_RollbackTransaction(); }
                return l_mensaje;
            }
            catch (Exception ex)
            {
                DataAccessPersonalSQL.DAP_RollbackTransaction();
                throw ex;
            }
        }
        public String BLUBIGD_AUbigeo(ref VENPY_Ubigeos p_Item)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_mensaje = null;
                l_mensaje = UBIGD_AUbigeo(ref p_Item);
                if (string.IsNullOrEmpty(l_mensaje))
                { DataAccessPersonalSQL.DAP_CommitTransaction(); }
                else
                { DataAccessPersonalSQL.DAP_RollbackTransaction(); }
                return l_mensaje;
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
