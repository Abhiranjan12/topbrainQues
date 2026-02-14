/*
Question 43
Nunit-Assement Q1

Description
Write the testcase using NUnit for the given scenario.
In the class Program, the below given 2 method is already provided. 
This Program class represents a bank account with a balance. It has a property called Balance, which stores the current balance of the bank account. The class has a constructor that takes an initial balance as a parameter and sets the Balance property to this initial balance.

1. Deposit
This method allows a user to deposit a specified amount into the bank account. It takes a decimal parameter called amount, which represents the amount to be deposited. The method adds the deposited amount to the current balance, effectively increasing the balance. In case the deposit amount is negative, it triggers an exception with the error message "Deposit amount cannot be negative".

2. Withdraw
This method allows a user to withdraw a specified amount from the bank account. It takes a decimal parameter called amount, which represents the amount to be withdrawn. The method checks if the withdrawal amount is greater than the current balance. If it is, an exception is thrown with the message "Insufficient funds." If the withdrawal amount is less than or equal to the current balance, the method deducts this amount from the balance. Like the Deposit method, the Withdraw method does not return a value but updates the Balance property.

In the UnitTest class, you are required to create test methods for the Deposit and Withdraw methods.

        Method
public void Test_Deposit_ValidAmount()
public void Test_Deposit_NegativeAmount()
public void Test_Withdraw_ValidAmount()
public void Test_Withdraw_InsufficientFunds()
        
        Rules
This test method checks whether the Deposit method correctly increases the account balance and ensures that the balance is updated as expected.
This test method verifies whether the Deposit method correctly handles a negative deposit amount and ensures that it throws an exception as expected.
This test method validates whether the Withdraw method correctly decreases the account balance and verifies the balance update.
This test method checks whether the Withdraw method properly throws an exception when the withdrawal amount exceeds the account balance, ensuring it throws the expected exception.

Note:
1) Add the required test attribute for the class UnitTest    
2) Add the required test attribute for each test methods
3) In every test methods, you should need to use only one Assert
4) Assert whether the actual is equal to the expected
*/
using System;

class Account
{
    public decimal Balance { get; private set; }

    public Account(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
            throw new Exception("Deposit amount cannot be negative");

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
            throw new Exception("Insufficient funds.");

        Balance -= amount;
    }
}

class UnitTest
{
    public static void Test_Deposit_ValidAmount()
    {
        var account = new Account(100m);
        account.Deposit(50m);

        Console.WriteLine(account.Balance == 150m);
    }

    public static void Test_Deposit_NegativeAmount()
    {
        var account = new Account(100m);
        bool result;

        try
        {
            account.Deposit(-20m);
            result = false;
        }
        catch
        {
            result = true;
        }

        Console.WriteLine(result);
    }

    public static void Test_Withdraw_ValidAmount()
    {
        var account = new Program(100m);
        account.Withdraw(40m);

        Console.WriteLine(account.Balance == 60m);
    }

    public static void Test_Withdraw_InsufficientFunds()
    {
        var account = new Program(100m);
        bool result;

        try
        {
            account.Withdraw(150m);
            result = false;
        }
        catch
        {
            result = true;
        }

        Console.WriteLine(result);
    }
}

class Question_Number_43
{
    public static void main()
    {
        UnitTest.Test_Deposit_ValidAmount();
        UnitTest.Test_Deposit_NegativeAmount();
        UnitTest.Test_Withdraw_ValidAmount();
        UnitTest.Test_Withdraw_InsufficientFunds();
    }
}