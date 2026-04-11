using System;
using static System.Console;
using System.Globalization;
class TypingGrades
{
	static void Main()
	{
		int[] wordLimit = {15, 30, 50, 75, int.MaxValue};
		string[] grades = {"F", "D", "C", "B", "A"};

		WriteLine("Enter number of words typed: ");
		int inputWords = Convert.ToInt32(ReadLine());

		int index = 0;

		while (inputWords > wordLimit[index])
		{
			index++;
		}

		WriteLine("Typing {0} words per minute: Grade {1}.", inputWords, grades[index]);
	}
}