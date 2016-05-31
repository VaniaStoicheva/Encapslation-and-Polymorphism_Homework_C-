using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bank_system.Contracts;


namespace Bank_system.Model
{
    public abstract  class Account:IAccount,IDepositable
    {
        private ICustomer customer;
        private decimal balance;
        private decimal interestRate;

        protected Account(ICustomer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public ICustomer Customer 
        {
            get { return this.customer; }
            set {
                if (value ==null)
                {
                    throw new ArgumentNullException("Account customer cannot be null");
                }
                this.customer= value; }
            }
        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                {
                    throw new
                    ArgumentNullException("Balance cannot be negative");
                }
                this.balance = value;
            }
        }
        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Rate canot be negative");
                }
                this.interestRate = value;
            }
        }
       
        
        public virtual decimal CalculateRate(double mounts)
        {
            return this.Balance*(1+((this.InterestRate*(decimal)mounts)/100));
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
