
namespace SEN381_Pr
{
    partial class AudOptionFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.brnReturn = new System.Windows.Forms.Button();
            this.btnCustVol = new System.Windows.Forms.Button();
            this.btnhearaid = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 60);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Premiere Service Solutions";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(11, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 42);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Audio Options";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.brnReturn);
            this.panel3.Controls.Add(this.btnCustVol);
            this.panel3.Controls.Add(this.btnhearaid);
            this.panel3.Location = new System.Drawing.Point(11, 126);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 193);
            this.panel3.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = global::SEN381_Pr.Properties.Settings.Default.DefaultBackColor;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SEN381_Pr.Properties.Settings.Default, "DefaultBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SEN381_Pr.Properties.Settings.Default, "DefaultTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label6.ForeColor = global::SEN381_Pr.Properties.Settings.Default.DefaultTextColor;
            this.label6.Location = new System.Drawing.Point(302, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Volume:";
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(253, 55);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(302, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "OFF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status:";
            // 
            // brnReturn
            // 
            this.brnReturn.BackColor = System.Drawing.Color.White;
            this.brnReturn.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.brnReturn.FlatAppearance.BorderSize = 3;
            this.brnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnReturn.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnReturn.Location = new System.Drawing.Point(12, 148);
            this.brnReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.brnReturn.Name = "brnReturn";
            this.brnReturn.Size = new System.Drawing.Size(342, 33);
            this.brnReturn.TabIndex = 5;
            this.brnReturn.Text = "Return";
            this.brnReturn.UseVisualStyleBackColor = false;
            this.brnReturn.Click += new System.EventHandler(this.brnReturn_Click);
            // 
            // btnCustVol
            // 
            this.btnCustVol.BackColor = System.Drawing.Color.White;
            this.btnCustVol.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCustVol.FlatAppearance.BorderSize = 3;
            this.btnCustVol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustVol.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustVol.Location = new System.Drawing.Point(14, 55);
            this.btnCustVol.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCustVol.Name = "btnCustVol";
            this.btnCustVol.Size = new System.Drawing.Size(230, 33);
            this.btnCustVol.TabIndex = 4;
            this.btnCustVol.Text = "Custom Volume";
            this.btnCustVol.UseVisualStyleBackColor = false;
            this.btnCustVol.Click += new System.EventHandler(this.btnCustVol_Click);
            // 
            // btnhearaid
            // 
            this.btnhearaid.BackColor = System.Drawing.Color.White;
            this.btnhearaid.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnhearaid.FlatAppearance.BorderSize = 3;
            this.btnhearaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhearaid.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhearaid.Location = new System.Drawing.Point(14, 16);
            this.btnhearaid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnhearaid.Name = "btnhearaid";
            this.btnhearaid.Size = new System.Drawing.Size(230, 33);
            this.btnhearaid.TabIndex = 3;
            this.btnhearaid.Text = "Hearing aid mode";
            this.btnhearaid.UseVisualStyleBackColor = false;
            this.btnhearaid.Click += new System.EventHandler(this.btnhearaid_Click);
            // 
            // AudOptionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::SEN381_Pr.Properties.Settings.Default.DefaultBackColor;
            this.ClientSize = new System.Drawing.Size(386, 325);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SEN381_Pr.Properties.Settings.Default, "DefaultBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AudOptionFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AudOptionFrm";
            this.Load += new System.EventHandler(this.AudOptionFrm_Load);
            this.Shown += new System.EventHandler(this.AudOptionFrm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button brnReturn;
        private System.Windows.Forms.Button btnCustVol;
        private System.Windows.Forms.Button btnhearaid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}