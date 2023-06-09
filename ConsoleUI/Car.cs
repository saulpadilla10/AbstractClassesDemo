using System;
namespace ConsoleUI
{
	public class Car : Vehicle
	{
		public Car()
		{
		}

        public override void DriveAbstract()
        {
            Console.WriteLine("Stuck in traffic.");
        }

        public bool Hastrunk { get; set; }

    }
}

