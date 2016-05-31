using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bank_system.Contracts;

namespace Bank_system.Model
{
    class LoanAccount:Account,IDepositable
    {
        public LoanAccount(ICustomer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateRate(double mounts)
        {
            if (this.Customer is IndividualCustomer)
            {
                if (mounts <= 3)
                {
                    return this.Balance;
                }
                else
                {
                    return base.CalculateRate(mounts-3);
                }
            }
            if (this.Customer is CompanyCustomer)
            {
                if (mounts >= 2)
                {
                    return base.CalculateRate(mounts - 2);
                }
                else
                {
                    return this.Balance;
                }
            }
            return base.CalculateRate(mounts);
        }
    }
}
