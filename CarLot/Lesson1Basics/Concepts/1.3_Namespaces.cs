


// import { Console } from "System";
//
// Would be like

using System;



// import { Observable } from "rxjs";
//
// Would be like
//
// using rxjs;
//
// Then, Observable and anything else in the "rxjs" namespace would be available



namespace CarLot.Lesson1Basics.Concepts
{
	public class LearningNamespaces
	{
		public LearningNamespaces()
		{






			// Using namespaces allows us to use objects in that namespace without fully qualifying the name
			// You can think about using statements like import statement except that you get everything
			// You do not specify what you want between curly brackets
			
			// Below we can use the "Console" class because we are using the "System" namespace above

			Console.ReadLine(); // <-- I cannot remove the using statement or this won't work



			// You never have to use using statements
			// Instead, you can fully qualify class names

			System.Console.ReadLine(); // <-- I could remove the "System" using statement above and this would still work



			// Visual Studio creates the main console application file with a using for "System" already added
			// Convenient!



			// Visual Studio wants to help, with Quick Actions
			// Visual Studio will make recommendations for namespaces to use for unrecognized classes
			
			// Right-click on the class and choose Quick Actions
			// With your cursor on the same line, press Ctrl + .






		}
	}
}

// Try it out

// 1) Remove the system using statement and reference fully qualify the namespace for Console.
// 2) Verify that everything is still working exactly the same.
