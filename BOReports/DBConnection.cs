using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
//using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Configuration.Assemblies;

namespace BOReports
{
    public class DBConnection
    {

        public SqlConnection con;

        public SqlTransaction trans;

        public SqlConnection CreateConnection()
        {
            string strCon = "";
            strCon = System.Configuration.ConfigurationManager.AppSettings.Get("ConnectionString");
            con = new SqlConnection(strCon);
            return con;
        }

        private void OpenConnection()
        {
            CreateConnection();
            con.Open();
        }

        private void CloseConnection()
        {
            if (con.State.Equals(ConnectionState.Open))
            {
                con.Close();
                con.Dispose();
            }
        }

        public void BeginTransaction()
        {
            OpenConnection();
            trans = con.BeginTransaction(IsolationLevel.ReadUncommitted);
        }

        public void CommitTransaction()
        {
            trans.Commit();
            trans.Dispose();
            CloseConnection();
        }

        public void RollbackTransaction()
        {
           
            try
            {
                trans.Rollback();
            }
            catch (SqlException)
            {

            }
            trans.Dispose();

            CloseConnection();
        }
    }
}