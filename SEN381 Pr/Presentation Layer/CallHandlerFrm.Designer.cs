namespace SEN381_Pr.Presentation_Layer
{
    partial class CallHandlerFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallHandlerFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvClientsContact = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblContacts = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCallHistory = new System.Windows.Forms.Label();
            this.dgvDataCalls = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnRequests = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnMakeCall = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsContact)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataCalls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientsContact
            // 
            this.dgvClientsContact.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientsContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientsContact.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClientsContact.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientsContact.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClientsContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientsContact.GridColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvClientsContact.Location = new System.Drawing.Point(4, 138);
            this.dgvClientsContact.Name = "dgvClientsContact";
            this.dgvClientsContact.RowHeadersVisible = false;
            this.dgvClientsContact.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientsContact.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClientsContact.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientsContact.Size = new System.Drawing.Size(230, 465);
            this.dgvClientsContact.TabIndex = 1;
            this.dgvClientsContact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientsContact_CellClick);
            this.dgvClientsContact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobs_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.lblContacts);
            this.panel1.Controls.Add(this.dgvClientsContact);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 605);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(74, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(4, 123);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(230, 3);
            this.textBox2.TabIndex = 20;
            // 
            // lblContacts
            // 
            this.lblContacts.AutoSize = true;
            this.lblContacts.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacts.Location = new System.Drawing.Point(91, 103);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(56, 17);
            this.lblContacts.TabIndex = 7;
            this.lblContacts.Text = "Contacts";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.lblCallHistory);
            this.panel2.Controls.Add(this.dgvDataCalls);
            this.panel2.Location = new System.Drawing.Point(257, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 605);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(8, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(700, 3);
            this.textBox1.TabIndex = 19;
            // 
            // lblCallHistory
            // 
            this.lblCallHistory.AutoSize = true;
            this.lblCallHistory.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallHistory.Location = new System.Drawing.Point(6, 9);
            this.lblCallHistory.Name = "lblCallHistory";
            this.lblCallHistory.Size = new System.Drawing.Size(71, 17);
            this.lblCallHistory.TabIndex = 9;
            this.lblCallHistory.Text = "Call History";
            this.lblCallHistory.Click += new System.EventHandler(this.lblCallHistory_Click);
            // 
            // dgvDataCalls
            // 
            this.dgvDataCalls.BackgroundColor = System.Drawing.Color.White;
            this.dgvDataCalls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDataCalls.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDataCalls.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataCalls.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDataCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataCalls.GridColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvDataCalls.Location = new System.Drawing.Point(16, 43);
            this.dgvDataCalls.Name = "dgvDataCalls";
            this.dgvDataCalls.RowHeadersVisible = false;
            this.dgvDataCalls.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDataCalls.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDataCalls.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataCalls.Size = new System.Drawing.Size(686, 550);
            this.dgvDataCalls.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1038, 577);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1024, 576);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(172, 41);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.btnRequests);
            this.panel3.Controls.Add(this.btnReports);
            this.panel3.Controls.Add(this.btnMakeCall);
            this.panel3.Location = new System.Drawing.Point(979, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 373);
            this.panel3.TabIndex = 20;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(63, 52);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // btnRequests
            // 
            this.btnRequests.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnRequests.FlatAppearance.BorderSize = 3;
            this.btnRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequests.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequests.Location = new System.Drawing.Point(19, 293);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(179, 36);
            this.btnRequests.TabIndex = 2;
            this.btnRequests.Text = "Requests";
            this.btnRequests.UseVisualStyleBackColor = true;
            this.btnRequests.Click += new System.EventHandler(this.btnRequests_Click);
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnReports.FlatAppearance.BorderSize = 3;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(19, 229);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(179, 36);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnMakeCall
            // 
            this.btnMakeCall.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnMakeCall.FlatAppearance.BorderSize = 3;
            this.btnMakeCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeCall.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeCall.Location = new System.Drawing.Point(19, 165);
            this.btnMakeCall.Name = "btnMakeCall";
            this.btnMakeCall.Size = new System.Drawing.Size(179, 36);
            this.btnMakeCall.TabIndex = 0;
            this.btnMakeCall.Text = "Make Call";
            this.btnMakeCall.UseVisualStyleBackColor = true;
            this.btnMakeCall.Click += new System.EventHandler(this.btnMakeCall_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CallHandlerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1208, 629);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CallHandlerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CallHandlerFrm";
            this.Load += new System.EventHandler(this.CallHandlerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsContact)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataCalls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientsContact;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblContacts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCallHistory;
        private System.Windows.Forms.DataGridView dgvDataCalls;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnMakeCall;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
    }
}