using System;

using FizzBuzz;

using NUnit.Framework;

namespace FizzBuzzTest
{
	[TestFixture]
	public abstract class FizzBuzzGeneratorTestBase
	{
		#region Private Fields

		protected IFizzBuzzGenerator _fizzBuzzGenerator;

		#endregion

		#region SetUp

		[SetUp]
		public abstract void SetUp();

		#endregion

		#region Test Methods

		[Test]
		[TestCase(1, 0)]
		[TestCase(-1, -5)]
		[TestCase(6, 2)]
		[TestCase(-4, -6)]
		public virtual void GenerateFizzBuzzForRange_InvalidRange_ArgumentException(float minRangeValue, float maxRangeValue)
		{
			Assert.Throws(typeof(ArgumentException), () => _fizzBuzzGenerator.GenerateFizzBuzzForRange(minRangeValue, maxRangeValue));
		}

		[Test]
		[TestCase(0, 0, ExpectedResult = "FizzBuzz")]
		[TestCase(-5, 0, ExpectedResult = "Buzz\n-4\nFizz\n-2\n-1\nFizzBuzz")]
		[TestCase(0, 2, ExpectedResult = "FizzBuzz\n1\n2")]
		[TestCase(1, 2, ExpectedResult = "1\n2")]
		[TestCase(1, 3, ExpectedResult = "1\n2\nFizz")]
		[TestCase(4, 5, ExpectedResult = "4\nBuzz")]
		[TestCase(1, 5, ExpectedResult = "1\n2\nFizz\n4\nBuzz")]
		[TestCase(1, 10, ExpectedResult = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz")]
		[TestCase(1, 15, ExpectedResult = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz")]
		[TestCase(1.8f, 10.4f, ExpectedResult = "2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz")]
		[TestCase(1.3f, 10.9f, ExpectedResult = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11")]
		[TestCase(1.5f, 9.5f, ExpectedResult = "2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz")]
		public virtual string GenerateFizzBuzzForRange_ValidRange_FizzBuzzMessage(float minRangeValue, float maxRangeValue)
		{
			return _fizzBuzzGenerator.GenerateFizzBuzzForRange(minRangeValue, maxRangeValue);
		}

		#endregion
	}
}