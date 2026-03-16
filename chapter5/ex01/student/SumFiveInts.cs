using System;
using static System.Console;
using System.Globalization;
class SumFiveInts
{
	static void Main()
	{
		int number;
		int sum = 0;

		for (int x = 1; x <= 5; x++) {
		WriteLine("Enter an integer: ");
		number = Convert.ToInt32(ReadLine());
		sum += number;
	}
	WriteLine("The sum is " + sum);	
}
}