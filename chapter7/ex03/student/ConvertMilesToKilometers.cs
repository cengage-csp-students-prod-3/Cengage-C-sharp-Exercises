using System;
using static System.Console;
using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
class ConvertMilesToKilometers
{
	static void Main()
	{
		WriteLine("Enter number of miles: ");
		int miles = Convert.ToInt32(ReadLine());

		double kms = ConvertToKilometers(miles);
		WriteLine("{0} miles is {1} kilometers", miles, kms);
	}

	public static double ConvertToKilometers(int miles)
	{
		double kms = miles * 1.60934;
		return kms;
	}
}