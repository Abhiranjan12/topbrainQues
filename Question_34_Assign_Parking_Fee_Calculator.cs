/*
Question
34
Assign-Parking Fee Calculator
Description
Scenario: Develop a smart parking system application for SmartPark System.They want console application ,via which they are able to charge the  fees based on vehicle type and parking duration.

Problem: Implement a fee calculation system with these rules:

Cars: $3 per hour, maximum $25 per day
Motorcycles: $2 per hour, maximum $15 per day
Trucks: $5 per hour, maximum $40 per day
First 30 minutes free for all vehicles
10% discount for parking over 8 hours
Input: Vehicle type (C, M, T), Parking hours (can be decimal)
Output: 

=== PARKING FEE CALCULATOR ===

Vehicle: Car
Parking Duration: 2.50 hours
Hourly Rate: $3.00
Daily Maximum: $25.00
Total Fee: $6.00
------------------------
Vehicle: Car
Parking Duration: 12.00 hours
Hourly Rate: $3.00
Daily Maximum: $25.00
Total Fee: $22.50
------------------------
Vehicle: Motorcycle
Parking Duration: 4.00 hours
Hourly Rate: $2.00
Daily Maximum: $15.00
Total Fee: $7.00
------------------------
Vehicle: Truck
Parking Duration: 6.50 hours
Hourly Rate: $5.00
Daily Maximum: $40.00
*/

// File: ParkingFeeCalculator.cs
using System;
using System.Collections.Generic;

class ParkingFeeCalculator
{
    static void Main()
    {
        Console.WriteLine("=== PARKING FEE CALCULATOR ===\n");

        // Sample data: VehicleType, Hours
        List<(char, double)> parkingRecords = new List<(char, double)>
        {
            ('C', 2.5),     // Car, 2.5 hours
            ('C', 12.0),    // Car, 12 hours (max fee applies)
            ('M', 4.0),     // Motorcycle, 4 hours
            ('T', 6.5),     // Truck, 6.5 hours
            ('C', 0.25),    // Car, 15 minutes (free)
            ('M', 10.0)     // Motorcycle, 10 hours (discount)
        };

        foreach (var record in parkingRecords)
        {
            CalculateAndDisplayFee(record.Item1, record.Item2);
            Console.WriteLine("------------------------");
        }
    }

    static void CalculateAndDisplayFee(char vehicleType, double hours)
    {
        double hourlyRate = GetHourlyRate(vehicleType);
        double dailyMax = GetDailyMaximum(vehicleType);
        string vehicleName = GetVehicleName(vehicleType);

        double fee = CalculateParkingFee(hours, hourlyRate, dailyMax);

        Console.WriteLine($"Vehicle: {vehicleName}");
        Console.WriteLine($"Parking Duration: {hours:F2} hours");
        Console.WriteLine($"Hourly Rate: ${hourlyRate:F2}");
        Console.WriteLine($"Daily Maximum: ${dailyMax:F2}");
        Console.WriteLine($"Total Fee: ${fee:F2}");
    }

    static double CalculateParkingFee(double hours, double hourlyRate, double dailyMax)
    {
        double totalPrice = 0.0;
        // First 30 minutes free
        if (hours < 0.50)
        {
            return 0;
        }

        // Remove first 30 minutes from calculation
        hours = hours - 0.50;

        // Calculate base fee
        totalPrice = hours * hourlyRate;

        // Apply daily maximum
        if (totalPrice > dailyMax)
        {
            totalPrice = dailyMax;
        }

        // Apply discount for long parking
        if (hours > 8)
        {
            double dis = (dailyMax * 0.1);
            totalPrice = totalPrice - dis;
        }

        return totalPrice;
    }

    static double GetHourlyRate(char vehicleType)
    {
        return vehicleType switch
        {
            'C' => 3.00,  // Car
            'M' => 2.00,  // Motorcycle
            'T' => 5.00,  // Trucksaz   QW232FCXQ
            _ => 0.00
        };
    }

    static double GetDailyMaximum(char vehicleType)
    {
        return vehicleType switch
        {
            'C' => 25.00,  // Car
            'M' => 15.00,  // Motorcycle
            'T' => 40.00,  // Truck
            _ => 0.00
        };
    }

    static string GetVehicleName(char vehicleType)
    {
        return vehicleType switch
        {
            'C' => "Car",
            'M' => "Motorcycle",
            'T' => "Truck",
            _ => "Unknown"
        };
    }
}