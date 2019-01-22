using System;
using System.Collections.Generic;

namespace CarLot.Lesson1Basics.Concepts
{
	public class Challenge
	{
		public Challenge()
		{






			// Take the car lot challenge

			// Build a console application that:

			// 1) Asks if you would like to add a car to the lot and takes input from the user as an answer.
			// 2) If yes, allows the user to add a car to the lot.
			// 3) If no, shows all cars (if any) in the lot.
			// 4) Allows the user to add as many cars as desired to the lot.

			// ** Bonus ** Show some additional statistics about what the make up of the lot looks like when printing out.






			// Tools You'll Need



			// Converter

			// What if I need to convert a type?

			var myString = "10";

			// Convert my string to an integer
			var myInteger = Convert.ToInt32(myString); // <-- Convert is in the "System" namespace, so it is already available!

			// The variable myInteger is now equal to 10



			// While + Input = An Interactive Application

			// A number adding example

			// Create a list of numbers
			var numbers = new List<int>();
			// Write message
			Console.WriteLine("I will add three numbers for you.");
			// Loop while there are not enough numbers
			while (numbers.Count < 3) // <----------------------------------------- A loop based on input
			{
				// Write message
				Console.WriteLine("I need another number.");
				// Ask for a number
				var number = Console.ReadLine(); // <------------------------------ Some input within the loop
				// Add the number to the list of numbers
				numbers.Add(Convert.ToInt32(number));
			}
			// Create numbers string
			var numbersString = "";
			// Create total
			var total = 0;
			// Run through numbers
			for (int i = 0; i < numbers.Count; i++)
			{
				var number = numbers[i];
				// Add number to string
				numbersString += (numbersString == "" ? "" : ", ") + number;
				// Add number to total
				total += number;
			}
			// Write message
			Console.WriteLine("Your numbers (" + numbersString + ") add up to " + total + "!");
			// Wait for final input before closing
			Console.ReadLine();






		}
	}
}
