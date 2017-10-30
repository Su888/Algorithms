using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmup
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Please Enter the number for the size of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Please Enter {n} numbers separated by space:");
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            Result(arr, n);
            Console.Read();
        }
        static void Result(int[] a, int n1)
        {
            int pos = 0;
            int neg = 0;
            int zer = 0;
            for (int i = 0; i < n1; i++)
            {
                if (a[i] < 0)
                {
                    neg = neg + 1;
                }
                else if (a[i] > 0)
                {
                    pos = pos + 1;
                }
                else
                {
                    zer = zer + 1;
                }
            }
            decimal p = (decimal)pos / n1;
            decimal n = (decimal)neg / n1;
            decimal z = (decimal)zer / n1;
           
            decimal[] dd = new decimal[3] {p, n, z };
           Console.WriteLine($"A decimal representing of the fraction of positive numbers in the array compared to its size:{ dd[0]}");
            Console.WriteLine($"A decimal representing of the fraction of negative numbers in the array compared to its size: {dd[1]}");
            Console.WriteLine($"A decimal representing of the fraction of zeroes in the array compared to its size: {dd[2]}");

        }
    }
}
