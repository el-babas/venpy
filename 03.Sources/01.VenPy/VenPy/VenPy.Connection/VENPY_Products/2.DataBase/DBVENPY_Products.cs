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
    public partial class BLVENPY_Products
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_Products> Loader { get; set; }
        [Dependency]
        private IBLVENPY_MeasurementUnitsProducts BL_VENPY_MeasurementUnitsProducts { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_Products()
        {
            Loader = new EntityLoader<VENPY_Products>();
            VENPY_Products Item = new VENPY_Products();
            Loader.EntityType = Item.GetType();
            BL_VENPY_MeasurementUnitsProducts = new BLVENPY_MeasurementUnitsProducts();
        }

        #endregion

        #region [ QUERIES ]

        private ObservableCollection<VENPY_Products> PRODS_ListProducts(Int32 p_BUSI_Code, String p_TBLE_TableFAP, String p_TBLE_CodeFAP, String p_TBLE_TableMAR, String p_TBLE_CodeMAR, String p_PROD_Name)
        {
            try
            {
                ObservableCollection<VENPY_Products> Items = new ObservableCollection<VENPY_Products>();
                VENPY_Products Item = new VENPY_Products();
                DataAccessPersonalSQL.DAP_StoredProcedure("PRODS_ListProducts");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableFAP", p_TBLE_TableFAP, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeFAP", p_TBLE_CodeFAP, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableMAR", p_TBLE_TableMAR, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeMAR", p_TBLE_CodeMAR, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPROD_Name", p_PROD_Name, SqlDbType.VarChar, 50, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_Products();
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
        private VENPY_Products PRODS_AProduct(Int32 p_BUSI_Code, Int32 p_PROD_Code)
        {
            try
            {
                VENPY_Products Item = new VENPY_Products();
                DataAccessPersonalSQL.DAP_StoredProcedure("PRODS_AProduct");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPROD_Code", p_PROD_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Item = new VENPY_Products();
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

        private String PRODI_AProduct(ref VENPY_Products p_Item)
        {
            try
            {
                String l_Message = null;
                Int32 l_PROD_Code;
                DataAccessPersonalSQL.DAP_StoredProcedure("PRODI_AProduct");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPROD_Code", p_Item.PROD_Code, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitPROD_Active", p_Item.PROD_Active, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableFAP", p_Item.TBLE_TableFAP, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeFAP", p_Item.TBLE_CodeFAP, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableUNM", p_Item.TBLE_TableUNM, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeUNM", p_Item.TBLE_CodeUNM, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPROD_Name", p_Item.PROD_Name, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPROD_Description", p_Item.PROD_Description, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitPROD_Original", p_Item.PROD_Original, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableMAR", p_Item.TBLE_TableMAR, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeMAR", p_Item.TBLE_CodeMAR, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPROD_Model", p_Item.PROD_Model, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPROD_Serie", p_Item.PROD_Serie, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_CreationUser", p_Item.AUDI_CreationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() >= 0)
                {
                    l_Message = null;
                    if (Int32.TryParse(DataAccessPersonalSQL.Sql_Command.Parameters["@pintPROD_Code"].Value.ToString(), out l_PROD_Code))
                    { p_Item.PROD_Code = l_PROD_Code; }
                }
                else
                { l_Message = "No se realizó ningún cambio en la Base de Datos"; }
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String PRODU_AProduct(ref VENPY_Products p_Item)
        {
            try
            {
                String l_Message = null;
                Int32 l_PROD_Code;
                DataAccessPersonalSQL.DAP_StoredProcedure("PRODU_AProduct");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPROD_Code", p_Item.PROD_Code, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitPROD_Active", p_Item.PROD_Active, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableFAP", p_Item.TBLE_TableFAP, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeFAP", p_Item.TBLE_CodeFAP, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableUNM", p_Item.TBLE_TableUNM, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeUNM", p_Item.TBLE_CodeUNM, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPROD_Name", p_Item.PROD_Name, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPROD_Description", p_Item.PROD_Description, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitPROD_Original", p_Item.PROD_Original, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableMAR", p_Item.TBLE_TableMAR, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeMAR", p_Item.TBLE_CodeMAR, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPROD_Model", p_Item.PROD_Model, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPROD_Serie", p_Item.PROD_Serie, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_ModificationUser", p_Item.AUDI_ModificationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() >= 0)
                {
                    l_Message = null;
                    if (Int32.TryParse(DataAccessPersonalSQL.Sql_Command.Parameters["@pintPROD_Code"].Value.ToString(), out l_PROD_Code))
                    { p_Item.PROD_Code = l_PROD_Code; }
                }
                else
                { l_Message = "No se realizó ningún cambio en la Base de Datos"; }
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String PRODD_AProduct(ref VENPY_Products p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("PRODD_AProduct");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPROD_Code", p_Item.PROD_Code, SqlDbType.Int, 4, ParameterDirection.Input);

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
