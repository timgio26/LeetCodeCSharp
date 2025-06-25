using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace LeetCode.src;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int ansI = 0;
        int ansJ = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = 0; j < nums.Length; j++)
            {
                // if (i == j) continue;
                if (nums[i] + nums[j] == target && i != j) { ansI = i; ansJ = j; break; }
            }
            // System.Console.WriteLine($"{ansI},{ansJ},{nums[ansI] + nums[ansJ]}");
            if (nums[ansI] + nums[ansJ] == target && ansI != ansJ) { break; }

        }
        return [ansI, ansJ];
    }
    public int[] TwoSumV2(int[] nums, int target)
    {
        int[] LoopedNum = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            // System.Console.WriteLine($"loop {i}");
            int toFind = target - nums[i];
            // System.Console.WriteLine(LoopedNum.Length);
            if (LoopedNum.Length > 0)
            {

                if (Array.IndexOf(LoopedNum, toFind) != -1 && Array.IndexOf(LoopedNum, toFind) != i)
                {
                    return [Array.IndexOf(LoopedNum, toFind), i];
                }
            }
            LoopedNum[i] = nums[i];
        }
        return Array.Empty<int>();
    }
    public int[] SortedSquares(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = nums[i] * nums[i];
        }
        Array.Sort(nums);
        return nums;
    }
    public int[] SortedSquaresV2(int[] nums)
    {
        int left = 0, right = nums.Length - 1, pos = nums.Length - 1;
        int[] result = new int[nums.Length];
        while (left <= right)
        {
            if (Math.Pow(nums[left], 2) > Math.Pow(nums[right], 2))
            {
                result[pos--] = nums[left] * nums[left];
                left++;
            }
            else
            {
                result[pos--] = nums[right] * nums[right];
                right--;
            }
        }
        return result;

    }

    public int[] BuildArray(int[] nums)
    {
        int[] result = new int[nums.Length];
        int n = 0;
        foreach (var item in nums)
        {
            result[n++] = nums[item];
            // n++;
        }
        return result;
    }

    public IList<int> FindWordsContaining(string[] words, char x)
    {
        List<int> ansList = [];
        for (var i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(x)) { ansList.Add(i); }
        }
        return ansList;
    }

    public int[] GetConcatenation(int[] nums)
    {
        int[] result = new int[nums.Length * 2];
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = nums[i];
            result[i + nums.Length] = nums[i];
        }
        return result;
    }

    public int NumIdenticalPairs(int[] nums)
    {
        int NumOfPairs = 0;
        for (var i = 0; i < nums.Length - 1; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {

                if (nums[i] == nums[j]) { System.Console.WriteLine("yeess"); ; NumOfPairs++; }
            }
        }
        return NumOfPairs;
    }

    public int[] TransformArray(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] = nums[i] % 2;
        }
        Array.Sort(nums);
        return nums;
    }

    public int FinalValueAfterOperations(string[] operations)
    {
        int initVal = 0;
        foreach (var item in operations)
        {
            if (item.Contains("++")) { initVal++; } else { initVal--; }
        }
        return initVal;
    }

    public int[] Shuffle(int[] nums, int n)
    {
        //1470
        int[] result = new int[nums.Length];
        int seq = 0;
        for (int i = 0; i < nums.Length; i += 2)
        {
            result[i] = nums[seq];
            result[i + 1] = nums[seq + n];
            seq++;
        }
        return result;
    }

    public bool CanBeIncreasing(int[] nums)
    {
        //1909
        bool result = false;
        for (int i = 0; i < nums.Length; i++)
        {
            List<int> tempNums = new List<int>();
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j) { continue; }
                tempNums.Add(nums[j]);
            }
            if (tempNums.Count > 1)
            {
                for (int j = 0; j < tempNums.Count() - 1; j++)
                {
                    if (tempNums[j + 1] <= tempNums[j]) { break; }
                    if (tempNums[j + 1] > tempNums[j] && j + 1 == tempNums.Count() - 1) { result = true; }
                }

            }
            else
            {
                result = true;
            }

            if (result) { break; }
        }
        return result;

    }

    public int MinimumOperations(int[] nums)
    {
        //3190
        int result = 0;
        foreach (var i in nums)
        {
            if ((i + 1) % 3 == 0 || (i - 1) % 3 == 0) { result++; }
        }
        return result;
    }

    public int MaximumWealth(int[][] accounts)
    {
        //1672
        int maxWealth = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            int curMaxWealth = 0;
            for (int j = 0; j < accounts[i].Length; j++)
            {
                curMaxWealth += accounts[i][j];
                if (j == accounts[i].Length - 1 && curMaxWealth > maxWealth) { maxWealth = curMaxWealth; }
            }
        }
        return maxWealth;
    }

    public int[] GetSneakyNumbers(int[] nums)
    {
        List<int> unique = new List<int>() { };
        List<int> duplicate = new List<int>() { };
        for (int i = 0; i < nums.Length; i++)
        {
            if (unique.Contains(nums[i]))
            {
                duplicate.Add(nums[i]);
            }
            else
            {
                unique.Add(nums[i]);
            }
        }
        return duplicate.ToArray();
    }

    public int CountConsistentStrings(string allowed, string[] words)
    {
        //1684
        int numOfConsistentStr = 0;
        List<string> allowLetter = [];
        for (int j = 0; j < allowed.Length; j++)
        {
            allowLetter.Add(allowed[j].ToString());
        }

        for (int i = 0; i < words.Length; i++)
        {
            List<string> letter = [];
            for (int j = 0; j < words[i].Length; j++)
            {
                letter.Add(words[i][j].ToString());
            }

            HashSet<string> wordChar = new HashSet<string>(letter);
            for (int j = 0; j < wordChar.Count; j++)
            {
                // System.Console.WriteLine(wordChar.ToArray()[j]);
                if (!allowLetter.Contains(wordChar.ToArray()[j])) { break; }
                if (j == wordChar.Count - 1) { numOfConsistentStr++; }
            }
            // System.Console.WriteLine("======");
        }
        return numOfConsistentStr;
    }

    public int CountConsistentStringsV2(string allowed, string[] words)
    {
        //1684
        int numOfConsistentStr = 0;
        HashSet<char> allowLetter = new HashSet<char>(allowed);

        for (int i = 0; i < words.Length; i++)
        {

            for (int j = 0; j < words[i].Length; j++)
            {
                // System.Console.WriteLine(wordChar.ToArray()[j]);
                if (!allowLetter.Contains(words[i][j])) { break; }
                if (j == words[i].Length - 1) { numOfConsistentStr++; }
            }
            // System.Console.WriteLine("======");
        }
        return numOfConsistentStr;
    }

    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int max = 0;
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] > max) { max = candies[i]; }
        }
        List<bool> result = [];
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] >= max - extraCandies) { result.Add(true); continue; }
            result.Add(false);
        }
        return result;
    }
    
}
