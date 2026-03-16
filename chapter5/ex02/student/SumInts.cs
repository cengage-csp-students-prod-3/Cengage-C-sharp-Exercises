using System;
using static System.Console;
using System.Globalization;
class SumInts
{
	static void Main()
	{
		int sum = 0;
		int number = 0;

		while (number != 999)
		{
			WriteLine("Enter an integer: ");
			number = Convert.ToInt32(ReadLine());
			if (number != 999) {
			sum += number; }
		}
		WriteLine("The sum of integers is " + sum);
	}
}