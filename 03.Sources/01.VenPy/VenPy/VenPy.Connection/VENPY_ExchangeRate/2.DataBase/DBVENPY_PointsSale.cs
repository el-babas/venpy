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
    public partial class BLVENPY_ExchangeRate
    {
        #region [ PROPERTIES ]

        public EntityLoader<VENPY_ExchangeRate> Loader { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public BLVENPY_ExchangeRate()
        {
            Loader = new EntityLoader<VENPY_ExchangeRate>();
            VENPY_ExchangeRate Item = new VENPY_ExchangeRate();
            Loader.EntityType = Item.GetType();
        }

        #endregion

        #region [ QUERIES ]

        private ObservableCollection<VENPY_ExchangeRate> EXRAS_ListExchangeRate(Int32 p_BUSI_Code, String p_EXRA_Year, String p_EXRA_Month)
        {
            try
            {
                ObservableCollection<VENPY_ExchangeRate> Items = new ObservableCollection<VENPY_ExchangeRate>();
                VENPY_ExchangeRate Item = new VENPY_ExchangeRate();
                DataAccessPersonalSQL.DAP_StoredProcedure("EXRAS_ListExchangeRate");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pchrEXRA_Year", p_EXRA_Year, SqlDbType.Char, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pchrEXRA_Month", p_EXRA_Month, SqlDbType.Char, 2, ParameterDirection.Input);
                using (IDataReader reader = DataAccessPersonalSQL.DAP_ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new VENPY_ExchangeRate();
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

        private String EXRAI_AExchangeRate(ref VENPY_ExchangeRate p_Item)
        {
            try
            {
                String l_Message = null;
                DateTime l_EXRA_Date;
                DataAccessPersonalSQL.DAP_StoredProcedure("EXRAI_AExchangeRate");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdteEXRA_Date", p_Item.EXRA_Date, SqlDbType.Date, 3, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecEXRA_OfficialPurchase", p_Item.EXRA_OfficialPurchase, SqlDbType.Decimal, 10, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecEXRA_OfficialSale", p_Item.EXRA_OfficialSale, SqlDbType.Decimal, 10, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecEXRA_InternalPurchase", p_Item.EXRA_InternalPurchase, SqlDbType.Decimal, 10, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecEXRA_InternalSale", p_Item.EXRA_InternalSale, SqlDbType.Decimal, 10, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_CreationUser", p_Item.AUDI_CreationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() >= 0)
                {
                    l_Message = null;
                    if (DateTime.TryParse(DataAccessPersonalSQL.Sql_Command.Parameters["@pdteEXRA_Date"].Value.ToString(), out l_EXRA_Date))
                    { p_Item.EXRA_Date = l_EXRA_Date; }
                }
                else
                { l_Message = "No se realizó ningún cambio en la Base de Datos"; }
                return l_Message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private String EXRAU_AExchangeRate(ref VENPY_ExchangeRate p_Item)
        {
            try
            {
                String l_Message = null;
                DateTime l_EXRA_Date;
                DataAccessPersonalSQL.DAP_StoredProcedure("EXRAU_AExchangeRate");
                DataAccessPersonalSQL.DAP_AddParameter("@pintBUSI_Code", p_Item.BUSI_Code, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdteEXRA_Date", p_Item.EXRA_Date, SqlDbType.Date, 3, ParameterDirection.InputOutput);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecEXRA_OfficialPurchase", p_Item.EXRA_OfficialPurchase, SqlDbType.Decimal, 10, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecEXRA_OfficialSale", p_Item.EXRA_OfficialSale, SqlDbType.Decimal, 10, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecEXRA_InternalPurchase", p_Item.EXRA_InternalPurchase, SqlDbType.Decimal, 10, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pdecEXRA_InternalSale", p_Item.EXRA_InternalSale, SqlDbType.Decimal, 10, 3, ParameterDirection.Input);
                DataAccessPersonalSQL.DAP_AddParameter("@pvchAUDI_ModificationUser", p_Item.AUDI_ModificationUser, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessPersonalSQL.DAP_ExecuteNonQuery() >= 0)
                {
                    l_Message = null;
                    if (DateTime.TryParse(DataAccessPersonalSQL.Sql_Command.Parameters["@pdteEXRA_Date"].Value.ToString(), out l_EXRA_Date))
                    { p_Item.EXRA_Date = l_EXRA_Date; }
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
