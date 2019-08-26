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
    public partial class BLVENPY_WarehousesBranches
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_WarehousesBranches> Loader { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_WarehousesBranches()
        {
            Loader = new EntityLoader<VENPY_WarehousesBranches>();
            VENPY_WarehousesBranches Item = new VENPY_WarehousesBranches();
            Loader.EntityType = Item.GetType();
        }

        #endregion

        #region [ QUERIES ]

        private ObservableCollection<VENPY_WarehousesBranches> WABRS_ByBranch(Int32 p_BUSI_Code, Nullable<Int32> p_BOFF_Code)
        {
            try
            {
                ObservableCollection<VENPY_WarehousesBranches> Items = new ObservableCollection<VENPY_WarehousesBranches>();
                VENPY_WarehousesBranches Item = new VENPY_WarehousesBranches();
                DataAccessPersonalSQL.DAP_StoredProcedure("WABRS_ByBranch");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintBOFF_Code", p_BOFF_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_WarehousesBranches();
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

        private Boolean WABRI_ByBranch(Int32 p_BUSI_Code, Int32 p_BOFF_Code, DataTable p_UDTT_WarehousesBranches, String p_AUDI_CreationUser)
        {
            try
            {
                DataAccessPersonalSQL.DAP_StoredProcedure("WABRI_ByBranch");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintBOFF_Code", p_BOFF_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@ptabUDTT_WarehousesBranches", p_UDTT_WarehousesBranches, SqlDbType.Structured, 2, ParameterDirection.Input);
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
