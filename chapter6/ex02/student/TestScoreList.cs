using System;
using static System.Console;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Numerics;
class TestScoreList
{
	static void Main()
	{
		// Write your code here

		int[] TestScoreList = new int[8];
		int total = 0;


		for (int i = 0; i < TestScoreList.Length; i++)
		{
			Write("Enter a test score: ");
			int score = Convert.ToInt32(ReadLine());
			TestScoreList[i] = score;
			total += score;
		}

		int average = total / TestScoreList.Length;
		
		for (int i = 0; i < TestScoreList.Length; i++)
		{
			int difference = TestScoreList[i] - average;
			Write("Test # " + i + ": " + TestScoreList[i] + " From average: " +
			+ difference + "\n");
		}
	}
}