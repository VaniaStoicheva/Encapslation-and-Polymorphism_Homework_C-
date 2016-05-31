using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bank_system.Contracts;

namespace Bank_system.Model
{
    class MortgageAccount:Account,IDepositable
    {
        public MortgageAccount(ICustomer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }
        public override decimal CalculateRate(double mounts)
        {
            if (this.Customer is IndividualCustomer)
            {
                if (mounts < 6)
                {
                    return this.Balance;
                }
                else
                {
                    return this.CalculateRate(mounts-6);
                }
            }
            if (this.Customer is CompanyCustomer)
            {
                if (mounts >= 12)
                {
                    return base.CalculateRate(12)/2+(base.CalculateRate(mounts-12)/2);
                }
                else
                {
                    return base.CalculateRate(mounts) / 2;
                }
            }
            return base.CalculateRate(mounts);
        }
    }
}
