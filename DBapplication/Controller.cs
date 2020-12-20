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

        public DataTable SelectAllSSN()
        {
            string query = "SELECT SSN FROM Employee;";
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

        public DataTable show_employees_by_salary(int salary)
        {

            string query = "SELECT SSN,Address FROM Employee where Salary<" + salary + ";";
            return dbMan.ExecuteReader(query);


        }
        //TODO:
        //Get all female employees who work in "Administration" department
        //FunctionName "returnType" GetAllGenderWorkingInDepartment(?,?)
        //Make sure to get their Names and maybe SSN only
        public DataTable show_Employees_by_gender_in_Dep(string gender,string Dep)
        {
            string query = "SELECT Fname,Minit,Lname,SSN FROM Employee,Department  Where Dno=Dnumber and Sex='"+ gender + "' and Dname='" + Dep + "' ;";


            return dbMan.ExecuteReader(query);

        }


        //TODO:
        //Get departments names for all departments located at "Houston" (1 mark)
        //FunctionName: "returnType" GetDepartmentNamesAtLocation(?)
        //Just Get the Names

        public DataTable Get_departments_names(string name)
        {



            string query = "SELECT Dname from Department as D,Dept_Locations as L where D.Dnumber=L.Dnumber and L.Dlocation='"+ name + "'; ";


            return dbMan.ExecuteReader(query);
        }

        //TODO:
        //Insert a new department. (1 mark)
        //Make sure all the required fields are given and if any important Field missing, give the user appropriate message
        public int InsertDepartment(string name, int number, string SSN, string Date)
        {
            string query = "insert into Department values " +
                            " ('" + name + "'," + number + ",'" + Int32.Parse(  SSN  ) + "','" + Date + "');";
            return dbMan.ExecuteNonQuery(query);
        }


        //TODO:
        //5-Get employees names and salaries for all employees 
        //who work in a project located at "Stafford" or in "Houston" 
        //and work less than 35 hours. (1 marks)

        public DataTable Get_By_project(string loc1,string loc2 , int hours)
        {
            string query = "select Fname, Salary From Employee Where SSN in ( " +
                            "Select W.Essn From Works_On As W,Project As P Where W.Pno = P.Pnumber and " +
                           " W.Hours < " + hours + "and ( P.Plocation = '" + loc1 + "' or P.Plocation = '" + loc2 + "' ))";
            return dbMan.ExecuteReader(query);
        }

        //6- Allow user to update salary of an employee of a certain SSN. (1 mark)
        public int UpdateSalary( int number, string SSN)
        {
            string query = "  Update Employee set Salary= " + number + " where SSN = " + Int32.Parse(SSN) + " ; ";
            return dbMan.ExecuteNonQuery(query);
        }



        

        //7-Get the last names of department managers and their salaries. (1 mark)
        public DataTable GetManagers()
        {

            string query = "SELECT LNAME,SALARY FROM Employee,Department WHERE Employee.SSN = Department.Mgr_SSN";

            return dbMan.ExecuteReader(query);

        }


        //8-Get Name and SSN for all employees working in "Research" department or working on projects controlled by "Research" department. (2 marks)
        public DataTable GetEmployee123(string Department)
        {
            string query = "SELECT DISTINCT Fname , SSN FROM Employee, Department, Project, Works_On WHERE(Employee.Dno = Department.Dnumber AND Department.Dname = '" + Department + "') OR(Works_On.Essn = Employee.SSN AND Works_On.Pno = Project.Pnumber AND Project.Dnum = Department.Dnumber AND Department.Dname = '" + Department+ "')";

            return dbMan.ExecuteReader(query);
        }



        //9-Get maximum, minimum and average salary for employees(1 mark)
        public DataTable GetMMA() 
        {
            string query = "SELECT AVG(SALARY),MAX(SALARY),MIN(SALARY) FROM Employee";

            return dbMan.ExecuteReader(query);
        }


    }
}
