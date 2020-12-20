namespace DBapplication
{
    partial class RetrieveProjects
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Execute2 = new System.Windows.Forms.Button();
            this.Selector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.Dep_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Project_Loc_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.NumericUpDown();
            this.Employee_Conditions = new System.Windows.Forms.GroupBox();
            this.Department_Conditions = new System.Windows.Forms.GroupBox();
            this.Is_Manager = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Execute1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).BeginInit();
            this.Gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).BeginInit();
            this.Employee_Conditions.SuspendLayout();
            this.Department_Conditions.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(184, 52);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department Location";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 503);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1115, 256);
            this.dataGridView1.TabIndex = 2;
            // 
            // Execute2
            // 
            this.Execute2.Location = new System.Drawing.Point(648, 162);
            this.Execute2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Execute2.Name = "Execute2";
            this.Execute2.Size = new System.Drawing.Size(100, 28);
            this.Execute2.TabIndex = 3;
            this.Execute2.Text = "Execute";
            this.Execute2.UseVisualStyleBackColor = true;
            this.Execute2.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Selector
            // 
            this.Selector.FormattingEnabled = true;
            this.Selector.Items.AddRange(new object[] {
            "Employees",
            "Department"});
            this.Selector.Location = new System.Drawing.Point(168, 90);
            this.Selector.Name = "Selector";
            this.Selector.Size = new System.Drawing.Size(228, 24);
            this.Selector.TabIndex = 4;
            this.Selector.SelectedIndexChanged += new System.EventHandler(this.Selector_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Get Data About";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Condition:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(130, 21);
            this.Salary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(120, 22);
            this.Salary.TabIndex = 7;
            this.Salary.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salary :";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(6, 48);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(59, 21);
            this.Male.TabIndex = 10;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(6, 21);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(75, 21);
            this.Female.TabIndex = 11;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.Female);
            this.Gender.Controls.Add(this.Male);
            this.Gender.Location = new System.Drawing.Point(325, 63);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(238, 100);
            this.Gender.TabIndex = 12;
            this.Gender.TabStop = false;
            this.Gender.Text = "Gender";
            // 
            // Dep_comboBox
            // 
            this.Dep_comboBox.FormattingEnabled = true;
            this.Dep_comboBox.Location = new System.Drawing.Point(443, 20);
            this.Dep_comboBox.Name = "Dep_comboBox";
            this.Dep_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Dep_comboBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Department";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Project_Loc_comboBox
            // 
            this.Project_Loc_comboBox.FormattingEnabled = true;
            this.Project_Loc_comboBox.Location = new System.Drawing.Point(130, 60);
            this.Project_Loc_comboBox.Name = "Project_Loc_comboBox";
            this.Project_Loc_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Project_Loc_comboBox.TabIndex = 15;
            this.Project_Loc_comboBox.SelectedIndexChanged += new System.EventHandler(this.Project_Loc_comboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Project Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Work Hours :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Hours
            // 
            this.Hours.Location = new System.Drawing.Point(130, 136);
            this.Hours.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(120, 22);
            this.Hours.TabIndex = 17;
            // 
            // Employee_Conditions
            // 
            this.Employee_Conditions.Controls.Add(this.Is_Manager);
            this.Employee_Conditions.Controls.Add(this.Salary);
            this.Employee_Conditions.Controls.Add(this.Gender);
            this.Employee_Conditions.Controls.Add(this.label7);
            this.Employee_Conditions.Controls.Add(this.label4);
            this.Employee_Conditions.Controls.Add(this.Hours);
            this.Employee_Conditions.Controls.Add(this.Execute2);
            this.Employee_Conditions.Controls.Add(this.Dep_comboBox);
            this.Employee_Conditions.Controls.Add(this.label6);
            this.Employee_Conditions.Controls.Add(this.Project_Loc_comboBox);
            this.Employee_Conditions.Controls.Add(this.label5);
            this.Employee_Conditions.Location = new System.Drawing.Point(483, 195);
            this.Employee_Conditions.Name = "Employee_Conditions";
            this.Employee_Conditions.Size = new System.Drawing.Size(755, 205);
            this.Employee_Conditions.TabIndex = 19;
            this.Employee_Conditions.TabStop = false;
            this.Employee_Conditions.Text = "Employee";
            // 
            // Department_Conditions
            // 
            this.Department_Conditions.Controls.Add(this.Execute1);
            this.Department_Conditions.Controls.Add(this.label1);
            this.Department_Conditions.Controls.Add(this.comboBox1);
            this.Department_Conditions.Location = new System.Drawing.Point(12, 195);
            this.Department_Conditions.Name = "Department_Conditions";
            this.Department_Conditions.Size = new System.Drawing.Size(465, 123);
            this.Department_Conditions.TabIndex = 20;
            this.Department_Conditions.TabStop = false;
            this.Department_Conditions.Text = "Department";
            // 
            // Is_Manager
            // 
            this.Is_Manager.AutoSize = true;
            this.Is_Manager.Location = new System.Drawing.Point(331, 169);
            this.Is_Manager.Name = "Is_Manager";
            this.Is_Manager.Size = new System.Drawing.Size(104, 21);
            this.Is_Manager.TabIndex = 19;
            this.Is_Manager.Text = "Is_Manager";
            this.Is_Manager.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "SSN",
            "Address",
            "Name",
            "Salary",
            "Last Name"});
            this.checkedListBox1.Location = new System.Drawing.Point(1135, 503);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(202, 106);
            this.checkedListBox1.TabIndex = 21;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Execute1
            // 
            this.Execute1.Location = new System.Drawing.Point(358, 88);
            this.Execute1.Margin = new System.Windows.Forms.Padding(4);
            this.Execute1.Name = "Execute1";
            this.Execute1.Size = new System.Drawing.Size(100, 28);
            this.Execute1.TabIndex = 22;
            this.Execute1.Text = "Execute";
            this.Execute1.UseVisualStyleBackColor = true;
            this.Execute1.Click += new System.EventHandler(this.Execute1_Click);
            // 
            // RetrieveProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 772);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Department_Conditions);
            this.Controls.Add(this.Employee_Conditions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Selector);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RetrieveProjects";
            this.Text = "Retrieve Projects";
            this.Load += new System.EventHandler(this.RetrieveProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).EndInit();
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).EndInit();
            this.Employee_Conditions.ResumeLayout(false);
            this.Employee_Conditions.PerformLayout();
            this.Department_Conditions.ResumeLayout(false);
            this.Department_Conditions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Execute2;
        private System.Windows.Forms.ComboBox Selector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Salary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.ComboBox Dep_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Project_Loc_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Hours;
        private System.Windows.Forms.GroupBox Employee_Conditions;
        private System.Windows.Forms.CheckBox Is_Manager;
        private System.Windows.Forms.GroupBox Department_Conditions;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button Execute1;
    }
}