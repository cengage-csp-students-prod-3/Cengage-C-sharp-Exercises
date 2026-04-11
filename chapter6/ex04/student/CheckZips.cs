using System;
using static System.Console;
using System.Globalization;
using System.Linq;
class CheckZips
{
	static void Main()
	{
		string[] zips = {"12789", "54012", "54481", "54982", "60007",
         "60103", "60187", "60188", "71244", "90210"};
		
		Write("Enter a zip code: ");
		string userzip = ReadLine();

		if (zips.Contains(userzip))
			WriteLine("Delivery to " + userzip + " OK");
		else 
			WriteLine("Sorry - no delivery to " + userzip);
	}
}
