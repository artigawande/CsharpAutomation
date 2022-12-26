using Math.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths.CSharpConcept
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Hello Everyone");

            double result= Area.AreaOfTriangle(10, 12);

            Console.WriteLine(result);

           double ans= Volume.VolumnOfSphere(10);
            Console.WriteLine(ans);

            double ans1 = Volume.VolumnOfCuboid(10,10.2,10.3);
            Console.WriteLine(ans1);

        }
    }
}
