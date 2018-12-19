using System;

namespace CarLot.Example
{
	public class Car
	{
		public string VehicleIdNumber { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string Color { get; set; }
		public string Notes { get; set; }

		public void RequestInformation()
		{
			// Set VIN
			VehicleIdNumber = _GetInput("What is the VIN number?");
			// Set make
			Make = _GetInput("What is the make?");
			// Set model
			Model = _GetInput("What is the model?");
			// Set color
			Year = Convert.ToInt32(_GetInput("What is the year?"));
			// Set color
			Color = _GetInput("What is the color?");
			// Set notes
			Notes = _GetInput("Please enter any additional notes:");
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

		private string _GetInput(string prompt)
		{
			// Write line
			Console.WriteLine(prompt);
			// Read line
			return Console.ReadLine();
		}
	}
}
