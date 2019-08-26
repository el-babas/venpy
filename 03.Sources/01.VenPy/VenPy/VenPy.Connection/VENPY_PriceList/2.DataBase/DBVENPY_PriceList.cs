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
    public partial class BLVENPY_PriceList
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_PriceList> Loader { get; set; }
        [Dependency]
        private IBLVENPY_PriceListDetail BL_VENPY_PriceListDetail { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_PriceList()
        {
            Loader = new EntityLoader<VENPY_PriceList>();
            VENPY_PriceList Item = new VENPY_PriceList();
            Loader.EntityType = Item.GetType();
            BL_VENPY_PriceListDetail = new BLVENPY_PriceListDetail();
        }

        #endregion

        #region [ QUERIES ]

        private ObservableCollection<VENPY_PriceList> PRLIS_ListPriceList(Int32 p_BUSI_Code, String p_PRLI_Name)
        {
            try
            {
                ObservableCollection<VENPY_PriceList> Items = new ObservableCollection<VENPY_PriceList>();
                VENPY_PriceList Item = new VENPY_PriceList();
                DataAccessPersonalSQL.DAP_StoredProcedure("PRLIS_ListPriceList");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPRLI_Name", p_PRLI_Name, SqlDbType.VarChar, 50, ParameterDirection.Input);

                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_PriceList();
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
        private ObservableCollection<VENPY_PriceList> PRLIS_ByUser(Int32 p_BUSI_Code, Int32 p_USER_Code)
        {
            try
            {
                ObservableCollection<VENPY_PriceList> Items = new ObservableCollection<VENPY_PriceList>();
                VENPY_PriceList Item = new VENPY_PriceList();
                DataAccessPersonalSQL.DAP_StoredProcedure("PRLIS_ByUser");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintUSER_Code", p_USER_Code, SqlDbType.Int, 4, ParameterDirection.Input);

                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_PriceList();
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
        private VENPY_PriceList PRLIS_APriceList(Int32 p_BUSI_Code, Int32 p_PRLI_Code)
        {
            try
            {
                VENPY_PriceList Item = new VENPY_PriceList();
                DataAccessPersonalSQL.DAP_StoredProcedure("PRLIS_APriceList");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPRLI_Code", p_PRLI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Item = new VENPY_PriceList();
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

        private String PRLII_APriceList(ref VENPY_PriceList p_Item)
        {
            try
            {
                String l_Message = null;
                Int32 l_PRLI_Code;
                DataAccessPersonalSQL.DAP_StoredProcedure("PRLII_APriceList");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPRLI_Code", p_Item.PRLI_Code, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitPRLI_Active", p_Item.PRLI_Active, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableMND", p_Item.TBLE_TableMND, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeMND", p_Item.TBLE_CodeMND, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPRLI_Name", p_Item.PRLI_Name, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableTAI", p_Item.TBLE_TableTAI, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeTAI", p_Item.TBLE_CodeTAI, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPRLI_Description", p_Item.PRLI_Description, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_CreationUser", p_Item.AUDI_CreationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() >= 0)
                {
                    l_Message = null;
                    if (Int32.TryParse(DataAccessPersonalSQL.Sql_Command.Parameters["@pintPRLI_Code"].Value.ToString(), out l_PRLI_Code))
                    { p_Item.PRLI_Code = l_PRLI_Code; }
                }
                else
                { l_Message = "No se realizó ningún cambio en la Base de Datos"; }
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String PRLIU_APriceList(ref VENPY_PriceList p_Item)
        {
            try
            {
                String l_Message = null;
                Int32 l_PRLI_Code;
                DataAccessPersonalSQL.DAP_StoredProcedure("PRLIU_APriceList");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPRLI_Code", p_Item.PRLI_Code, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitPRLI_Active", p_Item.PRLI_Active, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableMND", p_Item.TBLE_TableMND, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeMND", p_Item.TBLE_CodeMND, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPRLI_Name", p_Item.PRLI_Name, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableTAI", p_Item.TBLE_TableTAI, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeTAI", p_Item.TBLE_CodeTAI, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPRLI_Description", p_Item.PRLI_Description, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_ModificationUser", p_Item.AUDI_ModificationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() >= 0)
                {
                    l_Message = null;
                    if (Int32.TryParse(DataAccessPersonalSQL.Sql_Command.Parameters["@pintPRLI_Code"].Value.ToString(), out l_PRLI_Code))
                    { p_Item.PRLI_Code = l_PRLI_Code; }
                }
                else
                { l_Message = "No se realizó ningún cambio en la Base de Datos"; }
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String PRLID_APriceList(ref VENPY_PriceList p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("PRLID_APriceList");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPRLI_Code", p_Item.PRLI_Code, SqlDbType.Int, 4, ParameterDirection.Input);

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
