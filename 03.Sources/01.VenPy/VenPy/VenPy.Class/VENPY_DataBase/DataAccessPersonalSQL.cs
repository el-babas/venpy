using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Reflection;
using System.Collections.ObjectModel;

namespace VenPy.Class
{
    public class DataAccessPersonalSQL
    {
        #region [ PROPERTIES ]

        public static DataAccessPersonalSQL Instance { get; set; }
        public static SqlDatabase Sql_Database { get; set; }
        public static SqlCommand Sql_Command { get; set; }
        public static SqlParameter Sql_Parameter { get; set; }
        public static SqlConnection Sql_Connection { get; set; }
        public static SqlTransaction Sql_Transaction { get; set; }

        #endregion

        #region [ METHODS ]

        private DataAccessPersonalSQL(string p_connectionStrings)
        {
            try
            {
                Sql_Database = new SqlDatabase(p_connectionStrings);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public static DataAccessPersonalSQL StartConnection(string p_connectionStrings)
        {
            try
            {
                if (Instance == null)
                { Instance = new DataAccessPersonalSQL(p_connectionStrings); }
                Sql_Database = new SqlDatabase(p_connectionStrings);
                return Instance;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public static DataAccessPersonalSQL Reconnect(string p_connectionStrings)
        {
            try
            {
                Instance = new DataAccessPersonalSQL(p_connectionStrings);
                Sql_Database = new SqlDatabase(p_connectionStrings);
                return Instance;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public static Boolean ValidateConnection()
        {
            try
            {
                Sql_Connection = (SqlConnection)Sql_Database.CreateConnection();
                Sql_Connection.Open();
                Sql_Connection.Close();
                return true;
            }
            catch (Exception)
            { return false; }
            finally
            { Sql_Connection = null; }
        }

        #endregion

        #region [ PROCEDURE ]

        public static void DAP_StoredProcedure(String x_procedure)
        {
            try
            {
                Sql_Command = (SqlCommand)Sql_Database.GetStoredProcCommand(x_procedure);
                Sql_Connection = (SqlConnection)Sql_Database.CreateConnection();
                Sql_Command.CommandTimeout = Sql_Connection.ConnectionTimeout;
                Sql_Command.CommandType = CommandType.StoredProcedure;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ PARAMETER ]

        public static void DAP_AddParameter(String p_parameterName, Object p_value, SqlDbType p_sqlDbType, int x_size, ParameterDirection p_direction)
        {
            try
            {
                Sql_Parameter = Sql_Command.CreateParameter();
                Sql_Parameter.ParameterName = p_parameterName;
                Sql_Parameter.SqlDbType = p_sqlDbType;
                Sql_Parameter.Size = x_size;
                if (p_value == null) { Sql_Parameter.Value = DBNull.Value; } else { Sql_Parameter.Value = p_value; }
                Sql_Parameter.Direction = p_direction;
                Sql_Parameter.IsNullable = true;
                Sql_Command.Parameters.Add(Sql_Parameter);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public static void DAP_AddParameter(String p_parameterName, Object p_value, SqlDbType p_sqlDbType, byte p_precision, byte p_scale, ParameterDirection p_direction)
        {
            try
            {
                Sql_Parameter = Sql_Command.CreateParameter();
                Sql_Parameter.ParameterName = p_parameterName;
                Sql_Parameter.SqlDbType = p_sqlDbType;
                Sql_Parameter.Precision = p_precision;
                Sql_Parameter.Scale = p_scale;
                if (p_value == null) { Sql_Parameter.Value = DBNull.Value; } else { Sql_Parameter.Value = p_value; }
                Sql_Parameter.Direction = p_direction;
                Sql_Parameter.IsNullable = true;
                Sql_Command.Parameters.Add(Sql_Parameter);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ EXECUTE ]

        public static IDataReader DAP_ExecuteReader()
        {
            try
            {
                if (Sql_Transaction == null)
                { return Sql_Database.ExecuteReader(Sql_Command); }
                else
                { return Sql_Database.ExecuteReader(Sql_Command, Sql_Transaction); }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public static Int32 DAP_ExecuteNonQuery()
        {
            try
            {
                if (Sql_Transaction == null)
                { return Sql_Database.ExecuteNonQuery(Sql_Command); }
                else
                { return Sql_Database.ExecuteNonQuery(Sql_Command, Sql_Transaction); }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ TRANSACTION ]

        public static void DAP_BeginTransaction()
        {
            try
            {
                Sql_Connection = (SqlConnection)Sql_Database.CreateConnection();
                Sql_Connection.Open();
                Sql_Transaction = Sql_Connection.BeginTransaction();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public static void DAP_CommitTransaction()
        {
            try
            {
                if (Sql_Transaction != null)
                {
                    Sql_Transaction.Commit();
                    Sql_Connection.Close();
                    Sql_Transaction = null;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public static void DAP_RollbackTransaction()
        {
            try
            {
                if (Sql_Transaction != null)
                {
                    Sql_Transaction.Rollback();
                    Sql_Connection.Close();
                    Sql_Transaction = null;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
