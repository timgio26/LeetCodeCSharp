using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

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
                    tempArr[k] = arr[k + j] + tempArr[k- 1];
                }

                sum += tempArr[tempArrLen - 1];

            }
        }
        return sum;
    }

    
}
