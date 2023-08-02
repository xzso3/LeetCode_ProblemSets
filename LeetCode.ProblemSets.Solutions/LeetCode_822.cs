public class LeetCode_822
{
    public int Flipgame(int[] fronts, int[] backs)
    {
        var valid = new int[2000];
        var result = 0;
        var maxValue = -1;

        for (var i = 0; i < fronts.Length; i++)
        {
            var tmpMaxValue = -1;
            if (fronts[i] != backs[i])
            {
                var f = fronts[i] - 1;
                var b = backs[i] - 1;
                if (valid[f] == 0) valid[f] = 1;
                if (valid[b] == 0) valid[b] = 1;
                tmpMaxValue = fronts[i] > backs[i] ? fronts[i] : backs[i];
            }
            else
            {
                valid[fronts[i] - 1] = -1;
                tmpMaxValue = fronts[i];
            }
            maxValue = maxValue > tmpMaxValue ? maxValue : tmpMaxValue;
        }

        for (var i = 0; i < maxValue; i++)
        {
            if (valid[i] == 1)
            {
                if (result == 0)
                {
                    result = i + 1;
                }
                else
                {
                    result = result < i + i ? result : i + 1;
                }
            }
        }

        return result;
    }
}