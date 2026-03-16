using System;
using static System.Console;
using System.Globalization;
class DailyTemps
{
	static void Main()
	{
		int temp = 0;
		int total = 0;
		int count = 0;
		double average = 0;
		//WriteLine("Please enter a daily high temperature.");
		//temp = Convert.ToInt32(ReadLine());

		while (temp != 999)
		{
			WriteLine("Please enter a daily high temperature.");
			temp = Convert.ToInt32(ReadLine());
			if (temp <= 130 && temp >= -20)
			{
				total += temp;
				count++;
				average = total / count;
			}
			else
			WriteLine("Valid temperatures range from -20 to 130. Please reenter temperatures.");
		}
		WriteLine("Number of temperatures entered: " + count);
		WriteLine("Average temperature: " + average);
	}
}