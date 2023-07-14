public class LeetCode_20
{
    public bool IsValid(string s)
    {
        // () [] {}
        // stack
        // Left-side character is '(', '[', '{'
        // Right-side character is ')', ']', '}'       
        var closeBrackets = new Stack<char>();

        for (var i = 0; i < s.Length; i++)
        {
            var currentCloseBracket = GetCloseBracket(s[i]);

            if (currentCloseBracket == ' ')
            {
                if (closeBrackets.Count == 0) return false;

                if (closeBrackets.Peek() == s[i])
                {
                    closeBrackets.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                closeBrackets.Push(currentCloseBracket);
            }
        }

        return closeBrackets.Count == 0;
    }

    public char GetCloseBracket(char s)
    {
        return s switch
        {
            '(' => ')',
            '[' => ']',
            '{' => '}',
            _ => ' ',
        };
    }
}