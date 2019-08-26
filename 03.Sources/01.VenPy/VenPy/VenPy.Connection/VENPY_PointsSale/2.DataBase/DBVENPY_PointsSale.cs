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
    public partial class BLVENPY_PointsSale
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_PointsSale> Loader { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_PointsSale()
        {
            Loader = new EntityLoader<VENPY_PointsSale>();
            VENPY_PointsSale Item = new VENPY_PointsSale();
            Loader.EntityType = Item.GetType();
        }

        #endregion

        #region [ QUERIES ]

        private ObservableCollection<VENPY_PointsSale> PSALS_ByUser(Int32 p_USER_Code, Nullable<Int32> p_BUSI_Code)
        {
            try
            {
                ObservableCollection<VENPY_PointsSale> Items = new ObservableCollection<VENPY_PointsSale>();
                VENPY_PointsSale Item = new VENPY_PointsSale();
                DataAccessPersonalSQL.DAP_StoredProcedure("PSALS_ByUser");
                DataAccessPersonalSQL.DAP_AddParameter("@pintUSER_Code", p_USER_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_PointsSale();
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
        private ObservableCollection<VENPY_PointsSale> PSALS_ListPointsSale(Int32 p_BUSI_Code, Int32 p_USER_Code, String p_PSAL_Name)
        {
            try
            {
                ObservableCollection<VENPY_PointsSale> Items = new ObservableCollection<VENPY_PointsSale>();
                VENPY_PointsSale Item = new VENPY_PointsSale();
                DataAccessPersonalSQL.DAP_StoredProcedure("PSALS_ListPointsSale");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintUSER_Code", p_USER_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPSAL_Name", p_PSAL_Name, SqlDbType.VarChar, 100, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_PointsSale();
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
        private VENPY_PointsSale PSALS_APointSale(Int32 p_BUSI_Code, Int32 p_BOFF_Code,  Int32 p_PSAL_Code)
        {
            try
            {
                VENPY_PointsSale Item = new VENPY_PointsSale();
                DataAccessPersonalSQL.DAP_StoredProcedure("PSALS_APointSale");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintBOFF_Code", p_BOFF_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPSAL_Code", p_PSAL_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Item = new VENPY_PointsSale();
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

        private String PSALI_APointSale(ref VENPY_PointsSale p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("PSALI_APointSale");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintBOFF_Code", p_Item.BOFF_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPSAL_Code", p_Item.PSAL_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPSAL_Name", p_Item.PSAL_Name, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitPSAL_Main", p_Item.PSAL_Main, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pchrPSAL_Status", p_Item.PSAL_Status, SqlDbType.Char, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_CreationUser", p_Item.AUDI_CreationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPSAL_ErrorMessage", DBNull.Value, SqlDbType.VarChar, -1, ParameterDirection.InputOutput);

                DataAccessPersonalSQL.DAP_ExecuteNonQuery();
                l_Message = DataAccessPersonalSQL.Sql_Command.Parameters["@pvchPSAL_ErrorMessage"].Value.ToString();
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String PSALU_APointSale(ref VENPY_PointsSale p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("PSALU_APointSale");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintBOFF_Code", p_Item.BOFF_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPSAL_Code", p_Item.PSAL_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPSAL_Name", p_Item.PSAL_Name, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitPSAL_Main", p_Item.PSAL_Main, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pchrPSAL_Status", p_Item.PSAL_Status, SqlDbType.Char, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_ModificationUser", p_Item.AUDI_ModificationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPSAL_ErrorMessage", DBNull.Value, SqlDbType.VarChar, -1, ParameterDirection.InputOutput);

                DataAccessPersonalSQL.DAP_ExecuteNonQuery();
                l_Message = DataAccessPersonalSQL.Sql_Command.Parameters["@pvchPSAL_ErrorMessage"].Value.ToString();
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
