using System.Collections;

using NUnit.Framework;

namespace FizzBuzzTest
{
	public class FizzBuzzGeneratorTestCases
	{
		#region Public Constructors

		public FizzBuzzGeneratorTestCases()
		{

		}

		#endregion

		#region Public Static Methods

		public static IEnumerable InvalidIntRangeTestCases
		{
			get
			{
				yield return new TestCaseData(1, 0);
				yield return new TestCaseData(-1, -5);
				yield return new TestCaseData(6, 2);
				yield return new TestCaseData(-4, -6);
			}
		}

		public static IEnumerable InvalidFloatRangeTestCases
		{
			get
			{
				yield return new TestCaseData(1.4f, 0.2f);
				yield return new TestCaseData(-1.5f, -5.5f);
				yield return new TestCaseData(6.8f, 2.3f);
				yield return new TestCaseData(-4.9f, -6.5f);
			}
		}

		public static IEnumerable ValidFloatRangeTestCases
		{
			get
			{
				yield return new TestCaseData(0.2f, 0.5f) { ExpectedResult = "FizzBuzz" };
				yield return new TestCaseData(-5.4f, 0.1f) { ExpectedResult = "Buzz\n-4\nFizz\n-2\n-1\nFizzBuzz" };
				yield return new TestCaseData(0.3f, 1.8f) { ExpectedResult = "FizzBuzz\n1\n2" };
				yield return new TestCaseData(1.1f, 1.5f) { ExpectedResult = "1\n2" };
				yield return new TestCaseData(0.8f, 2.6f) { ExpectedResult = "1\n2\nFizz" };
				yield return new TestCaseData(3.9f, 5.2f) { ExpectedResult = "4\nBuzz" };
				yield return new TestCaseData(1.2f, 5.3f) { ExpectedResult = "1\n2\nFizz\n4\nBuzz" };
				yield return new TestCaseData(1.4f, 10.5f) { ExpectedResult = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz" };
				yield return new TestCaseData(0.6f, 15.2f) { ExpectedResult = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz" };
			}
		}

		public static IEnumerable ValidIntRangeTestCases
		{
			get
			{
				yield return new TestCaseData(0, 0) { ExpectedResult = "FizzBuzz" };
				yield return new TestCaseData(-5, 0) { ExpectedResult = "Buzz\n-4\nFizz\n-2\n-1\nFizzBuzz" };
				yield return new TestCaseData(0, 2) { ExpectedResult = "FizzBuzz\n1\n2" };
				yield return new TestCaseData(1, 2) { ExpectedResult = "1\n2" };
				yield return new TestCaseData(1, 3) { ExpectedResult = "1\n2\nFizz" };
				yield return new TestCaseData(4, 5) { ExpectedResult = "4\nBuzz" };
				yield return new TestCaseData(1, 5) { ExpectedResult = "1\n2\nFizz\n4\nBuzz" };
				yield return new TestCaseData(1, 10) { ExpectedResult = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz" };
				yield return new TestCaseData(1, 15) { ExpectedResult = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz" };
			}
		}

		#endregion
	}
}