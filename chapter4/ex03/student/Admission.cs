using System;
using static System.Console;
using System.Globalization;
class Admission
{
	static void Main()
	{
		string inputString;
		double GPA;
		int admissionScore;

		WriteLine("Enter a GPA: ");
		inputString = ReadLine();
		GPA = Convert.ToDouble(inputString);
		WriteLine("Enter an admission score: ");
		inputString = ReadLine();
		admissionScore = Convert.ToInt32(inputString);

		if ((GPA >= 3.0 && admissionScore >= 60) || (GPA < 3.0 && admissionScore >= 80))
			WriteLine("Accept");
		else
			WriteLine("Reject");

	}
}