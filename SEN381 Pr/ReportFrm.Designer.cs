namespace SEN381_Pr
{
    partial class ReportFrm
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
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.lblReportSearch = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnReportExit = new System.Windows.Forms.Button();
            this.btnReportPrevious = new System.Windows.Forms.Button();
            this.btnReportNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(12, 12);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(448, 426);
            this.dgvReport.TabIndex = 0;
            // 
            // lblReportSearch
            // 
            this.lblReportSearch.AutoSize = true;
            this.lblReportSearch.Location = new System.Drawing.Point(466, 107);
            this.lblReportSearch.Name = "lblReportSearch";
            this.lblReportSearch.Size = new System.Drawing.Size(44, 13);
            this.lblReportSearch.TabIndex = 1;
            this.lblReportSearch.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(516, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnReportExit
            // 
            this.btnReportExit.Location = new System.Drawing.Point(598, 372);
            this.btnReportExit.Name = "btnReportExit";
            this.btnReportExit.Size = new System.Drawing.Size(75, 23);
            this.btnReportExit.TabIndex = 3;
            this.btnReportExit.Text = "Exit";
            this.btnReportExit.UseVisualStyleBackColor = true;
            // 
            // btnReportPrevious
            // 
            this.btnReportPrevious.Location = new System.Drawing.Point(516, 214);
            this.btnReportPrevious.Name = "btnReportPrevious";
            this.btnReportPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnReportPrevious.TabIndex = 4;
            this.btnReportPrevious.Text = "<<";
            this.btnReportPrevious.UseVisualStyleBackColor = true;
            // 
            // btnReportNext
            // 
            this.btnReportNext.Location = new System.Drawing.Point(688, 214);
            this.btnReportNext.Name = "btnReportNext";
            this.btnReportNext.Size = new System.Drawing.Size(75, 23);
            this.btnReportNext.TabIndex = 5;
            this.btnReportNext.Text = ">>";
            this.btnReportNext.UseVisualStyleBackColor = true;
            // 
            // ReportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReportNext);
            this.Controls.Add(this.btnReportPrevious);
            this.Controls.Add(this.btnReportExit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblReportSearch);
            this.Controls.Add(this.dgvReport);
            this.Name = "ReportFrm";
            this.Text = "ReportFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label lblReportSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnReportExit;
        private System.Windows.Forms.Button btnReportPrevious;
        private System.Windows.Forms.Button btnReportNext;
    }
}