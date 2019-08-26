using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;

namespace VenPy.Connection
{
    public partial class BLVENPY_Business : IBLVENPY_Business
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_Business> BLBUSIS_ByUser(Int32 p_USER_Code)
        {
            try
            {
                return BUSIS_ByUser(p_USER_Code);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<VENPY_Business> BLBUSIS_ListCompanies(Int32 p_USER_Code, String p_BUSI_RUC, String p_BUSI_BusinessName)
        {
            try
            {
                return BUSIS_ListCompanies(p_USER_Code, p_BUSI_RUC, p_BUSI_BusinessName);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public VENPY_Business BLBUSIS_ACompany(Int32 p_BUSI_Code)
        {
            try
            {
                return BUSIS_ACompany(p_BUSI_Code);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public String BLBUSI_Save(ref VENPY_Business p_Item)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                switch (p_Item.Instance)
                {
                    case InstanceEntity.Insert:
                        l_message = BUSII_ACompany(ref p_Item);
                        break;
                    case InstanceEntity.Update:
                        l_message = BUSIU_ACompany(ref p_Item);
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
