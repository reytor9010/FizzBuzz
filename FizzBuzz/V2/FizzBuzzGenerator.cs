using System;
using System.Text;

namespace FizzBuzz.V2
{
	public class FizzBuzzGenerator : IFizzBuzzGenerator
	{
		#region Private Fields

		private StringBuilder _rangeFizzBuzzStringBuilder;
		private StringBuilder _valueFizzBuzzStringBuilder;

		#endregion

		#region Public Constructor

		public FizzBuzzGenerator()
		{
			_rangeFizzBuzzStringBuilder = new StringBuilder();
			_valueFizzBuzzStringBuilder = new StringBuilder();
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
		/// Generate the FizzBuzz message for all the values in an inclusive range [<paramref name="minRangeValue"/>, <paramref name="maxRangeValue"/>] separated by a new line.
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
				_valueFizzBuzzStringBuilder.Clear();

				GenerateFizzBuzzForValue(i, _valueFizzBuzzStringBuilder);

				_rangeFizzBuzzStringBuilder.Append(_valueFizzBuzzStringBuilder);
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
		private void GenerateFizzBuzzForValue(int value, StringBuilder result)
		{
			result.AppendIfDivisible(value, 3, "Fizz");
			result.AppendIfDivisible(value, 5, "Buzz");

			if (result.Length == 0)
			{
				result.Append(value.ToString());
			}
		}

		#endregion
	}
}
