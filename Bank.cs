using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo
{
    public class Bank
    {
        private double balance;
        public Bank(double balance)
        {
            this.balance = balance;
        }
        public Bank()
        {

        }

        public double Balance
        {
            get { return balance; }
        }


        public void AddBalance(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            balance += amount;
        }

        public void WithdrawAmount(double amount)
        {
            if (amount > balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));

            }
            if(amount<0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));

            }
            balance -= amount;
        }

        public void TransferFundTo(Bank otherAccount,double amount)
        {
            if(otherAccount is null)
            {
                throw new ArgumentNullException(nameof(otherAccount));
            }
            WithdrawAmount(amount);
            otherAccount.AddBalance(amount);
        }

    }
}
