using System;
using System.Text;

namespace FizzBuzz
{
	public class FizzBuzz
	{
		#region Public Methods

		/// <summary>
		/// Get the FizzBuzz message for all the values in an inclusive range [<paramref name="from"/>, <paramref name="to"/>] separated by a new line.
		/// </summary>
		/// <param name="from"></param>
		/// <param name="to"></param>
		public string GetFizzBuzzForRange(int from = 1, int to = 100)
		{
			if (from > to)
			{
				throw new ArgumentException("Invalid range");
			}

			StringBuilder messageStringBuilder = new StringBuilder();

			for (int i = from; i <= to; i++)
			{
				messageStringBuilder.Append(GetFizzBuzzForValue(i));
				messageStringBuilder.Append(i < to ? "\n" : "");
			}

			return messageStringBuilder.ToString();
		}

		#endregion

		#region Private Methods

		/// <summary>
		/// Get the FizzBuzz message for a single value
		/// </summary>
		/// <param name="value"></param>
		private string GetFizzBuzzForValue(int value) => (value % 3, value % 5) switch
		{
			(0, 0) => "FizzBuzz",
			(0, _) => "Fizz",
			(_, 0) => "Buzz",
			_ => value.ToString()
		};

		#endregion
	}
}
