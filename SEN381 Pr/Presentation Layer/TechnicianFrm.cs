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
    public partial class TechnicianFrm : Form
    {
        ADOMethodController Con = new ADOMethodController();
        private string _id;

        public TechnicianFrm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void TechnicianFrm_Load(object sender, EventArgs e)
        {
            dgvTechnician.AutoGenerateColumns = true;
            dgvTechnician.DataSource = Con.LoadTechData();
            dgvTechnician.DataMember = "Table";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Con.InsertTechData(dgvTechnician,txtName.Text,txtSurname.Text,txtNumber.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Con.UpdateTechData(dgvTechnician, txtName.Text, txtSurname.Text, txtNumber.Text, _id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Con.DeleteTechData(dgvTechnician, _id);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            (new MenuFrm()).Show();
            this.Hide();
        }
    }
}
