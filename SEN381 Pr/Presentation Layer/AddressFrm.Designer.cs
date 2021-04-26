namespace SEN381_Pr
{
    partial class AddressFrm
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
            this.dgvAddress = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddressID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvAddress);
            this.panel1.Location = new System.Drawing.Point(9, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 516);
            this.panel1.TabIndex = 0;
            // 
            // dgvAddress
            // 
            this.dgvAddress.BackgroundColor = System.Drawing.Color.White;
            this.dgvAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddress.GridColor = System.Drawing.Color.White;
            this.dgvAddress.Location = new System.Drawing.Point(14, 15);
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.Size = new System.Drawing.Size(360, 486);
            this.dgvAddress.TabIndex = 0;
            this.dgvAddress.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddress_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(9, 529);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(213, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(9, 569);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(213, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(228, 529);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(213, 34);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(447, 529);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(213, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.txtCountry);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtAddressID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtCity);
            this.panel2.Controls.Add(this.txtPostalCode);
            this.panel2.Controls.Add(this.txtStreet);
            this.panel2.Location = new System.Drawing.Point(400, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 515);
            this.panel2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(16, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(229, 3);
            this.textBox1.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Address ID";
            // 
            // txtAddressID
            // 
            this.txtAddressID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddressID.Location = new System.Drawing.Point(16, 31);
            this.txtAddressID.Multiline = true;
            this.txtAddressID.Name = "txtAddressID";
            this.txtAddressID.Size = new System.Drawing.Size(229, 20);
            this.txtAddressID.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Postal Code";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(16, 231);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(229, 3);
            this.textBox9.TabIndex = 30;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(16, 167);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(229, 3);
            this.textBox8.TabIndex = 29;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(16, 94);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(229, 3);
            this.textBox7.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Street";
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Location = new System.Drawing.Point(16, 214);
            this.txtCity.Multiline = true;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(229, 20);
            this.txtCity.TabIndex = 26;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPostalCode.Location = new System.Drawing.Point(16, 150);
            this.txtPostalCode.Multiline = true;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(229, 20);
            this.txtPostalCode.TabIndex = 25;
            // 
            // txtStreet
            // 
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStreet.Location = new System.Drawing.Point(16, 77);
            this.txtStreet.Multiline = true;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(229, 20);
            this.txtStreet.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Country";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(16, 291);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(229, 3);
            this.textBox2.TabIndex = 37;
            // 
            // txtCountry
            // 
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCountry.Location = new System.Drawing.Point(16, 274);
            this.txtCountry.Multiline = true;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(229, 20);
            this.txtCountry.TabIndex = 36;
            // 
            // AddressFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(669, 613);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddressFrm";
            this.Text = "AddressFrm";
            this.Load += new System.EventHandler(this.AddressFrm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddressID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtStreet;
    }
}