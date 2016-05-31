using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_system.Contracts
{
    interface IAccount
    {
         ICustomer Customer{get;set;}
         decimal Balance { get; }
         decimal InterestRate { get; }
         decimal CalculateRate(double mounts);
    }
}
