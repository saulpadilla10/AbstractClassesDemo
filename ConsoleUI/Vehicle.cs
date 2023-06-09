using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
		
		public string Year { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }

		public abstract void DriveAbstract();
  

        public virtual void DriveVirtual()
		{
			Console.WriteLine($"{GetType().Name} is for sale");

		}

		



		
	}
}

