using System.Diagnostics.Metrics;

namespace Assignment5
{
    public class Account
    {
        int id;
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        String accountType;
        public String AccountType
        {
            get
            {
                return accountType;
            }

            set
            {
                accountType = value;
            }
        }
        double balance;
        public double Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }
        public bool Withdraw(double amount)
        {
            bool res = false;
            if (balance > amount)
            {
                balance -= amount;
                res = true;
            }
            return res;
        }
        public String GetDetails()
        {
            return $"Id: {id} \n AccountType: {accountType} \n Balance: {balance}";
        }
    }
}