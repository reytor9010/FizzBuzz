using System;

using NUnit.Framework;

namespace FizzBuzzTest
{
	public class FizzBuzzTest
	{
		#region Private Fields

		private FizzBuzz.FizzBuzz _fizzBuzz;

		#endregion

		#region SetUp

		[SetUp]
		public void SetUp()
		{
			_fizzBuzz = new FizzBuzz.FizzBuzz();
		}

		#endregion

		#region Test Methods

		[Test]
		[TestCase(1, 0)]
		[TestCase(-1, -5)]
		[TestCase(6, 2)]
		[TestCase(-4, -6)]
		public void GetFizzBuzzForRange_InvalidRange_ArgumentException(int from, int to)
		{
			Assert.Throws(typeof(ArgumentException), () => _fizzBuzz.GetFizzBuzzForRange(from, to));
		}

		[Test]
		[TestCase(0, 0, ExpectedResult = "FizzBuzz")]
		[TestCase(-5, 0, ExpectedResult = "Buzz\n-4\nFizz\n-2\n-1\nFizzBuzz")]
		[TestCase(0, 2, ExpectedResult = "FizzBuzz\n1\n2")]
		[TestCase(1, 2, ExpectedResult = "1\n2")]
		[TestCase(1, 3, ExpectedResult = "1\n2\nFizz")]
		[TestCase(1, 5, ExpectedResult = "1\n2\nFizz\n4\nBuzz")]
		[TestCase(1, 10, ExpectedResult = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz")]
		[TestCase(1, 15, ExpectedResult = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz")]
		public string GetFizzBuzzForRange_ValidRange_FizzBuzzMessage(int from, int to)
		{
			return _fizzBuzz.GetFizzBuzzForRange(from, to);
		}

		#endregion
	}
}