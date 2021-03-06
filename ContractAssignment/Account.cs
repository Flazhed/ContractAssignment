﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractAssignment
{
    public class Account
    {
        private double Amount { get; set;}

        public Account(double startAmount)
        {
            this.Amount = startAmount;
        }

        public double Deposit(double amount)
        {
            Contract.Requires(amount > 0);
            Contract.Ensures(Contract.Result<double>() == Contract.OldValue(this.Amount) + amount);
            this.Amount += amount;
            return this.Amount;
        }

        public double Withdraw(double amount)
        {
            Contract.Requires(amount > 0);
            Contract.Ensures(Contract.Result<double>() == Contract.OldValue(this.Amount) - amount);
            Contract.EnsuresOnThrow<InvalidWithDraw>(this.Amount == Contract.OldValue(this.Amount));

            if (this.Amount-amount > 0) { 
            this.Amount -= amount;
            }
            else
            {
                throw new InvalidWithDraw("You are broke, my friend");
            }
            return this.Amount;
        }

    }

}
