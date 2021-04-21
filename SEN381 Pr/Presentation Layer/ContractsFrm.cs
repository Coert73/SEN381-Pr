using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN381_Pr.Presentation_Layer
{
    public partial class ContractsFrm : Form
    {
        public ContractsFrm()
        {
            InitializeComponent();
        }

        ADOMethodController Con = new ADOMethodController();

        private void dgvTechnician_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            (new MenuFrm()).Show();
            this.Hide();
        }

        private void ContractsFrm_Load(object sender, EventArgs e)
        {
            Con.LoadContracts(dgvContracts);
        }
    }
}
