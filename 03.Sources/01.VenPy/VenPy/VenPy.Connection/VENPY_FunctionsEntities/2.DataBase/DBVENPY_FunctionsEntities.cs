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
    public partial class BLVENPY_FunctionsEntities
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_FunctionsEntities> Loader { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_FunctionsEntities()
        {
            Loader = new EntityLoader<VENPY_FunctionsEntities>();
            VENPY_FunctionsEntities Item = new VENPY_FunctionsEntities();
            Loader.EntityType = Item.GetType();
        }

        #endregion

        #region [ QUERIES ]

        private ObservableCollection<VENPY_FunctionsEntities> FENTS_ByEntity(Int32 p_BUSI_Code, Nullable<Int32> p_ENTI_Code)
        {
            try
            {
                ObservableCollection<VENPY_FunctionsEntities> Items = new ObservableCollection<VENPY_FunctionsEntities>();
                VENPY_FunctionsEntities Item = new VENPY_FunctionsEntities();
                DataAccessPersonalSQL.DAP_StoredProcedure("FENTS_ByEntity");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintENTI_Code", p_ENTI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_FunctionsEntities();
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

        private Boolean FENTI_ByEntity(Int32 p_BUSI_Code, Int32 p_ENTI_Code, DataTable p_UDTT_FunctionsEntities, String p_AUDI_CreationUser)
        {
            try
            {
                DataAccessPersonalSQL.DAP_StoredProcedure("FENTI_ByEntity");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintENTI_Code", p_ENTI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@ptabUDTT_FunctionsEntities", p_UDTT_FunctionsEntities, SqlDbType.Structured, 2, ParameterDirection.Input);
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
