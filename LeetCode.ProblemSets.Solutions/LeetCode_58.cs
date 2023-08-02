public class LeetCode_58
{
    public int LengthOfLastWord(string s)
    {
        var length = 0;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                if (length > 0) break;
            }
            else
            {
                length++;
            }
        }
        
        return length;
    }
}