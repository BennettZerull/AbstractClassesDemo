using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public int NumberOfWheels { get; set; }
    public bool HasSideCart { get; set; }

    public override void DriveAbstract()
    {
        Console.WriteLine("This motorcycle is in stock");
    }
    public override void DriveVirtual()
    {
        Console.WriteLine($"The {Year}, {Make} {Model} is not available for test drive.");
    }
}