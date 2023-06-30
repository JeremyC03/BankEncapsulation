using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double _balance;
        
        public void Deposit(double amount)
        {
            _balance += amount;
        }
        public void Withdraw(double amount)
        {
            _balance -= amount;
        }
        public double GetBalance()
        {
            return _balance;
        }
    }
}
