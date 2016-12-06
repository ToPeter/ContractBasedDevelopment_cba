using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace ContractCode
{
    class Account {

        //public Account(double balance)
        //{
        //    Contract.Requires(balance >= 0.0);
        //    this.balance = balance;
        //}
        private double _balance ;
        public double balance
        {
            get { return _balance; }

            set
            {

                _balance = balance;
                Contract.Requires(_balance >= 0.0);
            }

        }


        public double Deposit(double amount)
        {
            _balance += amount;
            return _balance;
        }


        public double Withdraw(double amount)
        {
            //this.balance -= amount;
            //return this.balance;

            _balance += amount;
            return _balance;
        }

        public void checkBalance(double balance)
        {
            Contract.Requires(balance >= 0.0);
        }


    }
}
