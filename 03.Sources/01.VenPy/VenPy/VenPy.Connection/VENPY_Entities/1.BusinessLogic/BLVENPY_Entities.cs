using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;

namespace VenPy.Connection
{
    public partial class BLVENPY_Entities : IBLVENPY_Entities
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_Entities> BLENTIS_ListEntities(Int32 p_BUSI_Code, Int32 p_ETYP_Code, String p_ENTI_DocumentNumber, String p_ENTI_BusinessName, Boolean p_ENTI_Favourite)
        {
            try
            {
                return ENTIS_ListEntities(p_BUSI_Code, p_ETYP_Code, p_ENTI_DocumentNumber, p_ENTI_BusinessName, p_ENTI_Favourite);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<VENPY_Entities> BLENTIS_Help(Int32 p_BUSI_Code, Int32 p_ETYP_Code, String p_ENTI_DocumentNumber, String p_ENTI_BusinessName)
        {
            try
            {
                return ENTIS_Help(p_BUSI_Code, p_ETYP_Code, p_ENTI_DocumentNumber, p_ENTI_BusinessName);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public VENPY_Entities BLENTIS_AEntity(Int32 p_BUSI_Code, Int32 p_ENTI_Code)
        {
            try
            {
                VENPY_Entities l_item = new VENPY_Entities();
                l_item = ENTIS_AEntity(p_BUSI_Code, p_ENTI_Code);
                l_item.ENTI_FunctionsEntities = BL_VENPY_FunctionsEntities.BLFENTS_ByEntity(p_BUSI_Code, p_ENTI_Code);
                return l_item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public String BLENTI_Save(ref VENPY_Entities p_Item)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                switch (p_Item.Instance)
                {
                    case InstanceEntity.Insert:
                        l_message = ENTII_AEntity(ref p_Item);
                        if (string.IsNullOrEmpty(l_message))
                        {
                            if (!BL_VENPY_FunctionsEntities.BLFENTI_ByEntity(p_Item.BUSI_Code, p_Item.ENTI_Code, p_Item.UDTT_FunctionsEntities, p_Item.AUDI_CreationUser, false))
                            { l_message = "No se guardó las Funciones de la Entidad"; }
                        }
                        break;
                    case InstanceEntity.Update:
                        l_message = ENTIU_AEntity(ref p_Item);
                        if (string.IsNullOrEmpty(l_message))
                        {
                            if (!BL_VENPY_FunctionsEntities.BLFENTI_ByEntity(p_Item.BUSI_Code, p_Item.ENTI_Code, p_Item.UDTT_FunctionsEntities, p_Item.AUDI_CreationUser, false))
                            { l_message = "No se guardó las Funciones de la Entidad"; }
                        }
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
        public String BLENTID_AEntity(ref VENPY_Entities p_Item)
        {
            DataAccessPersonalSQL.DAP_BeginTransaction();
            try
            {
                string l_message = null;
                l_message = ENTID_AEntity(ref p_Item);
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
