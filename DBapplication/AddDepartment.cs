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
    public partial class AddDepartment : Form
    {
        Controller controllerObj;

        public AddDepartment()
        {
            InitializeComponent();
            controllerObj = new Controller();

            //Data For manager selection
            DataTable dt = controllerObj.SelectAllSSN();
            Manager.DataSource = dt;
            Manager.DisplayMember = "SSN";
        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {

        }

        private void Manager_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(name.Text=="" || number.Text=="" || StartDate.Text=="")
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                StringBuilder err = new StringBuilder();
                Object DNO = ValidationClass.isPositiveInteger(number.Text, err);
                if(DNO==null)
                {
                    MessageBox.Show("Some inputs has incorrect values " + err.ToString());
                }
                else
                {
                    int r = controllerObj.InsertDepartment(name.Text, Int16.Parse(number.Text) , Manager.Text, StartDate.Text);
                    
                    if(r !=0)
                        MessageBox.Show("Department inserted successfully");
                    else
                        MessageBox.Show("Invalid Inputs");

                }
            }
        }
    }
}
