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
    public partial class UpdateSalary : Form
    {
        Controller controllerObj;
        public UpdateSalary()
        {
            InitializeComponent();

            controllerObj = new Controller();

            //Data For manager selection
            DataTable dt = controllerObj.SelectAllSSN();
            SSN.DataSource = dt;
            SSN.DisplayMember = "SSN";
        }

        private void UpdateSalary_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SSN.Text == "" || Salary.Text == "")
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                StringBuilder err = new StringBuilder();
                Object DNO = ValidationClass.isPositiveInteger(Salary.Text, err);
                if (DNO == null)
                {
                    MessageBox.Show("Some inputs has incorrect values " + err.ToString());
                }
                else
                {
                    int r = controllerObj.UpdateSalary(Convert.ToInt32(Salary.Value), SSN.Text);
                    if (r > 0)
                        MessageBox.Show("Salary Updated successfully");
                    else
                        MessageBox.Show("Invalid Inputs");

                }
            }
        }
    }
}
