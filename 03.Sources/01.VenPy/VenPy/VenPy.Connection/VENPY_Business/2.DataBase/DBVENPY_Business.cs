using System;
using System.Collections.ObjectModel;
using VenPy.Entities;
using VenPy.Class;
using System.Data;

namespace VenPy.Connection
{
    public partial class BLVENPY_Business
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_Business> Loader { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_Business()
        {
            Loader = new EntityLoader<VENPY_Business>();
            VENPY_Business Item = new VENPY_Business();
            Loader.EntityType = Item.GetType();
        }

        #endregion

        #region [ QUERIES ]

        private ObservableCollection<VENPY_Business> BUSIS_ByUser(Int32 p_USER_Code)
        {
            try
            {
                ObservableCollection<VENPY_Business> Items = new ObservableCollection<VENPY_Business>();
                VENPY_Business Item = new VENPY_Business();
                DataAccessPersonalSQL.DAP_StoredProcedure("BUSIS_ByUser");
                DataAccessPersonalSQL.DAP_AddParameter("@pintUSER_Code", p_USER_Code, SqlDbType.Int, 8, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_Business();
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
        private VENPY_Business BUSIS_ACompany(Int32 p_BUSI_Code)
        {
            try
            {
                VENPY_Business Item = new VENPY_Business();
                DataAccessPersonalSQL.DAP_StoredProcedure("BUSIS_ACompany");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Item = new VENPY_Business();
                        Loader.LoadEntity(reader, Item);
                        Item.Instance = InstanceEntity.Unchanged;
                    }
                }
                return Item;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private ObservableCollection<VENPY_Business> BUSIS_ListCompanies(Int32 p_USER_Code, String p_BUSI_RUC, String p_BUSI_BusinessName)
        {
            try
            {
                ObservableCollection<VENPY_Business> Items = new ObservableCollection<VENPY_Business>();
                VENPY_Business Item = new VENPY_Business();
                DataAccessPersonalSQL.DAP_StoredProcedure("BUSIS_ListCompanies");
                DataAccessPersonalSQL.DAP_AddParameter("@pintUSER_Code", p_USER_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_RUC", p_BUSI_RUC, SqlDbType.VarChar, 11, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_BusinessName", p_BUSI_BusinessName, SqlDbType.VarChar, 100, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_Business();
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

        #endregion

        #region [ METODOS ]

        private String BUSII_ACompany(ref VENPY_Business p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("BUSII_ACompany");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_RUC", p_Item.BUSI_RUC, SqlDbType.VarChar, 11, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_BusinessName", p_Item.BUSI_BusinessName, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_TradeName", p_Item.BUSI_TradeName, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_Address1", p_Item.BUSI_Address1, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_Address2", p_Item.BUSI_Address2, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_Urbanization", p_Item.BUSI_Urbanization, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_Email", p_Item.BUSI_Email, SqlDbType.VarChar, 150, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_Web", p_Item.BUSI_Web, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_SocialNetworks", p_Item.BUSI_SocialNetworks, SqlDbType.VarChar, 250, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_PhoneNumber1", p_Item.BUSI_PhoneNumber1, SqlDbType.VarChar, 25, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_PhoneNumber2", p_Item.BUSI_PhoneNumber2, SqlDbType.VarChar, 25, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_BankAccount", p_Item.BUSI_BankAccount, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_Code", p_Item.UBIG_Code, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_CreationUser", p_Item.AUDI_CreationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_ErrorMessage", DBNull.Value, SqlDbType.VarChar, -1, ParameterDirection.InputOutput);

                DataAccessPersonalSQL.DAP_ExecuteNonQuery();
                l_Message = DataAccessPersonalSQL.Sql_Command.Parameters["@pvchBUSI_ErrorMessage"].Value.ToString();
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String BUSIU_ACompany(ref VENPY_Business p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("BUSIU_ACompany");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_RUC", p_Item.BUSI_RUC, SqlDbType.VarChar, 11, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_BusinessName", p_Item.BUSI_BusinessName, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_TradeName", p_Item.BUSI_TradeName, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_Address1", p_Item.BUSI_Address1, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_Address2", p_Item.BUSI_Address2, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_Urbanization", p_Item.BUSI_Urbanization, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_Email", p_Item.BUSI_Email, SqlDbType.VarChar, 150, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_Web", p_Item.BUSI_Web, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_SocialNetworks", p_Item.BUSI_SocialNetworks, SqlDbType.VarChar, 250, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_PhoneNumber1", p_Item.BUSI_PhoneNumber1, SqlDbType.VarChar, 25, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_PhoneNumber2", p_Item.BUSI_PhoneNumber2, SqlDbType.VarChar, 25, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_BankAccount", p_Item.BUSI_BankAccount, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_Code", p_Item.UBIG_Code, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_ModificationUser", p_Item.AUDI_ModificationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBUSI_ErrorMessage", DBNull.Value, SqlDbType.VarChar, -1, ParameterDirection.InputOutput);

                DataAccessPersonalSQL.DAP_ExecuteNonQuery();
                l_Message = DataAccessPersonalSQL.Sql_Command.Parameters["@pvchBUSI_ErrorMessage"].Value.ToString();
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
