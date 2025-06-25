using System;

namespace LeetCode.src;

public class SolutionString
{
    public int ScoreOfString(string s)
    {
        //3110
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

    public string DefangIPaddr(string address)
    {
        //1108
        List<string> result = new List<string>() { };
        for (int i = 0; i < address.Length; i++)
        {
            if (address[i] == '.')
            {
                result.Add("[.]");
                continue;
            }
            result.Add(address[i].ToString());
        }
        return String.Join("", result);
    }

    public int NumJewelsInStones(string jewels, string stones)
    {
        //711
        Dictionary<char, int> freq = new Dictionary<char, int>();
        for (int i = 0; i < stones.Length; i++)
        {
            if (!freq.ContainsKey(stones[i])) { freq[stones[i]] = 1; continue; }
            freq[stones[i]]++;

        }

        int result = 0;
        foreach (var item in jewels)
        {
            if (freq.ContainsKey(item))
            {
                result += freq[item];
            }
        }

        return result;
    }

    public string ConvertDateToBinary(string date)
    {
        //3280
        string[] dateComp = date.Split("-");
        // List<int> binDateComp = [];
        List<string> binStrDateComp = [];
        for (int i = 0; i < dateComp.Length; i++)
        {
            // binDateComp.Add(Convert.ToInt16(dateComp[i]));
            binStrDateComp.Add(Convert.ToString(Convert.ToInt16(dateComp[i]), 2));
        }
        return String.Join("-", binStrDateComp);
    }

    public string Interpret(string command)
    {
        //1678
        List<string> resultList = [];
        for (int i = 0; i < command.Length;)
        {

            if (command[i] == 'G'){resultList.Add("G");i++;continue; }
            if (command[i] == '(' & command[i + 1] == 'a') { System.Console.WriteLine("al"); resultList.Add("al"); i += 4; continue; }
            if (command[i] == '(') { System.Console.WriteLine("o"); resultList.Add("o"); i += 2; continue; }

        }
        return string.Join("", resultList);
    }
}
