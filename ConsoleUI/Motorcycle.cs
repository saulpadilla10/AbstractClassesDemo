
using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
		public Motorcycle()
		{
		}


        public override void DriveVirtual()
        {
            Console.WriteLine("Weaves through traffic.");

        }

        public override void DriveAbstract()
        {
            Console.WriteLine($"{GetType().Name} is not for sale.");
        }

        public bool HasSideCart { get; set; }


    }
}

