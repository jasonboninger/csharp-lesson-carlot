using System;
using System.Collections.Generic;

namespace CarLot.Lesson1Basics.Example
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
				// Get a or another
				var aAnother = cars.Count == 0 ? "a" : "another";
				// Write message
				Console.WriteLine("Do you want to add " + aAnother + " car?");
				// Write separator
				Utility.WriteSeparator();
				// Get input
				var input = Console.ReadLine().ToLower();
				// Check if input is yes
				if (input == "y" || input == "yes")
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
				else
				{
					// Stop loop
					break;
				}
			}
			// Write separator
			Utility.WriteSeparator();
			// Write line
			Console.WriteLine();
			// Get is or are
			var isAre = cars.Count == 1 ? "is" : "are";
			// Get s
			var s = cars.Count == 1 ? "" : "s";
			// Write message
			Console.WriteLine("There " + isAre + " " + cars.Count + " car" + s + " in your lot!");
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
