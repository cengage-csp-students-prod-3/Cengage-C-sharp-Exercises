using System;
using static System.Console;
using System.Globalization;
class InchesToCentimeterslnteractive
{
	static void Main()
	{
		// Write your code here
		const double CENT_IN_INCH = 2.54;
		double inches;
		Write("Enter Inches: ");
		inches = Convert.ToDouble(ReadLine());
		double centimeters = inches * CENT_IN_INCH;
		Write("{0} inches is {1} centimeters.", inches, centimeters);

	}
}
