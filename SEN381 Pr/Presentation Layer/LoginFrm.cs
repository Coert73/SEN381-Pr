using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN381_Pr
{
    public partial class LoginFrm : Form
    {
        
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            SecurityController Con = new SecurityController(this,txtUsername.Text,txtPassword.Text);
            
        }        

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Application.Exit();
        }

        private void LoginFrm_Shown(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
        }

        
    }
}
