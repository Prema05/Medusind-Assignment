using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Accounts
    {
        int AccountNo;
        string CustName;
        string AccountType;
        string transactionType;
        double Amount;
        double Balance;

        public Accounts(int Accountno, string CustName, string AccountType, string transactionType, double Amount) 
        {
            this.AccountNo = AccountNo;
            this.CustName = CustName;
            this.AccountType = AccountType;
            this.transactionType = transactionType;
            this.Amount = Amount;
            this.Balance = 1000;
        }

        public void Credit(double Amount)
        {
            Balance += Amount;
        }

        public void Debit(double Amount)
        {
            Balance -= Amount;
        }

        public void ShowData() 
        {
            Console.WriteLine("Enter Account Number:");
            this.AccountNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer's Name:");
            this.CustName = Console.ReadLine();
            Console.WriteLine("Enter Account Type:");
            this.AccountType = Console.ReadLine();
            Console.WriteLine("Enter Transaction Type (d->deposit / w->withdrawal):");
            this.transactionType = Console.ReadLine();
            Console.WriteLine("Enter Amount:");
            this.Amount = Convert.ToDouble(Console.ReadLine());
            if (transactionType == "d")
            {
                transactionType = "Deposit";
                Balance = Balance + Amount;
            }
            else if (transactionType == "w" && Amount < Balance)
            {
                transactionType = "Withdrawal";
                Balance = Balance - Amount;
            }
            else if (transactionType == "w" && Amount > Balance)
            {
                transactionType = "Transaction is not possible.";
            }
            Console.WriteLine("Account Number:" + AccountNo);
            Console.WriteLine("Customer Name:" + CustName);
            Console.WriteLine("Account Type:" + AccountType);
            Console.WriteLine("Transaction Type:" + transactionType);
            Console.WriteLine("Amount:" + Amount);
            Console.WriteLine("Balance:" + Balance);
        }
    }
    public class Accounts123
    {
        public static void Main(string[] args)
        {
            Accounts myacc = new Accounts(0938238, "harish", "savings", "d", 20000.00);
            myacc.Credit(1000);
            myacc.Debit(500);
            myacc.ShowData();
            Console.Read();
        }
    }

}



