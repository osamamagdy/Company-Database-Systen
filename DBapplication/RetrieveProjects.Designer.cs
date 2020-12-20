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
            this.Execute = new System.Windows.Forms.Button();
            this.Selector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.Dep_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.NumericUpDown();
            this.Q8 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Q1 = new System.Windows.Forms.GroupBox();
            this.Q2 = new System.Windows.Forms.GroupBox();
            this.Q3 = new System.Windows.Forms.GroupBox();
            this.Q5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).BeginInit();
            this.Gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).BeginInit();
            this.Q8.SuspendLayout();
            this.Q1.SuspendLayout();
            this.Q2.SuspendLayout();
            this.Q3.SuspendLayout();
            this.Q5.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 50);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
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
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1115, 256);
            this.dataGridView1.TabIndex = 2;
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(168, 180);
            this.Execute.Margin = new System.Windows.Forms.Padding(4);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(100, 28);
            this.Execute.TabIndex = 3;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Selector
            // 
            this.Selector.FormattingEnabled = true;
            this.Selector.Items.AddRange(new object[] {
            "Employees with Salary less than",
            "Gender Working in Department",
            "Deparment names at Location",
            "Working in projects with Hours",
            "All Department Managers",
            "Employee serving a Department",
            "Salary Statistics"});
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
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(74, 30);
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
            this.label4.Location = new System.Drawing.Point(7, 30);
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
            this.Gender.Location = new System.Drawing.Point(261, 35);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(238, 100);
            this.Gender.TabIndex = 12;
            this.Gender.TabStop = false;
            this.Gender.Text = "Gender";
            this.Gender.Enter += new System.EventHandler(this.Gender_Enter);
            // 
            // Dep_comboBox
            // 
            this.Dep_comboBox.FormattingEnabled = true;
            this.Dep_comboBox.Location = new System.Drawing.Point(73, 61);
            this.Dep_comboBox.Name = "Dep_comboBox";
            this.Dep_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Dep_comboBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Department";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(130, 60);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 15;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.Project_Loc_comboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Work Hours :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Hours
            // 
            this.Hours.Location = new System.Drawing.Point(131, 103);
            this.Hours.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(120, 22);
            this.Hours.TabIndex = 17;
            // 
            // Q8
            // 
            this.Q8.Controls.Add(this.label6);
            this.Q8.Controls.Add(this.comboBox4);
            this.Q8.Location = new System.Drawing.Point(733, 45);
            this.Q8.Name = "Q8";
            this.Q8.Size = new System.Drawing.Size(395, 163);
            this.Q8.TabIndex = 19;
            this.Q8.TabStop = false;
            this.Q8.Text = "Select Department";
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
            // Q1
            // 
            this.Q1.Controls.Add(this.label4);
            this.Q1.Controls.Add(this.Salary);
            this.Q1.Location = new System.Drawing.Point(468, 45);
            this.Q1.Name = "Q1";
            this.Q1.Size = new System.Drawing.Size(200, 100);
            this.Q1.TabIndex = 22;
            this.Q1.TabStop = false;
            this.Q1.Text = "Select max Salary";
            // 
            // Q2
            // 
            this.Q2.Controls.Add(this.Gender);
            this.Q2.Controls.Add(this.label5);
            this.Q2.Controls.Add(this.Dep_comboBox);
            this.Q2.Location = new System.Drawing.Point(429, 214);
            this.Q2.Name = "Q2";
            this.Q2.Size = new System.Drawing.Size(555, 146);
            this.Q2.TabIndex = 23;
            this.Q2.TabStop = false;
            this.Q2.Text = "Select Gender & Department";
            // 
            // Q3
            // 
            this.Q3.Controls.Add(this.comboBox1);
            this.Q3.Controls.Add(this.label1);
            this.Q3.Location = new System.Drawing.Point(1160, 45);
            this.Q3.Name = "Q3";
            this.Q3.Size = new System.Drawing.Size(324, 100);
            this.Q3.TabIndex = 24;
            this.Q3.TabStop = false;
            this.Q3.Text = "Select Department Location";
            // 
            // Q5
            // 
            this.Q5.Controls.Add(this.comboBox3);
            this.Q5.Controls.Add(this.label8);
            this.Q5.Controls.Add(this.label3);
            this.Q5.Controls.Add(this.comboBox2);
            this.Q5.Controls.Add(this.label7);
            this.Q5.Controls.Add(this.Hours);
            this.Q5.Location = new System.Drawing.Point(1007, 215);
            this.Q5.Name = "Q5";
            this.Q5.Size = new System.Drawing.Size(449, 149);
            this.Q5.TabIndex = 25;
            this.Q5.TabStop = false;
            this.Q5.Text = "Select Project Locations and Working Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Project Location";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(131, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "or";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(287, 42);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 22;
            // 
            // RetrieveProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 772);
            this.Controls.Add(this.Q5);
            this.Controls.Add(this.Q3);
            this.Controls.Add(this.Q2);
            this.Controls.Add(this.Q1);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Q8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Selector);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RetrieveProjects";
            this.Text = "Retrieve Projects";
            this.Load += new System.EventHandler(this.RetrieveProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).EndInit();
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).EndInit();
            this.Q8.ResumeLayout(false);
            this.Q8.PerformLayout();
            this.Q1.ResumeLayout(false);
            this.Q1.PerformLayout();
            this.Q2.ResumeLayout(false);
            this.Q2.PerformLayout();
            this.Q3.ResumeLayout(false);
            this.Q3.PerformLayout();
            this.Q5.ResumeLayout(false);
            this.Q5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.ComboBox Selector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Salary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.ComboBox Dep_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Hours;
        private System.Windows.Forms.GroupBox Q8;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox Q1;
        private System.Windows.Forms.GroupBox Q2;
        private System.Windows.Forms.GroupBox Q3;
        private System.Windows.Forms.GroupBox Q5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}