using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program6
    {
        static void Main()
        {
            int i = 2;
            do
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i <= 10);
            int j = 2;
            while (j <= 10)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }
            for (int x = 2; x <= 10; x++)
            {
                if (x % 2 != 0)
                {

                    Console.WriteLine(x);
                }
            }
        }
    }
}
