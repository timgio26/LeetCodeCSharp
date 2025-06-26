using System;

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
}
