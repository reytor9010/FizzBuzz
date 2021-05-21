namespace FizzBuzz
{
	public interface IFizzBuzzGenerator
	{
		string GenerateFizzBuzzForRange(float minRangeValue, float maxRangeValue);
		string GenerateFizzBuzzForRange(int minRangeValue, int maxRangeValue);
	}
}