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

        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnClientEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnClientDel_Click(object sender, EventArgs e)
        {

        }
    }
}
