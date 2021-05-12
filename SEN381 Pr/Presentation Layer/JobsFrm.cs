using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN381_Pr
{
    public partial class JobsFrm : Form
    {
        ADOMethodController Con = new ADOMethodController();

        public JobsFrm()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == string.Empty || txtReference.Text == string.Empty || txtLevel.Text == string.Empty || txtTech.Text == string.Empty || txtContract.Text == string.Empty)
            {
                MessageBox.Show("Please enter all fields!");
            }
            else
            {
                Con.InsertJobData(dgvJobs, txtJobID.Text, txtAddress.Text, txtReference.Text, txtLevel.Text, txtTech.Text, txtContract.Text);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtJobID.Text == string.Empty)
            {
                MessageBox.Show("Please select an ID to update!");
            }
            else if(txtAddress.Text == string.Empty || txtReference.Text == string.Empty || txtLevel.Text == string.Empty || txtTech.Text == string.Empty || txtContract.Text == string.Empty)
            {
                MessageBox.Show("Please enter all fields!");
            }
            else
            {                

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtJobID.Text == string.Empty)
            {
                MessageBox.Show("Please select an ID to escelate!");
            }
            else
            {
                Con.DeleteJobData(dgvJobs, txtJobID.Text, txtAddress.Text, txtReference.Text, txtLevel.Text, txtTech.Text, txtContract.Text);
            }
        }
        private void JobsFrm_Load(object sender, EventArgs e)
        {
            dgvJobs.AutoGenerateColumns = true;
            dgvJobs.DataSource = Con.LoadJobData();
            dgvJobs.DataMember = "Table";
            Con.LoadReqData(dgvRequests);
            dgvTechnicians.DataSource = Con.LoadTechData();
            dgvTechnicians.DataMember = "Table";
            txtLevel.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            (new MenuFrm()).Show();
            this.Hide();
        }

        private void dgvTechnicians_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvRequests.CurrentRow;
            if (!row.IsNewRow)
            {
                txtReference.Text = row.Cells["ReferenceNumber"].Value.ToString();
                txtAddress.Text = Con.GetClientInfoForJobs(row.Cells["ClientId"].Value.ToString())[1];
                txtContract.Text = Con.GetClientInfoForJobs(row.Cells["ClientId"].Value.ToString())[0];               
            }
        }

        private void dgvTechnicians_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTechnicians.CurrentRow;
            if (!row.IsNewRow)
            {
                txtTech.Text = row.Cells["TechID"].Value.ToString();
            }

        }
        private void btnEscelate_Click(object sender, EventArgs e)
        {
            if (txtJobID.Text == string.Empty)
            {
                MessageBox.Show("Please select an ID to escelate!");
            }
            else
            {
                Con.EscelateJob(dgvJobs, txtJobID.Text, txtAddress.Text, txtReference.Text, txtLevel.Text, txtTech.Text, txtContract.Text);
            }            
        }

        private void dgvJobs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvJobs.CurrentRow;
            if (!row.IsNewRow)
            {
                txtJobID.Text = row.Cells["JobId"].Value.ToString(); 
                txtContract.Text = row.Cells["ContractId"].Value.ToString(); 
                txtLevel.Text = row.Cells["EscalationLevel"].Value.ToString();
                txtReference.Text = row.Cells["ReferenceNumber"].Value.ToString();
                txtAddress.Text = row.Cells["AdressId"].Value.ToString();
                txtTech.Text = row.Cells["AssignedTechnician"].Value.ToString();

            }
        }
    }
}
