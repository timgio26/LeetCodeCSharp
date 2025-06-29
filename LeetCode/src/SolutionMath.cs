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
        return (Convert.ToInt16(numStr[0])-48) * 10 + Convert.ToInt16(numStr[2])-48 + (Convert.ToInt16(numStr[1])-48) * 10 + Convert.ToInt16(numStr[3])-48;
    }

    
}
