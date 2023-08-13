public class LeetCode_118
{
    public IList<IList<int>> Generate(int numRows)
    {

        var result = new List<IList<int>>(30);
        
        if (numRows == 1)
        {
            return new List<IList<int>>() { new List<int>() {1} };
        }

        if (numRows == 2)
        {
            return new List<IList<int>>() { new List<int>() {1}, new List<int>() {1, 1} }; 
        }
        
        result = new List<IList<int>>() { new List<int>() {1}, new List<int>() {1, 1} };

        for (var i = 2; i < numRows; i++)
        {
            var row = new int[i + 1];
            row[0] = row[i] = 1;

            var j = 1;
            for (; j < (i + 1) / 2; j++)
            {
                row[j] = row[^(j + 1)] = result[i - 1][j - 1] + result[i - 1][j];
            }

            if (i % 2 == 0)
            {
                row[j] = result[i - 1][j - 1] + result[i - 1][j];
            }
            
            result.Add(row);
        }
        
        return result;
    }
}