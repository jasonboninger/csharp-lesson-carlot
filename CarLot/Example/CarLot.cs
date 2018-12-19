using System;
using System.Collections.Generic;

namespace CarLot.Example
{
	public class CarLot
	{
		public static void Run()
		{
			// Write message
			Console.WriteLine("Welcome to your car lot!");
			// Write separator
			Utility.WriteSeparator();
			// Create cars
			var cars = new List<Car>();
			// Loop forever until break
			while (true)
			{
				// Write message
				Console.WriteLine("Do you want to add" + (cars.Count == 0 ? " a" : " another") + " car?");
				// Write separator
				Utility.WriteSeparator();
				// Get input
				var input = Console.ReadLine().ToLower();
				// Check if input is not yes
				if (input != "y" && input != "yes")
				{
					// Stop loop
					break;
				}
				else
				{
					// Create car
					var car = new Car();
					// Request information
					car.RequestInformation();
					// Add car to cars
					cars.Add(car);
					// Write separator
					Utility.WriteSeparator();
				}
			}
			// Write separator
			Utility.WriteSeparator();
			// Write line
			Console.WriteLine();
			// Write message
			Console.WriteLine("There " + (cars.Count == 1 ? "is" : "are") + " " + cars.Count + " car" + (cars.Count == 1 ? "" : "s") + " in your lot!");
			// Write line
			Console.WriteLine();
			// Write separator
			Utility.WriteSeparator();
			// Write line
			Console.WriteLine();
			// Run through cars
			for (int i = 0; i < cars.Count; i++)
			{
				var car = cars[i];
				// Write message
				car.WriteSummary();
				// Write line
				Console.WriteLine();
				// Write separator
				Utility.WriteSeparator();
				// Write line
				Console.WriteLine();
			}
			// Write message
			Console.WriteLine("Press enter to exit your car lot.");
			// Read line
			Console.ReadLine();
		}
	}
}
