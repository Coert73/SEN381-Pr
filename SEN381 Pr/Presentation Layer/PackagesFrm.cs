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
            (new ServiceSelectFrm()).Show();            
        }
    }
}
