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
    public partial class AddressFrm : Form
    {
        public AddressFrm()
        {
            InitializeComponent();
        }

        ADOMethodController Con = new ADOMethodController(); 

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (new MenuFrm()).Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Con.InsertAddressData(dgvAddress,txtAddressID.Text,txtStreet.Text,txtPostalCode.Text,txtCity.Text,txtCountry.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Con.UpdateAddressData(dgvAddress, txtAddressID.Text, txtStreet.Text, txtPostalCode.Text, txtCity.Text, txtCountry.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Con.DeleteAddressData(dgvAddress, txtAddressID.Text, txtStreet.Text, txtPostalCode.Text, txtCity.Text, txtCountry.Text);
        }

        private void AddressFrm_Load(object sender, EventArgs e)
        {
            Con.LoadAddressData(dgvAddress);
        }

        private void dgvAddress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvAddress.CurrentRow;
            if (!row.IsNewRow)
            {
                txtAddressID.Text = row.Cells["AddressId"].Value.ToString();
                txtStreet.Text = row.Cells["Street"].Value.ToString();
                txtPostalCode.Text = row.Cells["PostalCode"].Value.ToString();
                txtCity.Text = row.Cells["City"].Value.ToString();
                txtCountry.Text = row.Cells["Country"].Value.ToString();
            }
        }
    }
}
