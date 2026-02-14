/*
Question
33
Assign : E-Commerce Discount Calculator
Description
Scenario: You're building a checkout system for an online store that applies discounts based on customer type and purchase amount.

Problem: Write a program that calculates the final price after applying the following discount rules:

Regular customers get 5% discount on purchases over $100
Premium customers get 10% discount on all purchases
VIP customers get 15% discount, plus an additional 5% if purchase exceeds $200
Input: Customer type (R, P, V), Purchase amount
Output: Original price, Discount amount, Final price


Sample Output



=== E-COMMERCE DISCOUNT CALCULATOR ===

Customer Type: Regular
Original Price: $150.00
Discount Applied: 5 %
Discount Amount: $7.50
Final Price: $142.50
------------------------
Customer Type: Regular
Original Price: $80.00
Discount Applied: 0 %
Discount Amount: $0.00
Final Price: $80.00
------------------------
Customer Type: Premium
Original Price: $120.00
Discount Applied: 10 %
Discount Amount: $12.00
Final Price: $108.00
------------------------
Customer Type: VIP
Original Price: $250.00
Discount Applied: 20 %
Discount Amount: $50.00
Final Price: $200.00
------------------------
Customer Type: VIP
Original Price: $180.00
Discount Applied: 15 %
Discount Amount: $27.00
Final Price: $153.00
------------------------
Customer Type: Regular
Original Price: $500.00
Discount Applied: 5 %
Discount Amount: $25.00
Final Price: $475.00
------------------------
*/

using System;
using System.Collections.Generic;

class ECommerceDiscount
{
    static void Main()
    {
        Console.WriteLine("=== E-COMMERCE DISCOUNT CALCULATOR ===\n");

        // Sample data: CustomerType, PurchaseAmount
        List<(char, double)> purchases = new List<(char, double)>
        {
            ('R', 150.00),  // Regular, > $100
            ('R', 80.00),   // Regular, < $100
            ('P', 120.00),  // Premium
            ('V', 250.00),  // VIP, > $200
            ('V', 180.00),  // VIP, < $200
            ('R', 500.00)   // Regular, large purchase
        };

        foreach (var purchase in purchases)
        {
            ProcessPurchase(purchase.Item1, purchase.Item2);
            Console.WriteLine("------------------------");
        }
    }

    static void ProcessPurchase(char customerType, double purchaseAmount)
    {
        //Write Your Logic here
        string customerName = GetCustomerTypeName(customerType);
        double discountRate = CalculateDiscountRate(customerType, purchaseAmount);
        double discountAmount = (purchaseAmount * discountRate) / 100;
        double finalPrice = purchaseAmount - discountAmount;


        Console.WriteLine($"Customer Type: {customerName}");
        Console.WriteLine($"Original Price: ${purchaseAmount:F2}");
        Console.WriteLine($"Discount Applied: {discountRate} %");
        Console.WriteLine($"Discount Amount: ${discountAmount:F2}");
        Console.WriteLine($"Final Price: ${finalPrice:F2}");
    }

    static double CalculateDiscountRate(char customerType, double purchaseAmount)
    {
        //Write your logic here
        if (customerType == 'R' && purchaseAmount > 100) return 5;
        if (customerType == 'P') return 10;
        if (customerType == 'V' && purchaseAmount > 200) return 20;
        if (customerType == 'V') return 15;
        return 0;
    }

    static string GetCustomerTypeName(char customerType)
    {
        return customerType switch
        {
            'R' => "Regular",
            'P' => "Premium",
            'V' => "VIP",
            _ => "Unknown"
        };
    }
}