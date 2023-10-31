using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account act = new Account();

            Console.Write("Enter Account Id : ");
            act.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Account Type : ");
            act.AccountType = Console.ReadLine();

            Console.Write("Enter Balance : ");
            act.Balance = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Withdraw amount : ");
            int withdrawAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (withdrawAmount <= act.Balance)
            {
                double prevBalance = act.Balance;
                act.Withdraw(withdrawAmount);
                Console.WriteLine(act.GetDetails());

            }
            else
            {
                Console.WriteLine(act.GetDetails());
            }
        }
    }
}
