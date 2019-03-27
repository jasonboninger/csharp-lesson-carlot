using System;
using LoggerSolution = CarLot.Lesson3Review.Solution.Logger;
using LineSolution = CarLot.Lesson3Review.Solution.Logger.Line;

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
				var logger = new LoggerSolution();

				logger.Log("Hello, world!");

				logger.Log("Hello, company!");

				logger.Log("Hello, developer!");

				logger.Log
					(
						new LineSolution("Grocery List:"),
						new LineSolution(),
						new LineSolution("Important Item", ConsoleColor.Black, ConsoleColor.Yellow),
						new LineSolution(),
						new LineSolution("Deli:"),
						new LineSolution("Chicken"),
						new LineSolution("Cheese", ConsoleColor.Black, ConsoleColor.Yellow),
						new LineSolution(),
						new LineSolution("Produce:"),
						new LineSolution("Apples"),
						new LineSolution("Bananas"),
						new LineSolution(),
						new LineSolution("Other:"),
						new LineSolution("Bread", ConsoleColor.Black, ConsoleColor.Yellow),
						new LineSolution("Eggs")
					);
			}

			// Work here

			// QUESTION = What classes, methods, properties will be needed?

			// Logger class to do the extra work behind the scenes

			// Caller INPUTS of text color and background color, optional

			// Line class - Why?

			// Line group class

			// CODE

			// Write messages with spacing and divider text - Logger
			// Allow configuration of spacing and divider text
			// Write multi-line messages

			if (true)
			{
				var logger = new Logger(spacing: 2, divider: "=======");

				logger.Log
					(
						new Logger.Line("I am some text!"),
						new Logger.Line("I am some colored text!", backgroundColor: ConsoleColor.DarkBlue),
						new Logger.Line("I have no color... :-(")
					);

				logger.Log("Hello, company!");

				logger.Log("Hello, developer!");

				logger.Log
					(
						"Groceries:",
						"Apples",
						"Bananas"
					);

				//logger.Log
				//	(
				//		new Line("Grocery List:"),
				//		new Line(),
				//		new Line("Important Item", ConsoleColor.Black, ConsoleColor.Yellow),
				//		new Line(),
				//		new Line("Deli:"),
				//		new Line("Chicken"),
				//		new Line("Cheese", ConsoleColor.Black, ConsoleColor.Yellow),
				//		new Line(),
				//		new Line("Produce:"),
				//		new Line("Apples"),
				//		new Line("Bananas"),
				//		new Line(),
				//		new Line("Other:"),
				//		new Line("Bread", ConsoleColor.Black, ConsoleColor.Yellow),
				//		new Line("Eggs")
				//	);
			}
		}
	}
}
