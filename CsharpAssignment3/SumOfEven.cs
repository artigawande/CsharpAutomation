using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Maths.CsharpAssignment3
{
    public class SumOfEven
    {
        public static void L1()
        {
            int x ;
            int sum = 0;
            for (x=0; x<=50; x++)
            {
                if (x % 2 == 0)
                {
                    sum = sum + x;
                }
            }
            int a = 0;
            int sum1 = 0;
            for (x = 0; x <= 50; x++)
            {
                if (x % 2 != 0)
                {
                    sum1 = sum1 + x;
                }
            }
            Console.WriteLine(sum1);

            if (sum == 0)
            {
                Console.WriteLine(sum + " The sum is even");
            }
            else
                Console.WriteLine("The sum is odd");
        }
        }



        
            
    }

