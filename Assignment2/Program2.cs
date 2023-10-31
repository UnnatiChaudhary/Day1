using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program2
    {
        static void Main()
        {
            int[,] num = new int[3, 3];
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter value for ({0},{1}): ", i, j);
                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                    sum += num[i, j];
                }
            }
            Console.WriteLine("Sum is " + sum);
        }
    }
}
