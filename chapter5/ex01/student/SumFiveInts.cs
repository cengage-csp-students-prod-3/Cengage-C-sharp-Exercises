using System;
using static System.Console;
using System.Globalization;
class SumFiveInts
{
	static void Main()
	{
		int number = 0;
		int sum;

		for (x = 1; x <= 5; x++) {
		Writeline("Enter an integer: ");
		number = Convert.toInt32(Readline());
		sum += number;
	}
	Write("The sum is " + sum);
	
}