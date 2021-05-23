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

		[TestCaseSource(typeof(FizzBuzzGeneratorTestCases), "InvalidFloatRangeTestCases")]
		public virtual void GenerateFizzBuzzForRange_InvalidFloatRange_ArgumentException(float minRangeValue, float maxRangeValue)
		{
			Assert.Throws(typeof(ArgumentException), () => _fizzBuzzGenerator.GenerateFizzBuzzForRange(minRangeValue, maxRangeValue));
		}

		[TestCaseSource(typeof(FizzBuzzGeneratorTestCases), "InvalidIntRangeTestCases")]
		public virtual void GenerateFizzBuzzForRange_InvalidIntRange_ArgumentException(float minRangeValue, float maxRangeValue)
		{
			Assert.Throws(typeof(ArgumentException), () => _fizzBuzzGenerator.GenerateFizzBuzzForRange(minRangeValue, maxRangeValue));
		}

		[TestCaseSource(typeof(FizzBuzzGeneratorTestCases), "ValidFloatRangeTestCases")]
		public virtual string GenerateFizzBuzzForRange_ValidFloatRange_FizzBuzzMessage(float minRangeValue, float maxRangeValue)
		{
			return _fizzBuzzGenerator.GenerateFizzBuzzForRange(minRangeValue, maxRangeValue);
		}

		[TestCaseSource(typeof(FizzBuzzGeneratorTestCases), "ValidIntRangeTestCases")]
		public virtual string GenerateFizzBuzzForRange_ValidIntRange_FizzBuzzMessage(float minRangeValue, float maxRangeValue)
		{
			return _fizzBuzzGenerator.GenerateFizzBuzzForRange(minRangeValue, maxRangeValue);
		}

		#endregion
	}
}