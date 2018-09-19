using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数组为：3，1，4，1，5，9，2，6");
            int[] a = { 3, 1, 4, 1, 5, 9, 2, 6 };
            int Max, Min, Sum = 0;
            float Ave;
            Max = a[0];
            Min = a[0];
            foreach (int i in a)
            {
                if (Max < i)
                    Max = i;
            }
            Console.WriteLine("最大值为：" + Max);
            foreach (int i in a)
            {
                if (Min > i)
                    Min = i;
            }
            Console.WriteLine("最小值为：" + Min);
            foreach (int i in a)
            {
                Sum += i;
            }
            Console.WriteLine("和为：" + Sum);
            Ave = (float)Sum / 8;
            Console.WriteLine("平均值为：" + Ave);
        }
    }
}