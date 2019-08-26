using System;
using System.Collections.ObjectModel;
using VenPy.Entities;
using VenPy.Class;
using System.Data;

namespace VenPy.Connection
{
    public partial class BLVENPY_Tables
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_Tables> Loader { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_Tables()
        {
            Loader = new EntityLoader<VENPY_Tables>();
            VENPY_Tables Item = new VENPY_Tables();
            Loader.EntityType = Item.GetType();
        }

        #endregion

        #region [ QUERIES ]

        private ObservableCollection<VENPY_Tables> TBLES_All(Int32 p_BUSI_Code)
        {
            try
            {
                ObservableCollection<VENPY_Tables> Items = new ObservableCollection<VENPY_Tables>();
                VENPY_Tables Item = new VENPY_Tables();
                DataAccessPersonalSQL.DAP_StoredProcedure("TBLES_All");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_Tables();
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
        private ObservableCollection<VENPY_Tables> TBLES_ListTables(Int32 p_BUSI_Code, String p_TBLE_Table)
        {
            try
            {
                ObservableCollection<VENPY_Tables> Items = new ObservableCollection<VENPY_Tables>();
                VENPY_Tables Item = new VENPY_Tables();
                DataAccessPersonalSQL.DAP_StoredProcedure("TBLES_ListTables");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_Table", p_TBLE_Table, SqlDbType.VarChar, 3, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_Tables();
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
        private VENPY_Tables TBLES_ATable(Int32 p_BUSI_Code, String p_TBLE_Table, String p_TBLE_Code)
        {
            try
            {
                VENPY_Tables Item = new VENPY_Tables();
                DataAccessPersonalSQL.DAP_StoredProcedure("TBLES_ATable");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_Table", p_TBLE_Table, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_Code", p_TBLE_Code, SqlDbType.VarChar, 6, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Item = new VENPY_Tables();
                        Loader.LoadEntity(reader, Item);
                        Item.Instance = InstanceEntity.Unchanged;
                    }
                }
                return Item;
            }
            catch (Exception)
            { throw; }
        }

        #endregion

        #region [ METHODS ]

        private String TBLEI_ATable(ref VENPY_Tables p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("TBLEI_ATable");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_Table", p_Item.TBLE_Table, SqlDbType.VarChar, 3, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_Code", p_Item.TBLE_Code, SqlDbType.VarChar, 6, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_InternationalCode", p_Item.TBLE_InternationalCode, SqlDbType.VarChar, 5, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_SunatCode", p_Item.TBLE_SunatCode, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_Description1", p_Item.TBLE_Description1, SqlDbType.VarChar, 200, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_Description2", p_Item.TBLE_Description2, SqlDbType.VarChar, 150, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintTBLE_Number1", p_Item.TBLE_Number1, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecTBLE_Number2", p_Item.TBLE_Number2, SqlDbType.Decimal, 12, 2, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pchrTBLE_Status", p_Item.TBLE_Status, SqlDbType.Char, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitTBLE_Default", p_Item.TBLE_Default, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_CreationUser", p_Item.AUDI_CreationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() >= 0)
                {
                    l_Message = null;
                    if (DataAccessPersonalSQL.Sql_Command.Parameters["@pvchTBLE_Table"].Value != DBNull.Value && String.IsNullOrEmpty(DataAccessPersonalSQL.Sql_Command.Parameters["@pvchTBLE_Table"].Value.ToString()))
                    { p_Item.TBLE_Table = DataAccessPersonalSQL.Sql_Command.Parameters["@pvchTBLE_Table"].Value.ToString(); }
                    if (DataAccessPersonalSQL.Sql_Command.Parameters["@pvchTBLE_Code"].Value != DBNull.Value && String.IsNullOrEmpty(DataAccessPersonalSQL.Sql_Command.Parameters["@pvchTBLE_Code"].Value.ToString()))
                    { p_Item.TBLE_Code = DataAccessPersonalSQL.Sql_Command.Parameters["@pvchTBLE_Code"].Value.ToString(); }
                }
                else
                { l_Message = "No se realizó ningún cambio en la Base de Datos"; }
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String TBLEU_ATable(ref VENPY_Tables p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("TBLEU_ATable");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_Table", p_Item.TBLE_Table, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_Code", p_Item.TBLE_Code, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_InternationalCode", p_Item.TBLE_InternationalCode, SqlDbType.VarChar, 5, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_SunatCode", p_Item.TBLE_SunatCode, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_Description1", p_Item.TBLE_Description1, SqlDbType.VarChar, 200, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_Description2", p_Item.TBLE_Description2, SqlDbType.VarChar, 150, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintTBLE_Number1", p_Item.TBLE_Number1, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecTBLE_Number2", p_Item.TBLE_Number2, SqlDbType.Decimal, 12, 2, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pchrTBLE_Status", p_Item.TBLE_Status, SqlDbType.Char, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitTBLE_Default", p_Item.TBLE_Default, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_ModificationUser", p_Item.AUDI_ModificationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() >= 0)
                {
                    l_Message = null;
                }
                else
                { l_Message = "No se realizó ningún cambio en la Base de Datos"; }
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String TBLED_ATable(ref VENPY_Tables p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("TBLED_ATable");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_Table", p_Item.TBLE_Table, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_Code", p_Item.TBLE_Code, SqlDbType.VarChar, 6, ParameterDirection.Input);

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
