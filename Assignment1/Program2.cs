using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program2
    {
       static void Main()
        {
            Console.WriteLine("Enter Value of x:");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value of y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Addition: {x+y}");
            Console.WriteLine($"Subtraction: {x - y}");
            Console.WriteLine($"Product: {x * y}");
            Console.WriteLine($"Quotient: {x / y}");
        }
    }
}
