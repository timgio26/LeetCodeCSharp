using System;
using System.Net.Http.Headers;

namespace LeetCode.src;

public class SolutionOther
{
    public int[] CountBits(int n)
    {
        //338 
        int[] result = new int[n+1];
        for (int i = 0; i <= n; i++)
        {
            int count = 0;
            char[] chars = Convert.ToString(i, 2).ToCharArray();
            for (int j = 0; j < chars.Length; j++)
            {
                if (chars[j] == '1') { count++; }
            }
            result[i] = count;
        }
        return result;
    }

}
