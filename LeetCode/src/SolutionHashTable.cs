using System;
using System.Text;

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

    public int MaximumNumberOfStringPairs(string[] words)
    {
        //2744
        int count = 0;
        int len = words.Length;
        // StringBuilder stringBuilder = new StringBuilder();
        string[] wordsReverse = new string[len];
        for (int i = 0; i < len; i++)
        {
            wordsReverse[i] = string.Join("", words[i].ToCharArray().Reverse());
        }
        for (int i = 0; i < len; i++)
        {
            for (int j = i + 1; j < len; j++)
            {

                if (words[i] == wordsReverse[j])
                {
                    count++;
                }
            }
        }
        return count;
    }
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
    {
        //2032 
        HashSet<int> allNums = [.. nums1.Concat(nums2).Concat(nums3)];
        foreach (int i in allNums)
        {
            int count = 0;
            if (nums1.Contains(i)) { count++; }
            if (nums2.Contains(i)) { count++; }
            if (nums3.Contains(i)) { count++; }
            if (count < 2) { allNums.Remove(i); }
        }
        return [.. allNums];
    }
}
