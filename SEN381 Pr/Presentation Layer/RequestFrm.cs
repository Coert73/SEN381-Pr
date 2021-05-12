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
    public partial class RequestFrm : Form
    {
        public RequestFrm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            (new MenuFrm()).Show();
            this.Hide();
        }

        ADOMethodController Con = new ADOMethodController();

        private void RequestFrm_Load(object sender, EventArgs e)
        {
            Con.LoadReqData(dgvRequests);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Con.SortData(dgvRequests, cbxRequestSort.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Con.LoadReqData(dgvRequests);
        }       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Please select an request!");
            }
            else
            {
                Con.UpdateRequest(dgvRequests, txtID.Text);
            }
        }

        private void dgvRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvRequests.CurrentRow;
            if (!row.IsNewRow)
            {
                txtID.Text = row.Cells["ReferenceNumber"].Value.ToString();
            }
        }
    }
}
