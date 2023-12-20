using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task4._2
{
    public class Account
    {
        private string name;
        protected double balance;
        public Account(string name = "Unnamed Account", double balance = 0.0)
        {
            this.name = name;
            this.balance = balance;
        }

        public bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                balance += amount;
                return true;
            }
        }

        public bool Withdraw(double amount)
        {
            if (balance - amount >= 0)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        protected double GetBalance()
        {
            return balance;
        }

        public override string ToString()
        {
            return $"[Account: {name}: ${balance}]";
        }
        public static Account operator +(Account lhs, Account rhs)
        {
            string balance = new string(lhs.balance + " " + rhs.balance);
            return new Account(balance);


        }
        public void Display()
        {
            Console.WriteLine($"{balance}");
        }
    }
}
