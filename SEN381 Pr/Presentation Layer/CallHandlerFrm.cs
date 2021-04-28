using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN381_Pr.Presentation_Layer
{
    public partial class CallHandlerFrm : Form
    {
        public static string FirstName ="";
        public static string SurName = "";
        public static string Number = "";
        public static string ID = "";
        public static string contractid = "";
        public static byte inout;

        public delegate void DelEventHandler();        

        public CallHandlerFrm()
        {
            InitializeComponent();
        }

        private void dgvJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            (new MenuFrm()).Show();
            this.Hide();
        }

        ADOMethodController Con = new ADOMethodController();

        private void CallHandlerFrm_Load(object sender, EventArgs e)
        {
            Con.LoadCallClients(dgvClientsContact);
            Con.LoadCalls(dgvDataCalls);        
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            (new Presentation_Layer.ReportFrm()).Show();
            this.Hide();
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            (new RequestFrm()).Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMakeCall_Click(object sender, EventArgs e)
        {
            if (dgvClientsContact.Rows[0].Cells[0].Selected)
            {
                MessageBox.Show("Please choose a contact to call");
            }
            else
            {
                inout = 0;
                (new Dialer()).Show();
            }            
        }      

        private void dgvClientsContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvClientsContact.CurrentRow;

            if (!row.IsNewRow)
            {
                ID = row.Cells["ClientId"].Value.ToString();
                contractid = row.Cells["ContractId"].Value.ToString();               
                FirstName = row.Cells["ClientName"].Value.ToString();
                SurName = row.Cells["Surname"].Value.ToString();
                Number = row.Cells["Number"].Value.ToString();
            }
        }        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCallHistory_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void dgvDataCalls_Enter(object sender, EventArgs e)
        {
            Con.LoadCalls(dgvDataCalls);
        }

        private void CallHandlerFrm_Enter(object sender, EventArgs e)
        {
            Con.LoadCalls(dgvDataCalls);
        }
    }
}
