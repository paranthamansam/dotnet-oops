// WhatIsOOP.cs
// Demonstrates a simple class and object

public class Car
{
    public string Model;
    public void Drive()
    {
        Console.WriteLine("Driving the car...");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Model = "Toyota";
        myCar.Drive();
    }
}