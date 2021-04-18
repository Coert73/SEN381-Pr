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

    public partial class VisOptionFrm : Form
    {
        public VisOptionFrm()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            (new OptionsFrm()).Show();
            this.Hide();
        }

        private void btnVisOptions_Click(object sender, EventArgs e)
        {
            if (label4.Text == "OFF")
            {
                label4.ForeColor = Color.Green;
                label4.Text = "ON";

                //Properties.Settings.Default.DefaultBackColor = Color.SlateGray;
                //Properties.Settings.Default.DefaultTextColor = Color.White;
               // Properties.Settings.Default.Save();
                //Properties.Settings.Default.Reload();


            }
            else if (label4.Text == "ON")
            {
                label4.ForeColor = Color.Red;
                label4.Text = "OFF";
                //Properties.Settings.Default.Reset();
            }
        }

        private void VisOptionFrm_Load(object sender, EventArgs e)
        {
           /* Properties.Settings.Default.Reload();
            if (Properties.Settings.Default.DefaultBackColor == Color.SlateGray)
            {
                label4.ForeColor = Color.Green;
                label4.Text = "ON";
            }
            else if (Properties.Settings.Default.DefaultBackColor == Color.LightGray)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "OFF";
            } */
        }

        private void VisOptionFrm_Shown(object sender, EventArgs e)
        {
            /*Properties.Settings.Default.Reload();
            if (Properties.Settings.Default.DefaultBackColor == Color.SlateGray)
            {
                label4.ForeColor = Color.Green;
                label4.Text = "ON";
            }
            else if (Properties.Settings.Default.DefaultBackColor == Color.LightGray)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "OFF";
            }
            */
        }
    }
}
