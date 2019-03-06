using System;
using static CarLot.Lesson3Review.Solution;

namespace CarLot.Lesson3Review
{
	public class Program
	{
		public static void Execute(string[] args)
		{
			// My problem

			// It's a lot of typing the same method call over and over to get a very simple result
			// The output is hard to read, no distinction between logical groups
			// It is a completely plain text experience

			if (false)
			{
				Console.WriteLine("Hello, world!");

				Console.WriteLine("Hello, company!");

				Console.WriteLine("Hello, developer!");

				Console.WriteLine("Grocery List:");

				Console.WriteLine("Deli:");
				Console.WriteLine("Chicken");
				Console.WriteLine("Cheese");

				Console.WriteLine("Produce:");
				Console.WriteLine("Apples");
				Console.WriteLine("Bananas");
				Console.WriteLine("Grapes");

				Console.WriteLine("Other:");
				Console.WriteLine("Bread");
				Console.WriteLine("Eggs");
			}



			// What I want

			if (false)
			{
				var logger = new Logger();

				logger.Log("Hello, world!");

				logger.Log("Hello, company!");

				logger.Log("Hello, developer!");

				logger.Log
					(
						new Line("Grocery List:"),
						new Line(),
						new Line("Important Item", ConsoleColor.Black, ConsoleColor.Yellow),
						new Line(),
						new Line("Deli:"),
						new Line("Chicken"),
						new Line("Cheese", ConsoleColor.Black, ConsoleColor.Yellow),
						new Line(),
						new Line("Produce:"),
						new Line("Apples"),
						new Line("Bananas"),
						new Line(),
						new Line("Other:"),
						new Line("Bread", ConsoleColor.Black, ConsoleColor.Yellow),
						new Line("Eggs")
					);
			}

			// Work here

			if (true)
			{

			}
		}
	}
}
