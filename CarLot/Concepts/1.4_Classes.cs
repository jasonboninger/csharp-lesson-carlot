﻿using System.Collections.Generic;

namespace CarLot.Concepts
{
	public class LearningClasses
	{






		// Classes are the work horse of C#
		// Classes can primarily have two types of declarations inside them

		// 1) Member declarations

		public int MyNumber { get; set; }

		public int GetANumber()
		{
			return 10;
		}

		// 2) Static declarations

		public static int AnotherNumber { get; set; } // <-- Notice the static keyword

		public static int GetADifferentNumber() // <-- Notice the static keyword
		{
			return 15;
		}

		// Declarations in C# do not default to public
		// Explicitly declaring access modifiers is never a bad idea




		

		public LearningClasses()
		{






			// Let's create a "Car" class



			// Static declarations can be used through the class directly
			// Set makes of cars

			Car.Makes = new List<string>
			{
				"Ford",
				"Honda",
				"GMC",
				"Toyota",
				"Hyundai"
			};



			// Member declarations can be used only by an instanced of the class
			// First, we must instantiate a car

			var car = new Car();

			// Then, we can set its color

			car.Color = "Red";



			// But, wait, there's a better way to instantiate!
			// We can create an instance and set member properties all at once

			var car2 = new Car()
			{
				Color = "Silver"
			};



			// When we instantiate a class we are only required to use parenthesises or curly brackets
			// We don't have to use both

			var car3 = new Car // <-- Look ma, no parenthesises!
			{
				Color = "Black"
			};



			// When we use curly brackets, we are never required to set properties
			
			var car4 = new Car { }; // <-- This is valid






		}
	}
}

// Try it out

// 1) Create a car class.
// 2) Add at least three properties.
// 3) Add at least one method.
// 4) Write some information about your car to the console.

// ** Bonus ** Create a list of cars and write information from each car to the console.