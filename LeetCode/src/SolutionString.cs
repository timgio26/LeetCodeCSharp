using System;

namespace LeetCode.src;

public class SolutionString
{
    public int ScoreOfString(string s)
    {
        List<char> chars = new List<char>() { };
        foreach (char item in s)
        {
            chars.Add(item);
        }
        int score = 0;
        for (int i = 0; i < chars.Count - 1; i++)
        {
            score += Math.Abs((int)chars[i] - (int)chars[i + 1]);
        }
        return score;
    }
}
