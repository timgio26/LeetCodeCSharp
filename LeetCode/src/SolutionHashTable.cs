using System;

namespace LeetCode.src;

public class SolutionHashTable
{
    public int[] FindIntersectionValues(int[] nums1, int[] nums2)
    {
        //2956
        int count1 = 0;
        int count2 = 0;
        for (int i = 0; i < nums1.Length; i++)
        {
            if (nums2.Contains(nums1[i])) { count1++; }
        }
        for (int i = 0; i < nums2.Length; i++)
        {
            if (nums1.Contains(nums2[i])) { count2++; }
        }
        return [count1, count2];
    }

    public int NumberOfPairs(int[] nums1, int[] nums2, int k)
    {
        //3162
        int count = 0;
        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = 0; j < nums2.Length; j++)
            {
                if (nums1[i] % (nums2[j] * k) == 0) { count++; }
            }
        }
        return count;
    }
}
