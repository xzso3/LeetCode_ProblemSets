public class LeetCode_344
{
    public void ReverseString(char[] s)
    {
        for (var i = 0; i < s.Length / 2; i++)
        {
            var a = s[i];
            var r = i + 1;
            s[i] = s[^r];
            s[^r] = a;
        }
    }
}