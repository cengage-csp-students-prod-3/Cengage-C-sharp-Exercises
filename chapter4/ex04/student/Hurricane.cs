using System;
using static System.Console;
using System.Globalization;
using System.ComponentModel;
class Hurricane
{
	static void Main()
	{
		string inputString;
		int speed;
		int cat;

		WriteLine("Enter wind speed: ");
		inputString = ReadLine();
		speed = Convert.ToInt32(inputString);

		if (speed >= 157)
			cat = 5;
		else if (speed >= 130)
			cat = 4;
		else if (speed >= 111)
			cat = 3;
		else if (speed >= 96)
			cat = 2;
		else if (speed >= 74)
			cat = 1;
		else
			cat = 0;

		if (cat > 0)
			WriteLine("This is a category {0} hurricane.", cat);
		else
			WriteLine("This is not a hurricane.");
	}
}