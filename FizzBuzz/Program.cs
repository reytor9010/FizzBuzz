using System;

using FizzBuzz.V2;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			IFizzBuzzGenerator fizzBuzzGenerator = new FizzBuzzGenerator();
			string fizzBuzzResult;
			string minRangeValue;
			string maxRangeValue;

			while (true)
			{
				//Program Description
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("\tFIZZ - BUZZ PROGRAM");
				Console.WriteLine();
				Console.WriteLine("For each value in an inclusive range [min, max] prints: ");
				Console.WriteLine("  - \"Fizz\" if the value is divisible by 3");
				Console.WriteLine("  - \"Buzz\" if the value is divisible by 5");
				Console.WriteLine("  - \"FizzBuzz\" if the value is divisible by 3 and by 5");
				Console.WriteLine("  - Otherwise prints the value itself");
				Console.WriteLine();
				Console.WriteLine("* Floating point range values are allowed, but they will be rounded to the nearest even int if ends in .5 * ");
				Console.WriteLine("* An invalid input will tranlate into a value of 0 * ");
				Console.WriteLine();
				Console.WriteLine();

				//Input Data
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Please, enter the range:");
				Console.Write(" Min: ");
				minRangeValue = Console.ReadLine();
				Console.Write(" Max: ");
				maxRangeValue = Console.ReadLine();
				Console.WriteLine();
				Console.WriteLine();

				//Create FizzBuzz Message
				try
				{
					fizzBuzzResult = fizzBuzzGenerator.GenerateFizzBuzzForRange(minRangeValue, maxRangeValue);
				}
				catch (ArgumentException argumentException)
				{
					fizzBuzzResult = argumentException.Message;
				}

				//Print the FizzBuzz Message and Continue
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine($"FIZZ - BUZZ RESULT {fizzBuzzGenerator.Range}:");
				Console.WriteLine(fizzBuzzResult);
				Console.WriteLine();
				Console.WriteLine();

				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("Press any key to reset");
				Console.ReadLine();
				Console.Clear();
			}
		}
	}
}
