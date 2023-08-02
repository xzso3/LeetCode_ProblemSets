public class LeetCode_35
{
    public int SearchInsert(int[] nums, int target)
    {
        if (nums.Length == 1)
        {
            return nums[0] >= target ? 0 : 1;
        }
        
        if (nums.Length == 2)
        {
            if (target <= nums[0])
            {
                return 0;
            }
            else if (target > nums[1])
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        var result = 0;
        var min = 0;
        var max = nums.Length - 1;
        while (min <= max)
        {
            int mid = (min + max) / 2;
        
            if (target == nums[mid])
            {
                result = mid;
                break;
            }
            else if (target < nums[mid])
            {
                max = mid;
            }
            else
            {
                min = mid;
            }

            if (max - min == 1)
            {
                if (target <= nums[min])
                {
                    result = min;
                }
                else if (target > nums[max])
                {
                    result = max + 1;
                }
                else
                {
                    result = max;
                }
                break;
            }
        }

        return result;
    }
}