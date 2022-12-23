
using ConsoleAssignment;
using System.Diagnostics.Metrics;

namespace Math.ConsoleAssignment
{
    public class Program1
    {
        public  static void Main(String[]args)
        {
            Volume obj = new Volume();

            Console.WriteLine("Arti");

           double res= Volume.VolumeOfSpere(12);
            Console.WriteLine(res);

            String value=Volume.GetAuthorName();
            Console.WriteLine(value);

             obj.Quit(10);
            

        }
    }
}
