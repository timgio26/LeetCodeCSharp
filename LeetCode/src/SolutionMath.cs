namespace LeetCode.src;

public class SolutionMath
{
    public int DifferenceOfSums(int n, int m)
    {
        //2894
        int notDiv = 0, div = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % m == 0) { div += i; continue; }
            notDiv += i;
        }
        return notDiv - div;
    }

    public int SmallestEvenMultiple(int n)
    {
        //2413
        return n % 2 == 0 ? n : n * 2;
    }

    public int MinimumSum(int num)
    {
        // 2160
        char[] numStr = num.ToString().ToCharArray();
        Array.Sort(numStr);
        return (Convert.ToInt16(numStr[0]) - 48) * 10 + Convert.ToInt16(numStr[2]) - 48 + (Convert.ToInt16(numStr[1]) - 48) * 10 + Convert.ToInt16(numStr[3]) - 48;
    }

    public int[] GetFinalState(int[] nums, int k, int multiplier)
    {
        //3264
        for (int i = 0; i < k; i++)
        {
            int minidx = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] < nums[minidx]) { minidx = j; }
            }
            nums[minidx] = nums[minidx] * multiplier;
        }
        return nums;
    }

    public int MinOperations(int[] nums, int k)
    {
        //3512
        int sum = 0;
        foreach (int num in nums)
        {
            sum += num;
        }
        return sum % k;
    }

    public int SubtractProductAndSum(int n)
    {
        //1281
        List<int> digits = [];
        while (n > 0)
        {
            digits.Add(n % 10);
            n /= 10;
        }
        int sum = 0, product = 1;
        foreach (int i in digits)
        {
            product *= i;
            sum += i;
        }
        return product - sum;
    }


    public int MinTimeToVisitAllPoints(int[][] points)
    {
        //1266
        int count = 0;
        int startX = points[0][0];
        int startY = points[0][1];
        for (int i = 1; i < points.Length && points.Length > 1; i++)
        {
            if (Math.Abs(points[i][0] - startX) > Math.Abs(points[i][1] - startY))
            {
                count += Math.Abs(points[i][0] - startX);
            }
            else
            {
                count += Math.Abs(points[i][1] - startY);
            }
            startX = points[i][0]; startY = points[i][1];

        }
        return count;
    }

    public int ProjectionArea(int[][] grid)
    {
        //883
        int count = 0;
        // int countFront = 0;
        int[] countSide = new int[grid.Length];
        for (int i = 0; i < grid.Length; i++)
        {
            int maxHeight = 0;
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] > 0) { count++; }
                if (grid[i][j] > maxHeight) { maxHeight = grid[i][j]; }
                if (grid[i][j] > countSide[j]) { countSide[j] = grid[i][j]; }
            }
            count += maxHeight;
        }
        int countSideSum = 0;
        foreach (int i in countSide)
        {
            countSideSum += i;
        }
        return count + countSideSum;
    }

    public int Maximum69Number(int num)
    {
        //1323
        int[] numsDigits = new int[num.ToString().Length];
        int len = numsDigits.Length;
        int result = 0;
        for (int i = len - 1; i >= 0; i--)
        {
            numsDigits[i] = num % 10;
            num /= 10;
        }
        for (int i = 0; i < len; i++)
        {
            if (numsDigits[i] == 6)
            {
                numsDigits[i] = 9;
                break;
            }
        }
        int pengali = 1;
        for (int i = len - 1; i >= 0; i--)
        {
            result += numsDigits[i] * pengali;
            pengali *= 10;
        }
        return result;
    }

    public int SumOddLengthSubarrays(int[] arr)
    {
        //1588 can be improved
        int sum = 0;
        int len = arr.Length;
        for (int i = 1; i <= len; i += 2)
        {
            for (int j = 0; j <= len - i; j++)
            {
                int[] tempArr = new int[i];
                int tempArrLen = tempArr.Length;
                tempArr[0] = arr[j];
                for (int k = 1; k < tempArrLen; k++)
                {
                    tempArr[k] = arr[k + j] + tempArr[k - 1];
                }

                sum += tempArr[tempArrLen - 1];

            }
        }
        return sum;
    }

    public int NumberOfMatches(int n)
    {
        //1688
        int match = 0;
        while (n > 1)
        {
            match += n / 2;
            n = n / 2 + n % 2;
        }
        return match;
    }

    public int CountDigits(int num)
    {
        //2520
        int count = 0;
        int numTemp = num;
        while (numTemp > 0)
        {
            if (num % (numTemp % 10) == 0) { count++; }
            numTemp /= 10;
        }
        return count;
    }

    public int SumOfMultiples(int n)
    {
        //2652
        int sum = 0;
        for (int i = 0; i <= n; i++)
        {
            if (i % 3 == 0 || i % 5 == 0 || i % 7 == 0) { sum += i; }

        }
        return sum;
    }

    public int NumberOfSteps(int num)
    {
        //1342
        int count = 0;
        int start = num;
        while (start > 0)
        {
            if (start % 2 == 0) { start /= 2; count++; continue; }
            start -= 1;
            count++;
        }
        return count;
    }

    public int CountOperations(int num1, int num2)
    {
        //2169
        int count = 0;
        while (num1 > 0 && num2 > 0)
        {
            if (num1 > num2)
            {
                num1 -= num2;
                count++;
                continue;
            }
            num2 -= num1;
            count++;

        }
        return count;
    }

    public int OddCells(int m, int n, int[][] indices)
    {
        int count = 0;
        int[,] matrix = new int[m, n];
        foreach (var i in indices)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i[0], j] += 1;
            }
            for (int j = 0; j < m; j++)
            {
                matrix[j, i[1]] += 1;
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] % 2 == 1) { count++; }
            }
        }
        return count;
    }

    public int FindClosest(int x, int y, int z)
    {
        //3516
        return Math.Abs(z - x) == Math.Abs(z - y) ? 0 : Math.Abs(z - x) > Math.Abs(z - y) ? 2 : 1;
    }

    public int FindGCD(int[] nums)
    {
        //1979
        int min = nums.Min();
        int max = nums.Max();
        System.Console.WriteLine(max % min);
        while (max % min != 0)
        {
            int tempmax = max;
            max = min;
            min = tempmax % min;
        }
        return min;
    }

    public int FindNumbers1295(int[] nums)
    {
        //1295
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int count = 0;
            while (nums[i] > 0)
            {
                nums[i] /= 10;
                count++;
            }
            if (count % 2 == 0) { result++; }
        }
        return result;
    }

    public int SmallestIndex(int[] nums)
    {
        //3550
        for (int i = 0; i < nums.Length; i++)
        {
            int digitSum = 0;
            while (nums[i] > 0)
            {
                digitSum += nums[i] % 10;
                nums[i] /= 10;
            }
            if (i == digitSum) { return i; }
        }
        return -1;
    }

    public int PivotInteger(int n)
    {
        //2485 triangular numbers
        int all = n * (n + 1) / 2;
        for (int i = 1; i <= n; i++)
        {
            int left = i * (i + 1) / 2;
            int right = all - ((i - 1) * i / 2);
            if (left == right) { return i; }
            if (left > right) { break; }
        }
        return -1;
    }
    public bool IsPowerOfTwo(int n)
    {
        //231 can be improved using loop /=2
        int init = 0;
        while (Math.Pow(2, init) <= n)
        {
            if (Math.Pow(2, init) == n) { return true; }
            init++;
        }
        return false;
    }

    public int SumOfTheDigitsOfHarshadNumber(int x)
    {
        //3099
        int tempX = x, sum = 0;
        while (tempX > 0)
        {
            sum += tempX % 10;
            tempX /= 10;
        }
        return x % sum == 0 ? sum : -1;
    }

    public bool IsPowerOfThree(int n)
    {
        //326
        while (n >= 1)
        {
            if (n == 1) { return true; }
            if (n % 3 != 0) { break; }
            n /= 3;
        }
        return false;
    }

    public int CountSymmetricIntegers(int low, int high)
    {
        //2843
        int count = 0;
        for (int i = low; i <= high; i++)
        {
            int temp = i;
            int numsDigits = i.ToString().Length;
            if (numsDigits % 2 != 0) { continue; }
            int left = 0;
            int right = 0;
            for (int j = 0; j < numsDigits / 2; j++)
            {
                right += temp % 10;
                temp /= 10;
            }
            for (int j = 0; j < numsDigits / 2; j++)
            {
                left += temp % 10;
                temp /= 10;
            }
            if (left == right) { count++; }
        }
        return count;
    }

    public bool IsSameAfterReversals(int num)
    {
        //2119 only false if there is leading 0
        char[] numChar = num.ToString().ToCharArray();
        Array.Reverse(numChar);
        int numRevInt = Convert.ToInt32(string.Concat(numChar));

        numChar = numRevInt.ToString().ToCharArray();
        Array.Reverse(numChar);
        numRevInt = Convert.ToInt32(string.Concat(numChar));
        return num == numRevInt;
    }

    public int MinMaxDifference(int num)
    {
        //2566
        string numArr = num.ToString();
        char maxRep = new();
        char minRep = new();
        for (int i = 0; i < numArr.Length; i++)
        {
            if (numArr[i] != '9') { maxRep = numArr[i]; break; }
        }
        for (int i = 0; i < numArr.Length; i++)
        {
            if (numArr[i] != '0') { minRep = numArr[i]; break; }
        }
        int max = int.Parse(numArr.Replace(maxRep, '9'));
        int min = int.Parse(numArr.Replace(minRep, '0'));
        return max - min;
    }

    public int CommonFactors(int a, int b)
    {
        //2427
        int min = Math.Min(a, b);
        int count = 0;
        for (int i = 1; i <= min; i++)
        {
            if (a % i == 0 && b % i == 0) { count++; }
        }
        return count;

    }

    public bool IsPalindrome(int x)
    {
        //9
        string xStr = x.ToString();
        bool ans = true;
        int left = 0, right = xStr.Length - 1;
        while (left < right)
        {
            if (xStr[left] != xStr[right]) { ans = false; break; }
            left++; right--;
        }
        return ans;
    }

    public int[] PlusOne(int[] digits)
    {
        //66
        Stack<int> ints = new();
        int rem = 1;
        for (int i = digits.Length - 1; i >= 0; i--)
        {

            ints.Push((digits[i] + rem) % 10);
            rem = (digits[i] + rem) / 10;
        }
        if (rem > 0) { ints.Push(rem); }
        int[] result = new int[ints.Count];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = ints.Pop();
        }
        return result;
    }
}
