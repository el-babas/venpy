using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;

namespace VenPy.Connection
{
    public partial class BLVENPY_PointsSale : IBLVENPY_PointsSale
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_PointsSale> BLPSALS_ByUser(Int32 p_USER_Code, Nullable<Int32> p_BUSI_Code)
        {
            try
            {
                return PSALS_ByUser(p_USER_Code, p_BUSI_Code);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<VENPY_PointsSale> BLPSALS_ListPointsSale(Int32 p_BUSI_Code, Int32 p_USER_Code, String p_PSAL_Name)
        {
            try
            {
                return PSALS_ListPointsSale(p_BUSI_Code, p_USER_Code, p_PSAL_Name);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public VENPY_PointsSale BLPSALS_APointSale(Int32 p_BUSI_Code, Int32 p_BOFF_Code, Int32 p_PSAL_Code)
        {
            try
            {
                return PSALS_APointSale(p_BUSI_Code, p_BOFF_Code, p_PSAL_Code);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public String BLPSAL_Save(ref VENPY_PointsSale p_Item)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                switch (p_Item.Instance)
                {
                    case InstanceEntity.Insert:
                        l_message = PSALI_APointSale(ref p_Item);
                        break;
                    case InstanceEntity.Update:
                        l_message = PSALU_APointSale(ref p_Item);
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
