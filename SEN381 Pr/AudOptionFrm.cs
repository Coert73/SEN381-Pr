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
    public partial class AudOptionFrm : Form
    {
        public AudOptionFrm()
        {
            InitializeComponent();
        }

        private void btnhearaid_Click(object sender, EventArgs e)
        {
            if (label4.Text == "OFF")
            {
                label4.ForeColor = Color.Green;
                label4.Text = "ON";
            }
            else if (label4.Text == "ON") 
            {
                label4.ForeColor = Color.Red;
                label4.Text = "OFF";
            }
            
        }

        private void btnCustVol_Click(object sender, EventArgs e)
        {
            if (trackBar1.Enabled == false)
            {
                trackBar1.Enabled = true;
            }
            else if (trackBar1.Enabled == true) 
            {
                trackBar1.Enabled = false;
            };
        }

        private void brnReturn_Click(object sender, EventArgs e)
        {
            (new OptionsFrm()).Show();
            this.Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label6.Text = trackBar1.Value.ToString();
        }

        private void AudOptionFrm_Shown(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
        }

        private void AudOptionFrm_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
        }
    }
}
