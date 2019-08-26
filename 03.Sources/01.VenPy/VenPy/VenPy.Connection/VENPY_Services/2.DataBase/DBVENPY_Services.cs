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
    public partial class BLVENPY_Services
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_Services> Loader { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_Services()
        {
            Loader = new EntityLoader<VENPY_Services>();
            VENPY_Services Item = new VENPY_Services();
            Loader.EntityType = Item.GetType();
        }

        #endregion

        #region [ QUERIES ]

        private ObservableCollection<VENPY_Services> SERVS_ListServices(Int32 p_BUSI_Code, String p_TBLE_TableFAS, String p_TBLE_CodeFAS, String p_SERV_Name)
        {
            try
            {
                ObservableCollection<VENPY_Services> Items = new ObservableCollection<VENPY_Services>();
                VENPY_Services Item = new VENPY_Services();
                DataAccessPersonalSQL.DAP_StoredProcedure("SERVS_ListServices");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableFAS", p_TBLE_TableFAS, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeFAS", p_TBLE_CodeFAS, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchSERV_Name", p_SERV_Name, SqlDbType.VarChar, 50, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_Services();
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
        private VENPY_Services SERVS_AService(Int32 p_BUSI_Code, Int32 p_SERV_Code)
        {
            try
            {
                VENPY_Services Item = new VENPY_Services();
                DataAccessPersonalSQL.DAP_StoredProcedure("SERVS_AService");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintSERV_Code", p_SERV_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Item = new VENPY_Services();
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

        private String SERVI_AService(ref VENPY_Services p_Item)
        {
            try
            {
                String l_Message = null;
                Int32 l_SERV_Code;
                DataAccessPersonalSQL.DAP_StoredProcedure("SERVI_AService");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintSERV_Code", p_Item.SERV_Code, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitSERV_Active", p_Item.SERV_Active, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchSERV_Name", p_Item.SERV_Name, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchSERV_Description", p_Item.SERV_Description, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableFAS", p_Item.TBLE_TableFAS, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeFAS", p_Item.TBLE_CodeFAS, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableUNM", p_Item.TBLE_TableUNM, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeUNM", p_Item.TBLE_CodeUNM, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableTAI", p_Item.TBLE_TableTAI, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeTAI", p_Item.TBLE_CodeTAI, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableMND", p_Item.TBLE_TableMND, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeMND", p_Item.TBLE_CodeMND, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecSERV_UnitValue", p_Item.SERV_UnitValue, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecSERV_IGV", p_Item.SERV_IGV, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecSERV_UnitPrice", p_Item.SERV_UnitPrice, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_CreationUser", p_Item.AUDI_CreationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() >= 0)
                {
                    l_Message = null;
                    if (Int32.TryParse(DataAccessPersonalSQL.Sql_Command.Parameters["@pintSERV_Code"].Value.ToString(), out l_SERV_Code))
                    { p_Item.SERV_Code = l_SERV_Code; }
                }
                else
                { l_Message = "No se realizó ningún cambio en la Base de Datos"; }
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String SERVU_AService(ref VENPY_Services p_Item)
        {
            try
            {
                String l_Message = null;
                Int32 l_SERV_Code;
                DataAccessPersonalSQL.DAP_StoredProcedure("SERVU_AService");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintSERV_Code", p_Item.SERV_Code, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitSERV_Active", p_Item.SERV_Active, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchSERV_Name", p_Item.SERV_Name, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchSERV_Description", p_Item.SERV_Description, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableFAS", p_Item.TBLE_TableFAS, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeFAS", p_Item.TBLE_CodeFAS, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableUNM", p_Item.TBLE_TableUNM, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeUNM", p_Item.TBLE_CodeUNM, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableTAI", p_Item.TBLE_TableTAI, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeTAI", p_Item.TBLE_CodeTAI, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableMND", p_Item.TBLE_TableMND, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeMND", p_Item.TBLE_CodeMND, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecSERV_UnitValue", p_Item.SERV_UnitValue, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecSERV_IGV", p_Item.SERV_IGV, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecSERV_UnitPrice", p_Item.SERV_UnitPrice, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_ModificationUser", p_Item.AUDI_ModificationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() >= 0)
                {
                    l_Message = null;
                    if (Int32.TryParse(DataAccessPersonalSQL.Sql_Command.Parameters["@pintSERV_Code"].Value.ToString(), out l_SERV_Code))
                    { p_Item.SERV_Code = l_SERV_Code; }
                }
                else
                { l_Message = "No se realizó ningún cambio en la Base de Datos"; }
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String SERVD_AService(ref VENPY_Services p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("SERVD_AService");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintSERV_Code", p_Item.SERV_Code, SqlDbType.Int, 4, ParameterDirection.Input);

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
