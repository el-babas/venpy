using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;
using System.Data;

namespace VenPy.Connection
{
    public partial class BLVENPY_Entities
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_Entities> Loader { get; set; }
        [Dependency]
        private IBLVENPY_FunctionsEntities BL_VENPY_FunctionsEntities { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_Entities()
        {
            Loader = new EntityLoader<VENPY_Entities>();
            VENPY_Entities Item = new VENPY_Entities();
            Loader.EntityType = Item.GetType();
            BL_VENPY_FunctionsEntities = new BLVENPY_FunctionsEntities();
        }

        #endregion

        #region [ QUERIES ]

        private ObservableCollection<VENPY_Entities> ENTIS_ListEntities(Int32 p_BUSI_Code, Int32 p_ETYP_Code, String p_ENTI_DocumentNumber, String p_ENTI_BusinessName, Boolean p_ENTI_Favourite)
        {
            try
            {
                ObservableCollection<VENPY_Entities> Items = new ObservableCollection<VENPY_Entities>();
                VENPY_Entities Item = new VENPY_Entities();
                DataAccessPersonalSQL.DAP_StoredProcedure("ENTIS_ListEntities");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintETYP_Code", p_ETYP_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_DocumentNumber", p_ENTI_DocumentNumber, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_BusinessName", p_ENTI_BusinessName, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitENTI_Favourite", p_ENTI_Favourite, SqlDbType.Bit, 1, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_Entities();
                        Loader.LoadEntity(reader, Item);
                        Item.Instance = InstanceEntity.Unchanged;
                        Items.Add(Item);
                    }
                }
                return Items;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private ObservableCollection<VENPY_Entities> ENTIS_Help(Int32 p_BUSI_Code, Int32 p_ETYP_Code, String p_ENTI_DocumentNumber, String p_ENTI_BusinessName)
        {
            try
            {
                ObservableCollection<VENPY_Entities> Items = new ObservableCollection<VENPY_Entities>();
                VENPY_Entities Item = new VENPY_Entities();
                DataAccessPersonalSQL.DAP_StoredProcedure("ENTIS_Help");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintETYP_Code", p_ETYP_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_DocumentNumber", p_ENTI_DocumentNumber, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_BusinessName", p_ENTI_BusinessName, SqlDbType.VarChar, 100, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_Entities();
                        Loader.LoadEntity(reader, Item);
                        Item.Instance = InstanceEntity.Unchanged;
                        Items.Add(Item);
                    }
                }
                return Items;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private VENPY_Entities ENTIS_AEntity(Int32 p_BUSI_Code, Int32 p_ENTI_Code)
        {
            try
            {
                VENPY_Entities Item = new VENPY_Entities();
                DataAccessPersonalSQL.DAP_StoredProcedure("ENTIS_AEntity");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintENTI_Code", p_ENTI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Item = new VENPY_Entities();
                        Loader.LoadEntity(reader, Item);
                        Item.Instance = InstanceEntity.Unchanged;
                    }
                }
                return Item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METODOS ]

        private String ENTII_AEntity(ref VENPY_Entities p_Item)
        {
            try
            {
                String l_Message = null;
                Int32 l_ENTI_Code;
                DataAccessPersonalSQL.DAP_StoredProcedure("ENTII_AEntity");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintENTI_Code", p_Item.ENTI_Code, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableTDI", p_Item.TBLE_TableTDI, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeTDI", p_Item.TBLE_CodeTDI, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pchrENTI_EntityType", p_Item.ENTI_EntityType, SqlDbType.Char, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_DocumentNumber", p_Item.ENTI_DocumentNumber, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_BusinessName", p_Item.ENTI_BusinessName, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdteENTI_Birthdate", p_Item.ENTI_Birthdate, SqlDbType.Date, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_Address", p_Item.ENTI_Address, SqlDbType.VarChar, 200, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_Code", p_Item.UBIG_Code, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_Email", p_Item.ENTI_Email, SqlDbType.VarChar, 150, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_Web", p_Item.ENTI_Web, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_PhoneNumber", p_Item.ENTI_PhoneNumber, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_ReferentialAddress", p_Item.ENTI_ReferentialAddress, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitENTI_Domiciled", p_Item.ENTI_Domiciled, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TablePAI", p_Item.TBLE_TablePAI, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodePAI", p_Item.TBLE_CodePAI, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitENTI_Favourite", p_Item.ENTI_Favourite, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_BankAccount", p_Item.ENTI_BankAccount, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pchrENTI_Status", p_Item.ENTI_Status, SqlDbType.Char, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_CreationUser", p_Item.AUDI_CreationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_ErrorMessage", DBNull.Value, SqlDbType.VarChar, -1, ParameterDirection.InputOutput);

                DataAccessPersonalSQL.DAP_ExecuteNonQuery();
                l_Message = DataAccessPersonalSQL.Sql_Command.Parameters["@pvchENTI_ErrorMessage"].Value.ToString();
                if (Int32.TryParse(DataAccessPersonalSQL.Sql_Command.Parameters["@pintENTI_Code"].Value.ToString(), out l_ENTI_Code))
                { p_Item.ENTI_Code = l_ENTI_Code; }
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String ENTIU_AEntity(ref VENPY_Entities p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("ENTIU_AEntity");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintENTI_Code", p_Item.ENTI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableTDI", p_Item.TBLE_TableTDI, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeTDI", p_Item.TBLE_CodeTDI, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pchrENTI_EntityType", p_Item.ENTI_EntityType, SqlDbType.Char, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_DocumentNumber", p_Item.ENTI_DocumentNumber, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_BusinessName", p_Item.ENTI_BusinessName, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdteENTI_Birthdate", p_Item.ENTI_Birthdate, SqlDbType.Date, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_Address", p_Item.ENTI_Address, SqlDbType.VarChar, 200, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_Code", p_Item.UBIG_Code, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_Email", p_Item.ENTI_Email, SqlDbType.VarChar, 150, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_Web", p_Item.ENTI_Web, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_PhoneNumber", p_Item.ENTI_PhoneNumber, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_ReferentialAddress", p_Item.ENTI_ReferentialAddress, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitENTI_Domiciled", p_Item.ENTI_Domiciled, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TablePAI", p_Item.TBLE_TablePAI, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodePAI", p_Item.TBLE_CodePAI, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitENTI_Favourite", p_Item.ENTI_Favourite, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_BankAccount", p_Item.ENTI_BankAccount, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pchrENTI_Status", p_Item.ENTI_Status, SqlDbType.Char, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_ModificationUser", p_Item.AUDI_ModificationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchENTI_ErrorMessage", DBNull.Value, SqlDbType.VarChar, -1, ParameterDirection.InputOutput);

                DataAccessPersonalSQL.DAP_ExecuteNonQuery();
                l_Message = DataAccessPersonalSQL.Sql_Command.Parameters["@pvchENTI_ErrorMessage"].Value.ToString();
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String ENTID_AEntity(ref VENPY_Entities p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("ENTID_AEntity");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintENTI_Code", p_Item.ENTI_Code, SqlDbType.Int, 4, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() >= 0)
                { l_Message = null; }
                else
                { l_Message = "No se realizó ningún cambio en la Base de Datos"; }

                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
