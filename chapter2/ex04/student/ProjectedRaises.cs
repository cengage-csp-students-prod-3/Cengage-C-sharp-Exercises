using System;
using static System.Console;
using System.Globalization;
class ProjectedRaises
{
	static void Main()
	{
		// Write your code here
		const double RAISE_RATE = 0.04;
		double salary1 = 25000;
		double salary2 = 38000;
		double salary3 = 51000;

		double nextYrSalary1 = salary1 + (salary1 * RAISE_RATE);
		double nextYrSalary2 = salary2 + (salary2 * RAISE_RATE);
		double nextYrSalary3 = salary3 + (salary3 * RAISE_RATE);

		WriteLine("Next year's salary for the first employee will be {0}.", nextYrSalary1.ToString("C", CultureInfo.GetCultureInfo("en-US")));
		WriteLine("Next year's salary for the second employee will be {0}.", nextYrSalary2.ToString("C", CultureInfo.GetCultureInfo("en-US")));
		WriteLine("Next year's salary for the third employee will be {0}.", nextYrSalary3.ToString("C", CultureInfo.GetCultureInfo("en-US")));

	}
}