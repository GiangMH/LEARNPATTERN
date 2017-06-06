using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace ManageStudent.Utils
{
    /// <summary>
    /// Author: Mocke
    /// Goal: Connect to Database and Read, Insert, Update, Delete Data
    /// Date: 02.06.2017
    /// </summary>
    public class DataAccessUltility
    {
        private DataTable m_ResultTable;
        private SqlConnection m_Connection;

        static private string GetConnectionString()
        {
            try
            {
                //string connectionName = "managementStudent";
                string connectionName = ConfigurationManager.AppSettings["connectionName"];
                return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
            }
            catch (ConfigurationErrorsException)
            {
                return null;
                MessageBox.Show("Error setting config file!", "Error", MessageBoxButton.OK);
            }                        
        }
        private void OpenSqlConnection()
        {
            string connectString = GetConnectionString();
            using (m_Connection = new SqlConnection(connectString))
            {
                m_Connection.Open();
            }
        }
        private void CloseSqlConnection()
        {
            if (m_Connection != null)
                m_Connection.Close();
        }
        /*************************************
         * Author: Mocke
         * Input: ProcName, ProcPrametter
         * Output: DataSet
         * CreateDate: 02.06.2017
         *************************************/
        public DataSet ExcuteQuery(string procName, Dictionary<string,SqlParameter> procParameters)
        {
            DataSet ds = new DataSet();
            OpenSqlConnection();
            using (SqlCommand command = m_Connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procName;
                foreach (var parameter in procParameters)
                {
                    command.Parameters.Add(parameter.Value);
                }
                SqlDataAdapter dataApdater = new SqlDataAdapter(command);
                dataApdater.Fill(ds);
            }
            return ds;            
        }
    }
}
