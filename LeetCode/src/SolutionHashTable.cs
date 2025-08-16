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

    public int[] FrequencySort(int[] nums)
    {
        //1636
        Dictionary<int, int> numsDict = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!numsDict.ContainsKey(nums[i])) { numsDict.Add(nums[i], 0); }
            numsDict[nums[i]] += 1;
        }
        List<int> result = [];
        while (numsDict.Count > 0)
        {
            int tempKey = int.MinValue;
            int tempFreq = int.MaxValue;
            foreach (var i in numsDict)
            {
                if (i.Value < tempFreq) { tempFreq = i.Value; tempKey = i.Key; }
                if (i.Value == tempFreq && i.Key > tempKey) { tempKey = i.Key; }
            }
            for (int j = 0; j < tempFreq; j++)
            {
                result.Add(tempKey);
            }
            numsDict.Remove(tempKey);
        }
        return result.ToArray();

    }

    public string KthDistinct(string[] arr, int k)
    {
        //2053
        Dictionary<string, int> keyValuePairs = new();
        for (int i = 0; i < arr.Length; i++)
        {
            if (!keyValuePairs.ContainsKey(arr[i])) { keyValuePairs.Add(arr[i], 0); }
            keyValuePairs[arr[i]] += 1;
        }
        foreach (var i in keyValuePairs)
        {
            if (i.Value == 1) { k--; }
            if (k == 0) { return i.Key; }
        }
        return "";
    }

    public int MaxFrequencyElements(int[] nums)
    {
        //3005
        int result = 0;
        int maxFreq = 0;
        Dictionary<int, int> keyValuePairs = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!keyValuePairs.ContainsKey(nums[i])) { keyValuePairs.Add(nums[i], 0); }
            keyValuePairs[nums[i]] += 1;
            if (keyValuePairs[nums[i]] > maxFreq) { maxFreq = keyValuePairs[nums[i]]; }
        }
        foreach (var i in keyValuePairs)
        {
            if (i.Value == maxFreq) { result += i.Value; }
        }
        return result;
    }

    public int UniqueMorseRepresentations(string[] words)
    {
        //804
        string[] morseCode = [".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."];
        Dictionary<char, string> keyValuePairs = new();
        char alp = 'a';
        for (int i = 0; i < morseCode.Length; i++)
        {
            keyValuePairs.Add(alp++, morseCode[i]);
        }
        HashSet<string> convertedWord = [];
        for (int i = 0; i < words.Length; i++)
        {
            List<string> convertedLetter = [];
            for (int j = 0; j < words[i].Length; j++)
            {
                convertedLetter.Add(keyValuePairs[words[i][j]]);
            }
            convertedWord.Add(string.Concat(convertedLetter));
        }
        return convertedWord.Count;
    }

    public int[][] MergeArrays(int[][] nums1, int[][] nums2)
    {
        //2570
        SortedDictionary<int, int> keyValuePairs = new();
        List<int[]> ints = new();
        for (int i = 0; i < nums1.Length; i++)
        {
            if (!keyValuePairs.ContainsKey(nums1[i][0])) { keyValuePairs.Add(nums1[i][0], 0); }
            keyValuePairs[nums1[i][0]] += nums1[i][1];
        }
        for (int i = 0; i < nums2.Length; i++)
        {
            if (!keyValuePairs.ContainsKey(nums2[i][0])) { keyValuePairs.Add(nums2[i][0], 0); }
            keyValuePairs[nums2[i][0]] += nums2[i][1];
        }
        foreach (var i in keyValuePairs)
        {
            ints.Add([i.Key, i.Value]);
        }
        return ints.ToArray();
    }

    public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
    {
        //2363 cant make the test 
        SortedDictionary<int, int> keyValuePairs = new();
        List<List<int>> result = [];
        for (int i = 0; i < items1.Length; i++)
        {
            if (!keyValuePairs.ContainsKey(items1[i][0])) { keyValuePairs.Add(items1[i][0], 0); }
            keyValuePairs[items1[i][0]] += items1[i][1];
        }
        for (int i = 0; i < items2.Length; i++)
        {
            if (!keyValuePairs.ContainsKey(items2[i][0])) { keyValuePairs.Add(items2[i][0], 0); }
            keyValuePairs[items2[i][0]] += items2[i][1];
        }
        foreach (var i in keyValuePairs)
        {
            result.Add([i.Key, i.Value]);
        }
        return result.ToArray();
    }

    public IList<IList<int>> GroupThePeople(int[] groupSizes)
    {
        //1282
        // can be optimized using buckets[size].Clear(); so each time bucket full add to result
        Dictionary<int, int> keyValuePairs = new();
        for (int i = 0; i < groupSizes.Length; i++)
        {
            if (!keyValuePairs.ContainsKey(groupSizes[i])) { keyValuePairs.Add(groupSizes[i], 0); }
            keyValuePairs[groupSizes[i]]++;
        }
        // int count = 0;
        Dictionary<char, int> groupxcapacity = new();
        Dictionary<char, List<int>> groupxmember = new();
        char groupName = 'a';
        foreach (var i in keyValuePairs)
        {
            for (int j = 0; j < i.Value / i.Key; j++)
            {
                groupxcapacity.Add(groupName, i.Key);
                groupxmember.Add(groupName, []);
                groupName++;
            }
        }

        for (int i = 0; i < groupSizes.Length; i++)
        {
            foreach (var j in groupxcapacity)
            {
                if (j.Value == groupSizes[i] && groupxmember[j.Key].Count < groupSizes[i])
                {
                    groupxmember[j.Key].Add(i);
                    break;
                }
            }
        }
        IList<IList<int>> ints = [];
        foreach (var i in groupxmember)
        {
            ints.Add(i.Value);
        }
        return ints;
    }

    public int SumOfUnique(int[] nums)
    {
        Dictionary<int, int> keyValuePairs = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!keyValuePairs.ContainsKey(nums[i])) { keyValuePairs.Add(nums[i], 0); }
            keyValuePairs[nums[i]]++;
        }
        int count = 0;
        foreach (var i in keyValuePairs)
        {
            if (i.Value == 1) count += i.Key;
        }
        return count;
    }

    public bool UniqueOccurrences(int[] arr)
    {
        //1207
        Dictionary<int, int> keyValuePairs = new();
        for (int i = 0; i < arr.Length; i++)
        {
            if (!keyValuePairs.ContainsKey(arr[i])) { keyValuePairs.Add(arr[i], 0); }
            keyValuePairs[arr[i]]++;
        }
        HashSet<int> ints = [];
        foreach (KeyValuePair<int, int> i in keyValuePairs)
        {
            ints.Add(i.Value);
        }
        return ints.Count() == keyValuePairs.Count;
    }

    public int CountPoints(string rings)
    {
        //2103
        Dictionary<char, HashSet<char>> keyValuePairs = new();
        int count = 0;
        for (int i = 1; i < rings.Length; i += 2)
        {
            if (!keyValuePairs.ContainsKey(rings[i])) { keyValuePairs.Add(rings[i], []); }
            keyValuePairs[rings[i]].Add(rings[i - 1]);
        }
        foreach (var i in keyValuePairs)
        {
            if (i.Value.Count == 3) { count++; }
        }
        return count;
    }

    public int[] FindThePrefixCommonArray(int[] A, int[] B)
    {
        //2657
        // can be improved
        int[] ints3 = new int[A.Length];
        for (int i = 0; i < A.Length; i++)
        {
            HashSet<int> ints2 = new();
            for (int j = 0; j < i + 1; j++)
            {
                ints2.Add(A[j]);
                ints2.Add(B[j]);
            }
            ints3[i] = (i + 1) * 2 - ints2.Count;
        }
        return ints3;
    }

    public bool HasGroupsSizeX(int[] deck)
    {
        //still failed 914
        Dictionary<int, List<int>> keyValuePairs = new();
        for (int i = 0; i < deck.Length; i++)
        {
            if (!keyValuePairs.ContainsKey(deck[i])) { keyValuePairs.Add(deck[i], []); }
            keyValuePairs[deck[i]].Add(deck[i]);
        }
        int len = 0;
        foreach (var i in keyValuePairs)
        {
            if (len == 0) { len = i.Value.Count(); continue; }
            if (i.Value.Count != len) { return false; }
        }
        return true;
    }
    public int[] DistinctDifferenceArray(int[] nums)
    {
        //2670 optimze by makin prefix and suffix array
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            HashSet<int> left = new();
            HashSet<int> right = new();
            for (int j = 0; j < i + 1; j++)
            {
                left.Add(nums[j]);
            }
            for (int j = i + 1; j < nums.Length; j++)
            {
                right.Add(nums[j]);
            }
            result[i] = left.Count - right.Count;

        }
        return result;
    }

    public int[] NumberOfPairs(int[] nums)
    {
        //2341
        int count = 0;
        HashSet<int> queue = [];
        for (int i = 0; i < nums.Length; i++)
        {
            if (!queue.Contains(nums[i])) { queue.Add(nums[i]); }
            else
            {
                queue.Remove(nums[i]);
                count++;
            }
        }
        return [count,queue.Count];
    }
}
