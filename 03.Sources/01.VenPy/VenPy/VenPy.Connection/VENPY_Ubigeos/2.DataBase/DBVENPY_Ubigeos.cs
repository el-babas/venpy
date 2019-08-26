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
    public partial class BLVENPY_Ubigeos
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_Ubigeos> Loader { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_Ubigeos()
        {
            Loader = new EntityLoader<VENPY_Ubigeos>();
            VENPY_Ubigeos Item = new VENPY_Ubigeos();
            Loader.EntityType = Item.GetType();
        }

        #endregion

        #region [ QUERIES ]

        private ObservableCollection<VENPY_Ubigeos> UBIGS_All()
        {
            try
            {
                ObservableCollection<VENPY_Ubigeos> Items = new ObservableCollection<VENPY_Ubigeos>();
                VENPY_Ubigeos Item = new VENPY_Ubigeos();
                DataAccessPersonalSQL.DAP_StoredProcedure("UBIGS_All");
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_Ubigeos();
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
        private VENPY_Ubigeos UBIGS_AUbigeo(String p_UBIG_Code)
        {
            try
            {
                VENPY_Ubigeos Item = new VENPY_Ubigeos();
                DataAccessPersonalSQL.DAP_StoredProcedure("UBIGS_AUbigeo");
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_Code", p_UBIG_Code, SqlDbType.VarChar, 20, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Item = new VENPY_Ubigeos();
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

        private String UBIGI_AUbigeo(ref VENPY_Ubigeos p_Item)
        {
            try
            {
                String l_Mensaje = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("UBIGI_AUbigeo");
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_Code", p_Item.UBIG_Code, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_ParentCode", p_Item.UBIG_ParentCode, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_SunatCode", p_Item.UBIG_SunatCode, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_InternationalCode", p_Item.UBIG_InternationalCode, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_Description", p_Item.UBIG_Description, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_Observations", p_Item.UBIG_Observations, SqlDbType.VarChar, 250, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_CreationUser", p_Item.AUDI_CreationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdtmAUDI_CreationDate", p_Item.AUDI_CreationDate, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_ErrorMessage", DBNull.Value, SqlDbType.VarChar, -1, ParameterDirection.InputOutput);

                DataAccessPersonalSQL.DAP_ExecuteNonQuery();
                l_Mensaje = DataAccessPersonalSQL.Sql_Command.Parameters["@pvchUBIG_ErrorMessage"].Value.ToString();
                return l_Mensaje;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String UBIGU_AUbigeo(ref VENPY_Ubigeos p_Item)
        {
            try
            {
                String l_Mensaje = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("UBIGU_AUbigeo");
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_Code", p_Item.UBIG_Code, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_ParentCode", p_Item.UBIG_ParentCode, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_SunatCode", p_Item.UBIG_SunatCode, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_InternationalCode", p_Item.UBIG_InternationalCode, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_Description", p_Item.UBIG_Description, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_Observations", p_Item.UBIG_Observations, SqlDbType.VarChar, 250, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_ModificationUser", p_Item.AUDI_ModificationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdtmAUDI_ModificationDate", p_Item.AUDI_ModificationDate, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_ErrorMessage", DBNull.Value, SqlDbType.VarChar, -1, ParameterDirection.InputOutput);

                DataAccessPersonalSQL.DAP_ExecuteNonQuery();
                l_Mensaje = DataAccessPersonalSQL.Sql_Command.Parameters["@pvchUBIG_ErrorMessage"].Value.ToString();
                return l_Mensaje;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String UBIGD_AUbigeo(ref VENPY_Ubigeos p_Item)
        {
            try
            {
                String l_Mensaje = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("UBIGD_AUbigeo");
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_Code", p_Item.UBIG_Code, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() >= 0)
                { l_Mensaje = null; }
                else
                { l_Mensaje = "No se realizó ningún cambio en la Base de Datos"; }

                return l_Mensaje;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
