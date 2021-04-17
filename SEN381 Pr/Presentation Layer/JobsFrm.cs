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
    public partial class JobsFrm : Form
    {
        ADOMethodController Con = new ADOMethodController();

        public JobsFrm()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void JobsFrm_Load(object sender, EventArgs e)
        {
            dgvJobs.AutoGenerateColumns = true;
            dgvJobs.DataSource = Con.LoadJobData();
            dgvJobs.DataMember = "Table";
        }
    }
}
