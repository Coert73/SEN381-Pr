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
    }
}
