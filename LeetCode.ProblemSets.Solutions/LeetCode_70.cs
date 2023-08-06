public class LeetCode_70
{
    public int ClimbStairs(int n) {
        
        if (n <= 3) return n;
        
        // Fibonacci
        var pre = 1;
        var current = 1;
        var result = 0;

        for (var i = 1 ; i < n; i++)
        {
            result = pre + current;
            pre = current;
            current = result;   
        }

        return result;

    }
}