public class LeetCode_26
{
    public int RemoveDuplicates(int[] nums)
    {
        var length = 1;
        var prev = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != prev)
            {
                prev = nums[i];
                nums[length++] = nums[i];
            }
        }

        return length;
    }
}