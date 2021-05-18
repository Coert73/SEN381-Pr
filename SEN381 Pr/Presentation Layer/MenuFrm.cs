﻿using System;
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
    public partial class MenuFrm : Form
    {        
        public MenuFrm()
        {
            InitializeComponent();
        }

        public MenuFrm(string username)
        {
            InitializeComponent();
        }

        private void btnCallOpen_Click(object sender, EventArgs e)
        {
            (new Presentation_Layer.CallHandlerFrm()).Show();
            this.Hide();
        }

        private void btnReportsOpen_Click(object sender, EventArgs e)
        {
            (new Presentation_Layer.ReportFrm()).Show();
            this.Hide();
        }

        private void btnRequestsOpen_Click(object sender, EventArgs e)
        {
            (new RequestFrm()).Show();
            this.Hide();
        }

        private void btnContractsOpen_Click(object sender, EventArgs e)
        {
            (new Presentation_Layer.ContractsFrm()).Show();
            this.Hide();
        }

        private void btnClientsOpen_Click(object sender, EventArgs e)
        {
            (new ClientFrm()).Show();
            this.Hide();
        }

        private void btnJobsOpen_Click(object sender, EventArgs e)
        {
            (new JobsFrm()).Show();
            this.Hide();
        }

        private void btnTechOpen_Click(object sender, EventArgs e)
        {
            (new TechnicianFrm()).Show();
            this.Hide();
        }

        private void btnOptionsOpen_Click(object sender, EventArgs e)
        {
            (new OptionsFrm()).Show();
            this.Hide();
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            (new LoginFrm()).Show();
            this.Hide();
        }

        private void btnCallOpen_MouseEnter(object sender, EventArgs e)
        {
            btnCallOpen.BackColor = Color.MediumSpringGreen;
            btnCallOpen.ForeColor = Color.White;
        }

        private void btnCallOpen_MouseLeave(object sender, EventArgs e)
        {
            btnCallOpen.BackColor = SystemColors.ButtonFace;
            btnCallOpen.ForeColor = SystemColors.ControlText;
        }

        private void btnReportsOpen_MouseEnter(object sender, EventArgs e)
        {
            btnReportsOpen.BackColor = Color.MediumSpringGreen;
            btnReportsOpen.ForeColor = Color.White;
        }

        private void btnReportsOpen_MouseLeave(object sender, EventArgs e)
        {
            btnReportsOpen.BackColor = SystemColors.ButtonFace;
            btnReportsOpen.ForeColor = SystemColors.ControlText;
        }

        private void btnRequestsOpen_MouseEnter(object sender, EventArgs e)
        {
            btnRequestsOpen.BackColor = Color.MediumSpringGreen;
            btnRequestsOpen.ForeColor = Color.White;
        }

        private void btnRequestsOpen_MouseLeave(object sender, EventArgs e)
        {
            btnRequestsOpen.BackColor = SystemColors.ButtonFace;
            btnRequestsOpen.ForeColor = SystemColors.ControlText;
        }

        private void btnContractsOpen_MouseEnter(object sender, EventArgs e)
        {
            btnContractsOpen.BackColor = Color.MediumSpringGreen;
            btnContractsOpen.ForeColor = Color.White;
        }

        private void btnContractsOpen_MouseLeave(object sender, EventArgs e)
        {
            btnContractsOpen.BackColor = SystemColors.ButtonFace;
            btnContractsOpen.ForeColor = SystemColors.ControlText;
        }

        private void btnClientsOpen_MouseEnter(object sender, EventArgs e)
        {
            btnClientsOpen.BackColor = Color.MediumSpringGreen;
            btnClientsOpen.ForeColor = Color.White;
        }

        private void btnClientsOpen_MouseLeave(object sender, EventArgs e)
        {
            btnClientsOpen.BackColor = SystemColors.ButtonFace;
            btnClientsOpen.ForeColor = SystemColors.ControlText;
        }

        private void btnJobsOpen_MouseEnter(object sender, EventArgs e)
        {
            btnJobsOpen.BackColor = Color.MediumSpringGreen;
            btnJobsOpen.ForeColor = Color.White;
        }

        private void btnJobsOpen_MouseLeave(object sender, EventArgs e)
        {
            btnJobsOpen.BackColor = SystemColors.ButtonFace;
            btnJobsOpen.ForeColor = SystemColors.ControlText;
        }

        private void btnTechOpen_MouseEnter(object sender, EventArgs e)
        {
            btnTechOpen.BackColor = Color.MediumSpringGreen;
            btnTechOpen.ForeColor = Color.White;
        }

        private void btnTechOpen_MouseLeave(object sender, EventArgs e)
        {
            btnTechOpen.BackColor = SystemColors.ButtonFace;
            btnTechOpen.ForeColor = SystemColors.ControlText;
        }

        private void btnOptionsOpen_MouseEnter(object sender, EventArgs e)
        {
            btnOptionsOpen.BackColor = Color.MediumSpringGreen;
            btnOptionsOpen.ForeColor = Color.White;
        }

        private void btnOptionsOpen_MouseLeave(object sender, EventArgs e)
        {
            btnOptionsOpen.BackColor = SystemColors.ButtonFace;
            btnOptionsOpen.ForeColor = SystemColors.ControlText;
        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.MediumSpringGreen;
            btnLogOut.ForeColor = Color.White;
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.BackColor = SystemColors.ButtonFace;
            btnLogOut.ForeColor = SystemColors.ControlText;
        }


        private void MenuFrm_Load(object sender, EventArgs e)
        {
            ADOMethodController Con = new ADOMethodController();
            Con.CountJobs(lblJobsDone);            
            chart1.Series["Jobs"].Points.AddXY("January", "10");
            chart1.Series["Jobs"].Points.AddXY("Febuary", "8");
            chart1.Series["Jobs"].Points.AddXY("March", "7");
            chart1.Series["Jobs"].Points.AddXY("April", "15");
            chart1.Series["Jobs"].Points.AddXY("May", "25");          
            chart1.Titles.Add("PAST JOBS");          
        }

        public void GetUserName(string name)
        {
            lblUser.Text = name;
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            (new ServicesFrm()).Show();
            this.Hide();
        }  

        private void btnBusiness_Click_1(object sender, EventArgs e)
        {
            (new Business_Form()).Show();
            this.Hide();
        }

        private void lblJobsDone_Click(object sender, EventArgs e)
        {

        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            (new PackagesFrm()).Show();
            this.Hide();
        }

        private void btnTrackJobs_Click(object sender, EventArgs e)
        {
            (new TrackJobs()).Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:3000/fetch");
        }
    }
}
