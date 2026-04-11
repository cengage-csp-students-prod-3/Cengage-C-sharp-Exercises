using System;
using static System.Console;
using System.Globalization;
class DeliveryCharges
{
	static void Main()
	{
		string[] zips = {"12789", "54012", "54481", "54982", "60007", "60103", "60187", "60188", "71244", "90210"};
		double[] prices = {2.40, 3.00, 3.50, 4.00, 4.50, 5.00, 5.25, 5.75, 6.10, 10.00};

		WriteLine("Enter a zip code: ");
		string userzip = ReadLine();

		int index = Array.IndexOf(zips, userzip);


		if (index != -1)
			WriteLine("Delivery to {0} OK. Delivery charge is {1}", userzip, prices[index].ToString("C", CultureInfo.GetCultureInfo("en-US")));
		else 
			WriteLine("Sorry - no delivery to " + userzip);

	}
}