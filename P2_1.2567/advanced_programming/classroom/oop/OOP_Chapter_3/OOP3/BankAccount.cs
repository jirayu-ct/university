using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BankAccount
    {
        private string _accountNumber;
        private decimal _balnce;

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            _accountNumber = accountNumber;
            _balnce = initialBalance;
        }

        public void Deposit(decimal amount) => _balnce += amount;
        public void Withdraw(decimal amount)
        {
            if (_balnce - amount >= 0)
            {
                _balnce -= amount;
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }

        public string AccountNumber 
        { 
            get => _accountNumber;
        }

        public decimal Balance
        {
            get => _balnce;
        }
    }
}

/*
 BankAccount myAccout = new BankAccount(accountNumber: "99999999", initialBalance: 1000);
            myAccout.Deposit(2500);
            myAccout.Withdraw(500);

            Console.WriteLine("myAccout: {0}", myAccout.AccountNumber);
            Console.WriteLine("Balance: {0}", myAccout.Balance);
 */