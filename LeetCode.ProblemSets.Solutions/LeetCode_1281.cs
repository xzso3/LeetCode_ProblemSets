public class LeetCode_1281
{
    public int SubtractProductAndSum(int n)
    {
        var multiply = 1;
        var addition = 0;

        while (n > 0)
        {
            var digit = n % 10;
            multiply *= digit;
            addition += digit;
            n /= 10;
        }

        return multiply - addition;
    }
}