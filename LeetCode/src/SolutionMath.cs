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



    
}
