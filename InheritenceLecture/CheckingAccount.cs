using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceLecture
{
    internal class CheckingAccount : BankAccount
    {
        //properties
        public decimal OverdraftFee { get; set; }

        //constructor
        public CheckingAccount (int _accNumber, decimal _balance, string _cName, string _cAddress, decimal _overdraftfee)
            : base(_accNumber, _balance, _cName, _cAddress)
        {
            OverdraftFee = _overdraftfee;
        }

        //methods
        public override decimal Withdraw(decimal amount)
        {
            //return base.Withdraw(amount);
            if (amount > Balance)
            {
                Balance -= amount + OverdraftFee;
                return amount;
            }
            else
            {
                return amount;
            }
            
        }
    }
}
