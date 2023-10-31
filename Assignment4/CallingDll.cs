using ClassLibrary1;
using System;
namespace Assignment4
{
    internal class CallingDll
    {
        static void Main(string[] args)
        {
            int x = 10, y = 5;
           Console.WriteLine( NumericClass.Subtraction(x, y));
        }
    }
}