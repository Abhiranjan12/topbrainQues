/*
Question 41
Coding Challenge: Vehicle Driving Simulation

Description
Coding Challenge: Vehicle Driving Simulation Using Inheritance and Polymorphism
Problem Description
You are required to develop a Vehicle Driving Simulation System in C# that demonstrates the use of inheritance and runtime polymorphism.

Different types of vehicles should share common driving behavior while allowing each type to define its own specific implementation.

Requirements
Create a base class named Vehicle:
It should contain a protected integer variable to store the number of wheels.
It should have a constructor that initializes the number of wheels.
It should declare a virtual method named Drive() that returns a string in the format:

<number_of_wheels> wheeler driving

Create a derived class named TwoWheeler:
It should inherit from the Vehicle class.
The number of wheels should be fixed as 2.
It should override the Drive() method if required, or use the base implementation.

Create another derived class named HMV (Heavy Motor Vehicle):
It should inherit from the Vehicle class.
It should accept the number of wheels through its constructor (e.g., 6, 8, etc.).
It should use the base class Drive() behavior.

In the Main method:
Create objects of TwoWheeler and HMV using base class references.
Call the Drive() method for each object.
Display the output on the console.

Input
No user input is required.

Output
The program should print the following output:

2 wheeler driving
8 wheeler driving
Constraints
Use inheritance to share common behavior.
Use polymorphism by invoking overridden methods using base class references.
Do not use conditional statements to determine vehicle type.
Follow standard C# naming and coding conventions.
*/


using System;

class Vehicle
{
    protected int wheels;

    public Vehicle(int wheels)
    {
        this.wheels = wheels;
    }

    public virtual string Drive()
    {
        return wheels + " wheeler driving";
    }
}

class TwoWheeler : Vehicle
{
    public TwoWheeler() : base(2)
    {
    }
}

class HMV : Vehicle
{
    public HMV(int wheels) : base(wheels)
    {
    }
}

class Question_Number_41
{
    public static void main()
    {
        Vehicle v1 = new TwoWheeler();
        Vehicle v2 = new HMV(8);

        Console.WriteLine(v1.Drive());
        Console.WriteLine(v2.Drive());
    }
}