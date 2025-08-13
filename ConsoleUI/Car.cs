using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    public int NumberOfSeats { get; set; }
    public bool HasTrunk { get; set; }

    public override void DriveAbstract()
    {
        Console.WriteLine("This car is in stock");
    }
}