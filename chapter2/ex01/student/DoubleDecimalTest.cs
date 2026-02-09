using System;
using static System.Console;
using System.Globalization;
class DoubleDecimalTest
{
	static void Main()
	{
		// Write your code here
		double doubleNumber = 1e54;
		Write("Double: " + doubleNumber);
		decimal decimalNumber = 1e54;
		Write("Decimal: " + decimalNumber);
	}
}