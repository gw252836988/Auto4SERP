using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace DBUtil
{
    public class DBHelper
    {
        private  static   string dbProviderName = WebConfigurationManager.AppSettings["DbHelperProvider"];
        // private static string dbConnectionString = ConfigurationManager.AppSettings["DbHelperConnectionString"];
       // private static string dbDefaultOrgan = WebConfigurationManager.AppSettings["DbDefalutOrgan"];
       // private static string dbConnectionString = "";
       // private static string dbReadConnString = WebConfigurationManager.AppSettings["DbReadConnString"];

        private DbConnection connection;
        private string m_currentOrgan;
        
        //public DBHelper()
        //{
            //this.connection = CreateConnection(ConnectionStringFactory.getInstance().ReturnConnString(dbDefaultOrgan));
            //m_currentOrgan = dbDefaultOrgan;

       // }



        //public DBHelper(string connectionString)
        //{
        //    this.connection = CreateConnection(connectionString);
        //}

        public DBHelper(string organID)
        {
            //if (string.IsNullOrEmpty(organID))
            //{
            //    dbProviderName = "MySQLProv";
            //}
            this.connection = CreateConnection(ConnectionStringFactory.getInstance().ReturnConnString(organID));
            m_currentOrgan = organID;
         
        }

        public string GetOrganName()
        {
            return m_currentOrgan;

        }

      
        public void ChangeConnection(String organName)
        {
            if (m_currentOrgan == organName)
            {
                return;
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.ConnectionString = ConnectionStringFactory.getInstance().ReturnConnString(organName);

        }

        //public static DbConnection CreateConnection()
        //{
        //    DbProviderFactory dbfactory = DbProviderFactories.GetFactory(DBHelper.dbProviderName);
        //    DbConnection dbconn = dbfactory.CreateConnection();
        //    dbconn.ConnectionString = DBHelper.dbConnectionString;
        //    return dbconn;
        //}

        public static DbConnection CreateConnection(string connectionString)
        {
            DbProviderFactory dbfactory = DbProviderFactories.GetFactory(DBHelper.dbProviderName);
            DbConnection dbconn = dbfactory.CreateConnection();
            dbconn.ConnectionString = connectionString;
         

            return dbconn;
        }

        public DbCommand GetStoredProcCommond(string storedProcedure, IDataParameter[] parameters)
        {
            DbCommand dbCommand = connection.CreateCommand();
            dbCommand.CommandText = storedProcedure;
            dbCommand.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter parameter in parameters)
            {
                if (parameter != null)
                {
                    // 检查未分配值的输出参数,将其分配以DBNull.Value.
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    dbCommand.Parameters.Add(parameter);
                }
            }
            return dbCommand;
        }

        //public DbCommand GetStoredProcCommondWithParameters(string storedProcedure, IDataParameter[] parameters)
        //{
        //    SqlCommand command = new SqlCommand(storedProcName, connection);
        //    command.CommandType = CommandType.StoredProcedure;
        //    foreach (SqlParameter parameter in parameters)
        //    {
        //        if (parameter != null)
        //        {
        //            // 检查未分配值的输出参数,将其分配以DBNull.Value.
        //            if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
        //                (parameter.Value == null))
        //            {
        //                parameter.Value = DBNull.Value;
        //            }
        //            command.Parameters.Add(parameter);
        //        }
        //    }

        //    return command;

        //}


        public DbCommand GetSqlStringCommond(string sqlQuery)
        {
            //if (this.connection.State != ConnectionState.Open)
            //    connection.Open();
            DbCommand dbCommand = connection.CreateCommand();
            dbCommand.CommandText = sqlQuery;
            dbCommand.CommandType = CommandType.Text;
       
            return dbCommand;
        }


        public bool IsConnectDb()
        {
            
            try
            {
                if (this.connection.State != ConnectionState.Open)
                    connection.Open();
              
                  return true;
              
            }
            catch (SqlException ex)
            {
               // throw ex;
                 Console.WriteLine(ex.Message);
                  return false;
            }
          
        }



        //增加参数#region 增加参数
        #region
        public void AddParameterCollection(DbCommand cmd, DbParameterCollection dbParameterCollection)
        {
            foreach (DbParameter dbParameter in dbParameterCollection)
            {
                cmd.Parameters.Add(dbParameter);
            }
        }

        public void AddOutParameter(DbCommand cmd, string parameterName, DbType dbType, int size)
        {
            DbParameter dbParameter = cmd.CreateParameter();
            dbParameter.DbType = dbType;
            dbParameter.ParameterName = parameterName;
            dbParameter.Size = size;
            dbParameter.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(dbParameter);
        }

        public void AddInParameter(DbCommand cmd, string parameterName, DbType dbType, object value)
        {
            DbParameter dbParameter = cmd.CreateParameter();
            dbParameter.DbType = dbType;
            dbParameter.ParameterName = parameterName;
            dbParameter.Value = value;
            dbParameter.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(dbParameter);
        }

        public void AddReturnParameter(DbCommand cmd, string parameterName, DbType dbType)
        {
            DbParameter dbParameter = cmd.CreateParameter();
            dbParameter.DbType = dbType;
            dbParameter.ParameterName = parameterName;
            dbParameter.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(dbParameter);
        }



        public DbParameter GetParameter(DbCommand cmd, string parameterName)
        {
            return cmd.Parameters[parameterName];
        }

        #endregion

        //执行#region 执行
        #region

        public DataSet ExecuteDataSet(DbCommand cmd)
        {
            DbProviderFactory dbfactory = DbProviderFactories.GetFactory(DBHelper.dbProviderName);
            DbDataAdapter dbDataAdapter = dbfactory.CreateDataAdapter();
            dbDataAdapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            dbDataAdapter.Fill(ds);
            return ds;
        }

        public DataTable ExecuteDataTable(string sql)
        {
            DbCommand cmd = GetSqlStringCommond(sql);
            DbProviderFactory dbfactory = DbProviderFactories.GetFactory(DBHelper.dbProviderName);
            DbDataAdapter dbDataAdapter = dbfactory.CreateDataAdapter();
            dbDataAdapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            dbDataAdapter.Fill(dataTable);
            return dataTable;

        }

        public void BatchInsert(string TableName, DataTable dt)
        {
           // if (this.connection.State != ConnectionState.Open)
            connection.Open();
            using (SqlBulkCopy sbc = new SqlBulkCopy((SqlConnection)connection))
            {

                sbc.DestinationTableName = TableName;
                sbc.BatchSize = 1000;
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    //列映射定义数据源中的列和目标表中的列之间的关系   
                    sbc.ColumnMappings.Add(i,i);
                }
                sbc.WriteToServer(dt);

                //scope.Complete();//有效的事务 

            }
            connection.Close();
        }


        public DataTable ExecuteDataTable(DbCommand cmd)
        {
            DbProviderFactory dbfactory = DbProviderFactories.GetFactory(DBHelper.dbProviderName);
            DbDataAdapter dbDataAdapter = dbfactory.CreateDataAdapter();
            dbDataAdapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            dbDataAdapter.Fill(dataTable);
            return dataTable;
        }


        public DataTable ExecuteDataTableByPage(string SqlAllFields, string SqlTablesAndWhere, string IndexField, string OrderFields, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {

           
            string sql = GetPageSql(SqlAllFields, SqlTablesAndWhere, IndexField, OrderFields, PageIndex, PageSize, out  RecordCount, out  PageCount);
            DbCommand cmd =GetSqlStringCommond(sql);
            DbProviderFactory dbfactory = DbProviderFactories.GetFactory(DBHelper.dbProviderName);
            DbDataAdapter dbDataAdapter = dbfactory.CreateDataAdapter();
            dbDataAdapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            dbDataAdapter.Fill(dataTable);
            return dataTable;

        }


        private  string GetPageSql( string SqlAllFields, string SqlTablesAndWhere, string IndexField, string OrderFields, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {


            RecordCount = 0;
            PageCount = 0;
            if (PageSize <= 0)
            {
                PageSize = 10;
            }
            string SqlCount = "select count(" + IndexField + ") from " + SqlTablesAndWhere;
            DbCommand cmd = GetSqlStringCommond(SqlCount);
            if (cmd.Connection.State != ConnectionState.Open)
            cmd.Connection.Open();
            cmd.CommandText = SqlCount;
            RecordCount = (int)cmd.ExecuteScalar();
            cmd.Connection.Close();
            if (RecordCount % PageSize == 0)
            {
                PageCount = RecordCount / PageSize;
            }
            else
            {
                PageCount = RecordCount / PageSize + 1;
            }
            if (PageIndex > PageCount)
                PageIndex = PageCount;
            if (PageIndex < 1)
                PageIndex = 1;
            string Sql = null;
            if (PageIndex == 1)
            {
                Sql = "select top " + PageSize + " " + SqlAllFields + " from " + SqlTablesAndWhere + " " + OrderFields;
            }
            else
            {
                Sql = "select top " + PageSize + " " + SqlAllFields + " from ";
                if (SqlTablesAndWhere.ToLower().IndexOf(" where ") > 0)
                {
                    string _where = Regex.Replace(SqlTablesAndWhere, @"\ where\ ", " where (", RegexOptions.IgnoreCase | RegexOptions.Compiled);
                    int i = Regex.Split(_where, @"\ where\ ", RegexOptions.IgnoreCase | RegexOptions.Compiled).Length - 1;
                    Sql += _where;
                    for (int j = 0; j < i; j++)
                    {
                        Sql += ")";
                    }
                    Sql += " and (";
                }
                else
                {
                    Sql += SqlTablesAndWhere + " where (";
                }
                Sql += IndexField + " not in (select top " + (PageIndex - 1) * PageSize + " " + IndexField + " from " + SqlTablesAndWhere + " " + OrderFields;
                Sql += ")) " + OrderFields;
            }
            return Sql;
        }


        public DbDataReader ExecuteReader(DbCommand cmd)
        {
           if (cmd.Connection.State != ConnectionState.Open)
            cmd.Connection.Open();
            DbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            cmd.Connection.Close();
            return reader;
        }

        public int ExecuteNonQuery(String sql)
        {
            return ExecuteNonQuery(GetSqlStringCommond(sql));
        }


        public int ExecuteNonQueryByPro(string procedure, IDataParameter[] parameters)
        {
            return ExecuteNonQuery(GetStoredProcCommond(procedure, parameters));

        }

        public int ExecuteNonQuery(DbCommand cmd)
        {

            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            int ret = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return ret;
        }

        //public int ExecuteNonQuery(DbCommand cmd)
        //{

        //    if (cmd.Connection.State != ConnectionState.Open)
        //        cmd.Connection.Open();
        //    int ret = cmd.ExecuteNonQuery();
        //    return ret;
        //}


        public int ExecuteSqlTran(List<String> SQLStringList)
        {
            SqlConnection conn = (SqlConnection)connection;
           // if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection =conn;
            SqlTransaction tx = conn.BeginTransaction();
            cmd.Transaction = tx;
            try
            {
                int count = 0;
                for (int n = 0; n < SQLStringList.Count; n++)
                {
                    string strsql = SQLStringList[n];
                    if (strsql.Trim().Length > 1)
                    {
                        cmd.CommandText = strsql;
                        count += cmd.ExecuteNonQuery();
                    }
                }
                tx.Commit();
                conn.Close();
                return count;
            }
            catch
            {
                tx.Rollback();
                conn.Close();
                return 0;
            }
           
        }


        public  int ExecuteSqlTran(Hashtable SQLStringList)
        {

            SqlConnection conn = (SqlConnection)connection;
            //if (conn.State != ConnectionState.Open)
                conn.Open();


            using (SqlTransaction trans = conn.BeginTransaction())
            {
                SqlCommand cmd = new SqlCommand();
                 try
                    {
                        //循环
                        foreach (DictionaryEntry myDE in SQLStringList)
                        {
                            string cmdText = myDE.Key.ToString();
                            SqlParameter[] cmdParms = (SqlParameter[])myDE.Value;
                            PrepareCommand(cmd, conn, trans, cmdText, cmdParms);
                            int val = cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();

                        }
                        trans.Commit();
                        conn.Close();
                        return 1;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());
                        trans.Rollback();
                        conn.Close();
                        return 0;
                        throw;
                    }

            }   
                     
        }

        private void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, string cmdText, SqlParameter[] cmdParms)
        {
            //if (conn.State != ConnectionState.Open)
            //    conn.Open();
            cmd.Connection = conn;
            cmd.CommandTimeout = 10;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;//cmdType;
            if (cmdParms != null)
            {


                foreach (SqlParameter parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
        }


        public object ExecuteScalar(DbCommand cmd)
        {
           if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            object ret = cmd.ExecuteScalar();
            cmd.Connection.Close();
            return ret;
        }

        public object ExecuteScalar(string sql)
        {
            return ExecuteScalar(GetSqlStringCommond(sql));
        }


        public bool IsExists(string sql)
        {
            object obj = ExecuteScalar(sql);
            int cmdresult;
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = 1;
            }
            if (cmdresult == 0 )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        #endregion

        //执行事务#region 执行事务
        #region
        public DataSet ExecuteDataSet(DbCommand cmd, Trans t)
        {
            cmd.Connection = t.DbConnection;
            cmd.Transaction = t.DbTrans;
            DbProviderFactory dbfactory = DbProviderFactories.GetFactory(DBHelper.dbProviderName);
            DbDataAdapter dbDataAdapter = dbfactory.CreateDataAdapter();
            dbDataAdapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            dbDataAdapter.Fill(ds);
            return ds;
        }

        public DataTable ExecuteDataTable(DbCommand cmd, Trans t)
        {
            cmd.Connection = t.DbConnection;
            cmd.Transaction = t.DbTrans;
            DbProviderFactory dbfactory = DbProviderFactories.GetFactory(DBHelper.dbProviderName);
            DbDataAdapter dbDataAdapter = dbfactory.CreateDataAdapter();
            dbDataAdapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            dbDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DbDataReader ExecuteReader(DbCommand cmd, Trans t)
        {
            cmd.Connection.Close();
            cmd.Connection = t.DbConnection;
            cmd.Transaction = t.DbTrans;
            DbDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            return reader;
        }

        public int ExecuteNonQuery(DbCommand cmd, Trans t)
        {
            cmd.Connection.Close();
            cmd.Connection = t.DbConnection;
            cmd.Transaction = t.DbTrans;
            int ret = cmd.ExecuteNonQuery();
            return ret;
        }

        public object ExecuteScalar(DbCommand cmd, Trans t)
        {
            cmd.Connection.Close();
            cmd.Connection = t.DbConnection;
            cmd.Transaction = t.DbTrans;
            object ret = cmd.ExecuteScalar();
            return ret;
        }

        #endregion
    }

    public class Trans : IDisposable
    {
        private DbConnection conn;
        private DbTransaction dbTrans;
        public DbConnection DbConnection
        {
            get { return this.conn; }
        }
        public DbTransaction DbTrans
        {
            get { return this.dbTrans; }
        }

        //public Trans()
        //{
        //    conn = DBHelper.CreateConnection();
        //    conn.Open();
        //    dbTrans = conn.BeginTransaction();
        //}
        public Trans(string connectionString)
        {
            conn = DBHelper.CreateConnection(connectionString);
            conn.Open();
            dbTrans = conn.BeginTransaction();
        }
        public void Commit()
        {
            dbTrans.Commit();
            this.Colse();
        }

        public void RollBack()
        {
            dbTrans.Rollback();
            this.Colse();
        }

        public void Dispose()
        {
            this.Colse();
        }

        public void Colse()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }

}
