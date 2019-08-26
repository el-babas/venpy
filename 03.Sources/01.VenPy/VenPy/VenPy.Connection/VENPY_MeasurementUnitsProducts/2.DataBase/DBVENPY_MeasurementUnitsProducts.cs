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
    public partial class BLVENPY_MeasurementUnitsProducts
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_MeasurementUnitsProducts> Loader { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_MeasurementUnitsProducts()
        {
            Loader = new EntityLoader<VENPY_MeasurementUnitsProducts>();
            VENPY_MeasurementUnitsProducts Item = new VENPY_MeasurementUnitsProducts();
            Loader.EntityType = Item.GetType();
        }

        #endregion

        #region [ QUERIES ]

        private ObservableCollection<VENPY_MeasurementUnitsProducts> MUPRS_ByProduct(Int32 p_BUSI_Code, Int32 p_PROD_Code)
        {
            try
            {
                ObservableCollection<VENPY_MeasurementUnitsProducts> Items = new ObservableCollection<VENPY_MeasurementUnitsProducts>();
                VENPY_MeasurementUnitsProducts Item = new VENPY_MeasurementUnitsProducts();
                DataAccessPersonalSQL.DAP_StoredProcedure("MUPRS_ByProduct");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPROD_Code", p_PROD_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_MeasurementUnitsProducts();
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

        private Boolean MUPRI_ByProduct(Int32 p_BUSI_Code, Int32 p_PROD_Code, DataTable p_UDTT_MeasurementUnitsProducts, String p_AUDI_CreationUser)
        {
            try
            {
                DataAccessPersonalSQL.DAP_StoredProcedure("MUPRI_ByProduct");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPROD_Code", p_PROD_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@ptabUDTT_MeasurementUnitsProducts", p_UDTT_MeasurementUnitsProducts, SqlDbType.Structured, 2, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_CreationUser", p_AUDI_CreationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
