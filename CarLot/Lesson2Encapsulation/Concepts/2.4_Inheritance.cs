namespace CarLot.Lesson2Encapsulation.Concepts
{
	public class Inheritance
	{






		// Inheritance is a way to extend a class

		// Test is a class

		public class Test
		{
			public string TestValue { get; set; }

			public void Run()
			{
				// Do some tests here
			}
		}



		// InDepthTest inherits from Test

		public class InDepthTest : Test
		{
			public int TestNumber { get; set; }
		}

		/* IN TYPESCRIPT \/
		
		export class InDepthTest extends Test {
			testNumber: number;
		}

		/\ IN TYPESCRIPT */



		// Usage

		public Inheritance()
		{
			// We can create a test
			Test test = new Test();
			// We can create a in depth test
			InDepthTest inDepthTest = new InDepthTest();



			// We can set Test to InDepthTest
			test = inDepthTest;
			// We cannot set InDepthTest to Test
			//inDepthTest = test;



			// We can access all members of Test from InDepthTest
			inDepthTest.TestValue = "A Test Value";
			inDepthTest.Run();

			// We can also access the added members of InDepthTest
			inDepthTest.TestNumber = 9;
		}






	}
}
