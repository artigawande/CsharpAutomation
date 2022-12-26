using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignment3
{
    public class Pattern
    {
        public static void prog4()
        {
            int i, j;
            int n=4;

            for (i = 0; i < n; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    if (((i + j) % 2) == 0)
                        Console.Write("0");
                    else
                        Console.Write("1");

                    Console.Write("\t");
                }

                Console.WriteLine();
            }
        }

        public static void prog6() 
        {
            int i, j;
            int n = 6;

            for (i = 0; i < n; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    if (((i + j) % 2) == 0)
                        Console.Write("0");
                    else
                        Console.Write("1");

                    Console.Write("\t");
                }

                Console.WriteLine();
            }
        }
    }

    }


