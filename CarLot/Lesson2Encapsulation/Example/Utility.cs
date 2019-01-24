using System;

namespace CarLot.Lesson2Encapsulation.Example
{
	public class Utility
	{
		public static void WriteSeparator()
		{
			// Write separator
			Console.WriteLine("=====");
		}

		public static string GetInput(string prompt)
		{
			// Write line
			Console.WriteLine(prompt);
			// Read line
			return Console.ReadLine();
		}
	}
}