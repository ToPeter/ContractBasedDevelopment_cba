using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace ContractCode
{
    class Program
    {
        private static Account a1;
        private static Account a2;

        private static void Main(string[] args)
        {
            a1 = new Account();
            a2 = new Account();

            a1.balance = -50.00;
            a2.balance = -500.00;

            //Console.WriteLine("This is initial balance: " + a1.balance);
            //double returnBalanceWithdraw = a1.Withdraw(10.0);
            //a1.checkBalance(returnBalanceWithdraw);
            //Console.WriteLine("This is after first withdraw: " + returnBalanceWithdraw);

            a1.checkBalance(a1.Withdraw(10.0));
            
            double returnBalanceDeposit1 = a1.Deposit(10.0);
            a1.checkBalance(returnBalanceDeposit1);
            Console.WriteLine("This is after deposit: " + returnBalanceDeposit1);

            //while (true)
            //{

            //}

        }
    }
}


