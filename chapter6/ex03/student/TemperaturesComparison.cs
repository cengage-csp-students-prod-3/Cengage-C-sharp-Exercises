using System;
using static System.Console;
using System.Globalization;
class TemperaturesComparison
{
	static void Main()
	{
		int[] temps = new int[5];
		int total = 0;
		
		for (int i = 0; i < temps.Length; i++)
		{
			int temp;
			
			do
			{
				Write("Enter a temperature (-30 to 130): ");
				temp = Convert.ToInt32(ReadLine());
			
				if (temp < -30 || temp > 130)
				{
					WriteLine("Invalid Temperature. Try again.");
				}
			}
			while (temp < -30 || temp > 130);

			temps[i] = temp;
			total += temp;		
		}

		double average = (double)total / temps.Length;

		bool ascending = true;
		bool descending = true;

		for (int i = 0; i < temps.Length - 1; i++)
		{
			if (temps[i] < temps[i + 1])
				descending = false;
			if (temps[i] > temps[i + 1])
				ascending = false;
		}

		if (ascending)
			Write("Getting warmer: ");
		else if (descending)
			Write("Getting cooler: ");
		else
			Write("It's a mixed bag: ");

		for (int i = 0; i < temps.Length; i++)
			Write(temps[i] + " ");
		
		WriteLine();
		WriteLine("Average: " + average);
	}
}