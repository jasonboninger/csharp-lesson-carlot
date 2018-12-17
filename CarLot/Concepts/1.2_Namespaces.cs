using System;

namespace CarLot.Concepts
{
	public class LearningNamespaces
	{
		public LearningNamespaces()
		{






			// Using namespaces allows us to use objects in that namespace without fully qualifying the name
			
			// Let's use the "Console" class, which is in the "System" namespace

			Console.ReadLine(); // <-- I cannot remove the using statement or this won't work



			// You never have to use using statements if you fully qualify all class names

			System.Console.ReadLine(); // <-- I could remove the using statement and this would still work



			// Visual Studio creates the main console application file with a using for "System" already added
			// Convenient!






		}
	}
}

// Try it out

// 1) Remove the system using statement and reference fully qualify the namespace for Console.
// 2) Verify that everything is still working exactly the same.
