using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignment3
{
    public class EvenOdd
    {
        public static void prog1()
        {
            int i;
            Console.WriteLine("Even Number :");
            for (i = 0; i <= 30; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");

                }
            }
            Console.WriteLine("/nOdd number :");
            for (i = 0; i <= 30; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine(" ");
        }
    }
}
