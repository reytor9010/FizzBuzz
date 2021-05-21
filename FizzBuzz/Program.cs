using System;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			IFizzBuzzGenerator fizzBuzzGenerator = new V2.FizzBuzzGenerator();
			string rangeFizzBuzz;
			float minRangeValue = 0;
			float maxRangeValue = 0;

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
				minRangeValue = float.TryParse(Console.ReadLine(), out float min) ? min : 0;
				Console.Write(" Max: ");
				maxRangeValue = float.TryParse(Console.ReadLine(), out float max) ? max : 0;
				Console.WriteLine();
				Console.WriteLine();

				//Create FizzBuzz Message
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine($"FIZZ - BUZZ RESULT [{(int)Math.Round(minRangeValue)},{(int)Math.Round(maxRangeValue)}]:");

				try
				{
					rangeFizzBuzz = fizzBuzzGenerator.GenerateFizzBuzzForRange(minRangeValue, maxRangeValue);
				}
				catch (ArgumentException argumentException)
				{
					rangeFizzBuzz = argumentException.Message;
				}

				//Print the FizzBuzz Message and Continue
				Console.WriteLine(rangeFizzBuzz);
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
