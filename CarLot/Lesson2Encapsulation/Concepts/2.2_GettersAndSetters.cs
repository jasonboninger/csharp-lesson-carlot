namespace CarLot.Lesson2Encapsulation.Concepts
{
	public class GettersAndSetters
	{






		// Getters and setters are how properties are defined in a class

		// Getters and setters make good use of access modifiers (public, protected, private, etc.)

		// The following House class has a property called NumberOfWindows that is publicly gettable and publicly settable

		public class HouseBlueprint
		{
			public int NumberOfWindows { get; set; }
		}



		// Should an outside force be able to change the number of windows that a house has? Maybe... but maybe not.

		// So what can we do about it? Only allow public getting, and private setting

		public class ConstructedHouse
		{
			public int NumberOfWindows { get; private set; } // <-- The private in front of set changes its access setting
			public int PanesOfGlass { get; private set; }

			public ConstructedHouse(int numberOfWindows, bool doublePanedWindows)
			{
				NumberOfWindows = numberOfWindows;
				PanesOfGlass = numberOfWindows * (doublePanedWindows ? 2 : 1);
			}
		}



		// Who decides how many windows? The creator.

		// Who owns the number of windows? The constructed house.

		public GettersAndSetters()
		{
			// Create a contructed house
			var constructedHouse = new ConstructedHouse(5, false);
			// Get the number of windows
			var numberOfWindows = constructedHouse.NumberOfWindows;
			// Cannot set the number of windows
			//constructedHouse.NumberOfWindows = 10;
		}






	}
}
