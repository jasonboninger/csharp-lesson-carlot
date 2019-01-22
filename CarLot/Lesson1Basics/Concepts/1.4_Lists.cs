using System;
using System.Collections.Generic;

namespace CarLot.Lesson1Basics.Concepts
{
	public class LearningLists
	{
		public LearningLists()
		{






			// The List class

			// It's useful for... lists
			// This is the closest thing in C# to an array in JavaScript
			// There are arrays in C# but they are much more rigid than arrays in JavaScript, hence the existence of the list class

			// We're going to need a using statement for the namespace which contains the list class

			// using System.Collections.Generic // <-- Add this to the top of the file;



			// Create a list of integers

			var integers = new List<int>();

			// Add an integer to the list

			integers.Add(99);

			// Add another integer

			integers.Add(25);



			// Create a list of integers using list shorthand

			var integersEasier = new List<int>
			{
				99,
				25
			};



			// Iterate through the list of integers using a for loop

			for (int i = 0; i < integers.Count; i++)
			{
				var integer = integers[i];
				// Write to the console
				Console.WriteLine("The value is: " + integer);
			}



			// List is a generic class
			// So you can make lists of anything

			var strings = new List<string>();

			var booleans = new List<bool>();



			// Lists are strongly typed just like everything else

			//strings.Add(10); // <-- Will not compile!



			// Some useful methods and properties of lists

			var myList = new List<string>();

			// Add a value
			myList.Add("Put me in!");

			// Get the number of values
			var itemsInMyList = myList.Count;

			// Remove at an index
			myList.RemoveAt(0);

			// And many more...






		}
	}
}

// Try it out

// 1) Create a list of numbers or strings.
// 2) Write the values from your list to the console.
