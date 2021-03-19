using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class DataHandeler
    {
        private string _connectionString;
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataReader _reader;   

        public DataHandeler(string ConnectionString)
        {
            _connectionString = ConnectionString;
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        public void ReadFromDatabase()
        {

        }

        public void DeleteFromDatabase(string TextLine)
        {

        }

        public void SearchDatabase(string TextLine)
        {

        }

        public void UpdateDatabase(string TextLine)
        {

        }

        public void InsertDatabase(string TextLine)
        {

        }

        public void SortDatabase(string TextLine)
        {

        }
    }
}