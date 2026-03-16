using System;
using static System.Console;
using System.Globalization;
class EnterUppercaseLetters
{
	static void Main()
	{
	
		WriteLine("Enter an uppercase letter");
		String letter = ReadLine();

		while (letter != "!") {
			
		if (letter == letter.ToUpper())
			{
				WriteLine("OK");
			}
		else
			WriteLine("Sorry - that was not an uppercase letter.");
		
		WriteLine("Enter an uppercase letter or ! to quit");
		letter = ReadLine();

	}
	}
}