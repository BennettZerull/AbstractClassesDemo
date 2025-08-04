using System;

namespace ConsoleUI;

public abstract class Vehicle
{
    public int year { get; set; }
    public string make { get; set; }
    public string model { get; set; }

    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine($"The {year}, {make} {model} is available for test drive.");
    }
}