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

        public ADOController()
        {
          
        }

        DataHandeler dataConnection = new DataHandeler();      

        public DataSet CarryCommand(string command)
        {          
            using (dataConnection.Connection)
            {                
                _dataAdapter.SelectCommand = new SqlCommand(command,dataConnection.Connection);
                _dataAdapter.Fill(_set);
            }

            _command.Dispose();
            return _set;
        }    
       
    }
}
