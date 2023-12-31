﻿using System;
namespace Task4._2
{
    public class AccountUtil
    {
        public static void Display(List<Account> accounts)
        {
            Console.WriteLine("\n=== Accounts ==========================================");
            foreach (var acc in accounts)
            {
                Console.WriteLine(acc);
            }
        }

        public static void Deposit(List<Account> accounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to Accounts =================================");
            foreach (var acc in accounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }

        public static void Withdraw(List<Account> accounts, double amount)
        {
            Console.WriteLine("\n=== Withdrawing from Accounts ==============================");
            foreach (var acc in accounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }
        }

        // Helper functions for Savings Account class
        public static void Display(List<SavingsAccount> savAccounts)
        {
            Console.WriteLine("\n=== savAccounts ==========================================");
            foreach (var acc in savAccounts)
            {
                Console.WriteLine(acc);
            }

        }
        public static void Deposit(List<SavingsAccount> savAccounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to savingsAccounts  =================================");
            foreach (var acc in savAccounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");

            }
        }
        public static void Withdraw(List<SavingsAccount> savAccounts, double amount)
        {
            Console.WriteLine("\n=== Withdrawing from savingsAccounts ==============================");
            foreach (var acc in savAccounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }

        }


        // Helper functions for Checking Account class
        public static void Display(List<CheckingAccount> checAccounts)
        {
            Console.WriteLine("\n=== checkingAccounts ==========================================");
            foreach (var acc in checAccounts)
            {
                Console.WriteLine(acc);
            }

        }
        public static void Deposit(List<CheckingAccount> checAccounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to checkingAccounts  =================================");
            foreach (var acc in checAccounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");

            }


        }

        public static void Withdraw(List<CheckingAccount> checAccounts, double amount)
        {
            Console.WriteLine("\n=== Withdrawing from checkingAccounts ==============================");
            foreach (var acc in checAccounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }

        }
        // Helper functions for Trust account class
        public static void Display(List<TrustAccount> trustAccounts)
        {


            Console.WriteLine("\n=== trustAccounts ==========================================");
            foreach (var acc in trustAccounts)
            {
                Console.WriteLine(acc);
            }

        }
        public static void Deposit(List<TrustAccount> trustAccounts,double amount)
        {
            Console.WriteLine("\n=== Depositing to  TrustAccounts  =================================");
            foreach (var acc in trustAccounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");

            }


        }
        public static void Withdraw(List<TrustAccount>trustAccounts,double amount)
        {
            Console.WriteLine("\n=== Withdrawing from TrustAccounts ==============================");
            foreach (var acc in trustAccounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }


        }

    }


}