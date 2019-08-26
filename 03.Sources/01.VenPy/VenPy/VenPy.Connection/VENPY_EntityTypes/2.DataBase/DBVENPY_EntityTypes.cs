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
    public partial class BLVENPY_EntityTypes
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_EntityTypes> Loader { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_EntityTypes()
        {
            Loader = new EntityLoader<VENPY_EntityTypes>();
            VENPY_EntityTypes Item = new VENPY_EntityTypes();
            Loader.EntityType = Item.GetType();
        }

        #endregion

        #region [ QUERIES ]

        private ObservableCollection<VENPY_EntityTypes> ETYPS_ListEntityTypes(Int32 p_BUSI_Code, String p_ETYP_Name)
        {
            try
            {
                ObservableCollection<VENPY_EntityTypes> Items = new ObservableCollection<VENPY_EntityTypes>();
                VENPY_EntityTypes Item = new VENPY_EntityTypes();
                DataAccessPersonalSQL.DAP_StoredProcedure("ETYPS_ListEntityTypes");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchETYP_Name", p_ETYP_Name, SqlDbType.VarChar, 100, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_EntityTypes();
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
        private VENPY_EntityTypes ETYPS_AEntityType(Int32 p_BUSI_Code, Int32 p_ETYP_Code)
        {
            try
            {
                VENPY_EntityTypes Item = new VENPY_EntityTypes();
                DataAccessPersonalSQL.DAP_StoredProcedure("ETYPS_AEntityType");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintETYP_Code", p_ETYP_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Item = new VENPY_EntityTypes();
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

        private String ETYPI_AEntityType(ref VENPY_EntityTypes p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("ETYPI_AEntityType");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintETYP_Code", p_Item.ETYP_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchETYP_Name", p_Item.ETYP_Name, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchETYP_Description", p_Item.ETYP_Description, SqlDbType.VarChar, 150, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitETYP_Active", p_Item.ETYP_Active, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitETYP_Default", p_Item.ETYP_Default, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_CreationUser", p_Item.AUDI_CreationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchETYP_ErrorMessage", DBNull.Value, SqlDbType.VarChar, -1, ParameterDirection.InputOutput);

                DataAccessPersonalSQL.DAP_ExecuteNonQuery();
                l_Message = DataAccessPersonalSQL.Sql_Command.Parameters["@pvchETYP_ErrorMessage"].Value.ToString();
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String ETYPU_AEntityType(ref VENPY_EntityTypes p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("ETYPU_AEntityType");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintETYP_Code", p_Item.ETYP_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchETYP_Name", p_Item.ETYP_Name, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchETYP_Description", p_Item.ETYP_Description, SqlDbType.VarChar, 150, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitETYP_Active", p_Item.ETYP_Active, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitETYP_Default", p_Item.ETYP_Default, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_ModificationUser", p_Item.AUDI_ModificationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchETYP_ErrorMessage", DBNull.Value, SqlDbType.VarChar, -1, ParameterDirection.InputOutput);

                DataAccessPersonalSQL.DAP_ExecuteNonQuery();
                l_Message = DataAccessPersonalSQL.Sql_Command.Parameters["@pvchETYP_ErrorMessage"].Value.ToString();
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String ETYPD_AEntityType(ref VENPY_EntityTypes p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("ETYPD_AEntityType");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintETYP_Code", p_Item.ETYP_Code, SqlDbType.Int, 4, ParameterDirection.Input);

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
