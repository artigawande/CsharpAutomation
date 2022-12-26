using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignment3
{
    public class PrintEONum
    {
        public static void prog5()
        {
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum of even number is  :" + sum);
            int sum1 = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {

                    sum1 = sum1 + i;
                }
            }
            Console.WriteLine(sum+sum+"sum of odd number :" + sum1);
        }
    }
}

