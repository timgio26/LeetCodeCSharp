using System;
using System.ComponentModel;
using System.Globalization;
using System.IO.Pipelines;
using System.Net;
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

    public int[][] LargestLocal(int[][] grid)
    {
        //2373
        int mSize = grid.Length;

        int[][] result = new int[mSize - 2][];
        for (int i = 0; i < mSize - 2; i++)
        {
            result[i] = new int[mSize - 2];
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {

                for (int r = 0; r < result.Length; r++)
                {
                    for (int k = 0; k < result.Length; k++)
                    {

                        if (grid[i + r][j + k] > result[r][k]) { result[r][k] = grid[i + r][j + k]; }
                    }
                }


            }
        }
        return result;

    }

    public int DiagonalSum(int[][] mat)
    {
        //1572
        int right = mat.Length - 1;
        int sum = 0;
        for (int i = 0; i < mat.Length; i++)
        {

            if (right == i) { sum += mat[i][i]; right--; continue; }
            sum += mat[i][i];
            sum += mat[i][right--];

        }
        return sum;
    }

    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {
        //2965
        int dup = 0;
        int miss = 0;
        int[] numList = new int[grid.Length * grid.Length];
        foreach (var i in grid)
        {
            foreach (var j in i)
            {

                if (numList[j - 1] != 0) { dup = j; continue; }
                numList[j - 1] = 1;
            }
        }
        for (int i = 0; i < numList.Length; i++)
        {

            if (numList[i] == 0) { miss = i + 1; break; }
        }
        return [dup, miss];

    }

    public string[] SortPeople(string[] names, int[] heights)
    {
        //2418
        Dictionary<int, string> namesHeight = new Dictionary<int, string>();
        for (int i = 0; i < names.Length; i++)
        {
            namesHeight[heights[i]] = names[i];
        }

        string[] result = new string[names.Length];
        Array.Sort(heights);

        for (int i = names.Length - 1, j = 0; i >= 0; i--, j++)
        {
            result[j] = namesHeight[heights[i]];
        }
        return result;
    }

    public int ArithmeticTriplets(int[] nums, int diff)
    {
        //2367
        int count = 0;
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (nums.Contains(nums[i] + diff) & nums.Contains(nums[i] + (2 * diff))) { count++; }
        }
        return count;
    }

    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
    {
        //2798
        int count = 0;
        foreach (var h in hours)
        {
            if (h >= target) count++;
        }
        return count;
    }

    public int CountPairs(IList<int> nums, int target)
    {
        //2824
        int result = 0;
        for (int i = 0; i < nums.Count - 1; i++)
        {
            int right = nums.Count - 1;
            while (i < right)
            {
                if (nums[i] + nums[right] < target) { result++; }
                right--;
            }
        }
        return result;
    }

    public int[] LeftRightDifference(int[] nums)
    {
        //2574

        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {

            result[i] = Math.Abs(nums[..i].Sum() - nums[(i + 1)..].Sum());

        }

        return result;
    }

    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        //1365
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j) { continue; }
                if (nums[i] > nums[j]) { result[i]++; }
            }
        }
        return result;
    }

    public int MinMovesToSeat(int[] seats, int[] students)
    {
        //2037
        Array.Sort(seats);
        Array.Sort(students);
        int count = 0;
        for (int i = 0; i < seats.Length; i++)
        {
            count += Math.Abs(seats[i] - students[i]);
        }
        return count;
    }

    public int[] MinOperations(string boxes)
    {
        //1769
        int[] result = new int[boxes.Length];
        for (int i = 0; i < boxes.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < boxes.Length; j++)
            {
                if (boxes[j] == '1') { count += Math.Abs(j - i); }
                if (j == boxes.Length - 1) { result[i] = count; }
            }
        }
        return result;
    }

    public int MaxWidthOfVerticalArea(int[][] points)
    {
        //1637
        int max = 0;
        List<int> widths = [];
        foreach (var i in points)
        {
            widths.Add(i[0]);
        }
        widths.Sort();
        for (int i = 0; i < widths.Count - 1; i++)
        {
            if (widths[i + 1] - widths[i] > max) { max = widths[i + 1] - widths[i]; }
        }
        return max;
    }

    public double MinimumAverage(int[] nums)
    {
        //3194
        double min = double.MaxValue;
        Array.Sort(nums);
        int left = 0;
        int right = nums.Length - 1;
        while (left < right)
        {
            double avg = (double)(nums[left] + nums[right]) / 2;
            if (avg < min) { min = avg; }
            left++; right--;

        }
        return min;
    }

    public int[] RunningSum(int[] nums)
    {
        //1480
        int[] result = new int[nums.Length];
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            count += nums[i];
            result[i] = count;
        }
        return result;
    }

    public IList<int> StableMountains(int[] height, int threshold)
    {
        //3285
        List<int> result = [];
        for (int i = 1; i < height.Length; i++)
        {
            if (height[i - 1] > threshold) { result.Add(i); }
        }
        return result;
    }

    public int MaxProduct(int[] nums)
    {
        //1464
        Array.Sort(nums);
        return (nums[nums.Length - 1] - 1) * (nums[nums.Length - 2] - 1);
    }

    public int CountPairs2176(int[] nums, int k)
    {
        //2176
        int count = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int product = i * j;
                if (nums[i] == nums[j] && product % k == 0) { count++; }
            }
        }
        return count;
    }

    public int SubarraySum(int[] nums)
    {
        //3427
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int start = i - nums[i] > 0 ? i - nums[i] : 0;
            // result += nums[start..(i + 1)].Sum();
            int sum = 0;
            for (int j = start; j < i + 1; j++)
            {
                sum += nums[j];
            }
            result += sum;

        }
        return result;
    }

    public int[] MinCosts(int[] cost)
    {
        //3502
        int minCost = int.MaxValue;
        for (int i = 0; i < cost.Length; i++)
        {
            if (cost[i] > minCost) { cost[i] = minCost; continue; }
            minCost = cost[i];
        }
        return cost;
    }

    public IList<int> LuckyNumbers(int[][] matrix)
    {
        //1380
        List<int> result = [];
        int matrixRow = matrix.Length;
        int matrixCol = matrix[0].Length;
        for (int i = 0; i < matrixRow; i++)
        {
            for (int j = 0; j < matrixCol; j++)
            {
                int numFocus = matrix[i][j];
                bool colCheck = false, rowCheck = false;
                for (int col = 0; col < matrixCol; col++)//col
                {
                    if (numFocus > matrix[i][col]) { break; }
                    if (col == matrixCol - 1) { colCheck = true; }
                }
                for (int row = 0; row < matrixRow; row++)//col
                {
                    if (numFocus < matrix[row][j]) { break; }
                    if (row == matrixRow - 1) { rowCheck = true; }
                }
                if (rowCheck && colCheck) { result.Add(numFocus); }

            }
        }
        return result;
    }

    public int MinOperations1827(int[] nums)
    {
        //1827
        int result = 0, curVal = 0;
        foreach (int num in nums)
        {
            if (num <= curVal) { result += curVal - num + 1; curVal += 1; continue; }
            curVal = num;
        }
        return result;
    }

    public int[] NumberGame(int[] nums)
    {
        //2974
        int[] result = new int[nums.Length];
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i += 2)
        {
            result[i] = nums[i + 1];
            result[i + 1] = nums[i];
        }
        return result;
    }

    public int LargestAltitude(int[] gain)
    {
        //1732
        int max = 0, curAlt = 0;
        foreach (int i in gain)
        {
            curAlt += i;
            if (curAlt > max) { max = curAlt; }
        }
        return max;
    }

    public int CountNegatives(int[][] grid)
    {
        //1351 can be improved with binary search
        int count = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] < 0) { count++; }
            }
        }
        return count;
    }

    public int HeightChecker(int[] heights)
    {
        //1051
        int count = 0;

        int[] expected = new int[heights.Length];
        for (int i = 0; i < expected.Length; i++)
        {
            expected[i] = heights[i];
        }
        Array.Sort(expected);
        for (int i = 0; i < expected.Length; i++)
        {
            if (expected[i] != heights[i]) { count++; }
        }
        return count;
    }

    public int MaxProductDifference(int[] nums)
    {
        //1913
        Array.Sort(nums);
        int len = nums.Length;
        return (nums[len - 1] * nums[len - 2]) - (nums[0] * nums[1]);
    }

    public int[] CreateTargetArray(int[] nums, int[] index)
    {
        //1389
        List<int> result = new List<int>(nums.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            result.Insert(index[i], nums[i]);
        }
        return result.ToArray();
    }

    public int[] FinalPrices(int[] prices)
    {
        //1475
        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                if (prices[j] <= prices[i]) { prices[i] = prices[i] - prices[j]; break; }
            }
        }
        return prices;
    }

    public int[] PivotArray(int[] nums, int pivot)
    {
        //2161 need to improve runtime
        List<int> leftPivot = [];
        List<int> midPivot = [];
        List<int> rightPivot = [];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < pivot) { leftPivot.Add(nums[i]); continue; }
            if (nums[i] > pivot) { rightPivot.Add(nums[i]); continue; }
            midPivot.Add(nums[i]);
        }
        return [.. leftPivot.Concat(midPivot).Concat(rightPivot)];
    }

    public int ArrayPairSum(int[] nums)
    {
        //561
        Array.Sort(nums);
        int count = 0;
        for (int i = 0; i < nums.Length; i += 2)
        {
            count += nums[i];
        }
        return count;
    }

    public int MaximizeSum(int[] nums, int k)
    {
        //2656
        int max = nums[0];
        int result = 0;
        for (int i = 1; i < nums.Length; i++) { if (nums[i] > max) { max = nums[i]; } }
        for (int i = 0; i < k; i++)
        {
            result += max + i;

        }
        return result;
    }

    public int MinOperations3065(int[] nums, int k)
    {
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < k) { count++; }
        }
        return count;
    }

    public int[] DecompressRLElist(int[] nums)
    {
        List<int> result = [];
        for (int i = 0; i < nums.Length; i += 2)
        {

            for (int j = 0; j < nums[i]; j++)
            {
                result.Add(nums[i + 1]);
            }

        }
        return result.ToArray();
    }

    public int SumIndicesWithKSetBits(IList<int> nums, int k)
    {
        //2859
        int result = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            string bin = Convert.ToString(i, 2);
            int count = 0;
            for (int j = 0; j < bin.Length; j++)
            {
                if (bin[j] == '1') { count++; }
                if (count == k && j == bin.Length - 1)
                {
                    result += nums[i];
                }
            }
        }
        return result;
    }
}
