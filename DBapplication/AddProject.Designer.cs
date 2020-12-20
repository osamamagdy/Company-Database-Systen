namespace DBapplication
{
    partial class AddProject
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
            this.label4 = new System.Windows.Forms.Label();
            this.ProjectName_textBox = new System.Windows.Forms.TextBox();
            this.ProjectNo_textBox = new System.Windows.Forms.TextBox();
            this.ProjectLocation_textBox = new System.Windows.Forms.TextBox();
            this.DepartmentNo_ComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department name";
            // 
            // ProjectName_textBox
            // 
            this.ProjectName_textBox.Location = new System.Drawing.Point(255, 53);
            this.ProjectName_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProjectName_textBox.Name = "ProjectName_textBox";
            this.ProjectName_textBox.Size = new System.Drawing.Size(132, 22);
            this.ProjectName_textBox.TabIndex = 4;
            // 
            // ProjectNo_textBox
            // 
            this.ProjectNo_textBox.Location = new System.Drawing.Point(255, 101);
            this.ProjectNo_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProjectNo_textBox.Name = "ProjectNo_textBox";
            this.ProjectNo_textBox.Size = new System.Drawing.Size(132, 22);
            this.ProjectNo_textBox.TabIndex = 5;
            // 
            // ProjectLocation_textBox
            // 
            this.ProjectLocation_textBox.Location = new System.Drawing.Point(255, 153);
            this.ProjectLocation_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProjectLocation_textBox.Name = "ProjectLocation_textBox";
            this.ProjectLocation_textBox.Size = new System.Drawing.Size(132, 22);
            this.ProjectLocation_textBox.TabIndex = 6;
            // 
            // DepartmentNo_ComboBox
            // 
            this.DepartmentNo_ComboBox.FormattingEnabled = true;
            this.DepartmentNo_ComboBox.Location = new System.Drawing.Point(244, 214);
            this.DepartmentNo_ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.DepartmentNo_ComboBox.Name = "DepartmentNo_ComboBox";
            this.DepartmentNo_ComboBox.Size = new System.Drawing.Size(160, 24);
            this.DepartmentNo_ComboBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 309);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DepartmentNo_ComboBox);
            this.Controls.Add(this.ProjectLocation_textBox);
            this.Controls.Add(this.ProjectNo_textBox);
            this.Controls.Add(this.ProjectName_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProject";
            this.Text = "Add Project";
            this.Load += new System.EventHandler(this.AddProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProjectName_textBox;
        private System.Windows.Forms.TextBox ProjectNo_textBox;
        private System.Windows.Forms.TextBox ProjectLocation_textBox;
        private System.Windows.Forms.ComboBox DepartmentNo_ComboBox;
        private System.Windows.Forms.Button button1;
    }
}