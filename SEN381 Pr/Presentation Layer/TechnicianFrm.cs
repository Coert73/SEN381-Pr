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
    public partial class TechnicianFrm : Form
    {
        ADOMethodController Con = new ADOMethodController();
        private string _id;

        public TechnicianFrm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void TechnicianFrm_Load(object sender, EventArgs e)
        {            
            dgvTechnician.DataSource = Con.LoadTechData();
            dgvTechnician.DataMember = "Table";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtSurname.Text == string.Empty || txtNumber.Text == string.Empty)
            {
                MessageBox.Show("Please enter all fields!");
            }
            else 
            {
                Con.InsertTechData(dgvTechnician, txtTechID.Text, txtName.Text, txtSurname.Text, txtNumber.Text); 
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTechID.Text == string.Empty)
            {
                MessageBox.Show("Please select and ID!");
            } 
            else if (txtName.Text == string.Empty || txtSurname.Text == string.Empty || txtNumber.Text == string.Empty)
            {
                MessageBox.Show("Please enter all fields!");
            }
            else
            {
                Con.UpdateTechData(dgvTechnician, txtTechID.Text, txtName.Text, txtSurname.Text, txtNumber.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtTechID.Text == string.Empty)
            {
                MessageBox.Show("Please select and ID!");
            }
            else
            {
                Con.DeleteTechData(dgvTechnician, txtTechID.Text, txtName.Text, txtSurname.Text, txtNumber.Text);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            (new MenuFrm()).Show();
            this.Hide();
        }

        private void dgvTechnician_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTechnician.CurrentRow;
            if (!row.IsNewRow)
            {
                txtTechID.Text = row.Cells["TechID"].Value.ToString();
                txtName.Text = row.Cells["TechName"].Value.ToString();
                txtNumber.Text = row.Cells["Number"].Value.ToString();
                txtSurname.Text = row.Cells["Surname"].Value.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
