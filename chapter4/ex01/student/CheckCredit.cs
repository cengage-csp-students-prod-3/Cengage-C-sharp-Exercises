using System;
using static System.Console;
using System.Globalization;
class CheckCredit
{
	static void Main()
	{
		string inputString;
		double purchase;
		WriteLine("Enter a purchase price: ");
		inputString = ReadLine();
		purchase = Convert.ToDouble(inputString);

		if (purchase > 8000)
			WriteLine("You have exceeded the credit limit");
		else
			WriteLine("Approved");
	}
}