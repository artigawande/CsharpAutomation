using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths.CSharpConcept
{
    
        public class Volume
        {
            public static double VolumnOfSphere(double radius)
            {
                double ans = 4 * 3.14 * radius * radius * radius / 3;
                return ans;
            }
            public static double VolumnOfCone(int radius, int height)
            {
                double ans = 3.14 * radius * radius * height / 3;
                return ans;
            }
            public static double VolumnOfCuboid(double length, double width, double height)
            {
                double ans = length * width * height;
                return ans;
            }
            public static double VolumnOfHemiSphere(int radius)
            {
                double ans = 2 * 3.14 * radius * radius * radius / 3;
                return ans;
            }
        }
    }




