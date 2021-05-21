using System.Text;

namespace FizzBuzz
{
	public static class StringBuilderUtility
	{
		public static void AppendIfDivisible(this StringBuilder stringBuilder, int divident, int divider, string text)
		{
			if (divident % divider == 0)
			{
				stringBuilder.Append(text);
			}
		}
	}
}