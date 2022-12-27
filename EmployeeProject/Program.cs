using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee.CompanyName= "Maveric"; 
            
            Employee.CompanyLocation = "Pune";

            Employee emp1= new Employee();
            Employee emp2= new Employee();
            Employee emp3= new Employee();
            Employee emp4= new Employee();


            emp1.emp_id = 101;
            emp1.emp_name = "Krishna";
            emp1.emp_salary = 12000;
            emp1.empPerformance = 'A';
            emp1.EmpSalary = 2000;
            

            emp2.emp_id = 1;
            emp2.emp_name = "Mira";
            emp2.emp_salary = 20000;
            emp2.empPerformance = 'B';
            emp2.EmpSalary = 2300;

            emp3.emp_id = 102;
            emp3.emp_name = "Siya";
            emp3.emp_salary = 9000;
            emp3.empPerformance = 'C';
            emp3.EmpSalary = 2000.34;

            emp4.emp_id = 103;
            emp4.emp_name = "ABC";
            emp4.emp_salary = 8000;
            emp4.empPerformance = 'D';
            emp4.EmpSalary = 2500;


            emp1.EmployeeDetails();
            emp2.EmployeeDetails();
            emp3.EmployeeDetails();
            emp4.EmployeeDetails();

            emp1.GetGrossSalaryWithBonus();
           



        }
    }
}
