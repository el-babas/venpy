using System;
using System.Collections.ObjectModel;
using VenPy.Entities;
using VenPy.Class;
using System.Data;

namespace VenPy.Connection
{
    public partial class BLVENPY_PersonalConfiguration
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_PersonalConfiguration> Loader { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_PersonalConfiguration()
        {
            Loader = new EntityLoader<VENPY_PersonalConfiguration>();
            VENPY_PersonalConfiguration Item = new VENPY_PersonalConfiguration();
            Loader.EntityType = Item.GetType();
        }

        #endregion

        #region [ QUERIES ]

        private ObservableCollection<VENPY_PersonalConfiguration> PCONS_ByUser(Int32 p_BUSI_Code, Int32 p_USER_Code)
        {
            try
            {
                ObservableCollection<VENPY_PersonalConfiguration> Items = new ObservableCollection<VENPY_PersonalConfiguration>();
                VENPY_PersonalConfiguration Item = new VENPY_PersonalConfiguration();
                DataAccessPersonalSQL.DAP_StoredProcedure("PCONS_ByUser");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintUSER_Code", p_USER_Code, SqlDbType.Int, 8, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_PersonalConfiguration();
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
    }
}
