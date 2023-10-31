using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program3
    {
        static void Main()
        {
            int[] num = new int[5];
            for(int i = 0; i < 5; i++)
            {
                num[i]=Convert.ToInt32(Console.ReadLine());
            }
            int max = Int32.MinValue;
            for(int i = 0; i < 5; i++)
            {
                if (max < num[i])
                {
                    max = num[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
