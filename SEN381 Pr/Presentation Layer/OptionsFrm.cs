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
    public partial class OptionsFrm : Form
    {
        
        public OptionsFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new MenuFrm()).Show();
            this.Hide();
            
        }

        private void OptionsFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnVisOptions_MouseEnter(object sender, EventArgs e)
        {
            btnVisOptions.BackColor = Color.MediumSpringGreen;
            btnVisOptions.ForeColor = Color.White;
        }

        private void btnVisOptions_MouseLeave(object sender, EventArgs e)
        {
            btnVisOptions.BackColor = SystemColors.ButtonFace;
            btnVisOptions.ForeColor = SystemColors.ControlText;
        }

        private void btnAudioOptions_MouseEnter(object sender, EventArgs e)
        {
            btnAudioOptions.BackColor = Color.MediumSpringGreen;
            btnAudioOptions.ForeColor = Color.White;
        }

        private void btnAudioOptions_MouseLeave(object sender, EventArgs e)
        {
            btnAudioOptions.BackColor = SystemColors.ButtonFace;
            btnAudioOptions.ForeColor = SystemColors.ControlText;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumSpringGreen;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.ButtonFace;
            button1.ForeColor = SystemColors.ControlText;
        }

        private void btnAudioOptions_Click(object sender, EventArgs e)
        {
            (new AudOptionFrm()).Show();
            this.Hide();
        }

        private void btnVisOptions_Click(object sender, EventArgs e)
        {
            (new VisOptionFrm()).Show();
            this.Hide();
        }
    }
}
