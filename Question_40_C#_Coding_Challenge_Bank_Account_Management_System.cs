/*
Question 40
C# Coding Challenge: Bank Account Management System

Description
C# Coding Challenge: Bank Account Management System
Scenario
You're building a simple banking application for a small financial institution. Your task is to implement the core 
Account class that will manage customer account information and basic transactions. Each account should track the account holder's name and balance, and support basic operations like deposits and balance inquiries.

Challenge Requirements
Implement the Account class according to the following specifications:

Class Structure
text
Account
├── Private Fields
│   ├── name (string)
│   └── balance (double)
├── Constructor
│   └── Account(string name, double initialBalance)
└── Public Methods
    ├── deposit(double amount) → returns double
    ├── getBalance() → returns double
    ├── setName(string newName) → returns void
    └── getName() → returns string
Method Specifications
Constructor

Initialize the account with the customer's name and initial balance

Both parameters must be stored in the private fields

deposit(double depositAmount)

Adds the deposit amount to the current balance

Returns the updated balance

Example: If balance is 100 and deposit(50) is called, returns 150

getBalance()

Returns the current account balance

Does not modify the balance

setName(string newName)

Updates the account holder's name

Returns nothing (void)

getName()

Returns the account holder's name

Constraints
All fields must be private
Method names must match exactly as specified
Return types must match exactly
Use proper encapsulation principles

Sample Output
1250
John Doe
500
1250.5
1250.5
Riya Amit Mehta 
*/


using System;

namespace BankSys
{
    public class Account
    {
        // Private fields
        private double balance;
        private string name;

        // Constructor
        public Account(string name, double initialBalance)
        {
            this.name = name;
            this.balance = initialBalance;
        }

        // Deposit method
        public double deposit(double amount)
        {
            balance += amount;
            return balance;
        }

        // Get balance
        public double getBalance()
        {
            return balance;
        }

        // Set account holder name
        public void setName(string newName)
        {
            name = newName;
        }

        // Get account holder name
        public string getName()
        {
            return name;
        }
    }

    class Question_Number_40
    {
        public static void main()
        {
            Account account1 = new Account("John Doe", 1250.00);

            Console.WriteLine(account1.getBalance());
            Console.WriteLine(account1.getName());

            Console.WriteLine(account1.deposit(-750));
            Console.WriteLine(account1.deposit(750.5)); 
            Console.WriteLine(account1.getBalance());

            account1.setName("Riya Amit Mehta ");
            Console.WriteLine(account1.getName());
        }
    }
}
