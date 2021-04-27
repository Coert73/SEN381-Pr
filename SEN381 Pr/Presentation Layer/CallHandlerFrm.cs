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
            timer1.Interval = 90000;
            timer1.Start();
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
                (new Dialer()).Show();
            }            
        }

        private void dgvClientsContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvClientsContact.CurrentRow;

            if (!row.IsNewRow)
            {
                FirstName = row.Cells["Name"].Value.ToString();
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
    }
}
