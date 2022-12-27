using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student stud1= new Student();
            Student stud2= new Student();
            Student stud3= new Student();

            stud1.student_id = 1001;
            stud1.student_name = "Jack";
            stud1.student_mail = "jack@gmail.com";
            stud1.studentPercentage = 45.2;

            Student.schoolName = "Global school";
            Student.schoolAddress = "Chennai";

            stud2.student_id = 1002;
            stud2.student_name = "Peter";
            stud2.student_mail = "peter@gmail.com";
            stud2.studentPercentage = 85.2;

            stud3.student_id = 1003;
            stud3.student_name = "Mark";
            stud3.student_mail = "mark@gmail.com";
            stud3.studentPercentage = 56.5;

            stud1.PrintStudentDetails();
            stud2.PrintStudentDetails();
            stud3.PrintStudentDetails();

            stud1.DisplayCertification();
            stud2.DisplayCertification();
            stud3.DisplayCertification();
        }
    }
}
