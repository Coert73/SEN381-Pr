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
    public partial class ClientFrm : Form
    {
        public ClientFrm()
        {
            InitializeComponent();
        }

        private void btnClientAdd_MouseEnter(object sender, EventArgs e)
        {
            btnClientAdd.BackColor = Color.MediumSpringGreen;
            btnClientAdd.ForeColor = Color.White;
        }

        private void btnClientAdd_MouseLeave(object sender, EventArgs e)
        {
            btnClientAdd.BackColor = SystemColors.ButtonFace;
            btnClientAdd.ForeColor = SystemColors.ControlText;

        }
        private void btnClientEdit_MouseEnter(object sender, EventArgs e)
        {
            btnClientEdit.BackColor = Color.MediumSpringGreen;
            btnClientEdit.ForeColor = Color.White;
        }

        private void btnClientEdit_MouseLeave(object sender, EventArgs e)
        {
            btnClientEdit.BackColor = SystemColors.ButtonFace;
            btnClientEdit.ForeColor = SystemColors.ControlText;
        }

        private void btnClientDel_MouseEnter(object sender, EventArgs e)
        {
            btnClientDel.BackColor = Color.MediumSpringGreen;
            btnClientDel.ForeColor = Color.White;
        }

        private void btnClientDel_MouseLeave(object sender, EventArgs e)
        {
            btnClientDel.BackColor = SystemColors.ButtonFace;
            btnClientDel.ForeColor = SystemColors.ControlText;
        }

        ADOMethodController Con = new ADOMethodController();

        private void ClientFrm_Load(object sender, EventArgs e)
        {
            dgvClients.DataSource = Con.LoadClientData();
            dgvClients.DataMember = "Table";
            Con.LoadAddressData(dgvAddress);
            dgvAddress.DataMember = "Table";
            Con.LoadContracts(dgvContractGrid);
            dgvContractGrid.DataMember = "Table";
            Con.LoadBusinessData(dgvBusinessGrid);
            dgvBusinessGrid.DataMember = "Table";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            (new MenuFrm()).Show();
            this.Hide();
        }

        private void btnClientEdit_Click(object sender, EventArgs e)
        {
            if (txtClientID.Text == string.Empty)
            {
                MessageBox.Show("Please select an ID first!");
            }
            else if (txtBusiness.Text == string.Empty || txtContract.Text == string.Empty || txtAddress.Text == string.Empty || txtClientName.Text == string.Empty || txtClientSurn.Text == string.Empty || txtClientNum.Text == string.Empty || txtPos.Text == string.Empty || txtservicelevel.Text == string.Empty)
            {
                MessageBox.Show("Please enter all fields!");
            }
            else
            {
                Con.UpdateClientData(dgvClients, txtBusiness.Text, txtContract.Text, txtAddress.Text, txtClientName.Text, txtClientSurn.Text, txtClientNum.Text, txtCalls.Text, txtPos.Text, txtAltContact.Text, txtAltNumb.Text, txtClientID.Text, txtservicelevel.Text);
            }
            
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            (new AddressFrm()).Show();
            this.Hide();
        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            if (txtBusiness.Text == string.Empty || txtContract.Text == string.Empty || txtAddress.Text == string.Empty || txtClientName.Text == string.Empty || txtClientSurn.Text == string.Empty || txtClientNum.Text == string.Empty || txtPos.Text == string.Empty || txtservicelevel.Text == string.Empty)
            {
                MessageBox.Show("Please enter all fields!");
            }
            else
            {
                Con.InsertClientData(dgvClients, txtBusiness.Text, txtContract.Text, txtAddress.Text, txtClientName.Text, txtClientSurn.Text, txtClientNum.Text, txtCalls.Text, txtPos.Text, txtAltContact.Text, txtAltNumb.Text, txtClientID.Text, txtservicelevel.Text);
            }
            
        }

        private void btnClientDel_Click(object sender, EventArgs e)
        {
            if (txtClientID.Text == string.Empty)
            {
                MessageBox.Show("Please select an ID first!");
            }
            else
            {
                Con.DeleteClientData(dgvClients, txtBusiness.Text, txtContract.Text, txtAddress.Text, txtClientName.Text, txtClientSurn.Text, txtClientNum.Text, txtCalls.Text, txtPos.Text, txtAltContact.Text, txtAltNumb.Text, txtClientID.Text, txtservicelevel.Text);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvAddress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvAddress.CurrentRow;
            if (!row.IsNewRow)
            {
                txtAddress.Text = row.Cells["AddressId"].Value.ToString();
                
            }
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvClients.CurrentRow;
            if (!row.IsNewRow)
            {
                txtBusiness.Text = row.Cells["BusinessId"].Value.ToString();
                txtContract.Text = row.Cells["ContractId"].Value.ToString();
                txtAddress.Text = row.Cells["AddressId"].Value.ToString();
                txtClientName.Text = row.Cells["ClientName"].Value.ToString();
                txtClientSurn.Text = row.Cells["Surname"].Value.ToString();
                txtClientNum.Text = row.Cells["Number"].Value.ToString();
                txtCalls.Text = row.Cells["CallsMade"].Value.ToString();
                txtPos.Text = row.Cells["Position"].Value.ToString();
                txtAltContact.Text = row.Cells["AlternativeContact"].Value.ToString();
                txtAltNumb.Text = row.Cells["AlternativeNumber"].Value.ToString();
                txtClientID.Text = row.Cells["ClientId"].Value.ToString();
            }
        }

        private void dgvBusinessGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvBusinessGrid.CurrentRow;
            if (!row.IsNewRow)
            {
                txtBusiness.Text = row.Cells["BusinessId"].Value.ToString();
            }
        }

        private void dgvContractGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvContractGrid.CurrentRow;
            if (!row.IsNewRow)
            {
                txtContract.Text = row.Cells["ContractId"].Value.ToString();
            }
        }
    }
}
