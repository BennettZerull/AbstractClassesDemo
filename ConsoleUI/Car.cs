using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    public int numberOfSeats { get; set; }
    public bool hasTrunk { get; set; }

    public override void DriveAbstract()
    {
        Console.WriteLine("This car is in stock");
    }
}