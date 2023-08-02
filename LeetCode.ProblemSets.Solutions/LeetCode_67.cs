using System.Text;

public class LeetCode_67
{
    public string AddBinary(string a, string b)
    {

        var iterations = a.Length < b.Length ? a.Length : b.Length;
        var maxStringLength = a.Length > b.Length ? a.Length : b.Length;
        var longerString = 0;
        if (a.Length > b.Length)
        {
            longerString = 1;
        }
        else if (a.Length < b.Length)
        {
            longerString = -1;
        }



        var carryFlag = false;
        var intResult = new int[maxStringLength];
        var sb = new StringBuilder(maxStringLength + 1);

        // Add the same length part.
        for (var i = 1; i <= iterations; i++)
        {
            var bitValue = 0;
            bitValue = GetBitValue(a[^i]) + GetBitValue(b[^i]);

            if (carryFlag) bitValue++;
            
            if (bitValue > 1)
            {
                intResult[i - 1] = bitValue - 2;
                carryFlag = true;
            }
            else
            {
                intResult[i - 1] = bitValue;
                carryFlag = false;
            }
        }

        // process remaining bits calculations.
        if (longerString != 0)
        {
            var remaining = longerString > 0 ? a : b;

            for (var i = iterations + 1; i <= remaining.Length; i++)
            {
                var bitValue = 0;
                bitValue = GetBitValue(remaining[^i]);

                if (carryFlag) bitValue++;
                if (bitValue > 1)
                {
                    intResult[i - 1] = bitValue - 2;
                    carryFlag = true;
                }
                else
                {
                    intResult[i - 1] = bitValue;
                    carryFlag = false;
                }
            }
        }
        
        // Process result int array to string.
        if (carryFlag) sb.Append('1');

        for (var i = 1; i <= intResult.Length; i++)
        {
            sb.Append(intResult[^i] == 0 ? '0' : '1');
        }

        return sb.ToString();
    }

    public int GetBitValue(char c)
    {
        return (c) switch
        {
            '0' => 0,
            '1' => 1,
            _ => throw new ArgumentOutOfRangeException(nameof(c), c, null)
        };
    }
}