using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class RetrieveProjects : Form
    {
        Controller controllerObj;

        string condition;
        public RetrieveProjects()
        {
            InitializeComponent();
            Execute2.Visible = false;
            Department_Conditions.Visible = false;
            Employee_Conditions.Visible = false;
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectDepLoc();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Dlocation";
           
        }
        private void RetrieveProjects_Load(object sender, EventArgs e)
        {
           
            
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectProject(comboBox1.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(Salary.Value>0)
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Project_Loc_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Selector.SelectedIndex == 0)
            {
                Execute2.Visible = true;
                Employee_Conditions.Visible = true;
                Department_Conditions.Visible = false;
            }
            else if (Selector.SelectedIndex == 1)
            {
                Execute2.Visible = true;
                Department_Conditions.Visible = true;
                Employee_Conditions.Visible = false;
            }
            else
            {
                Execute2.Visible = false;
                Department_Conditions.Visible = false;
                Employee_Conditions.Visible = false;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Execute1_Click(object sender, EventArgs e)
        {

        }
    }
}
