using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDiff
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Please enter a size of a square matrix (N):");
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            Console.WriteLine($"Please enter a square matrix of size {n}x{n} with spaces:");
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            Console.WriteLine($"the absolute difference between the two sums of the matrix's diagonals is : {diff(a, n)}");
            Console.Read();
        }
        static int diff(int[][] b, int n1)
        {
            int answer1 = 0;
            int answer2 = 0;
            int j = n1 - 1;
            for (int i = 0; i < n1; i++)
            {
                answer1 = answer1 + b[i][i];
                answer2 = answer2 + b[i][j];
                j--;
            }
            int answer = answer1 - answer2;
            if (answer < 0)
            {
                answer = -(answer);
            }
            return answer;
        }
    }
}
