using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bank_system.Contracts;

namespace Bank_system.Model
{
    class DepositAccount:Account,IDepositable,IWithdrawable,IAccount
    {
        public DepositAccount(ICustomer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }
        public override decimal CalculateRate(double mounts)
        {
            if (this.Balance < 1000 && this.Balance >= 0)
            {
                return this.Balance;
            }
            return base.CalculateRate(mounts);
        }
       

    public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }
    }
}
