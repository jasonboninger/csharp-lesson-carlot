using System;
using System.Collections.Generic;

namespace CarLot.Lesson2Encapsulation.Concepts
{
	public class Generics
	{






		// Generics let your user decide the type that they want

		// Generic types are typically prefixed with a T by convention

		// Generics can be used with just about everything

		// 1) Classes

		public class MyGenericContainerClass<TValue>
		{
			public TValue Value { get; set; }
		}

		// 2) Interfaces

		public interface MyGenericInterface<TValue>
		{
			TValue Value { get; set; }
		}

		// 3) Methods

		public TValue MyGenericMethod<TValue>(TValue value)
		{
			return value;
		}






		// Generic types are only as useful as they are defined

		// Combining generics and interfaces is quite powerful

		public interface IFlaggable
		{
			bool Flagged { get; }
		}

		public class FlaggableList<TFlaggable> where TFlaggable : IFlaggable
		{
			public List<TFlaggable> Items { get; }

			public FlaggableList()
			{
				Items = new List<TFlaggable>();
			}

			public int CountFlagged()
			{
				var countFlagged = 0;
				for (int i = 0; i < Items.Count; i++)
				{
					var item = Items[i];
					if (item != null & item.Flagged)
					{
						countFlagged++;
					}
				}
				return countFlagged;
			}

			public List<TFlaggable> GetFlagged()
			{
				var flaggables = new List<TFlaggable>();
				for (int i = 0; i < Items.Count; i++)
				{
					var item = Items[i];
					if (item != null & item.Flagged)
					{
						flaggables.Add(item);
					}
				}
				return flaggables;
			}
		}

		// Let's use it like someone else would

		public class Animal : IFlaggable
		{
			public string Name { get; set; }
			public bool Flagged { get; set; }
		}

		public Generics()
		{
			// Create a flaggable list
			var flaggableList = new FlaggableList<Animal>();
			// Add animals
			flaggableList.Items.Add(new Animal { Name = "Lion", Flagged = false });
			flaggableList.Items.Add(new Animal { Name = "Tigers", Flagged = true });
			flaggableList.Items.Add(new Animal { Name = "Bears", Flagged = false });
			// Get flagged animals
			var animalsFlagged = flaggableList.GetFlagged();
			// Log the flagged animals
			for (int i = 0; i < animalsFlagged.Count; i++)
			{
				// Log the name of the animal
				Console.WriteLine(animalsFlagged[i].Name);
			}
		}






	}
}
