public class LeetCode_66
{
    public int[] PlusOne(int[] digits)
    {
        digits[^1]++;
        var carryFlag = false;
        
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            if (carryFlag)
            {
                digits[i]++;
            }

            if (digits[i] > 9)
            {
                carryFlag = true;
                digits[i] -= 10;
            }
            else
            {
                carryFlag = false;
            }
        }

        if (carryFlag)
        {
            var newValue = new int[digits.Length + 1];
            newValue[0] = 1;
            for (var i = 0; i < digits.Length; i++)
            {
                newValue[i + 1] = digits[i];
            }

            digits = newValue;
        }
        
        return digits;
    }
}