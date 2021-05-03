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
    public partial class PackagesFrm : Form
    {
        public delegate void delPassService(ListBox box);
        ADOMethodController Con = new ADOMethodController();

        public PackagesFrm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            (new MenuFrm()).Show();
            this.Hide();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            ServiceSelectFrm ser = new ServiceSelectFrm();
            delPassService del = new delPassService(ser.GetService);
            del(this.listBox1);
            ser.Show();
        }

        public void RecieveService(String str)
        {
            listBox1.Items.Add(str);
        }

        private void PackagesFrm_Load(object sender, EventArgs e)
        {
            Con.LoadPackageData(dgvPackages);
        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            Con.InsertPackageData(dgvPackages, txtId.Text,txtName.Text,txtType.Text,listBox1);
        }

        private void btnClientEdit_Click(object sender, EventArgs e)
        {
            Con.UpdatePackageData(dgvPackages, txtId.Text, txtName.Text, txtType.Text, listBox1);
        }

        private void btnClientDel_Click(object sender, EventArgs e)
        {
            Con.DeletePackageData(dgvPackages, txtId.Text, txtName.Text, txtType.Text, listBox1);
        }

        private void dgvPackages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvPackages.CurrentRow;
            if (!row.IsNewRow)
            {
                txtId.Text = row.Cells["PackageId"].Value.ToString();
                txtName.Text = row.Cells["PackageName"].Value.ToString();
                txtType.Text = row.Cells["PackageType"].Value.ToString();                
            }
        }
    }
}
