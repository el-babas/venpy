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
    public partial class BLVENPY_Proformas
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_Proformas> Loader { get; set; }
        [Dependency]
        private IBLVENPY_ProformaDetails BL_VENPY_ProformaDetails { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_Proformas()
        {
            Loader = new EntityLoader<VENPY_Proformas>();
            VENPY_Proformas Item = new VENPY_Proformas();
            Loader.EntityType = Item.GetType();
        }

        #endregion

        #region [ QUERIES ]

        private ObservableCollection<VENPY_Proformas> PROFS_ListProformas(Int32 p_BUSI_Code, String p_PROF_Number, DateTime p_PROF_DateBegin, DateTime p_PROF_DateEnd, Boolean p_PROF_OnlyActive)
        {
            try
            {
                ObservableCollection<VENPY_Proformas> Items = new ObservableCollection<VENPY_Proformas>();
                VENPY_Proformas Item = new VENPY_Proformas();
                DataAccessPersonalSQL.DAP_StoredProcedure("PROFS_ListProformas");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPROF_Number", p_PROF_Number, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdtePROF_DateBegin", p_PROF_DateBegin, SqlDbType.Date, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdtePROF_DateEnd", p_PROF_DateEnd, SqlDbType.Date, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitPROF_OnlyActive", p_PROF_OnlyActive, SqlDbType.Bit, 1, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_Proformas();
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
        private VENPY_Proformas PROFS_AProforma(Int32 p_BUSI_Code, Int32 p_PROF_Code)
        {
            try
            {
                VENPY_Proformas Item = new VENPY_Proformas();
                DataAccessPersonalSQL.DAP_StoredProcedure("PROFS_AProforma");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPROF_Code", p_PROF_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Item = new VENPY_Proformas();
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

        private String PROFI_AProforma(ref VENPY_Proformas p_Item)
        {
            try
            {
                String l_Message = null;
                Int32 l_PROF_Code;
                DataAccessPersonalSQL.DAP_StoredProcedure("PROFI_AProforma");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPROF_Code", p_Item.PROF_Code, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pintENTI_Code", p_Item.ENTI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPROF_Number", p_Item.PROF_Number, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdtePROF_Date", p_Item.PROF_Date, SqlDbType.Date, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdtePROF_DueDate", p_Item.PROF_DueDate, SqlDbType.Date, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableMND", p_Item.TBLE_TableMND, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeMND", p_Item.TBLE_CodeMND, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPRLI_Code", p_Item.PRLI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pchrPROF_Status", p_Item.PROF_Status, SqlDbType.Char, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitPROF_Export", p_Item.PROF_Export, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPROF_IGV", p_Item.PROF_IGV, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPROF_PercentageIGV", p_Item.PROF_PercentageIGV, SqlDbType.Decimal, 20, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPROF_ISC", p_Item.PROF_ISC, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPROF_Discount", p_Item.PROF_Discount, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPROF_TotalPrice", p_Item.PROF_TotalPrice, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitPROF_Generated", p_Item.PROF_Generated, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_CreationUser", p_Item.AUDI_CreationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() >= 0)
                {
                    l_Message = null;
                    if (Int32.TryParse(DataAccessPersonalSQL.Sql_Command.Parameters["@pintPROF_Code"].Value.ToString(), out l_PROF_Code))
                    { p_Item.PROF_Code = l_PROF_Code; }
                }
                else
                { l_Message = "No se realizó ningún cambio en la Base de Datos"; }
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String PROFU_AProforma(ref VENPY_Proformas p_Item)
        {
            try
            {
                String l_Message = null;
                Int32 l_PROF_Code;
                DataAccessPersonalSQL.DAP_StoredProcedure("PROFU_AProforma");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPROF_Code", p_Item.PROF_Code, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pintENTI_Code", p_Item.ENTI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchPROF_Number", p_Item.PROF_Number, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdtePROF_Date", p_Item.PROF_Date, SqlDbType.Date, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdtePROF_DueDate", p_Item.PROF_DueDate, SqlDbType.Date, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_TableMND", p_Item.TBLE_TableMND, SqlDbType.VarChar, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchTBLE_CodeMND", p_Item.TBLE_CodeMND, SqlDbType.VarChar, 6, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pintPRLI_Code", p_Item.PRLI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pchrPROF_Status", p_Item.PROF_Status, SqlDbType.Char, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitPROF_Export", p_Item.PROF_Export, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPROF_IGV", p_Item.PROF_IGV, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPROF_PercentageIGV", p_Item.PROF_PercentageIGV, SqlDbType.Decimal, 20, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPROF_ISC", p_Item.PROF_ISC, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPROF_Discount", p_Item.PROF_Discount, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecPROF_TotalPrice", p_Item.PROF_TotalPrice, SqlDbType.Decimal, 20, 8, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pbitPROF_Generated", p_Item.PROF_Generated, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_ModificationUser", p_Item.AUDI_ModificationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() >= 0)
                {
                    l_Message = null;
                    if (Int32.TryParse(DataAccessPersonalSQL.Sql_Command.Parameters["@pintPROF_Code"].Value.ToString(), out l_PROF_Code))
                    { p_Item.PROF_Code = l_PROF_Code; }
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
