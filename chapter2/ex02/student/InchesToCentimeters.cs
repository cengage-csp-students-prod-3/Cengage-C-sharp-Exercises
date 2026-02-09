using System;
using static System.Console;
using System.Globalization;
class InchesToCentimeters
{
	static void Main()
	{
		// Write your code here
		const double CENT_IN_INCH = 2.54;
		double inches = 3;
		double centimeters = inches * CENT_IN_INCH;
		Write("{0} inches is {1} centimeters.", inches, centimeters);
	}
}