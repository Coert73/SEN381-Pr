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
    public partial class ServiceSelectFrm : Form
    {

        ADOMethodController Con = new ADOMethodController();

        public ServiceSelectFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ServiceSelectFrm_Load(object sender, EventArgs e)
        {
            Con.LoadServices(dgvServiceSelect);
        }

        private void dgvServiceSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvServiceSelect.CurrentRow;
            if (!row.IsNewRow)
            {
                rtbText. = row.Cells["ServiceId"].Value.ToString();
                txtName.Text = row.Cells["ServiceName"].Value.ToString();
                txtDescription.Text = row.Cells["ServiceDescription"].Value.ToString();
                textLevel.Text = row.Cells["ServiceLevel"].Value.ToString();
                textDur.Text = row.Cells["ResolutionPeriod"].Value.ToString();
                textSLA.Text = row.Cells["ServiceLevelAgreement"].Value.ToString();
                chkEquipment.Checked = Convert.ToBoolean(row.Cells["IsEquipment"].Value);

            }
        }
    }
}
