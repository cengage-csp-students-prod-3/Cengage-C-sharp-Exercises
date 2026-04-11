using System;
using static System.Console;
using System.Globalization;
using System.ComponentModel.Design.Serialization;
class PaintingEstimate
{
	static void Main()
	{
		WriteLine("Enter room length >> ");
		int length = Convert.ToInt32(ReadLine());
		WriteLine("Enter room width >> ");
		int width = Convert.ToInt32(ReadLine());
		double cost = PaintCost(length, width);

		WriteLine("Cost of job for {0} X {1} foot room is {2}", length, width, cost.ToString("C", CultureInfo.GetCultureInfo("en-US")));
	}

	public static double PaintCost(int length, int width)
	{
		double area = (2 * length + 2 * width) * 9;
		double cost = area * 6;
		return cost;
	}
}