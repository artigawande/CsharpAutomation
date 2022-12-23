using Math.CSharp;
using Maths.CSharpConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.CSharpConcept
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello Everyone");

            // Area of rectangle

           double Result= Area.AreaOfTriangle(10, 10);
            Console.WriteLine(Result);


            // Volume 

            double ans = Volume.VolumnOfSphere(10);

            double ans1 = Volume.VolumnOfCuboid(10, 20, 30);
            double ans2 = Volume.VolumnOfCone(10, 10);
            double ans3 = Volume.VolumnOfSphere(10);
            Console.WriteLine(ans);
            Console.WriteLine(ans1);
            Console.WriteLine(ans2);
            Console.WriteLine(ans3);



//Age Program
            int smith = 25;
            int John = 45;
            int henry = 65;
            if (smith > John || smith > henry)
            {
                if (John > henry)
                {
                    Console.WriteLine("henry is younger");
                }
                else
                {
                    Console.WriteLine("john is younger");
                }
            }
            else
            {
                Console.WriteLine("smith is younger");



            }
            if (smith == John && John == henry)
            {
                Console.WriteLine("Smith, John, henry are same age" + John);
            }


            //Array

            String[] abc = new String[3];
            abc[0] = "Red";
            abc[1] = "Yellow";
            abc[2] = "Green";

            Console.WriteLine(abc[0]);
            Console.WriteLine(abc[1]);
            Console.WriteLine(abc[2]);




        }

        

    }

    


}

