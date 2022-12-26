using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    public class Employee
    {
        public int emp_id;
        public string emp_name;
        public double emp_salary;
        public char empPerformance;
        public static string CompanyName;
        public static string CompanyLocation;


        public double EmpSalary
        {
            get
            {
                return emp_salary;
            }
            set
            {
                if (value>3000)
                {
                    emp_salary = value;
                }
                else
                {
                    Console.WriteLine("Invalid Salary. so default value remains !!!");
                }
            }
        }

        public  void EmployeeDetails()
        {
            Console.WriteLine("Employee id " +emp_id);
            Console.WriteLine("Employee name " + emp_name);
            Console.WriteLine("Employee salary " + emp_salary);
            Console.WriteLine("Employee performance " +empPerformance);
            Console.WriteLine("Company Name " + Employee.CompanyName);
            Console.WriteLine("Company Location" + Employee.CompanyLocation);
            Console.WriteLine("-----------------------------------------------");
        }

        //calculation bonus

        public void GetGrossSalaryWithBonus()
        {
            Console.WriteLine("Employee id " + emp_id);
            if(empPerformance=='A')
            {
                Console.WriteLine("25%");
                //return emp_salary + (emp_salary * 25 / 100);
            }
        }


    }

    

}
