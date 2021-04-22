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

        string idToCarry = "";

        private void dgvServiceSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbxItems.Items.Clear();

            DataGridViewRow row = dgvServiceSelect.CurrentRow;
            if (!row.IsNewRow)
            {
                lbxItems.Items.Add(row.Cells["ServiceId"].Value.ToString());
                idToCarry = row.Cells["ServiceId"].Value.ToString();
                lbxItems.Items.Add(row.Cells["ServiceName"].Value.ToString());
                lbxItems.Items.Add(row.Cells["ServiceDescription"].Value.ToString());
                lbxItems.Items.Add(row.Cells["ServiceLevel"].Value.ToString());
                lbxItems.Items.Add(row.Cells["ResolutionPeriod"].Value.ToString());
                lbxItems.Items.Add(row.Cells["ServiceLevelAgreement"].Value.ToString());
                lbxItems.Items.Add(Convert.ToBoolean(row.Cells["IsEquipment"].Value));
            }
        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            box.Items.Add(idToCarry);
        }

        ListBox box = new ListBox();

        public void GetService(ListBox list)
        {
            box = list;
        }
    }
}
