using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAssignment
{
    public class Volume
    {
        public static double VolumeOfSpere(double redius)
        {
            return (4 * 3.14 * redius * redius * redius) / 3;
             
        }

        public static string GetAuthorName()
        {
            return "ASG";
        }
         public void Quit(int a)
        {
            
        }

    }
}
