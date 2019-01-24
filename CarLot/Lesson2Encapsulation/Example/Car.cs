using System;

namespace CarLot.Lesson2Encapsulation.Example
{
	public class Car : IThing<string>
	{
		public string Color { get; set; }
		public string Notes { get; set; }

		public string Id { get; private set; }
		public string VehicleIdNumber { get; private set; }
		public string Make { get; private set; }
		public string Model { get; private set; }
		public int Year { get; private set; }

		public Car()
		{
			// Set VIN
			VehicleIdNumber = Utility.GetInput("What is the VIN number?");
			// Set ID
			Id = VehicleIdNumber;
			// Set make
			Make = Utility.GetInput("What is the make?");
			// Set model
			Model = Utility.GetInput("What is the model?");
			// Set color
			Year = Convert.ToInt32(Utility.GetInput("What is the year?"));
			// Set color
			Color = Utility.GetInput("What is the color?");
			// Set notes
			Notes = Utility.GetInput("Please enter any additional notes:");
		}

		public bool HasSameId(string vehicleIdNumber)
		{
			// Return if ID is the same
			return VehicleIdNumber == vehicleIdNumber;
		}

		public string GetIdFromString(string idString)
		{
			// Return ID
			return idString;
		}

		public string GetStringFromId(string id)
		{
			// Return ID string
			return id;
		}

		public void WriteSummary()
		{
			// Write line
			Console.WriteLine("Vehicle ID Number: " + VehicleIdNumber);
			// Write line
			Console.WriteLine("Make: " + Make);
			// Write line
			Console.WriteLine("Model: " + Model);
			// Write line
			Console.WriteLine("Year: " + Year);
			// Write line
			Console.WriteLine("Color: " + Color);
			// Write line
			Console.WriteLine("Notes: " + Notes);
		}
	}
}
