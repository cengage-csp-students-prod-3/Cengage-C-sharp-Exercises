using System;
using static System.Console;
using System.Globalization;
class Twitter
{
	static void Main()
	{
		string inputString;
		int messageLength;

		WriteLine("Write your message: ");
		inputString = ReadLine();
		messageLength = inputString.length();

		if (messageLength > 140)
			WriteLine("The message is too long.");
		else
			WriteLine("The message is okay.");
	}
}