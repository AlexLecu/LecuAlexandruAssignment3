namespace SecretaryClient
{
    partial class SecretaryForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdentityCardNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPersonalNumericalCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreateConsultation = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConsultationId = new System.Windows.Forms.TextBox();
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.txtPatientIdentityCardNumber = new System.Windows.Forms.TextBox();
            this.btnUpdateConsultation = new System.Windows.Forms.Button();
            this.btnDeleteConsultation = new System.Windows.Forms.Button();
            this.btnViewConsultation = new System.Windows.Forms.Button();
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(194, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 197);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show ";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IdentityCardNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PersonalNumericalCode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "BirthDate";
            // 
            // txtIdentityCardNumber
            // 
            this.txtIdentityCardNumber.Location = new System.Drawing.Point(452, 17);
            this.txtIdentityCardNumber.Name = "txtIdentityCardNumber";
            this.txtIdentityCardNumber.Size = new System.Drawing.Size(100, 20);
            this.txtIdentityCardNumber.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(452, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtPersonalNumericalCode
            // 
            this.txtPersonalNumericalCode.Location = new System.Drawing.Point(452, 81);
            this.txtPersonalNumericalCode.Name = "txtPersonalNumericalCode";
            this.txtPersonalNumericalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPersonalNumericalCode.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(452, 110);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 10;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(385, 149);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthDate.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(288, 196);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Patient";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(411, 195);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update Patient";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreateConsultation
            // 
            this.btnCreateConsultation.Location = new System.Drawing.Point(475, 236);
            this.btnCreateConsultation.Name = "btnCreateConsultation";
            this.btnCreateConsultation.Size = new System.Drawing.Size(131, 23);
            this.btnCreateConsultation.TabIndex = 14;
            this.btnCreateConsultation.Text = "Create consultation";
            this.btnCreateConsultation.UseVisualStyleBackColor = true;
            this.btnCreateConsultation.Click += new System.EventHandler(this.btnCreateConsultation_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Appointment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Doctor Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Patient IdentityCardNumber";
            // 
            // txtConsultationId
            // 
            this.txtConsultationId.Location = new System.Drawing.Point(229, 239);
            this.txtConsultationId.Name = "txtConsultationId";
            this.txtConsultationId.Size = new System.Drawing.Size(100, 20);
            this.txtConsultationId.TabIndex = 19;
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.Location = new System.Drawing.Point(229, 303);
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.Size = new System.Drawing.Size(100, 20);
            this.txtDoctorId.TabIndex = 21;
            // 
            // txtPatientIdentityCardNumber
            // 
            this.txtPatientIdentityCardNumber.Location = new System.Drawing.Point(229, 330);
            this.txtPatientIdentityCardNumber.Name = "txtPatientIdentityCardNumber";
            this.txtPatientIdentityCardNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPatientIdentityCardNumber.TabIndex = 22;
            // 
            // btnUpdateConsultation
            // 
            this.btnUpdateConsultation.Location = new System.Drawing.Point(475, 272);
            this.btnUpdateConsultation.Name = "btnUpdateConsultation";
            this.btnUpdateConsultation.Size = new System.Drawing.Size(131, 23);
            this.btnUpdateConsultation.TabIndex = 23;
            this.btnUpdateConsultation.Text = "Update Consultation";
            this.btnUpdateConsultation.UseVisualStyleBackColor = true;
            this.btnUpdateConsultation.Click += new System.EventHandler(this.btnUpdateConsultation_Click);
            // 
            // btnDeleteConsultation
            // 
            this.btnDeleteConsultation.Location = new System.Drawing.Point(475, 306);
            this.btnDeleteConsultation.Name = "btnDeleteConsultation";
            this.btnDeleteConsultation.Size = new System.Drawing.Size(131, 23);
            this.btnDeleteConsultation.TabIndex = 24;
            this.btnDeleteConsultation.Text = "Delete Consultation";
            this.btnDeleteConsultation.UseVisualStyleBackColor = true;
            this.btnDeleteConsultation.Click += new System.EventHandler(this.btnDeleteConsultation_Click);
            // 
            // btnViewConsultation
            // 
            this.btnViewConsultation.Location = new System.Drawing.Point(475, 407);
            this.btnViewConsultation.Name = "btnViewConsultation";
            this.btnViewConsultation.Size = new System.Drawing.Size(131, 23);
            this.btnViewConsultation.TabIndex = 25;
            this.btnViewConsultation.Text = "View Consultations";
            this.btnViewConsultation.UseVisualStyleBackColor = true;
            this.btnViewConsultation.Click += new System.EventHandler(this.btnViewConsultation_Click);
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.Location = new System.Drawing.Point(229, 271);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.Size = new System.Drawing.Size(200, 20);
            this.dtpAppointment.TabIndex = 26;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(60, 382);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(387, 68);
            this.dataGridView2.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 462);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dtpAppointment);
            this.Controls.Add(this.btnViewConsultation);
            this.Controls.Add(this.btnDeleteConsultation);
            this.Controls.Add(this.btnUpdateConsultation);
            this.Controls.Add(this.txtPatientIdentityCardNumber);
            this.Controls.Add(this.txtDoctorId);
            this.Controls.Add(this.txtConsultationId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCreateConsultation);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPersonalNumericalCode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtIdentityCardNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdentityCardNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPersonalNumericalCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreateConsultation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtConsultationId;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.TextBox txtPatientIdentityCardNumber;
        private System.Windows.Forms.Button btnUpdateConsultation;
        private System.Windows.Forms.Button btnDeleteConsultation;
        private System.Windows.Forms.Button btnViewConsultation;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

