public class LeetCode_13
{
    public int RomanToInt(string s)
    {
        var romanLetterValue = new Dictionary<char, int>();
        romanLetterValue.Add('I', 1);
        romanLetterValue.Add('V', 5);
        romanLetterValue.Add('X', 10);
        romanLetterValue.Add('L', 50);
        romanLetterValue.Add('C', 100);
        romanLetterValue.Add('D', 500);
        romanLetterValue.Add('M', 1000);

        var romanLetterPair = new Dictionary<char, char>();
        romanLetterPair.Add('M', 'C');
        romanLetterPair.Add('D', 'C');
        romanLetterPair.Add('C', 'X');
        romanLetterPair.Add('L', 'X');
        romanLetterPair.Add('X', 'I');
        romanLetterPair.Add('V', 'I');
        romanLetterPair.Add('I', ' ');
        
        
        // 存储最终结果
        var result = 0;
        // 字符串中字符位下标
        // 临时累加器Flag
        var tempAccumulationFlag = false;
        var tempAccumulation = 0;

        for (var i = 0; i < s.Length; i++)
        {
            // 首位直接设置位临时累加值
            if (i == 0)
            {
                tempAccumulation = romanLetterValue[s[i]];
            }
            else
            {
                if (IsContainAccumulationChar(s[i]))
                {
                    // 如果上一位与当前位字符相同，则继续累加临时值
                    if (s[i - 1] == s[i])
                    {
                        tempAccumulation += romanLetterValue[s[i]];
                    }
                    else
                    {
                        if (romanLetterPair[s[i]] == s[i - 1])
                        {
                            result += (romanLetterValue[s[i]] - tempAccumulation);
                            tempAccumulation = 0;
                        }
                        else
                        {
                            result += tempAccumulation;
                            tempAccumulation = romanLetterValue[s[i]];
                        }
                    }
                }
                else
                {
                    if (romanLetterPair[s[i]] == s[i - 1])
                    {
                        result += (romanLetterValue[s[i]] - tempAccumulation);
                        tempAccumulation = 0;
                    }
                    else
                    {
                        result += tempAccumulation;
                        tempAccumulation = romanLetterValue[s[i]];
                    }
                }
            }

            if (i == s.Length - 1)
            {
                result += tempAccumulation;
            }
        }
        

        return result;
    }


    public bool IsContainAccumulationChar(char c)
    {
        return c == 'C' || c == 'X' || c == 'I';
    }
}