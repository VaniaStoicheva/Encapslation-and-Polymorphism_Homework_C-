using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bank_system.Model;
using Bank_system.Contracts;

namespace Bank_system
{
    class TestBankSystem
    {
        static void Main(string[] args)
        {
            ICustomer ivan = new IndividualCustomer("Ivan Petrov");
            ICustomer ltd = new CompanyCustomer("Iva LTD");

            IAccount deposit = new DepositAccount(ivan,100m,3.7m);
            IAccount depositLtd = new DepositAccount(ltd,1100m,7m);

            IAccount loan = new LoanAccount(ivan,12000m,4.5m);
            IAccount loanLtd = new LoanAccount(ltd,24000m,5.2m);

            IAccount mortgage = new MortgageAccount(ivan,20000m,9.8m);
            IAccount mortgageLtd = new MortgageAccount(ltd,44000m,8.9m);

            List<IAccount> accounts = new List<IAccount>()
            {
                deposit,
                depositLtd,
                loan,
                loanLtd,
                mortgage,
                mortgageLtd
            };

            foreach (var acc in accounts)
            {
                Console.WriteLine(
                    "{5} {0,-15}: {1:N2}, {2:N2}, {3:N2}, {4:N2}",
                    acc.GetType().Name,
                    acc.CalculateRate(2),
                    acc.CalculateRate(3),
                    acc.CalculateRate(10),
                    acc.CalculateRate(13),
                    acc.Customer.GetType().Name);
            }
        }
    }
}
