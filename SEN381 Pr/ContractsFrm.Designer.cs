namespace SEN381_Pr
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
            this.pnlPremadePackages = new System.Windows.Forms.Panel();
            this.btnPremadePackages = new System.Windows.Forms.Button();
            this.btnCreatePackage = new System.Windows.Forms.Button();
            this.pnlCreatePackages = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlPremadePackages
            // 
            this.pnlPremadePackages.Location = new System.Drawing.Point(218, 12);
            this.pnlPremadePackages.Name = "pnlPremadePackages";
            this.pnlPremadePackages.Size = new System.Drawing.Size(354, 194);
            this.pnlPremadePackages.TabIndex = 0;
            // 
            // btnPremadePackages
            // 
            this.btnPremadePackages.Location = new System.Drawing.Point(32, 30);
            this.btnPremadePackages.Name = "btnPremadePackages";
            this.btnPremadePackages.Size = new System.Drawing.Size(135, 23);
            this.btnPremadePackages.TabIndex = 1;
            this.btnPremadePackages.Text = "Premade Packages";
            this.btnPremadePackages.UseVisualStyleBackColor = true;
            // 
            // btnCreatePackage
            // 
            this.btnCreatePackage.Location = new System.Drawing.Point(12, 268);
            this.btnCreatePackage.Name = "btnCreatePackage";
            this.btnCreatePackage.Size = new System.Drawing.Size(137, 23);
            this.btnCreatePackage.TabIndex = 2;
            this.btnCreatePackage.Text = "Create Package";
            this.btnCreatePackage.UseVisualStyleBackColor = true;
            // 
            // pnlCreatePackages
            // 
            this.pnlCreatePackages.Location = new System.Drawing.Point(218, 264);
            this.pnlCreatePackages.Name = "pnlCreatePackages";
            this.pnlCreatePackages.Size = new System.Drawing.Size(354, 185);
            this.pnlCreatePackages.TabIndex = 3;
            // 
            // ContractsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.pnlCreatePackages);
            this.Controls.Add(this.btnCreatePackage);
            this.Controls.Add(this.btnPremadePackages);
            this.Controls.Add(this.pnlPremadePackages);
            this.Name = "ContractsFrm";
            this.Text = "ContractsFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPremadePackages;
        private System.Windows.Forms.Button btnPremadePackages;
        private System.Windows.Forms.Button btnCreatePackage;
        private System.Windows.Forms.Panel pnlCreatePackages;
    }
}