public class MathUtils
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty");
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return (double)sum / numbers.Length;
    }
}
