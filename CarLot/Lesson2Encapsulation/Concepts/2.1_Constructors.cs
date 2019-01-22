namespace CarLot.Lesson2Encapsulation.Concepts
{
	public class Constructors
	{






		// When a class is created, it must call a constructor

		// Creating constructors is such a common task there is a snippet for them: type "ctor" and then hit tab twice

		// A constructor LOOKS like a method, but it's really completely specialized

		public class Test
		{
			public int MyNumber { get; set; }

			public Test(int myNumber)	// <-- This is the constructor for the Test class
			{							// <--
				MyNumber = myNumber;	// <--
			}							// <--
		}

		/* IN TYPESCRIPT \/
		
		export class Test {
			myNumber: number;

			constructor(myNumber: number) {
				this.myNumber = myNumber;
			}
		}

		/\ IN TYPESCRIPT */

		// To create an instance of the Test class we must call its constructor

		public Constructors()
		{
			// Create a test
			var test = new Test(10); // <-- The constructor has one parameter
		}

		// Some special things about constructors

		// 1) Constructors always have the same name as their class

		// 2) Constructors do not have a return type

		// 3) Exactly one constructor will be called when a class is instantiated




		

		// So why is this class valid?

		public class LookMaNoHands
		{
			public int NumberOfHandsBeingUsed { get; set; }
		}

		// If no constructor is explicity defined, then a class has a default constructor with no parameters

		// Very convenient

		

		// However, if a constructor is defined, and a parameterless constructor is desired, then it must be defined as well

		public class LookMaIAmResponsible
		{
			public int NumberOfHandsBeingUsed { get; }

			public LookMaIAmResponsible(int numberOfHandsBeingUsed) // <-- This is now the only constructor on this class
			{
				NumberOfHandsBeingUsed = numberOfHandsBeingUsed;
			}
		}
	}
}
