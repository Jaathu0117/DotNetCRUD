﻿namespace WindowsFormsApp1
{
    partial class DBConnection
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
            this.btnTest = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnGetAllStudents = new System.Windows.Forms.Button();
            this.stuTable = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btngetStudent = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.comGrade = new System.Windows.Forms.ComboBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stuTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(1140, 52);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(236, 48);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test Connection";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(564, 52);
            this.btn.Margin = new System.Windows.Forms.Padding(4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(276, 48);
            this.btn.TabIndex = 0;
            this.btn.Text = "Student";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnGetAllStudents
            // 
            this.btnGetAllStudents.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAllStudents.Location = new System.Drawing.Point(28, 52);
            this.btnGetAllStudents.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetAllStudents.Name = "btnGetAllStudents";
            this.btnGetAllStudents.Size = new System.Drawing.Size(236, 48);
            this.btnGetAllStudents.TabIndex = 0;
            this.btnGetAllStudents.Text = "Get All Students";
            this.btnGetAllStudents.UseVisualStyleBackColor = true;
            this.btnGetAllStudents.Click += new System.EventHandler(this.btnGetAllStudents_Click);
            // 
            // stuTable
            // 
            this.stuTable.AllowUserToAddRows = false;
            this.stuTable.AllowUserToDeleteRows = false;
            this.stuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stuTable.Location = new System.Drawing.Point(28, 129);
            this.stuTable.Margin = new System.Windows.Forms.Padding(4);
            this.stuTable.MultiSelect = false;
            this.stuTable.Name = "stuTable";
            this.stuTable.RowHeadersWidth = 82;
            this.stuTable.RowTemplate.Height = 33;
            this.stuTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stuTable.Size = new System.Drawing.Size(1348, 612);
            this.stuTable.TabIndex = 1;
            this.stuTable.SelectionChanged += new System.EventHandler(this.stuTable_SelectionChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(668, 769);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(224, 48);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create ";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1152, 769);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(224, 48);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btngetStudent
            // 
            this.btngetStudent.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetStudent.Location = new System.Drawing.Point(296, 52);
            this.btngetStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btngetStudent.Name = "btngetStudent";
            this.btngetStudent.Size = new System.Drawing.Size(236, 48);
            this.btngetStudent.TabIndex = 0;
            this.btngetStudent.Text = "Get Student";
            this.btngetStudent.UseVisualStyleBackColor = true;
            this.btngetStudent.Click += new System.EventHandler(this.btngetStudent_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(916, 769);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(224, 48);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(872, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Data Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(418, 769);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(224, 48);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(1741, 521);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(148, 48);
            this.btnSubmit.TabIndex = 30;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // comGrade
            // 
            this.comGrade.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comGrade.FormattingEnabled = true;
            this.comGrade.Items.AddRange(new object[] {
            "10A",
            "10B",
            "10C",
            "11A",
            "11B",
            "11C"});
            this.comGrade.Location = new System.Drawing.Point(1581, 315);
            this.comGrade.Margin = new System.Windows.Forms.Padding(6);
            this.comGrade.Name = "comGrade";
            this.comGrade.Size = new System.Drawing.Size(308, 45);
            this.comGrade.TabIndex = 28;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFemale.Location = new System.Drawing.Point(1737, 256);
            this.radioFemale.Margin = new System.Windows.Forms.Padding(6);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(153, 41);
            this.radioFemale.TabIndex = 27;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMale.Location = new System.Drawing.Point(1581, 254);
            this.radioMale.Margin = new System.Windows.Forms.Padding(6);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(119, 41);
            this.radioMale.TabIndex = 26;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(1581, 388);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(308, 104);
            this.txtAddress.TabIndex = 29;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(1581, 192);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(308, 45);
            this.txtLastName.TabIndex = 25;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(1581, 131);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(308, 45);
            this.txtFirstName.TabIndex = 24;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(1409, 413);
            this.Address.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(138, 37);
            this.Address.TabIndex = 20;
            this.Address.Text = "Address";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(1401, 256);
            this.Gender.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(125, 37);
            this.Gender.TabIndex = 21;
            this.Gender.Text = "Gender";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(1401, 192);
            this.LastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(163, 37);
            this.LastName.TabIndex = 22;
            this.LastName.Text = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(1401, 137);
            this.FirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(171, 37);
            this.FirstName.TabIndex = 23;
            this.FirstName.Text = "FirstName";
            // 
            // DBConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2447, 840);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.comGrade);
            this.Controls.Add(this.radioFemale);
            this.Controls.Add(this.radioMale);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.stuTable);
            this.Controls.Add(this.btngetStudent);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnGetAllStudents);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnTest);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DBConnection";
            this.Text = "DBConnection";
            ((System.ComponentModel.ISupportInitialize)(this.stuTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnGetAllStudents;
        private System.Windows.Forms.DataGridView stuTable;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btngetStudent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox comGrade;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
    }
}

