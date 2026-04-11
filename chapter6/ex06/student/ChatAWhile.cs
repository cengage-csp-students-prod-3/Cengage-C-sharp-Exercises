using System;
using static System.Console;
using System.Globalization;
class ChatAWhile
{
	static void Main()
	{
		int[] areaCodes = {262, 414, 608, 715, 815, 920};
		double[] rates = {0.07, 0.10, 0.05, 0.16, 0.24, 0.14};

		WriteLine("Enter an area code: ");
		int inputArea = Convert.ToInt32(ReadLine());
		WriteLine("Enter length of call in minutes: ");
		int callLength = Convert.ToInt32(ReadLine());

		int index = Array.IndexOf(areaCodes, inputArea);

		if (index != -1)
		{
			double totalCost = callLength * rates[index];
			WriteLine("Your phone call to area {0} costs {1} per minute \nFor {2} minutes the total is {3}.", inputArea, rates[index].ToString("C", CultureInfo.GetCultureInfo("en-US")), callLength, totalCost.ToString("C", CultureInfo.GetCultureInfo("en-US")));
		}
		else 
			WriteLine("Sorry - no calls allowed to area " + inputArea);
	}
}