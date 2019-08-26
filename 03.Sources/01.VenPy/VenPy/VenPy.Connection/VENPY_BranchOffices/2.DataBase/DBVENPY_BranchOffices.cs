using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;
using System.Data;

namespace VenPy.Connection
{
    public partial class BLVENPY_BranchOffices
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_BranchOffices> Loader { get; set; }
        [Dependency]
        private IBLVENPY_WarehousesBranches BL_VENPY_WarehousesBranches { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_BranchOffices()
        {
            Loader = new EntityLoader<VENPY_BranchOffices>();
            VENPY_BranchOffices Item = new VENPY_BranchOffices();
            Loader.EntityType = Item.GetType();
            BL_VENPY_WarehousesBranches = new BLVENPY_WarehousesBranches();
        }

        #endregion

        #region [ QUERIES ]

        private ObservableCollection<VENPY_BranchOffices> BOFFS_ByUser(Int32 p_USER_Code, Nullable<Int32> p_BUSI_Code)
        {
            try
            {
                ObservableCollection<VENPY_BranchOffices> Items = new ObservableCollection<VENPY_BranchOffices>();
                VENPY_BranchOffices Item = new VENPY_BranchOffices();
                DataAccessPersonalSQL.DAP_StoredProcedure("BOFFS_ByUser");
                DataAccessPersonalSQL.DAP_AddParameter("@pintUSER_Code", p_USER_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_BranchOffices();
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
        private ObservableCollection<VENPY_BranchOffices> BOFFS_ListBranchOffices(Int32 p_BUSI_Code, Int32 p_USER_Code, String p_BOFF_Name)
        {
            try
            {
                ObservableCollection<VENPY_BranchOffices> Items = new ObservableCollection<VENPY_BranchOffices>();
                VENPY_BranchOffices Item = new VENPY_BranchOffices();
                DataAccessPersonalSQL.DAP_StoredProcedure("BOFFS_ListBranchOffices");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintUSER_Code", p_USER_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBOFF_Name", p_BOFF_Name, SqlDbType.VarChar, 100, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_BranchOffices();
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
        private VENPY_BranchOffices BOFFS_ABranchOffice(Int32 p_BUSI_Code, Int32 p_BOFF_Code)
        {
            try
            {
                VENPY_BranchOffices Item = new VENPY_BranchOffices();
                DataAccessPersonalSQL.DAP_StoredProcedure("BOFFS_ABranchOffice");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintBOFF_Code", p_BOFF_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Item = new VENPY_BranchOffices();
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

        private String BOFFI_ABranchOffice(ref VENPY_BranchOffices p_Item)
        {
            try
            {
                String l_Message = null;
                Int32 l_BOFF_Code;
                DataAccessPersonalSQL.DAP_StoredProcedure("BOFFI_ABranchOffice");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintBOFF_Code", p_Item.BOFF_Code, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBOFF_Name", p_Item.BOFF_Name, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBOFF_Address", p_Item.BOFF_Address, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBOFF_Description", p_Item.BOFF_Description, SqlDbType.VarChar, 250, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBOFF_Email", p_Item.BOFF_Email, SqlDbType.VarChar, 150, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBOFF_Web", p_Item.BOFF_Web, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBOFF_SocialNetworks", p_Item.BOFF_SocialNetworks, SqlDbType.VarChar, 250, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBOFF_PhoneNumber1", p_Item.BOFF_PhoneNumber1, SqlDbType.VarChar, 25, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBOFF_PhoneNumber2", p_Item.BOFF_PhoneNumber2, SqlDbType.VarChar, 25, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_Code", p_Item.UBIG_Code, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_CreationUser", p_Item.AUDI_CreationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBOFF_ErrorMessage", DBNull.Value, SqlDbType.VarChar, -1, ParameterDirection.InputOutput);
                
                DataAccessPersonalSQL.DAP_ExecuteNonQuery();
                l_Message = DataAccessPersonalSQL.Sql_Command.Parameters["@pvchBOFF_ErrorMessage"].Value.ToString();
                if (Int32.TryParse(DataAccessPersonalSQL.Sql_Command.Parameters["@pintBOFF_Code"].Value.ToString(), out l_BOFF_Code))
                { p_Item.BOFF_Code = l_BOFF_Code; }
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String BOFFU_ABranchOffice(ref VENPY_BranchOffices p_Item)
        {
            try
            {
                String l_Message = null;
                DataAccessPersonalSQL.DAP_StoredProcedure("BOFFU_ABranchOffice");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintBOFF_Code", p_Item.BOFF_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBOFF_Name", p_Item.BOFF_Name, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBOFF_Address", p_Item.BOFF_Address, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBOFF_Description", p_Item.BOFF_Description, SqlDbType.VarChar, 250, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBOFF_Email", p_Item.BOFF_Email, SqlDbType.VarChar, 150, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBOFF_Web", p_Item.BOFF_Web, SqlDbType.VarChar, 100, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBOFF_SocialNetworks", p_Item.BOFF_SocialNetworks, SqlDbType.VarChar, 250, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBOFF_PhoneNumber1", p_Item.BOFF_PhoneNumber1, SqlDbType.VarChar, 25, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBOFF_PhoneNumber2", p_Item.BOFF_PhoneNumber2, SqlDbType.VarChar, 25, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchUBIG_Code", p_Item.UBIG_Code, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_ModificationUser", p_Item.AUDI_ModificationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchBOFF_ErrorMessage", DBNull.Value, SqlDbType.VarChar, -1, ParameterDirection.InputOutput);

                DataAccessPersonalSQL.DAP_ExecuteNonQuery();
                l_Message = DataAccessPersonalSQL.Sql_Command.Parameters["@pvchBOFF_ErrorMessage"].Value.ToString();
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
