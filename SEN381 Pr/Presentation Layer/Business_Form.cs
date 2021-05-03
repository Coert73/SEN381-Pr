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
            Con.InsertBusinessData(dgvBusiness,txtID.Text,txtName.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Con.UpdateBusinessData(dgvBusiness, txtID.Text, txtName.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Con.DeleteBusinessData(dgvBusiness, txtID.Text, txtName.Text);
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
