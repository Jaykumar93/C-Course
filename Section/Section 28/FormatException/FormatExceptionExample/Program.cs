﻿using System;

namespace FormatExceptionExample
{
    class BankAccount
    {
        public string AccountHolderName { get; set; }
        public int AccountNumber { get; set; }
        public double CurrentBalance { get; set; }
    }
    class Program
    {
        static void Main()
        {
            try
            {
                BankAccount bankAccount = new BankAccount();

                Console.Write("Enter account holder name: ");
                bankAccount.AccountHolderName = Console.ReadLine();
                Console.Write("Enter account number: ");
                bankAccount.AccountNumber = int.Parse(Console.ReadLine()); 
                Console.Write("Enter current balance: ");
                bankAccount.CurrentBalance = double.Parse(Console.ReadLine()); 
                Console.WriteLine("\nNew bank account details:");
                Console.WriteLine("Account holder name: " + bankAccount.AccountHolderName);
                Console.WriteLine("Account number: " + bankAccount.AccountNumber);
                Console.WriteLine("Current balance: " + bankAccount.CurrentBalance);
            }
            catch (FormatException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
