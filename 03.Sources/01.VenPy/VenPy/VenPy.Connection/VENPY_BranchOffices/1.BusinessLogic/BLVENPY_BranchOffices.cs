using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;

namespace VenPy.Connection
{
    public partial class BLVENPY_BranchOffices : IBLVENPY_BranchOffices
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_BranchOffices> BLBOFFS_ByUser(Int32 p_USER_Code, Nullable<Int32> p_BUSI_Code)
        {
            try
            {
                return BOFFS_ByUser(p_USER_Code, p_BUSI_Code);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<VENPY_BranchOffices> BLBOFFS_ListBranchOffices(Int32 p_BUSI_Code, Int32 p_USER_Code, String p_BOFF_Name)
        {
            try
            {
                return BOFFS_ListBranchOffices(p_BUSI_Code, p_USER_Code, p_BOFF_Name);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public VENPY_BranchOffices BLBOFFS_ABranchOffice(Int32 p_BUSI_Code, Int32 p_BOFF_Code)
        {
            try
            {
                VENPY_BranchOffices l_item = new VENPY_BranchOffices();
                l_item = BOFFS_ABranchOffice(p_BUSI_Code, p_BOFF_Code);
                l_item.BOFF_WarehousesBranches = BL_VENPY_WarehousesBranches.BLWABRS_ByBranch(p_BUSI_Code, p_BOFF_Code);
                return l_item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public String BLBOFF_Save(ref VENPY_BranchOffices p_Item)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                switch (p_Item.Instance)
                {
                    case InstanceEntity.Insert:
                        l_message = BOFFI_ABranchOffice(ref p_Item);
                        break;
                    case InstanceEntity.Update:
                        l_message = BOFFU_ABranchOffice(ref p_Item);
                        break;
                }
                if (string.IsNullOrEmpty(l_message))
                {
                    if (!BL_VENPY_WarehousesBranches.BLWABRI_ByBranch(p_Item.BUSI_Code, p_Item.BOFF_Code, p_Item.UDTT_WarehousesBranches, p_Item.AUDI_CreationUser, false))
                    { l_message = "No se guardó los Alamcenes"; }
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
