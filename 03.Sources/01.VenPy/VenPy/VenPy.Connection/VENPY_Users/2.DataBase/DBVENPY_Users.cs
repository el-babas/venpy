using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;
using System.Data;

namespace VenPy.Connection
{
    public partial class BLVENPY_Users
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_Users> Loader { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_Users()
        {
            Loader = new EntityLoader<VENPY_Users>();
            VENPY_Users Item = new VENPY_Users();
            Loader.EntityType = Item.GetType();
        }

        #endregion

        #region [ QUERIES ]

        private VENPY_Users USERS_Authentication(String p_USER_UserId, String p_USER_Password)
        {
            try
            {
                VENPY_Users Item = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("USERS_Authentication");
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUSER_UserId", p_USER_UserId, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUSER_Password", p_USER_Password, SqlDbType.VarChar, 20, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Item = new VENPY_Users();
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
    }
}
