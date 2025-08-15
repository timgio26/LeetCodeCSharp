using System.Security.Principal;

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

    public int MinElement3300(int[] nums)
    {
        //3300
        int min = int.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            char[] digits = nums[i].ToString().ToCharArray();
            int sum = 0;
            for (int j = 0; j < digits.Length; j++)
            {
                sum += int.Parse(digits[j].ToString());
            }
            if (sum < min) { min = sum; }
            System.Console.WriteLine("=========");
        }
        return min;
    }

    public int DifferenceOfSum(int[] nums)
    {
        //2535
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 10) { continue; }
            char[] digits = nums[i].ToString().ToCharArray();
            int charsum = 0;
            for (int j = 0; j < digits.Length; j++)
            {
                charsum += int.Parse(digits[j].ToString());
            }
            result += Math.Abs(nums[i] - charsum);
        }
        return result;
    }

    public int CountKDifference(int[] nums, int k)
    {
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (Math.Abs(nums[i] - nums[j]) == k) { count++; }
            }
        }
        return count;
    }

    public int DeleteGreatestValue(int[][] grid)
    {
        //2500
        int result = 0;
        int count = 0;
        while (count != grid[0].Length)
        {
            int max = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                int maxLocal = 0;
                int maxLocalIdx = 0;
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] > maxLocal) { maxLocal = grid[i][j]; maxLocalIdx = j; }
                    if (maxLocal > max) { max = maxLocal; }
                }
                grid[i][maxLocalIdx] = 0;
            }
            result += max;
            count++;
        }
        return result;
    }

    public int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        //1534
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                for (int k = j + 1; k < arr.Length; k++)
                {
                    // if (i < j && j < k)
                    // {
                    if ((Math.Abs(arr[i] - arr[j]) <= a) && (Math.Abs(arr[j] - arr[k]) <= b) && (Math.Abs(arr[i] - arr[k]) <= c))
                    {
                        count++;
                    }

                    // }
                }
            }
        }
        return count;
    }

    public int[][] FlipAndInvertImage(int[][] image)
    {
        //832
        for (int i = 0; i < image.Length; i++)
        {
            int left = 0, right = image[i].Length - 1;
            while (left <= right)
            {
                int tempRightInv = image[i][right] == 1 ? 0 : 1;
                image[i][right] = image[i][left] == 1 ? 0 : 1;
                image[i][left] = tempRightInv;
                left++; right--;
            }
        }
        return image;
    }

    public int[] SeparateDigits(int[] nums)
    {
        //2553
        List<int> ints = new();
        for (int i = 0; i < nums.Length; i++)
        {
            List<int> ints1 = new();
            while (nums[i] > 0)
            {
                ints1.Add(nums[i] % 10);
                nums[i] /= 10;
            }
            for (int j = ints1.Count - 1; j >= 0; j--)
            {
                ints.Add(ints1[j]);
            }
        }
        return ints.ToArray();
    }

    public int MaximumCount(int[] nums)
    {
        //2529
        int numsLen = nums.Length;
        int left = 0, right = numsLen - 1;
        while (nums[left] < 0 || nums[right] > 0)
        {
            if (nums[left] < 0) { left++; }
            if (nums[right] > 0) { right--; }
            if (right == -1 || left == numsLen) { break; }
        }
        return left > numsLen - right - 1 ? left : numsLen - right - 1;
    }

    public IList<int> FindPeaks(int[] mountain)
    {
        //2951
        List<int> ints = new();
        for (int i = 1; i < mountain.Length - 1; i++)
        {
            if (mountain[i] > mountain[i - 1] && mountain[i] > mountain[i + 1]) { ints.Add(i); }
        }
        return ints;
    }

    public int SmallestEqual(int[] nums)
    {
        //2057
        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 10 == nums[i]) { return i; }
        }
        return -1;
    }

    public IList<int> TargetIndices(int[] nums, int target)
    {
        //2089
        List<int> ints = [];
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target) { ints.Add(i); }
            if (nums[i] > target) { break; }
        }
        return ints;
    }
    public int[] RowAndMaximumOnes(int[][] mat)
    {
        //2643
        int maxidx = 0, maxcount = 0;
        for (int i = 0; i < mat.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < mat[i].Length; j++)
            {
                if (mat[i][j] == 1) { count++; }
            }
            if (count > maxcount) { maxidx = i; maxcount = count; }
        }
        return [maxidx, maxcount];
    }

    public int AddedInteger(int[] nums1, int[] nums2)
    {
        //3131
        return nums2.Max() - nums1.Max();
    }

    public int SumOfSquares(int[] nums)
    {
        //2778
        int sum = 0;
        int len = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            if (len % (i + 1) == 0) { sum += nums[i] * nums[i]; }
        }
        return sum;
    }

    public bool IsArraySpecial(int[] nums)
    {
        //3151
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] % 2 == nums[i + 1] % 2) { return false; }
        }
        return true;
    }

    public int[] FindEvenNumbers(int[] digits)
    {
        //2094
        // can optimized by check using from 100 to 999
        HashSet<int> ints = new();
        Array.Sort(digits);
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] == 0) { continue; }
            for (int j = 0; j < digits.Length; j++)
            {
                if (j == i) { continue; }
                for (int k = 0; k < digits.Length; k++)
                {
                    if (k == j || k == i || digits[k] % 2 == 1) { continue; }
                    ints.Add(digits[i] * 100 + digits[j] * 10 + digits[k]);
                }
            }
        }
        return ints.ToArray();
    }

    public int SumCounts2913(IList<int> nums)
    {
        //2913
        int count = 0;
        int[] ints = nums.ToArray();
        for (int i = 0; i < nums.Count; i++)
        {
            for (int j = i; j < nums.Count; j++)
            {
                HashSet<int> ints1 = new HashSet<int>(ints[i..(j + 1)]);
                count += ints1.Count * ints1.Count;
            }
        }
        return count;
    }

    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        //2215
        HashSet<int> ints1 = new(nums1), ints2 = new(nums2);
        List<int> onlyIn1 = [], onlyIn2 = [];
        foreach (int i in ints1)
        {
            if (!ints2.Contains(i)) { onlyIn1.Add(i); }
        }
        foreach (int i in ints2)
        {
            if (!ints1.Contains(i)) { onlyIn2.Add(i); }
        }
        return [onlyIn1, onlyIn2];
    }

    public string DestCity(IList<IList<string>> paths)
    {
        //1436
        List<string> from = [], dest = [];
        for (int i = 0; i < paths.Count; i++)
        {
            from.Add(paths[i][0]); dest.Add(paths[i][1]);
        }
        for (int i = 0; i < dest.Count; i++)
        {
            if (!from.Contains(dest[i])) { return dest[i]; }
        }
        return "";
    }
    public bool DivideArray(int[] nums)
    {
        //2206
        List<int> ints = [];
        for (int i = 0; i < nums.Length; i++)
        {
            if (!ints.Contains(nums[i])) { ints.Add(nums[i]); continue; }
            ints.RemoveAt(ints.IndexOf(nums[i]));
        }
        return ints.Count == 0;
    }

    public int[] Decrypt(int[] code, int k)
    {
        //1652 bisa improve pake (i + j) % n
        int len = code.Length;
        int[] ints = new int[len];
        for (int i = 0; i < code.Length; i++)
        {
            int sum = 0;
            if (k == 0) { code[i] = 0; }
            if (k < 0)
            {
                for (int j = k; j < 0; j++)
                {
                    sum += code[i + j < 0 ? i + j + len : i + j];
                }
                // code[i] = sum;
            }
            if (k > 0)
            {
                for (int j = k; j > 0; j--)
                {
                    sum += code[i + j > len - 1 ? i + j - len : i + j];
                }
            }
            ints[i] = sum;
            // System.Console.WriteLine(sum);
        }
        return ints;
    }

    public int[] SumZero(int n)
    {
        //1304
        int[] ints = new int[n];
        int len = n % 2 == 0 ? n : n - 1;
        int val = 1;
        for (int i = 0; i < len; i++)
        {
            if (i % 2 == 1) { ints[i] = val * -1; val++; continue; }
            ints[i] = val;
        }

        return ints;
    }

    public int CountStudents(int[] students, int[] sandwiches)
    {
        //1700
        // Instead of simulating the queue, we can:
        // - Count how many students want each type of sandwich (0 or 1).
        // - Iterate through the sandwiches.
        // - If no student wants the current sandwich, stop.

        Queue<int> studentQ = new Queue<int>(students);
        int sandwichCount = 0;
        for (int count = 0; count < studentQ.Count && sandwichCount < sandwiches.Length;)
        {
            if (sandwiches[sandwichCount] == studentQ.First())
            {
                sandwichCount++;
                studentQ.Dequeue();
                count = 0;
            }
            else
            {
                studentQ.Enqueue(studentQ.First());
                studentQ.Dequeue();
                count++;
            }

        }
        return studentQ.Count();
    }

    public int[] SortByBits(int[] arr)
    {
        //1356
        // Use a custom comparer that:
        // - Counts the number of 1s in binary (efficiently)
        // - Sorts by bit count, then by value

        Array.Sort(arr);
        SortedDictionary<int, List<int>> keyValuePairs = new();
        List<int> result = new();
        for (int i = 0; i < arr.Length; i++)
        {
            string binInt = Convert.ToString(arr[i], 2);
            int count = 0;
            for (int j = 0; j < binInt.Length; j++)
            {
                if (binInt[j] == '1') { count++; }
            }
            if (!keyValuePairs.ContainsKey(count)) { keyValuePairs.Add(count, []); }
            keyValuePairs[count].Add(arr[i]);
        }
        foreach (var i in keyValuePairs)
        {
            result.AddRange(i.Value);
        }
        return result.ToArray();
    }

    public int MaxAdjacentDistance(int[] nums)
    {
        //3423
        int max = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            int val = Math.Abs(nums[(i + 1) % nums.Length] - nums[i]);
            if (val > max) { max = val; }
        }
        return max;
    }

    public int[] DeckRevealedIncreasing(int[] deck)
    {
        //950
        Array.Sort(deck, (a, b) => b.CompareTo(a));
        Queue<int> ints2 = new();
        for (int i = 0; i < deck.Length; i++)
        {
            if (ints2.Count > 0)
            {
                int deq = ints2.Dequeue();
                ints2.Enqueue(deq);
            }
            ints2.Enqueue(deck[i]);
        }
        return ints2.Reverse().ToArray();
    }

    public int SingleNumber(int[] nums)
    {
        //136
        List<int> ints2 = new();
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (!ints2.Contains(nums[i])) { ints2.Add(nums[i]); sum += nums[i]; continue; }
            sum -= nums[i];
        }
        return sum;
    }

    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        //496
        int[] res = new int[nums1.Length];
        Dictionary<int, int> valIdx = new();
        for (int i = 0; i < nums2.Length; i++)
        {
            valIdx.Add(nums2[i], i);
        }
        for (int i = 0; i < res.Length; i++)
        {
            for (int j = valIdx[nums1[i]]; j < nums2.Length; j++)
            {
                if (nums2[j] > nums1[i]) { res[i] = nums2[j]; break; }
                if (j == nums2.Length - 1)
                {
                    { res[i] = -1; }
                }
            }
        }
        return res;
    }

    public int CalPoints(string[] operations)
    {
        //682
        List<int> result = new();
        for (int i = 0; i < operations.Length; i++)
        {
            if (int.TryParse(operations[i], out int num))
            {
                result.Add(num);
            }
            else
            {
                if (operations[i] == "C")
                {
                    result.RemoveAt(result.Count - 1);
                }
                else if (operations[i] == "D")
                {
                    result.Add(result[result.Count - 1] * 2);
                }
                else
                {
                    result.Add(result[result.Count - 1] + result[result.Count - 2]);
                }
            }
        }
        return result.Sum();
    }

    public int CountTestedDevices(int[] batteryPercentages)
    {
        //2960
        int count = 0;
        for (int i = 0; i < batteryPercentages.Length; i++)
        {
            if (batteryPercentages[i] > count) { count++; }
        }
        return count;
    }

    public bool CanBeEqual(int[] target, int[] arr)
    {
        //1460
        Array.Sort(target);
        Array.Sort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            if (target[i] != arr[i]) { return false; }
        }
        return true;
    }

    public IList<IList<int>> MinimumAbsDifference(int[] arr)
    {
        //1200
        Array.Sort(arr);
        int min = int.MaxValue;
        List<List<int>> result = [];
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int diff = arr[i + 1] - arr[i];
            if (diff < min)
            {
                result.Clear();
                result.Add([arr[i], arr[i + 1]]);
                min = diff;
            }
            else if (diff == min) { result.Add([arr[i], arr[i + 1]]); }
        }
        return result.ToArray();
    }

    public IList<IList<int>> Generate(int numRows)
    {
        //118
        List<int[]> ints1 = new();
        for (int i = 1; i <= numRows; i++)
        {
            int[] ints2 = new int[i];
            for (int j = 0; j < ints2.Length; j++)
            {
                if (j == 0 || j == ints2.Length - 1) { ints2[j] = 1; continue; }
                ints2[j] = ints1[i - 2][j - 1] + ints1[i - 2][j];
            }
            ints1.Add(ints2);
        }
        return ints1.ToArray();
    }

    public bool ValidMountainArray(int[] arr)
    {
        //941
        int peakLeft = 0;
        int peakRight = arr.Length - 1;
        for (int i = peakLeft; i < arr.Length - 1; i++)
        {
            if (arr[i + 1] <= arr[i]) { peakLeft = i; break; }
        }
        for (int i = peakRight; i > 0; i--)
        {
            if (arr[i - 1] <= arr[i]) { peakRight = i; break; }
        }
        return peakLeft > 0 && peakLeft == peakRight && peakRight < arr.Length - 1;

    }

    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        //605
        int count = 0;
        int len = flowerbed.Length;
        for (int i = 0; i < len; i++)
        {
            if (flowerbed[i] == 1) { continue; }
            if (i > 0) { if (flowerbed[i - 1] == 1) { continue; } }
            if (i < len - 1) { if (flowerbed[i + 1] == 1) { continue; } }
            flowerbed[i] = 1;
            count++;
        }
        return count >= n;
    }

    public int ThirdMax(int[] nums)
    {
        //414 can be improved
        Array.Sort(nums);
        HashSet<int> numSet = new(nums);
        if (numSet.Count < 3) { return numSet.Last(); }
        nums = numSet.ToArray();
        return nums[nums.Length - 3];
    }

    public IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        //2200
        List<int> keyIdx = [];
        List<int> result = [];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == key) { keyIdx.Add(i); }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            foreach (int j in keyIdx)
            {
                if (Math.Abs(i - j) <= k) { result.Add(i); break; }
            }
        }
        return result;
    }

    public int CountGoodRectangles(int[][] rectangles)
    {
        //1725
        int count = 0;
        int largest = int.MinValue;

        for (int i = 0; i < rectangles.Length; i++)
        {
            int localmin = Math.Min(rectangles[i][0], rectangles[i][1]);
            if (localmin > largest) { largest = localmin; count = 1; continue; }
            if (localmin == largest) { count++; }
        }
        return count;
    }

    public int CountCompleteDayPairs(int[] hours)
    {
        //3184
        int count = 0;
        for (int i = 0; i < hours.Length - 1; i++)
        {
            for (int j = i + 1; j < hours.Length; j++)
            {
                if ((hours[i] + hours[j]) % 24 == 0) { count++; }
            }
        }
        return count;
    }

    public bool CanArrange(int[] arr, int k)
    {
        //1497 exceed time limit
        HashSet<int> usedIdx = [];
        int count = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (usedIdx.Contains(i)) { continue; }
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (usedIdx.Contains(j) || usedIdx.Contains(i)) { continue; }
                if ((arr[i] + arr[j]) % k == 0) { usedIdx.Add(i); usedIdx.Add(j); count++; System.Console.WriteLine(i); System.Console.WriteLine(j); System.Console.WriteLine("=========="); }
            }
        }
        return count == arr.Length / 2;
    }

    public int[] Intersection(int[] nums1, int[] nums2)
    {
        //349
        List<int> ints = [];
        HashSet<int> ints1 = new(nums1), ints2 = new(nums2);
        int shortest = ints1.Count < ints2.Count ? 1 : 2;
        if (shortest == 1)
        {
            foreach (var i in ints1)
            {
                if (ints2.Contains(i)) { ints.Add(i); }
            }
        }
        else
        {
            foreach (var i in ints2)
            {
                if (ints1.Contains(i)) { ints.Add(i); }
            }
        }
        return ints.ToArray();
    }

    public bool IsPowerOfFour(int n)
    {
        //342 recursive
        int rem = n % 4;
        if (n == 1 ) return true;
        if (n <= 0 || rem != 0) return false;
        return IsPowerOfFour(n / 4);
    }

}