namespace SEN381_Pr
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
            this.lblCallLogger = new System.Windows.Forms.Label();
            this.pnlCallLogger = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlContacts = new System.Windows.Forms.FlowLayoutPanel();
            this.lblContacts = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCallLogger
            // 
            this.lblCallLogger.AutoSize = true;
            this.lblCallLogger.Location = new System.Drawing.Point(9, 28);
            this.lblCallLogger.Name = "lblCallLogger";
            this.lblCallLogger.Size = new System.Drawing.Size(63, 13);
            this.lblCallLogger.TabIndex = 0;
            this.lblCallLogger.Text = "Call Logger:";
            // 
            // pnlCallLogger
            // 
            this.pnlCallLogger.Location = new System.Drawing.Point(12, 56);
            this.pnlCallLogger.Name = "pnlCallLogger";
            this.pnlCallLogger.Size = new System.Drawing.Size(215, 293);
            this.pnlCallLogger.TabIndex = 1;
            // 
            // pnlContacts
            // 
            this.pnlContacts.Location = new System.Drawing.Point(438, 56);
            this.pnlContacts.Name = "pnlContacts";
            this.pnlContacts.Size = new System.Drawing.Size(215, 293);
            this.pnlContacts.TabIndex = 3;
            // 
            // lblContacts
            // 
            this.lblContacts.AutoSize = true;
            this.lblContacts.Location = new System.Drawing.Point(435, 28);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(52, 13);
            this.lblContacts.TabIndex = 2;
            this.lblContacts.Text = "Contacts:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(224, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(499, 398);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // CallHandlerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlContacts);
            this.Controls.Add(this.lblContacts);
            this.Controls.Add(this.pnlCallLogger);
            this.Controls.Add(this.lblCallLogger);
            this.Name = "CallHandlerFrm";
            this.Text = "CallHandlerFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCallLogger;
        private System.Windows.Forms.FlowLayoutPanel pnlCallLogger;
        private System.Windows.Forms.FlowLayoutPanel pnlContacts;
        private System.Windows.Forms.Label lblContacts;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReport;
    }
}