using System;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			FizzBuzz fizzBuzz = new FizzBuzz();
			string fizzbuzzMessage;
			int from = 0;
			int to = 0;

			while (true)
			{
				//Program Description
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("\tFIZZ - BUZZ PROGRAM");
				Console.WriteLine();
				Console.WriteLine("For each value in an inclusive range [from, to] prints: ");
				Console.WriteLine("  - \"Fizz\" if the value is divisible by 3");
				Console.WriteLine("  - \"Buzz\" if the value is divisible by 5");
				Console.WriteLine("  - \"FizzBuzz\" if the value is divisible by 3 and by 5");
				Console.WriteLine("  - Otherwise prints the value itself");
				Console.WriteLine();
				Console.WriteLine("* Floating point range values are allowed, but it will be rounded to the nearest int * ");
				Console.WriteLine("* Any invalid input will tranlate into a value of 0 * ");
				Console.WriteLine();
				Console.WriteLine();

				//Input Data
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Please, enter the range:");
				Console.Write(" From: ");
				from = decimal.TryParse(Console.ReadLine(), out decimal fromValue) ? (int)Math.Round(fromValue) : 0;
				Console.Write(" To: ");
				to = decimal.TryParse(Console.ReadLine(), out decimal toValue) ? (int)Math.Round(toValue) : 0;
				Console.WriteLine();
				Console.WriteLine();

				//Create FizzBuzz Message
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine($"FIZZ - BUZZ RESULT [{from},{to}]:");

				try
				{
					fizzbuzzMessage = fizzBuzz.GetFizzBuzzForRange(from, to);
				}
				catch (ArgumentException argumentException)
				{
					fizzbuzzMessage = argumentException.Message;
				}

				//Print the FizzBuzz Message and Continue
				Console.WriteLine(fizzbuzzMessage);
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
