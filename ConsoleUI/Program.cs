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
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

      
            var vehicles = new List<Vehicle>();

            Vehicle motorcycle01 = new Motorcycle { Year = "2023", Make = "Indian", Model = "RoadMaster Elite", HasSideCart = true };
            
            Vehicle car01 = new Car { Year = "2010", Make = "Chevorlet", Model = "Camaro", Hastrunk = true };
          
            Car mustang = new Car();

            Motorcycle harley = new Motorcycle();

            vehicles.AddRange(new Vehicle[] { motorcycle01, car01, mustang, harley });

            mustang.Year = "2021";
            mustang.Make = "Ford";
            mustang.Model = "Mustang";
            mustang.Hastrunk = true;


            harley.Year = "2019";
            harley.Make = "Harley-Davidson";
            harley.Model = "FLTRXS - Road Glide Special";
            harley.HasSideCart = false;


            foreach (var property in typeof(Motorcycle).GetProperties())
            {
                var value = property.GetValue(harley);
                Console.WriteLine($"{property.Name}: {value}");

            }
                harley.DriveVirtual();

            Console.WriteLine("-----------------------------");


            foreach (var property in typeof(Motorcycle).GetProperties())
            {
                var value = property.GetValue(motorcycle01);
                Console.WriteLine($"{property.Name}: {value}");

            }
                motorcycle01.DriveAbstract();

            Console.WriteLine("-----------------------------");


            foreach (var property in typeof(Car).GetProperties())
            {
                var value = property.GetValue(car01);
                Console.WriteLine($"{property.Name}: {value}");

            }
                car01.DriveVirtual();

            Console.WriteLine("-----------------------------");

            foreach (var property in typeof(Car).GetProperties())
            {
                var value = property.GetValue(mustang);
                Console.WriteLine($"{property.Name}: {value}");
            }
                mustang.DriveAbstract();

            Console.WriteLine("-----------------------------");




            #endregion
            Console.ReadLine();
        }
    }
}
