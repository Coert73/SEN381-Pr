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
                txtContracId.Text = row.Cells["ContractId"].Value.ToString();
                txtContractName.Text = row.Cells["ContractName"].Value.ToString();
                txtContractType.Text = row.Cells["ContractType"].Value.ToString();
                txtPackageID.Text = row.Cells["PackageId"].Value.ToString();
                dtpEnd.Text = row.Cells["ContractLeaseEnd"].Value.ToString(); ;
                dtpStart.Text = row.Cells["ContractLeaseStart"].Value.ToString(); ;        
                chkbxStatus.Checked = Convert.ToBoolean(row.Cells["ContractStatus"].Value); 
                txtServiceLevel.Text =  row.Cells["ContractServiceLevel"].Value.ToString();
            }
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            if (txtPackageID.Text == string.Empty || txtContractName.Text == string.Empty  || txtContractType.Text == string.Empty  || dtpStart.Text == string.Empty  || dtpEnd.Text == string.Empty  || txtServiceLevel.Text == string.Empty )
            {
                MessageBox.Show("Please enter all fields!");
            }
            else
            {
                Con.InsertContracts(dgvContracts, txtContracId.Text, txtPackageID.Text, txtContractName.Text, txtContractType.Text, dtpStart.Text, dtpEnd.Text, chkbxStatus.Checked, txtServiceLevel.Text);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtContracId.Text == string.Empty)
            {
                MessageBox.Show("Please select an ID to update!");
            } 
            else if(txtPackageID.Text == string.Empty || txtContractName.Text == string.Empty || txtContractType.Text == string.Empty || dtpStart.Text == string.Empty || dtpEnd.Text == string.Empty || txtServiceLevel.Text == string.Empty)
            {
                MessageBox.Show("Please enter all fields!");
            }
            else
            {
                Con.UpdateContracts(dgvContracts, txtContracId.Text, txtPackageID.Text, txtContractName.Text, txtContractType.Text, dtpStart.Text, dtpEnd.Text, chkbxStatus.Checked, txtServiceLevel.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtContracId.Text == string.Empty)
            {
                MessageBox.Show("Please select an ID to delete!");
            }
            else
            {
                Con.DeleteContracts(dgvContracts, txtContracId.Text, txtPackageID.Text, txtContractName.Text, txtContractType.Text, dtpStart.Text, dtpEnd.Text, chkbxStatus.Checked, txtServiceLevel.Text);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
