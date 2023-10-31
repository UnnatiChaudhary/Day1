using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program4
    {
        static void Main()
        {
            int[,] num = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter value for ({0},{1}): ", i, j);
                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
           
            for(int i = 0;i < 3; i++)
            {
                int sum = 0;
                for(int j = 0; j < 3; j++)
                {
                    sum += num[i, j];
                    
                }
                Console.WriteLine("Sum of row {0}", sum);
            }
        }
    }
}
