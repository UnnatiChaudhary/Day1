using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program7
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{x}*{i}={x * i}");
            }
            Console.WriteLine("Do While Loop:");
            int j = 0;
            do
            {
                Console.WriteLine($"{x}*{j}={x * j}");
                j++;
            } while (j <= 10);
        }
       }  
    }


