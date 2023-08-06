public class LeetCode_69
{
    public int MySqrt(int x)
    {
        var result = 0;
        var min = 2;
        var max = x / 2;

        while (min <= max)
        {
            if (min == max)
            {
                result = min;
                break;
            }
            
            var mid = (min + max) / 2;
            var midSquare = mid * mid;
            if (midSquare > x)
            {
                min = mid;
            }
            else if (midSquare < x)
            {
                max = mid;
            }
            else
            {
                result = mid;
                break;
            }
                
        }

        return result;
    }
}