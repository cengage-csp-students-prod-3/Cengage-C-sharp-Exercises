using System;
using static System.Console;
using System.Globalization;
using System.Numerics;
class ResortPrices
{
	static void Main()
	{
		int[] nightLimits = {2, 4, 7, int.MaxValue};
		double[] rates = {200, 180, 160, 145};

		WriteLine("Enter amount of nights: ");
		int nights = Convert.ToInt32(ReadLine());

		int index = 0;
		double total;

		while (nights > nightLimits[index])
		{
			index++;
		}
		
		total = rates[index] * nights;

		WriteLine("Price per night is {0} \nTotal for {1} night(s) is {2}", rates[index].ToString("C", CultureInfo.GetCultureInfo("en-US")), nights, total.ToString("C", CultureInfo.GetCultureInfo("en-US")));
	}
}