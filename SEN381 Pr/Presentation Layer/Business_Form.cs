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
    public partial class Business_Form : Form
    {
        ADOMethodController Con = new ADOMethodController();

        public Business_Form()
        {
            InitializeComponent();
        }

        private void Business_Form_Load(object sender, EventArgs e)
        {
            Con.LoadBusinessData(dgvBusiness);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            (new MenuFrm()).Show();
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Please enter the name of the business!");
            }
            else 
            {
                Con.InsertBusinessData(dgvBusiness, txtID.Text, txtName.Text); 
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Please select an ID!");
            }
            else
            {
                Con.UpdateBusinessData(dgvBusiness, txtID.Text, txtName.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Please select an ID!");
            }
            else
            {
                Con.DeleteBusinessData(dgvBusiness, txtID.Text, txtName.Text);
            }
        }

        private void dgvBusiness_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvBusiness.CurrentRow;
            if (!row.IsNewRow)
            {
                txtID.Text = row.Cells["BusinessId"].Value.ToString();
                txtName.Text = row.Cells["BusinessName"].Value.ToString();
            }
        }
    }
}
