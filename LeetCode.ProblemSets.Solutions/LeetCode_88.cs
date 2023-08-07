public class LeetCode_88
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (m == 0)
        {
            CopyResult(nums2, nums1);
            return;
        }

        if (n == 0)
        {
            return;
        }
        
        var result = new int[nums1.Length];

        var index1 = 0;
        var index2 = 0;
        var indexResult = 0;
        
        while (index1 < m && index2 < n)
        {
            result[indexResult++] = nums1[index1] < nums2[index2] ? nums1[index1++] : nums2[index2++];
        }

        if (indexResult == nums1.Length)
        {
            CopyResult(result, nums1);
            return;
        }
        
        while (indexResult < nums1.Length)
        {
            result[indexResult++] = index1 == m ? nums2[index2++] : nums1[index1++];
        }
        
        CopyResult(result, nums1);
    }

    public void CopyResult(int[] source, int[] destination)
    {
        for (var i = 0; i < source.Length; i++)
        {
            destination[i] = source[i];
        }
    }
}