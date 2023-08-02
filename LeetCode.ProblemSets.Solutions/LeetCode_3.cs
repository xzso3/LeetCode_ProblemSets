public class LeetCode_3
{
    public int LengthOfLongestSubstring(string s) {
        if (s.Length < 2)
        {
            return s.Length;
        }

        var maxLength = 0;
        var sameCharArraySize = s.Length - 1;
        
        
        var sameCharIndex = new int[sameCharArraySize];
        // Find the nearest same character

        for (var i = 0; i < sameCharArraySize; i++)
        {
            for (var j = i + 1; j < s.Length; j++)
            {
                if (s[i] == s[j])
                {
                    sameCharIndex[i] = j;
                    break;
                }
            }

            sameCharIndex[i] = sameCharIndex[i] == 0 ? -1 : sameCharIndex[i];
        }


        for (var i = 0; i < sameCharArraySize; i++)
        {
            var maxReachIndex = sameCharIndex[i];
            if ((sameCharIndex[i] < 0 ? s.Length : sameCharIndex[i]) - i <= maxLength)
            {
                continue;
            }

            if (s.Length - i - 1 < maxLength)
            {
                break;
            }
            
            for (var j = i + 1; j < (maxReachIndex < 0 ? sameCharArraySize : maxReachIndex); j++)
            {
                if (sameCharIndex[j] < 0)
                {
                    continue;
                }
                
                if (maxReachIndex < 0)
                {
                    maxReachIndex = sameCharIndex[j];
                }
                else
                {
                    maxReachIndex = maxReachIndex < sameCharIndex[j] ? maxReachIndex : sameCharIndex[j];
                }
                
            }

            var currentSubstringLength = (maxReachIndex < 0 ? s.Length : maxReachIndex) - i;
            
            
            maxLength = maxLength > currentSubstringLength ? maxLength : currentSubstringLength;
        }
        
        return maxLength;
    }
}