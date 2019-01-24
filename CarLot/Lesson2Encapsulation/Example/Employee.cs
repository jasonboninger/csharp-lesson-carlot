using System;

namespace CarLot.Lesson2Encapsulation.Example
{
	public class Employee : IThing<int>
	{
		public int Id { get; private set; }
		public string Name { get; private set; }

		public Employee()
		{
			// Set ID
			Id = Convert.ToInt32(Utility.GetInput("What is the employee's ID?"));
			// Set name
			Name = Utility.GetInput("What is the employee's name?");
		}

		public int GetIdFromString(string idString)
		{
			// Return ID
			return Convert.ToInt32(idString);
		}

		public string GetStringFromId(int id)
		{
			// Return ID string
			return id.ToString();
		}

		public bool HasSameId(int id)
		{
			// Return if ID is the same
			return Id == id;
		}

		public void WriteSummary()
		{
			// Write line
			Console.WriteLine("ID = " + Id + ", Name = " + Name);
		}
	}
}
