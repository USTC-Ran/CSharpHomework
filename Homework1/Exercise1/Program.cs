using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            double m, n;
            Console.Write("Please input a number:");
            a = Console.ReadLine();
            m = Double.Parse(a);
            Console.Write("Please input a number:");
            b = Console.ReadLine();
            n = Double.Parse(b);
            Console.WriteLine("The product is:" + m * n);
        }
    }
}
