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
    public partial class MenuFrm : Form
    {
        OptionsFrm Options = new OptionsFrm();
        public MenuFrm()
        {
            InitializeComponent();
        }

        private void btnCallOpen_Click(object sender, EventArgs e)
        {

        }

        private void btnReportsOpen_Click(object sender, EventArgs e)
        {

        }

        private void btnRequestsOpen_Click(object sender, EventArgs e)
        {

        }

        private void btnContractsOpen_Click(object sender, EventArgs e)
        {

        }

        private void btnClientsOpen_Click(object sender, EventArgs e)
        {

        }

        private void btnJobsOpen_Click(object sender, EventArgs e)
        {

        }

        private void btnTechOpen_Click(object sender, EventArgs e)
        {

        }

        private void btnOptionsOpen_Click(object sender, EventArgs e)
        {
            Options.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}
