namespace SEN381_Pr
{
    partial class ServiceSelectFrm
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
            this.btnClientAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.dgvServiceSelect = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientAdd
            // 
            this.btnClientAdd.BackColor = System.Drawing.Color.White;
            this.btnClientAdd.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnClientAdd.FlatAppearance.BorderSize = 3;
            this.btnClientAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientAdd.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientAdd.Location = new System.Drawing.Point(12, 542);
            this.btnClientAdd.Name = "btnClientAdd";
            this.btnClientAdd.Size = new System.Drawing.Size(187, 36);
            this.btnClientAdd.TabIndex = 1;
            this.btnClientAdd.Text = "Select";
            this.btnClientAdd.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(205, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvServiceSelect);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 392);
            this.panel1.TabIndex = 3;
            // 
            // rtbText
            // 
            this.rtbText.BackColor = System.Drawing.Color.White;
            this.rtbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbText.Location = new System.Drawing.Point(12, 410);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(385, 126);
            this.rtbText.TabIndex = 4;
            this.rtbText.Text = "";
            // 
            // dgvServiceSelect
            // 
            this.dgvServiceSelect.BackgroundColor = System.Drawing.Color.White;
            this.dgvServiceSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceSelect.Location = new System.Drawing.Point(16, 16);
            this.dgvServiceSelect.Name = "dgvServiceSelect";
            this.dgvServiceSelect.Size = new System.Drawing.Size(353, 360);
            this.dgvServiceSelect.TabIndex = 0;
            this.dgvServiceSelect.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceSelect_CellClick);
            // 
            // ServiceSelectFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 590);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClientAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ServiceSelectFrm";
            this.Text = "ServiceSelectFrm";
            this.Load += new System.EventHandler(this.ServiceSelectFrm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvServiceSelect;
        private System.Windows.Forms.RichTextBox rtbText;
    }
}