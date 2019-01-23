namespace CarLot.Lesson1Basics.Concepts
{
	public class Null
	{
		public Null()
		{






			// Null is the value of nothing
			// Classes and strings can always be null

			CarExample car = null; // <-- No problem

			string myString = null; // <-- No problem



			// Integers cannot be null

			//int myInteger = null; // <-- Will not compile!

			// We need to indicate that it is nullable

			int? myNullableInteger = null; // <-- This works



			// What's going on here?

			// Reference types can always be null
			// Value types can never be null unless they are declared with a question mark after their type



			// Let's talk about strings

			// Strings are special
			// They are value types, but they always act as if they were declared with a question mark after their type

			// Basically, you can think of string as always being string? implicitly






		}
	}
}
