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
    class ADOMethodController
    {

        //Business Logic Layer part of the data passing thru...

        TechADOController TechCon = new TechADOController();
        JobsADOController JobCon = new JobsADOController();
        LoginADOController SecCon = new LoginADOController();
        RequestADOController ReqCon = new RequestADOController();

        //Methods For Technicians

        public DataSet LoadTechData()
        {
            return TechCon.LoadData();
        }

        public void InsertTechData(DataGridView tab, string name, string surname, string number)
        {
            tab.AutoGenerateColumns = true;
            tab.DataSource = TechCon.InsertTechnician(name, surname, number);
            tab.DataMember = "Table";            
        }

        public void UpdateTechData(DataGridView tab, string name, string surname, string number, string id)
        {
            tab.AutoGenerateColumns = true;
            tab.DataSource = TechCon.UpdateTechnician(name,surname,number,id);
            tab.DataMember = "Table";
        }

        public void DeleteTechData(DataGridView tab,string id)
        {
            tab.AutoGenerateColumns = true;
            tab.DataSource = TechCon.DeleteTechnician(id);
            tab.DataMember = "Table";
        }

        //Methods for Jobs
        public DataSet LoadJobData()
        {
            return JobCon.LoadData();
        }

        public void InsertJobData(DataGridView tab, string name, string surname, string number)
        {
            tab.AutoGenerateColumns = true;
            tab.DataSource = JobCon.InsertJob(name, surname, number);
            tab.DataMember = "Table";
        }

        public void UpdateJobData(DataGridView tab, string name, string surname, string number, string id)
        {
            tab.AutoGenerateColumns = true;
            tab.DataSource = JobCon.UpdateJob(name, surname, number, id);
            tab.DataMember = "Table";
        }

        public void DeleteJobData(DataGridView tab, string id)
        {
            tab.AutoGenerateColumns = true;
            tab.DataSource = JobCon.DeleteJob(id);
            tab.DataMember = "Table";
        }

        //Security Layer Controllers

        public List<string> ValidateCredentials(string username)
        {
            List<string> UserCredentials = new List<string>();
            int i = 0;

            foreach (DataRow row in SecCon.LoadData(username).Tables[i].Rows)
            {               
                if (username == row.ItemArray.GetValue(1).ToString())
                {
                    UserCredentials.Add(row.ItemArray.GetValue(1).ToString());
                    UserCredentials.Add(row.ItemArray.GetValue(3).ToString());
                    break;
                }
                else
                {
                    UserCredentials.Add(null);
                    UserCredentials.Add(null);
                }
                i++;
            }

            return UserCredentials;
        }

        //Request ADO Controllers/Methods

        public void LoadReqData(DataGridView tab)
        {
            tab.AutoGenerateColumns = true;
            tab.DataSource = ReqCon.LoadData();
            tab.DataMember = "Table";
        }

        public void SortData(DataGridView tab,string sort)
        {
            tab.AutoGenerateColumns = true;
            tab.DataSource = ReqCon.SortData(sort);
            tab.DataMember = "Table";
        }
    }
}
