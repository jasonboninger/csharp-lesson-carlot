namespace CarLot.Lesson2Encapsulation.Concepts
{
	public class Interfaces
	{






		// Interfaces are a guarantee of a certain structure

		// An interface could be thought of as a contract

		// Interfaces are typically prefixed with an "I" by convention

		public interface ICar
		{
			string Color { get; set; }
		}



		// Interfaces do not set public, protected, or private on their members because they must always be implemented

		// Interfaces must be implemented exactly

		public interface IThingOne
		{
			string Name { get; set; }
		}

		// Is different from

		public interface IThingTwo
		{
			string Name { get; }
		}

		// Why different? IThingTwo only requires that the Name property be gettable but IThingOne requires it be gettable and settable



		// A class can implement any number of interfaces

		public class CoolCar : ICar, IThingOne
		{
			public string Color { get; set; }

			public string Name { get; set; }
		}






	}
}
