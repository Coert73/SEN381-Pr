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
        public TechnicianFrm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TechnicianFrm_Load(object sender, EventArgs e)
        {
            ADOMethodController Con = new ADOMethodController();
            dgvTechnician.AutoGenerateColumns = true;           
            dgvTechnician.DataSource = Con.LoadData();
            dgvTechnician.DataMember = "Table";         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
