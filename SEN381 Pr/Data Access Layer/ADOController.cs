using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN381_Pr
{
    class ADOController
    {
        //Runs the command/query the user selected to run...

        private SqlCommand _command = new SqlCommand();        
        private SqlDataAdapter _dataAdapter = new SqlDataAdapter();
        private DataTable _table = new DataTable();
        private DataSet _set = new DataSet();
        private SqlConnection _con = new SqlConnection();

        public ADOController()
        {
          
        }       

        public DataSet CarryCommand(string command)
        {
            _set = new DataSet();
            DataHandeler dataConnection = new DataHandeler();
            _dataAdapter = new SqlDataAdapter();

            using (var _con = new SqlConnection(dataConnection.ConnectionString))
            {
                using (var cmd = new SqlCommand(command, _con))
                {
                    _dataAdapter.SelectCommand = new SqlCommand(command,_con);
                    _dataAdapter.Fill(_set);
                }
            }

            _dataAdapter.Dispose();
            _command.Dispose();

            dataConnection.CloseConnection();

            return _set;
        }    
       
    }
}
