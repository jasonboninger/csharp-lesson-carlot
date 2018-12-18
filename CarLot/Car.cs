using System;
using System.Collections.Generic;
using System.Text;

namespace CarLot
{
	// || Declare that the class is publicly available
	// \/
	public class Car
	{
		// || Declare a static property
		// \/
		public static List<string> Makes { get; set; }

		// || Declare a member property
		// \/
		public string Color { get; set; }

		// || Declare a member method
		// \/
		public bool IsCool(string color)
		{
			return true;
		}
	}
}

/*

export class Car {

	static makes: string[];

	color: string;

	isCool(): boolean {
		return true;
	}
}

*/
