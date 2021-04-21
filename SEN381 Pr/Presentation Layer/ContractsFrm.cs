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
    public partial class ContractsFrm : Form
    {
        public ContractsFrm()
        {
            InitializeComponent();
        }

        ADOMethodController Con = new ADOMethodController();

        private void dgvTechnician_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            (new MenuFrm()).Show();
            this.Hide();
        }

        private void ContractsFrm_Load(object sender, EventArgs e)
        {
            Con.LoadContracts(dgvContracts);
            Con.LoadPackageData(dgvPackages);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dgvPackages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvPackages.CurrentRow;
            if (!row.IsNewRow)
            {
                txtPackageID.Text = row.Cells[0].Value.ToString();                        
            }
        }

        private void dgvContracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvContracts.CurrentRow;
            if (!row.IsNewRow)
            {                
                txtContracId.Text = row.Cells[""].Value.ToString();
                txtContractName.Text = row.Cells[""].Value.ToString();
                txtContractType.Text = row.Cells[""].Value.ToString();
            }
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            Con.InsertContracts(dgvContracts,txtContracId.Text,txtPackageID.Text, txtContractName.Text, txtContractType.Text, dtpStart.Text,dtpEnd.Text,chkbxStatus.Checked,char.Parse(txtServiceLevel.ToString()));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Con.UpdateContracts(dgvContracts, txtContracId.Text, txtPackageID.Text, txtContractName.Text, txtContractType.Text, dtpStart.Text, dtpEnd.Text, chkbxStatus.Checked, char.Parse(txtServiceLevel.ToString()));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Con.DeleteContracts(dgvContracts, txtContracId.Text, txtPackageID.Text, txtContractName.Text, txtContractType.Text, dtpStart.Text, dtpEnd.Text, chkbxStatus.Checked, char.Parse(txtServiceLevel.ToString()));
        }
    }
}
