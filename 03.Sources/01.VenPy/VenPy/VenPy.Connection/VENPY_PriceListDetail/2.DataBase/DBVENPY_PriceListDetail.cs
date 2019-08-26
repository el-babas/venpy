using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;
using System.Data;

namespace VenPy.Connection
{
    public partial class BLVENPY_PriceListDetail
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_PriceListDetail> Loader { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_PriceListDetail()
        {
            Loader = new EntityLoader<VENPY_PriceListDetail>();
            VENPY_PriceListDetail Item = new VENPY_PriceListDetail();
            Loader.EntityType = Item.GetType();
        }

        #endregion

        #region [ QUERIES ]

        private ObservableCollection<VENPY_PriceListDetail> PLDES_ByPriceList(Int32 p_BUSI_Code, Nullable<Int32> p_PRLI_Code)
        {
            try
            {
                ObservableCollection<VENPY_PriceListDetail> Items = new ObservableCollection<VENPY_PriceListDetail>();
                VENPY_PriceListDetail Item = new VENPY_PriceListDetail();
                DataAccessPersonalSQL.DAP_StoredProcedure("PLDES_ByPriceList");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPRLI_Code", p_PRLI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_PriceListDetail();
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

        private String PLDEI_APriceListDetail(ref VENPY_PriceListDetail p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("PLDEI_APriceListDetail");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPRLI_Code", p_Item.PRLI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPLDE_Item", p_Item.PLDE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPROD_Code", p_Item.PROD_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableUNM", p_Item.TBLE_TableUNM, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeUNM", p_Item.TBLE_CodeUNM, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableTAI", p_Item.TBLE_TableTAI, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeTAI", p_Item.TBLE_CodeTAI, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPLDE_UnitValue", p_Item.PLDE_UnitValue, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPLDE_IGV", p_Item.PLDE_IGV, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPLDE_UnitPrice", p_Item.PLDE_UnitPrice, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_CreationUser", p_Item.AUDI_CreationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() >= 0)
                { l_Message = null; }
                else
                { l_Message = "No se realizó ningún cambio en la Base de Datos"; }
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String PLDEU_APriceListDetail(ref VENPY_PriceListDetail p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("PLDEU_APriceListDetail");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPRLI_Code", p_Item.PRLI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPLDE_Item", p_Item.PLDE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPROD_Code", p_Item.PROD_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableUNM", p_Item.TBLE_TableUNM, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeUNM", p_Item.TBLE_CodeUNM, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableTAI", p_Item.TBLE_TableTAI, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeTAI", p_Item.TBLE_CodeTAI, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPLDE_UnitValue", p_Item.PLDE_UnitValue, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPLDE_IGV", p_Item.PLDE_IGV, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPLDE_UnitPrice", p_Item.PLDE_UnitPrice, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_ModificationUser", p_Item.AUDI_ModificationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);

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
