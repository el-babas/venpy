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
    public partial class BLVENPY_ProformaDetails
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_ProformaDetails> Loader { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_ProformaDetails()
        {
            Loader = new EntityLoader<VENPY_ProformaDetails>();
            VENPY_ProformaDetails Item = new VENPY_ProformaDetails();
            Loader.EntityType = Item.GetType();
        }

        #endregion

        #region [ QUERIES ]

        private ObservableCollection<VENPY_ProformaDetails> PFDES_ByProforma(Int32 p_BUSI_Code, Nullable<Int32> p_PROF_Code)
        {
            try
            {
                ObservableCollection<VENPY_ProformaDetails> Items = new ObservableCollection<VENPY_ProformaDetails>();
                VENPY_ProformaDetails Item = new VENPY_ProformaDetails();
                DataAccessPersonalSQL.DAP_StoredProcedure("PFDES_ByProforma");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPROF_Code", p_PROF_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_ProformaDetails();
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

        private String PFDEI_AProformaDetail(ref VENPY_ProformaDetails p_Item)
        {
            try
            {
                String l_Message = null;

                DataAccessPersonalSQL.DAP_StoredProcedure("PFDEI_AProformaDetail");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPROF_Code", p_Item.PROF_Code, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPFDE_Item", p_Item.PFDE_Item, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pchrPFDE_Type", p_Item.PFDE_Type, SqlDbType.Char, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableFAP", p_Item.TBLE_TableFAP, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeFAP", p_Item.TBLE_CodeFAP, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableFAS", p_Item.TBLE_TableFAS, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeFAS", p_Item.TBLE_CodeFAS, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPROD_Code", p_Item.PROD_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintSERV_Code", p_Item.SERV_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableUNM", p_Item.TBLE_TableUNM, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeUNM", p_Item.TBLE_CodeUNM, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableTAI", p_Item.TBLE_TableTAI, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeTAI", p_Item.TBLE_CodeTAI, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPLDE_UnitValue", p_Item.PLDE_UnitValue, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPLDE_UnitPrice", p_Item.PLDE_UnitPrice, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPLDE_Quantity", p_Item.PLDE_Quantity, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPLDE_IGV", p_Item.PLDE_IGV, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPLDE_ISC", p_Item.PLDE_ISC, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPROF_Discount", p_Item.PROF_Discount, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_CreationUser", p_Item.AUDI_CreationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() >= 0)
                {
                    l_Message = null;
                    Int32 l_BUSI_Code;
                    if (Int32.TryParse(DataAccessPersonalSQL.Sql_Command.Parameters["@pintBUSI_Code"].Value.ToString(), out l_BUSI_Code))
                    { p_Item.BUSI_Code = l_BUSI_Code; }
                    Int32 l_PROF_Code;
                    if (Int32.TryParse(DataAccessPersonalSQL.Sql_Command.Parameters["@pintPROF_Code"].Value.ToString(), out l_PROF_Code))
                    { p_Item.PROF_Code = l_PROF_Code; }
                    Int32 l_PFDE_Item;
                    if (Int32.TryParse(DataAccessPersonalSQL.Sql_Command.Parameters["@pintPFDE_Item"].Value.ToString(), out l_PFDE_Item))
                    { p_Item.PFDE_Item = l_PFDE_Item; }
                }
                else
                { l_Message = "No se realizó ningún cambio en la Base de Datos"; }
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String PFDEU_AProformaDetail(ref VENPY_ProformaDetails p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("PFDEU_AProformaDetail");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPROF_Code", p_Item.PROF_Code, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPFDE_Item", p_Item.PFDE_Item, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pchrPFDE_Type", p_Item.PFDE_Type, SqlDbType.Char, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableFAP", p_Item.TBLE_TableFAP, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeFAP", p_Item.TBLE_CodeFAP, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableFAS", p_Item.TBLE_TableFAS, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeFAS", p_Item.TBLE_CodeFAS, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPROD_Code", p_Item.PROD_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintSERV_Code", p_Item.SERV_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableUNM", p_Item.TBLE_TableUNM, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeUNM", p_Item.TBLE_CodeUNM, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableTAI", p_Item.TBLE_TableTAI, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeTAI", p_Item.TBLE_CodeTAI, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPLDE_UnitValue", p_Item.PLDE_UnitValue, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPLDE_UnitPrice", p_Item.PLDE_UnitPrice, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPLDE_Quantity", p_Item.PLDE_Quantity, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPLDE_IGV", p_Item.PLDE_IGV, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPLDE_ISC", p_Item.PLDE_ISC, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPROF_Discount", p_Item.PROF_Discount, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_ModificationUser", p_Item.AUDI_ModificationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() >= 0)
                {
                    l_Message = null;
                    Int32 l_BUSI_Code;
                    if (Int32.TryParse(DataAccessPersonalSQL.Sql_Command.Parameters["@pintBUSI_Code"].Value.ToString(), out l_BUSI_Code))
                    { p_Item.BUSI_Code = l_BUSI_Code; }
                    Int32 l_PROF_Code;
                    if (Int32.TryParse(DataAccessPersonalSQL.Sql_Command.Parameters["@pintPROF_Code"].Value.ToString(), out l_PROF_Code))
                    { p_Item.PROF_Code = l_PROF_Code; }
                    Int32 l_PFDE_Item;
                    if (Int32.TryParse(DataAccessPersonalSQL.Sql_Command.Parameters["@pintPFDE_Item"].Value.ToString(), out l_PFDE_Item))
                    { p_Item.PFDE_Item = l_PFDE_Item; }
                }
                else
                { l_Message = "No se realizó ningún cambio en la Base de Datos"; }
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String PFDED_AProformaDetail(ref VENPY_ProformaDetails p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("PFDED_AProformaDetail");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPROD_Code", p_Item.PROD_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPFDE_Item", p_Item.PFDE_Item, SqlDbType.Int, 4, ParameterDirection.Input);

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
