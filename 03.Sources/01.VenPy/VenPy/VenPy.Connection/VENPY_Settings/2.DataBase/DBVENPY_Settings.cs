using System;
using System.Collections.ObjectModel;
using VenPy.Entities;
using VenPy.Class;
using System.Data;

namespace VenPy.Connection
{
    public partial class BLVENPY_Settings
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_Settings> Loader { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_Settings()
        {
            Loader = new EntityLoader<VENPY_Settings>();
            VENPY_Settings Item = new VENPY_Settings();
            Loader.EntityType = Item.GetType();
        }

        #endregion

        #region [ QUERIES ]

        private ObservableCollection<VENPY_Settings> SETTS_ByBusiness(Int32 p_BUSI_Code)
        {
            try
            {
                ObservableCollection<VENPY_Settings> Items = new ObservableCollection<VENPY_Settings>();
                VENPY_Settings Item = new VENPY_Settings();
                DataAccessPersonalSQL.DAP_StoredProcedure("SETTS_ByBusiness");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 8, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_Settings();
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

        #region [ METHODS ]

        private String SETTI_ASetting(ref VENPY_Settings p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("SETTI_ASetting");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pchrSETT_Key", p_Item.SETT_Key, SqlDbType.Char, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchSETT_Value", p_Item.SETT_Value, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchSETT_Description", p_Item.SETT_Description, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_CreationUser", p_Item.AUDI_CreationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() >= 0)
                {
                    l_Message = null;
                }
                else
                { l_Message = "No se realizó ningún cambio en la Base de Datos"; }
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String SETTU_ASetting(ref VENPY_Settings p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("SETTU_ASetting");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pchrSETT_Key", p_Item.SETT_Key, SqlDbType.Char, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchSETT_Value", p_Item.SETT_Value, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_ModificationUser", p_Item.AUDI_ModificationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() >= 0)
                {
                    l_Message = null;
                }
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
