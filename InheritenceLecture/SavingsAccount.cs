using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceLecture
{
    internal class SavingsAccount : BankAccount
    {
        //properties
        //all of the parent's properties/methods come down as well
        public decimal InterestRate { get; set; }

        //constructor
        //also account for parent's constructor
        public SavingsAccount(int _accNumber, decimal _balance, string _cName, string _cAddress, decimal _interest) :base(_accNumber, _balance, _cName, _cAddress)
        {
            InterestRate = _interest;
        }

        //methods
        //any method not overwrittened can be accessed
        public override void Deposit(decimal cash)
        {
            //this will call the original if needed
            //base.Deposit(cash);
            Balance += cash;
            Balance = Balance * (InterestRate + 1);
        }
    }
}
