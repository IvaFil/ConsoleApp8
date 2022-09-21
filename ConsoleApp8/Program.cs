using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введи X1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введи Y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введи Z1: ");
            double z1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введи X2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введи Y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введи Z2: ");
            double z2 = Convert.ToDouble(Console.ReadLine());

            double res = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2);

            Console.WriteLine(Math.Sqrt(res));
        }
    }
}
