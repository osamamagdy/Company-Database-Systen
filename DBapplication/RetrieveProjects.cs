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
            Execute.Visible = false;
            Q1.Visible = false;
            Q2.Visible = false;
            Q3.Visible = false;
            Q5.Visible = false;
            Q8.Visible = false;
            controllerObj = new Controller();

            DataTable dt;

            //Data for Q2 Combobox
            dt = controllerObj.SelectDepName();
            Dep_comboBox.DataSource = dt;
            Dep_comboBox.DisplayMember = "Dname";

            //Data for Q3 Combobox
            dt = controllerObj.SelectDepLoc();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Dlocation";

            //Data for Q5 Combobox
            dt = controllerObj.SelectProjectLoc();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Plocation";
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "Plocation";

            //Data for Q8 Combobox
            dt = controllerObj.SelectDepName();
            comboBox4.DataSource = dt;
            comboBox4.DisplayMember = "Dname";


        }
        private void RetrieveProjects_Load(object sender, EventArgs e)
        {
           
            
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            if (Selector.SelectedIndex==0)
            {

                int s = Convert.ToInt32(Salary.Value);
                
                 DataTable d= controllerObj.show_employees_by_salary(s);

                dataGridView1.DataSource = d;
                dataGridView1.Refresh();
            }
            else if(Selector.SelectedIndex == 1)
            {

                string gen;
                if (Female.Checked&& !Male.Checked)
                    gen = "F";
                else if(Male.Checked&&!Female.Checked)
                {

                    gen = "M";
                }
                else if(!Male.Checked && !Female.Checked)
                {
                    MessageBox.Show("Please Select the Gender");
                    return;

                }
                else
                {
                    return;
                }

                string dep = Dep_comboBox.Text;
                 DataTable d= controllerObj.show_Employees_by_gender_in_Dep(gen, dep);
                dataGridView1.DataSource = d;
                dataGridView1.Refresh();

            }
            else if(Selector.SelectedIndex == 2)
            {
                string Dp = comboBox1.Text;
                DataTable d = controllerObj.Get_departments_names(Dp);

                dataGridView1.DataSource = d;
                dataGridView1.Refresh();
            }

            if (Selector.SelectedIndex == 4)
            {
                DataTable dt = controllerObj.GetManagers();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }

            if (Selector.SelectedIndex == 5)
            {
                DataTable dt = controllerObj.GetEmployee123(comboBox4.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            if (Selector.SelectedIndex == 6)
            {
               DataTable dt = controllerObj.GetMMA();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "AVG";
                dataGridView1.Columns[1].HeaderText = "MAX";
                dataGridView1.Columns[2].HeaderText = "MIN";

                dataGridView1.Refresh();
            }
          

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

            switch(Selector.SelectedIndex)
            {
                case 0:

                    Execute.Visible = true;
                    Q1.Visible = true;
                    Q2.Visible = false;
                    Q3.Visible = false;
                    Q5.Visible = false;
                    Q8.Visible = false;

                    break;
                case 1:

                    Execute.Visible = true;
                    Q1.Visible = false;
                    Q2.Visible = true;
                    Q3.Visible = false;
                    Q5.Visible = false;
                    Q8.Visible = false;

                    break;
                case 2:

                    Execute.Visible = true;
                    Q1.Visible = false;
                    Q2.Visible = false;
                    Q3.Visible = true;
                    Q5.Visible = false;
                    Q8.Visible = false;

                    break;
                case 3:

                    Execute.Visible = true;
                    Q1.Visible = false;
                    Q2.Visible = false;
                    Q3.Visible = false;
                    Q5.Visible = true;
                    Q8.Visible = false;

                    break;
                case 4:

                    Execute.Visible = true;
                    Q1.Visible = false;
                    Q2.Visible = false;
                    Q3.Visible = false;
                    Q5.Visible = false;
                    Q8.Visible = false;

                    break;
                case 5:

                    Execute.Visible = true;
                    Q1.Visible = false;
                    Q2.Visible = false;
                    Q3.Visible = false;
                    Q5.Visible = false;
                    Q8.Visible = true;

                    break;
                case 6:

                    Execute.Visible = true;
                    Q1.Visible = false;
                    Q2.Visible = false;
                    Q3.Visible = false;
                    Q5.Visible = false;
                    Q8.Visible = false;

                    break;
                default:
                    Execute.Visible = false;
                    Q1.Visible = false;
                    Q2.Visible = false;
                    Q3.Visible = false;
                    Q5.Visible = false;
                    Q8.Visible = false;

                    break;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Execute1_Click(object sender, EventArgs e)
        {
            

        }

        private void Gender_Enter(object sender, EventArgs e)
        {

        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Dep_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
