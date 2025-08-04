using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * **Create an abstract class called Vehicle
             * **The vehicle class shall have three string properties: Year, Make, and Model
             * **Set the defaults of the properties to something generic in the Vehicle class
             * **Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * **Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * **Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * **Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * **Provide the implementations for the abstract methods
             * **Only in the Motorcycle class will you override the virtual drive method
            */

            // **Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * **Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * **Set the properties values with object initializer syntax
             */
            Car traverse = new Car()
                { hasTrunk = true, make = "Chevy", model = "Traverse", numberOfSeats = 7, year = 2016 };
            Motorcycle roadKing = new Motorcycle() 
                { HasSideCart = false, make = "Harley-Davidson", model = "Road King", NumberOfWheels = 2, year = 2020 };
            Vehicle cyberTruck = new Car() 
                { hasTrunk = true, make = "Tesla", model = "Cyber Truck", numberOfSeats = 5, year = 2026 };
            Vehicle fz6r = new Motorcycle()
                { HasSideCart = false, make = "Yamaha", model = "FZ-6R", NumberOfWheels = 2, year = 2012 };
            /*
             * **Add the 4 vehicles to the list
             * **Using a foreach loop iterate through the list and display each of the properties
             */
            vehicles.Add(traverse);
            vehicles.Add(roadKing);
            vehicles.Add(cyberTruck);
            vehicles.Add(fz6r);
            foreach (var auto in vehicles)
            {
                Console.WriteLine($"Year: {auto.year}\r\nMake: {auto.make}\r\nModel: {auto.model}\r\n");
                auto.DriveAbstract();
                auto.DriveVirtual();
                Console.WriteLine("-------------------------");
            }
            // **Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
