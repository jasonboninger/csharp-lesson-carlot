using System;
using System.Collections.Generic;

namespace CarLot.Lesson2Encapsulation.Example
{
	public class Lot<TThing, TId> where TThing : IThing<TId>, new()
	{
		public List<TThing> Things { get; private set; }

		public Lot()
		{
			// Create things
			Things = new List<TThing>();
		}

		public void ManageThings()
		{
			// Write welcome
			_WriteWelcome();
			// Loop forever until break
			while (true)
			{
				// Get action
				var action = Utility.GetInput("What would you like to do? You can ADD, REMOVE, REVIEW, OR EXIT.").ToUpper();
				// Write separator
				Utility.WriteSeparator();
				// Check action
				if (action == "ADD")
				{
					// Add things
					_AddThings();
				}
				else if (action == "REMOVE")
				{
					// Remove things
					_RemoveThings();
				}
				else if (action == "REVIEW")
				{
					// Review things
					_ReviewThings();
				}
				else if (action == "EXIT")
				{
					// Write farewell
					_WriteFarewell();
					// Stop loop
					break;
				}
				else
				{
					// Write line
					Console.WriteLine("That's not valid input.");
					// Write separator
					Utility.WriteSeparator();
				}
			}
		}

		private void _AddThings()
		{
			// Loop forever until break
			while (true)
			{
				// Add thing
				_AddThing();
				// Write separator
				Utility.WriteSeparator();
				// Get yes
				var yes = _GetYes("Do you want to add another thing?");
				// Write separator
				Utility.WriteSeparator();
				// Check if not yes
				if (!yes)
				{
					// Stop loop
					break;
				}
			}
		}

		private void _RemoveThings()
		{
			// Loop forever until break
			while (true)
			{
				// Remove thing
				_RemoveThing(Utility.GetInput("What thing would you like to remove?"));
				// Write separator
				Utility.WriteSeparator();
				// Get yes
				var yes = _GetYes("Do you want to remove another thing?");
				// Write separator
				Utility.WriteSeparator();
				// Check if not yes
				if (!yes)
				{
					// Stop loop
					break;
				}
			}
		}

		private void _ReviewThings()
		{
			// Write line
			Console.WriteLine();
			// Get is or are
			var isAre = Things.Count == 1 ? "is" : "are";
			// Get s
			var s = Things.Count == 1 ? "" : "s";
			// Write message
			Console.WriteLine("There " + isAre + " " + Things.Count + " thing" + s + " in your lot!");
			// Write line
			Console.WriteLine();
			// Write separator
			Utility.WriteSeparator();
			// Write line
			Console.WriteLine();
			// Run through things
			for (int i = 0; i < Things.Count; i++)
			{
				var thing = Things[i];
				// Write message
				thing.WriteSummary();
				// Write line
				Console.WriteLine();
				// Write separator
				Utility.WriteSeparator();
				// Write line
				Console.WriteLine();
			}
		}

		private void _AddThing()
		{
			// Create thing
			var thing = new TThing();
			// Add thing to things
			Things.Add(thing);
		}

		private void _RemoveThing(string idString)
		{
			// Run through things
			for (int i = 0; i < Things.Count; i++)
			{
				var thing = Things[i];
				// Get ID
				var id = thing.GetIdFromString(idString);
				// Check if thing ID is same
				if (thing.HasSameId(id))
				{
					// Remove thing
					Things.RemoveAt(i);
					// Write message
					Console.WriteLine("Removed thing with ID of " + thing.GetStringFromId(id) + ".");
					// Return
					return;
				}
			}
			// Write message
			Console.WriteLine("Could not find a thing with ID of " + idString + ".");
		}

		private bool _GetYes(string prompt)
		{
			// Get input
			var input = Utility.GetInput(prompt + " YES OR NO?").ToLower();
			// Return if input is yes
			return input == "y" || input == "yes";
		}

		private void _WriteWelcome()
		{
			// Write message
			Console.WriteLine("Welcome to your lot!");
			// Write separator
			Utility.WriteSeparator();
		}

		private void _WriteFarewell()
		{
			// Write message
			Console.WriteLine("See you next time!");
			// Write separator
			Utility.WriteSeparator();
		}
	}
}
