using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

      
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public DataTable SelectAllEmp()
        {
            string query = "SELECT * FROM Employee;";
            return dbMan.ExecuteReader(query);
        }


        public int InsertProject(string Pname, int pnumber, string Plocation, int Dnum)
        {
            string query = "INSERT INTO Project (Pname, Pnumber, Plocation, Dnum)" +
                            "Values ('" + Pname + "'," + pnumber + ",'" + Plocation + "'," + Dnum + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectDepNum()
        {
            string query= "SELECT Dnumber, Dname FROM Department;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectDepLoc()
        {
            string query = "SELECT DISTINCT Dlocation FROM Dept_Locations;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectProject(string location)
        {
            string query = "SELECT Pname,Dname FROM Department D, Project P, Dept_Locations L"
             +" where P.Dnum=D.Dnumber and L.Dnumber=D.Dnumber and L.Dlocation='"+location+"';"; 
            
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectDepName()
        {
            string query = "SELECT DISTINCT Dname FROM Department;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectProjectLoc()
        {
            string query = "SELECT DISTINCT Plocation FROM Project;";
            return dbMan.ExecuteReader(query);
        }





        //TODO:
        //Get SSN and address for all employees with salary less than 40000.
        //FunctionName "returnType" SelectAllEmployeesWithSalaryLessThan(?)
        //Make Sure to show only SSN and Address Not all columns

        //TODO:
        //Get all female employees who work in "Administration" department
        //FunctionName "returnType" GetAllGenderWorkingInDepartment(?,?)
        //Make sure to get their Names and maybe SSN only

        //TODO:
        //Get departments names for all departments located at "Houston" (1 mark)
        //FunctionName: "returnType" GetDepartmentNamesAtLocation(?)
        //Just Get the Names


        //TODO:
        //Insert a new department. (1 mark)
        //Make sure all the required fields are given and if any important Field missing, give the user appropriate message


        //(To be delivered next lab)
        //
        //TODO:
        //5-Get employees names and salaries for all employees 
        //who work in a project located at "Stafford" or in "Houston" 
        //and work less than 35 hours. (1 marks)

        //6- Allow user to update salary of an employee of a certain SSN. (1 mark)
        //7-Get the last names of department managers and their salaries. (1 mark)
        //8-Get Name and SSN for all employees working in "Research" department or working on projects controlled by "Research" department. (2 marks)
        //9-Get maximum, minimum and average salary for employees(1 mark)



        public DataTable GetManagers() // 7
        {

            string query = "SELECT LNAME,SALARY FROM Employee,Department WHERE Employee.SSN = Department.Mgr_SSN";

            return dbMan.ExecuteReader(query);

        }


        public DataTable GetEmployee123(string Department)  // 8
        {
            string query = "SELECT DISTINCT Fname , SSN FROM Employee, Department, Project, Works_On WHERE(Employee.Dno = Department.Dnumber AND Department.Dname = '" + Department + "') OR(Works_On.Essn = Employee.SSN AND Works_On.Pno = Project.Pnumber AND Project.Dnum = Department.Dnumber AND Department.Dname = '" + Department+ "')";

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetMMA() //9
        {
            string query = "SELECT AVG(SALARY),MAX(SALARY),MIN(SALARY) FROM Employee";

            return dbMan.ExecuteReader(query);
        }


    }
}
