using System;
using System.Text;

namespace FizzBuzz.V1
{
	public class FizzBuzzGenerator : IFizzBuzzGenerator
	{
		#region Private Fields

		private StringBuilder _rangeFizzBuzzStringBuilder;

		#endregion

		#region Public Constructor

		public FizzBuzzGenerator()
		{
			_rangeFizzBuzzStringBuilder = new StringBuilder();
		}

		#endregion

		#region Public Methods

		/// <summary>
		/// Generate the FizzBuzz message for all the values in an inclusive range [float <paramref name="minRangeValue"/>, float <paramref name="maxRangeValue"/>] separated by a new line.
		/// </summary>
		/// <param name="minRangeValue"></param>
		/// <param name="maxRangeValue"></param>
		public string GenerateFizzBuzzForRange(float minRangeValue = 1, float maxRangeValue = 100)
		{
			return GenerateFizzBuzzForRange((int)Math.Round(minRangeValue), (int)Math.Round(maxRangeValue));
		}

		/// <summary>
		/// Generate the FizzBuzz message for all the values in an inclusive range [int <paramref name="minRangeValue"/>, int <paramref name="maxRangeValue"/>] separated by a new line.
		/// </summary>
		/// <param name="minRangeValue"></param>
		/// <param name="maxRangeValue"></param>
		public string GenerateFizzBuzzForRange(int minRangeValue = 1, int maxRangeValue = 100)
		{
			if (minRangeValue > maxRangeValue)
			{
				throw new ArgumentException("Invalid range");
			}

			_rangeFizzBuzzStringBuilder.Clear();

			for (int i = minRangeValue; i <= maxRangeValue; i++)
			{
				_rangeFizzBuzzStringBuilder.Append(GenerateFizzBuzzForValue(i));
				_rangeFizzBuzzStringBuilder.Append(i < maxRangeValue ? "\n" : "");
			}

			return _rangeFizzBuzzStringBuilder.ToString();
		}

		#endregion

		#region Private Methods

		/// <summary>
		/// Generate the FizzBuzz message for a single value
		/// </summary>
		/// <param name="value"></param>
		private string GenerateFizzBuzzForValue(int value) => (value % 3, value % 5) switch
		{
			(0, 0) => "FizzBuzz",
			(0, _) => "Fizz",
			(_, 0) => "Buzz",
			_ => value.ToString()
		};

		#endregion
	}
}
