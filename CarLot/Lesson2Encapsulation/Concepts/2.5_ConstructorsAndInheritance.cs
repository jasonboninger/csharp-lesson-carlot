namespace CarLot.Lesson2Encapsulation.Concepts
{
	public class ConstructorsAndInheritance
	{






		// Constructors must be respected when a class inherits from another class

		// Remember, a construct must be called when a class is instantiated

		// This must be respected by every implementation of a class

		public class Test
		{
			public string Name { get; private set; }

			public Test(string name)
			{
				Name = name;
			}
		}

		public class AnotherTest : Test
		{
			public string Location { get; private set; }

			public AnotherTest(string name, string location) : base(name)
			{
				Location = location;
			}
		}

		// Why is this only coming up now?

		// Every class we've inherited from before this one has always had a default constructor






	}
}
