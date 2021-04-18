using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SEN381_Pr
{
    public class DataHandeler
    {
        //Sorts out the connection for the database

        private string _connectionString = "Server=LocalHost;Database=PremierServiceSolutionsDB;Trusted_Connection=True;";
        private SqlConnection _connection = new SqlConnection();    
        private SqlDataReader _reader;   

        public DataHandeler()
        {
            try
            {                
                _connection = new SqlConnection(ConnectionString);
                _connection.Open();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to Database - Error: " + ex);
                throw;
            }         
        }

        public SqlConnection Connection { get => _connection; set => _connection = value; }
        public string ConnectionString { get => _connectionString; set => _connectionString = value; }

        public void CloseConnection()
        {
            this.Connection.Close();
            MessageBox.Show("Connection Closed");
        }
    }
}