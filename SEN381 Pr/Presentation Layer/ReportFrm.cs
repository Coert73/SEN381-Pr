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
    public partial class ReportFrm : Form
    {
        ADOMethodController Con = new ADOMethodController();

        public ReportFrm()
        {
            InitializeComponent();
        }

        private void ReportFrm_Load(object sender, EventArgs e)
        {
            Con.LoadReports(dgvReport);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            (new MenuFrm()).Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Con.SearchReport(dgvReport, int.Parse(txtReferenceNumber.Text));
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Con.SortReports(dgvReport);
        }
    }
}
