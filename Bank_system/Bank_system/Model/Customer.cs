using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bank_system.Model;
using Bank_system.Contracts;

namespace Bank_system.Model
{
    public abstract class Customer : ICustomer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }
        public string Name 
        { 
            get
            { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Customer name cannot be null or white space");
                }
                this.name = value;
            }

        }
    }    
  }