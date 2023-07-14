using System.Text;

public class LeetCode_14
{
    public string LongestCommonPrefix(string[] strs)
    {

        var resultBuilder = new StringBuilder("", strs[0].Length);
        var endFlag = false;
        for (var i = 0; i < strs[0].Length; i++)
        {
            for (var j = 1; j < strs.Length; j++)
            {
                if (i == strs[j].Length)
                {
                    endFlag = true;
                    break;
                }
                
                if (strs[0][i] != strs[j][i])
                {
                    endFlag = true;
                    break;
                }
            }

            if (endFlag) break;
            resultBuilder.Append(strs[0][i]);
        }

        return resultBuilder.ToString();
    }
}