using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 space-separated integers:");
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            Array.Sort(arr);
            MinMaxSum(arr);
            Console.Read();
        }
        static void MinMaxSum(int[] a)
        {   
            Int64 min = 0;
            Int64 max = 0;
            Int64 sum = 0;
            for(int i=0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            max =sum - a[0];
            min = sum - a[a.Length-1];
            Int64[] answer = new Int64[2] {min, max};
            Console.WriteLine($"minimum value that can be calculated by summing exactly four of the five integers is: {answer[0]}");
            Console.WriteLine($"minimum value that can be calculated by summing exactly four of the five integersis: {answer[1]}");
            
        }
    }
}
