using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[99];
            a[2] = 0;
            int k = 2, t = 0;
            while (t < 99)
            {
                for (int i = 1; i < a.Length; i++)
                    if (i % k == 0 && i != k) a[i] = 1;
                for (int i = 1; i < a.Length; i++)
                    if (i > k && a[i] == 0)
                    {
                        k = i;
                        break;
                    }
                t++;
            }
            Console.Write("2—100的素数有：");
            for (int i = 2; i < a.Length; i++)
                if (a[i] == 0)
                    Console.Write(i + " ");
        }
    }
}