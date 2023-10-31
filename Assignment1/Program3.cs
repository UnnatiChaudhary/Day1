using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program3
    {
        static void Main()
        {
            Console.WriteLine("Enter x:");
            int x=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operator:");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case '+':
                    Console.WriteLine(x + y);
                    break;
                case '*':
                    Console.WriteLine(x * y);
                    break;
                case '-':
                    Console.WriteLine(x - y);
                    break;
                case '/':
                    Console.WriteLine(x / y);
                    break;
            }
        }
    }
}
