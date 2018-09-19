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
            Console.Write("Please input an int:");
            string s = Console.ReadLine();
            int n = Int32.Parse(s);
            int m = n / 2;
            int[] result = new int[m];
            int[] prime_num = new int[m];
            bool isPrime = true;
            int r_p = 0, p_p = 0;

            prime_num[p_p++] = 2;
            if (n % 2 == 0)
                result[r_p++] = 2;

            for (int i = 3; i <= m; i++)
            {
                for (int j = 0; j < p_p; j++)
                {
                    if (i % prime_num[j] != 0)
                    {
                        isPrime = true;
                        continue;
                    }
                    else
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    prime_num[p_p++] = i;
                    if (n % i == 0)
                        result[r_p++] = i;
                }
            }
            if (r_p == 0)
                result[r_p++] = n;
            Console.Write("Prime number(s):");
            for (int i = 0; i < r_p; i++)
                Console.Write(" " + result[i]);
        }
    }
}