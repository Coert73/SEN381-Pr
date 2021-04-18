namespace SEN381_Pr.Presentation_Layer
{
    partial class CreateContractFrm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCreatePackage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cbxPackage = new System.Windows.Forms.ComboBox();
            this.lblPackage = new System.Windows.Forms.Label();
            this.lblContractType = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblContractName = new System.Windows.Forms.Label();
            this.txtContractType = new System.Windows.Forms.TextBox();
            this.txtContractName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPackages = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSubmit);
            this.panel3.Controls.Add(this.btnCreatePackage);
            this.panel3.Location = new System.Drawing.Point(504, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 178);
            this.panel3.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(15, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(351, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSubmit.FlatAppearance.BorderSize = 3;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(15, 65);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(351, 36);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCreatePackage
            // 
            this.btnCreatePackage.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCreatePackage.FlatAppearance.BorderSize = 3;
            this.btnCreatePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePackage.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePackage.Location = new System.Drawing.Point(15, 14);
            this.btnCreatePackage.Name = "btnCreatePackage";
            this.btnCreatePackage.Size = new System.Drawing.Size(351, 36);
            this.btnCreatePackage.TabIndex = 0;
            this.btnCreatePackage.Text = "Create Package";
            this.btnCreatePackage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.cbxPackage);
            this.panel2.Controls.Add(this.lblPackage);
            this.panel2.Controls.Add(this.lblContractType);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.lblContractName);
            this.panel2.Controls.Add(this.txtContractType);
            this.panel2.Controls.Add(this.txtContractName);
            this.panel2.Location = new System.Drawing.Point(504, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 242);
            this.panel2.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(15, 207);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(233, 3);
            this.textBox4.TabIndex = 22;
            // 
            // cbxPackage
            // 
            this.cbxPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPackage.ForeColor = System.Drawing.Color.Black;
            this.cbxPackage.FormattingEnabled = true;
            this.cbxPackage.Items.AddRange(new object[] {
            "Bronze Package",
            "Silver Package",
            "Gold Package",
            "Platinum Package"});
            this.cbxPackage.Location = new System.Drawing.Point(15, 189);
            this.cbxPackage.Name = "cbxPackage";
            this.cbxPackage.Size = new System.Drawing.Size(233, 21);
            this.cbxPackage.TabIndex = 21;
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackage.Location = new System.Drawing.Point(11, 160);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(55, 17);
            this.lblPackage.TabIndex = 20;
            this.lblPackage.Text = "Package";
            // 
            // lblContractType
            // 
            this.lblContractType.AutoSize = true;
            this.lblContractType.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractType.Location = new System.Drawing.Point(11, 96);
            this.lblContractType.Name = "lblContractType";
            this.lblContractType.Size = new System.Drawing.Size(83, 17);
            this.lblContractType.TabIndex = 19;
            this.lblContractType.Text = "Contract Type";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(14, 133);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(351, 3);
            this.textBox8.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(14, 60);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(351, 3);
            this.textBox7.TabIndex = 16;
            // 
            // lblContractName
            // 
            this.lblContractName.AutoSize = true;
            this.lblContractName.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractName.Location = new System.Drawing.Point(11, 23);
            this.lblContractName.Name = "lblContractName";
            this.lblContractName.Size = new System.Drawing.Size(88, 17);
            this.lblContractName.TabIndex = 6;
            this.lblContractName.Text = "Contract Name";
            // 
            // txtContractType
            // 
            this.txtContractType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContractType.Location = new System.Drawing.Point(14, 116);
            this.txtContractType.Multiline = true;
            this.txtContractType.Name = "txtContractType";
            this.txtContractType.Size = new System.Drawing.Size(351, 20);
            this.txtContractType.TabIndex = 1;
            // 
            // txtContractName
            // 
            this.txtContractName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContractName.Location = new System.Drawing.Point(14, 43);
            this.txtContractName.Multiline = true;
            this.txtContractName.Name = "txtContractName";
            this.txtContractName.Size = new System.Drawing.Size(351, 20);
            this.txtContractName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvPackages);
            this.panel1.Location = new System.Drawing.Point(19, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 435);
            this.panel1.TabIndex = 5;
            // 
            // dgvPackages
            // 
            this.dgvPackages.BackgroundColor = System.Drawing.Color.White;
            this.dgvPackages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPackages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPackages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPackages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackages.GridColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvPackages.Location = new System.Drawing.Point(3, 3);
            this.dgvPackages.Name = "dgvPackages";
            this.dgvPackages.RowHeadersVisible = false;
            this.dgvPackages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPackages.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPackages.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPackages.Size = new System.Drawing.Size(237, 429);
            this.dgvPackages.TabIndex = 0;
            // 
            // CreateContractFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateContractFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateContractFrm";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCreatePackage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox cbxPackage;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label lblContractType;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblContractName;
        private System.Windows.Forms.TextBox txtContractType;
        private System.Windows.Forms.TextBox txtContractName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPackages;
    }
}