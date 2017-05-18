namespace AdministratorClient
{
    partial class AdministratorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecretaryId = new System.Windows.Forms.TextBox();
            this.txtSecretaryName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.btnAddSecretary = new System.Windows.Forms.Button();
            this.btnUpdateSecretary = new System.Windows.Forms.Button();
            this.btnViewSecretary = new System.Windows.Forms.Button();
            this.btnDeleteSecretary = new System.Windows.Forms.Button();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.btnUpdateDoctor = new System.Windows.Forms.Button();
            this.btnViewDoctor = new System.Windows.Forms.Button();
            this.btnDeleteDoctor = new System.Windows.Forms.Button();
            this.dataGridViewSecretary = new System.Windows.Forms.DataGridView();
            this.dataGridViewDoctor = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSecretaryPassword = new System.Windows.Forms.TextBox();
            this.txtDoctorPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecretary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Secretary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // txtSecretaryId
            // 
            this.txtSecretaryId.Location = new System.Drawing.Point(120, 67);
            this.txtSecretaryId.Name = "txtSecretaryId";
            this.txtSecretaryId.Size = new System.Drawing.Size(100, 20);
            this.txtSecretaryId.TabIndex = 3;
            // 
            // txtSecretaryName
            // 
            this.txtSecretaryName.Location = new System.Drawing.Point(120, 102);
            this.txtSecretaryName.Name = "txtSecretaryName";
            this.txtSecretaryName.Size = new System.Drawing.Size(100, 20);
            this.txtSecretaryName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Name";
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.Location = new System.Drawing.Point(470, 64);
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.Size = new System.Drawing.Size(100, 20);
            this.txtDoctorId.TabIndex = 9;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(470, 99);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(100, 20);
            this.txtDoctorName.TabIndex = 10;
            // 
            // btnAddSecretary
            // 
            this.btnAddSecretary.Location = new System.Drawing.Point(37, 201);
            this.btnAddSecretary.Name = "btnAddSecretary";
            this.btnAddSecretary.Size = new System.Drawing.Size(75, 23);
            this.btnAddSecretary.TabIndex = 11;
            this.btnAddSecretary.Text = "Add";
            this.btnAddSecretary.UseVisualStyleBackColor = true;
            this.btnAddSecretary.Click += new System.EventHandler(this.btnAddSecretary_Click);
            // 
            // btnUpdateSecretary
            // 
            this.btnUpdateSecretary.Location = new System.Drawing.Point(145, 201);
            this.btnUpdateSecretary.Name = "btnUpdateSecretary";
            this.btnUpdateSecretary.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSecretary.TabIndex = 12;
            this.btnUpdateSecretary.Text = "Update";
            this.btnUpdateSecretary.UseVisualStyleBackColor = true;
            this.btnUpdateSecretary.Click += new System.EventHandler(this.btnUpdateSecretary_Click);
            // 
            // btnViewSecretary
            // 
            this.btnViewSecretary.Location = new System.Drawing.Point(37, 249);
            this.btnViewSecretary.Name = "btnViewSecretary";
            this.btnViewSecretary.Size = new System.Drawing.Size(75, 23);
            this.btnViewSecretary.TabIndex = 13;
            this.btnViewSecretary.Text = "View";
            this.btnViewSecretary.UseVisualStyleBackColor = true;
            this.btnViewSecretary.Click += new System.EventHandler(this.btnViewSecretary_Click);
            // 
            // btnDeleteSecretary
            // 
            this.btnDeleteSecretary.Location = new System.Drawing.Point(145, 249);
            this.btnDeleteSecretary.Name = "btnDeleteSecretary";
            this.btnDeleteSecretary.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSecretary.TabIndex = 14;
            this.btnDeleteSecretary.Text = "Delete";
            this.btnDeleteSecretary.UseVisualStyleBackColor = true;
            this.btnDeleteSecretary.Click += new System.EventHandler(this.btnDeleteSecretary_Click);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.Location = new System.Drawing.Point(379, 201);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(75, 23);
            this.btnAddDoctor.TabIndex = 15;
            this.btnAddDoctor.Text = "Add";
            this.btnAddDoctor.UseVisualStyleBackColor = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // btnUpdateDoctor
            // 
            this.btnUpdateDoctor.Location = new System.Drawing.Point(495, 201);
            this.btnUpdateDoctor.Name = "btnUpdateDoctor";
            this.btnUpdateDoctor.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateDoctor.TabIndex = 16;
            this.btnUpdateDoctor.Text = "Update";
            this.btnUpdateDoctor.UseVisualStyleBackColor = true;
            this.btnUpdateDoctor.Click += new System.EventHandler(this.btnUpdateDoctor_Click);
            // 
            // btnViewDoctor
            // 
            this.btnViewDoctor.Location = new System.Drawing.Point(379, 249);
            this.btnViewDoctor.Name = "btnViewDoctor";
            this.btnViewDoctor.Size = new System.Drawing.Size(75, 23);
            this.btnViewDoctor.TabIndex = 17;
            this.btnViewDoctor.Text = "View";
            this.btnViewDoctor.UseVisualStyleBackColor = true;
            this.btnViewDoctor.Click += new System.EventHandler(this.btnViewDoctor_Click);
            // 
            // btnDeleteDoctor
            // 
            this.btnDeleteDoctor.Location = new System.Drawing.Point(495, 249);
            this.btnDeleteDoctor.Name = "btnDeleteDoctor";
            this.btnDeleteDoctor.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDoctor.TabIndex = 18;
            this.btnDeleteDoctor.Text = "Delete";
            this.btnDeleteDoctor.UseVisualStyleBackColor = true;
            this.btnDeleteDoctor.Click += new System.EventHandler(this.btnDeleteDoctor_Click);
            // 
            // dataGridViewSecretary
            // 
            this.dataGridViewSecretary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecretary.Location = new System.Drawing.Point(37, 309);
            this.dataGridViewSecretary.Name = "dataGridViewSecretary";
            this.dataGridViewSecretary.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewSecretary.TabIndex = 19;
            // 
            // dataGridViewDoctor
            // 
            this.dataGridViewDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctor.Location = new System.Drawing.Point(370, 309);
            this.dataGridViewDoctor.Name = "dataGridViewDoctor";
            this.dataGridViewDoctor.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewDoctor.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Password";
            // 
            // txtSecretaryPassword
            // 
            this.txtSecretaryPassword.Location = new System.Drawing.Point(120, 139);
            this.txtSecretaryPassword.Name = "txtSecretaryPassword";
            this.txtSecretaryPassword.Size = new System.Drawing.Size(100, 20);
            this.txtSecretaryPassword.TabIndex = 23;
            // 
            // txtDoctorPassword
            // 
            this.txtDoctorPassword.Location = new System.Drawing.Point(470, 139);
            this.txtDoctorPassword.Name = "txtDoctorPassword";
            this.txtDoctorPassword.Size = new System.Drawing.Size(100, 20);
            this.txtDoctorPassword.TabIndex = 24;
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 529);
            this.Controls.Add(this.txtDoctorPassword);
            this.Controls.Add(this.txtSecretaryPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewDoctor);
            this.Controls.Add(this.dataGridViewSecretary);
            this.Controls.Add(this.btnDeleteDoctor);
            this.Controls.Add(this.btnViewDoctor);
            this.Controls.Add(this.btnUpdateDoctor);
            this.Controls.Add(this.btnAddDoctor);
            this.Controls.Add(this.btnDeleteSecretary);
            this.Controls.Add(this.btnViewSecretary);
            this.Controls.Add(this.btnUpdateSecretary);
            this.Controls.Add(this.btnAddSecretary);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.txtDoctorId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSecretaryName);
            this.Controls.Add(this.txtSecretaryId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdministratorForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecretary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecretaryId;
        private System.Windows.Forms.TextBox txtSecretaryName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Button btnAddSecretary;
        private System.Windows.Forms.Button btnUpdateSecretary;
        private System.Windows.Forms.Button btnViewSecretary;
        private System.Windows.Forms.Button btnDeleteSecretary;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Button btnUpdateDoctor;
        private System.Windows.Forms.Button btnViewDoctor;
        private System.Windows.Forms.Button btnDeleteDoctor;
        private System.Windows.Forms.DataGridView dataGridViewSecretary;
        private System.Windows.Forms.DataGridView dataGridViewDoctor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSecretaryPassword;
        private System.Windows.Forms.TextBox txtDoctorPassword;
    }
}

