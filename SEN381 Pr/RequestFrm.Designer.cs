namespace SEN381_Pr
{
    partial class RequestFrm
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
            this.dgvRequestFrm = new System.Windows.Forms.DataGridView();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRequestBack = new System.Windows.Forms.Button();
            this.cbxRequestSort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestFrm)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRequestFrm
            // 
            this.dgvRequestFrm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestFrm.Location = new System.Drawing.Point(12, 12);
            this.dgvRequestFrm.Name = "dgvRequestFrm";
            this.dgvRequestFrm.Size = new System.Drawing.Size(1082, 456);
            this.dgvRequestFrm.TabIndex = 0;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(12, 523);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 552);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnRequestBack
            // 
            this.btnRequestBack.Location = new System.Drawing.Point(976, 607);
            this.btnRequestBack.Name = "btnRequestBack";
            this.btnRequestBack.Size = new System.Drawing.Size(118, 23);
            this.btnRequestBack.TabIndex = 3;
            this.btnRequestBack.Text = "Back";
            this.btnRequestBack.UseVisualStyleBackColor = true;
            // 
            // cbxRequestSort
            // 
            this.cbxRequestSort.FormattingEnabled = true;
            this.cbxRequestSort.Location = new System.Drawing.Point(12, 486);
            this.cbxRequestSort.Name = "cbxRequestSort";
            this.cbxRequestSort.Size = new System.Drawing.Size(233, 21);
            this.cbxRequestSort.TabIndex = 4;
            // 
            // RequestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 642);
            this.Controls.Add(this.cbxRequestSort);
            this.Controls.Add(this.btnRequestBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.dgvRequestFrm);
            this.Name = "RequestFrm";
            this.Text = "RequestFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestFrm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRequestFrm;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRequestBack;
        private System.Windows.Forms.ComboBox cbxRequestSort;
    }
}