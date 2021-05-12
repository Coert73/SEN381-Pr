namespace SEN381_Pr.Presentation_Layer
{
    partial class ContractsFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractsFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnContract = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkbxStatus = new System.Windows.Forms.CheckBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txtServiceLevel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContractType = new System.Windows.Forms.TextBox();
            this.txtPackageID = new System.Windows.Forms.TextBox();
            this.lblContractID = new System.Windows.Forms.Label();
            this.lblContractType = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblContractName = new System.Windows.Forms.Label();
            this.txtContractName = new System.Windows.Forms.TextBox();
            this.txtContracId = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvPackages = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvContracts);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 485);
            this.panel1.TabIndex = 1;
            // 
            // dgvContracts
            // 
            this.dgvContracts.BackgroundColor = System.Drawing.Color.White;
            this.dgvContracts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContracts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvContracts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContracts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.GridColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvContracts.Location = new System.Drawing.Point(3, 3);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.RowHeadersVisible = false;
            this.dgvContracts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvContracts.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContracts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContracts.Size = new System.Drawing.Size(473, 476);
            this.dgvContracts.TabIndex = 0;
            this.dgvContracts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContracts_CellClick);
            this.dgvContracts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTechnician_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnContract);
            this.panel3.Location = new System.Drawing.Point(12, 503);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 178);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(15, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(351, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnEdit.FlatAppearance.BorderSize = 3;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(15, 65);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(351, 36);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnContract
            // 
            this.btnContract.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnContract.FlatAppearance.BorderSize = 3;
            this.btnContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContract.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContract.Location = new System.Drawing.Point(15, 14);
            this.btnContract.Name = "btnContract";
            this.btnContract.Size = new System.Drawing.Size(351, 36);
            this.btnContract.TabIndex = 0;
            this.btnContract.Text = "Create Contract";
            this.btnContract.UseVisualStyleBackColor = true;
            this.btnContract.Click += new System.EventHandler(this.btnContract_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.nudDays);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.chkbxStatus);
            this.panel2.Controls.Add(this.dtpEnd);
            this.panel2.Controls.Add(this.dtpStart);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.txtServiceLevel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtContractType);
            this.panel2.Controls.Add(this.txtPackageID);
            this.panel2.Controls.Add(this.lblContractID);
            this.panel2.Controls.Add(this.lblContractType);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.lblContractName);
            this.panel2.Controls.Add(this.txtContractName);
            this.panel2.Controls.Add(this.txtContracId);
            this.panel2.Location = new System.Drawing.Point(497, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 245);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // chkbxStatus
            // 
            this.chkbxStatus.AutoSize = true;
            this.chkbxStatus.Location = new System.Drawing.Point(219, 205);
            this.chkbxStatus.Name = "chkbxStatus";
            this.chkbxStatus.Size = new System.Drawing.Size(56, 17);
            this.chkbxStatus.TabIndex = 40;
            this.chkbxStatus.Text = "Status";
            this.chkbxStatus.UseVisualStyleBackColor = true;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(330, 150);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(292, 20);
            this.dtpEnd.TabIndex = 39;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(16, 150);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(292, 20);
            this.dtpStart.TabIndex = 38;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(330, 219);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(292, 3);
            this.textBox10.TabIndex = 37;
            // 
            // txtServiceLevel
            // 
            this.txtServiceLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServiceLevel.Location = new System.Drawing.Point(330, 202);
            this.txtServiceLevel.Multiline = true;
            this.txtServiceLevel.Name = "txtServiceLevel";
            this.txtServiceLevel.Size = new System.Drawing.Size(292, 20);
            this.txtServiceLevel.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Service Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Contract Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Contract Type";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(330, 114);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(292, 3);
            this.textBox4.TabIndex = 27;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(330, 60);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(292, 3);
            this.textBox5.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Package ID";
            // 
            // txtContractType
            // 
            this.txtContractType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContractType.Location = new System.Drawing.Point(330, 97);
            this.txtContractType.Multiline = true;
            this.txtContractType.Name = "txtContractType";
            this.txtContractType.Size = new System.Drawing.Size(292, 20);
            this.txtContractType.TabIndex = 24;
            // 
            // txtPackageID
            // 
            this.txtPackageID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPackageID.Location = new System.Drawing.Point(330, 43);
            this.txtPackageID.Multiline = true;
            this.txtPackageID.Name = "txtPackageID";
            this.txtPackageID.Size = new System.Drawing.Size(292, 20);
            this.txtPackageID.TabIndex = 23;
            // 
            // lblContractID
            // 
            this.lblContractID.AutoSize = true;
            this.lblContractID.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractID.Location = new System.Drawing.Point(16, 127);
            this.lblContractID.Name = "lblContractID";
            this.lblContractID.Size = new System.Drawing.Size(62, 17);
            this.lblContractID.TabIndex = 20;
            this.lblContractID.Text = "Start Date";
            // 
            // lblContractType
            // 
            this.lblContractType.AutoSize = true;
            this.lblContractType.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractType.Location = new System.Drawing.Point(16, 77);
            this.lblContractType.Name = "lblContractType";
            this.lblContractType.Size = new System.Drawing.Size(88, 17);
            this.lblContractType.TabIndex = 19;
            this.lblContractType.Text = "Contract Name";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(16, 114);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(292, 3);
            this.textBox8.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(16, 60);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(292, 3);
            this.textBox7.TabIndex = 16;
            // 
            // lblContractName
            // 
            this.lblContractName.AutoSize = true;
            this.lblContractName.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractName.Location = new System.Drawing.Point(16, 23);
            this.lblContractName.Name = "lblContractName";
            this.lblContractName.Size = new System.Drawing.Size(68, 17);
            this.lblContractName.TabIndex = 6;
            this.lblContractName.Text = "Contract ID";
            // 
            // txtContractName
            // 
            this.txtContractName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContractName.Location = new System.Drawing.Point(16, 97);
            this.txtContractName.Multiline = true;
            this.txtContractName.Name = "txtContractName";
            this.txtContractName.Size = new System.Drawing.Size(292, 20);
            this.txtContractName.TabIndex = 1;
            // 
            // txtContracId
            // 
            this.txtContracId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContracId.Location = new System.Drawing.Point(16, 43);
            this.txtContracId.Multiline = true;
            this.txtContracId.Name = "txtContracId";
            this.txtContracId.ReadOnly = true;
            this.txtContracId.Size = new System.Drawing.Size(292, 20);
            this.txtContracId.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(963, 640);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(963, 640);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(172, 41);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dgvPackages);
            this.panel4.Location = new System.Drawing.Point(497, 263);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(637, 234);
            this.panel4.TabIndex = 13;
            // 
            // dgvPackages
            // 
            this.dgvPackages.BackgroundColor = System.Drawing.Color.White;
            this.dgvPackages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackages.Location = new System.Drawing.Point(15, 16);
            this.dgvPackages.Name = "dgvPackages";
            this.dgvPackages.Size = new System.Drawing.Size(607, 203);
            this.dgvPackages.TabIndex = 0;
            this.dgvPackages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackages_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Days to resolve:";
            // 
            // nudDays
            // 
            this.nudDays.Location = new System.Drawing.Point(19, 205);
            this.nudDays.Name = "nudDays";
            this.nudDays.Size = new System.Drawing.Size(85, 20);
            this.nudDays.TabIndex = 42;
            // 
            // ContractsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1145, 697);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContractsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContractsFrm";
            this.Load += new System.EventHandler(this.ContractsFrm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblContractID;
        private System.Windows.Forms.Label lblContractType;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblContractName;
        private System.Windows.Forms.TextBox txtContractName;
        private System.Windows.Forms.TextBox txtContracId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContractType;
        private System.Windows.Forms.TextBox txtPackageID;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox txtServiceLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvPackages;
        private System.Windows.Forms.CheckBox chkbxStatus;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudDays;
    }
}