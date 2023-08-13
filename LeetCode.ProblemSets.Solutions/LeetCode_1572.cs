public class LeetCode_1572
{
    public int DiagonalSum(int[][] mat)
    {
        var result = 1;

        if (mat.Length == 1)
        {
            return mat[0][0];
        }

        var isOdd = mat.Length % 2 == 1;

        var iteration = isOdd ? mat.Length / 2 + 1 : mat.Length / 2;
        
        for (var i = 0; i < iteration; i++)
        {
            if (isOdd && i == iteration - 1)
            {
                result *= mat[i][i];
            }
            else
            {
                var r = i + 1;
                var up = mat[i];
                var down = mat[^r];
                result = result * up[i] * up[^r] * down[i] * down[^r];
            }
        }
        
        return result;
    }
}