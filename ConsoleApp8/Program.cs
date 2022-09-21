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

            Console.WriteLine("Введи число: ");

            int number = Convert.ToInt32(Console.ReadLine());
            int res=0;
            for (int i = 1; i <=number; i++)
            {
                res = i * i * i;
                Console.WriteLine(res);
            }
            
        }
    }
}
