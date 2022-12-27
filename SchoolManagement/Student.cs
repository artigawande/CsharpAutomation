using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Student
    {
        public int student_id;
        public string student_name;
        public string student_mail;
        public double studentPercentage;
        public static string schoolName;
        public static string schoolAddress;



        public void PrintStudentDetails()
        {
            Console.WriteLine("student_id : " + student_id);
            Console.WriteLine("student name : " + student_name);
            Console.WriteLine("student email : " + student_mail);
            Console.WriteLine("student percentage : " + studentPercentage);
            Console.WriteLine("school name : " + schoolName);
            Console.WriteLine("schoolName address : " + schoolAddress);

            Console.WriteLine("---------------------------------------------------------");


            
        }


        public void DisplayCertification()
        {
            char grade;
           
            if(studentPercentage>90)
            {
                grade = 'A';
                Console.WriteLine("Hi Jack! You have successfully passed with grade A ");
            }

            else
            {
                if (studentPercentage >= 80 && studentPercentage <= 89)
                {
                    grade = 'B';
                    Console.WriteLine("Hi Peter! You have successfully passed with grade B ");
                }

                else
                {
                    if (studentPercentage >= 60 && studentPercentage <= 79)
                    {
                        grade = 'C';
                    }
                    else
                    {
                        if (studentPercentage<=60)
                        {
                            grade = 'D';
                        }
                        else
                        {
                            grade = 'F';
                        }
                    }
                }
            }

            Console.WriteLine("You have successfully passed with grade : " + grade);
        }

    }


    }

