﻿namespace CarLot
{
	class Program
	{
		static void Main(string[] args)
		{
			if (false)
			{
				// To see an example solution to the lesson one challenge
				Lesson1Basics.Example.CarLot.Run();
			}
			if (false)
			{
				// To see an example solution to the lesson two challenge
				new Lesson2Encapsulation.Example.Lot<Lesson2Encapsulation.Example.Car, string>().ManageThings();
				new Lesson2Encapsulation.Example.Lot<Lesson2Encapsulation.Example.Employee, int>().ManageThings();
			}
			if (true)
			{
				// Run the lesson three program
				Lesson3Review.Program.Execute(args);
			}
		}
	}
}
