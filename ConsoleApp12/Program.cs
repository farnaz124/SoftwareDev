using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter h:");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter v:");
            double v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masaht is={0}", 0.5 * h * v);

        }
    }
}