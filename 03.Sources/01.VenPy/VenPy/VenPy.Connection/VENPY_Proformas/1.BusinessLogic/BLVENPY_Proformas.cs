using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;

namespace VenPy.Connection
{
    public partial class BLVENPY_Proformas : IBLVENPY_Proformas
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_Proformas> BLPROFS_ListProformas(Int32 p_BUSI_Code, String p_PROF_Number, DateTime p_PROF_DateBegin, DateTime p_PROF_DateEnd, Boolean p_PROF_OnlyActive)
        {
            try
            {
                return PROFS_ListProformas(p_BUSI_Code, p_PROF_Number, p_PROF_DateBegin, p_PROF_DateEnd, p_PROF_OnlyActive);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public VENPY_Proformas BLPROFS_AProforma(Int32 p_BUSI_Code, Int32 p_PROF_Code)
        {
            try
            {
                VENPY_Proformas l_item = new VENPY_Proformas();
                l_item = PROFS_AProforma(p_BUSI_Code, p_PROF_Code);
                l_item.PROF_ProformaDetails = BL_VENPY_ProformaDetails.BLPFDES_ByProforma(p_BUSI_Code, p_PROF_Code);
                return l_item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public String BLPROD_Save(ref VENPY_Proformas p_Item)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                switch (p_Item.Instance)
                {
                    case InstanceEntity.Insert:
                        l_message = PROFI_AProforma(ref p_Item);
                        break;
                    case InstanceEntity.Update:
                        l_message = PROFU_AProforma(ref p_Item);
                        break;
                }
                if (string.IsNullOrEmpty(l_message))
                {
                    ObservableCollection<VENPY_ProformaDetails> l_details = p_Item.PROF_ProformaDetails;
                    string l_messageDetails = BL_VENPY_ProformaDetails.BLPFDE_Save(ref l_details, p_Item.AUDI_CreationUser);
                    if (string.IsNullOrEmpty(l_messageDetails))
                    {
                        if (p_Item.PROF_ProformaDetailsDeleted != null && p_Item.PROF_ProformaDetailsDeleted.Count() > 0)
                        {
                            l_details = p_Item.PROF_ProformaDetailsDeleted;
                            l_messageDetails = BL_VENPY_ProformaDetails.BLPFDED_AProformaDetail(ref l_details);
                            if (!string.IsNullOrEmpty(l_messageDetails))
                            { l_message = "Ocurrio un problema al eliminar los detalles " + l_messageDetails; }
                        }
                    }
                    else
                    { l_message = "Ocurrio un problema al guardar los detalles " + l_messageDetails; }
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
