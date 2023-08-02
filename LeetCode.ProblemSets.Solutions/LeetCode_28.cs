public class LeetCode_28
{
    public int StrStr(string haystack, string needle)
    {
        var result = -1;
        var compares = haystack.Length - needle.Length + 1;
        for (var i = 0; i < compares; i++)
        {
            var flag = true;
            for (var j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] != needle[j])
                {
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;
                }
            }

            if (flag)
            {
                result = i;
                break;
            }
        }

        return result;
    }
}