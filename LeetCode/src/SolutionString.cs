using System;
using System.IO.Pipelines;
using System.Runtime.Serialization;
using System.Text;

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

            if (command[i] == 'G') { resultList.Add("G"); i++; continue; }
            if (command[i] == '(' & command[i + 1] == 'a') { System.Console.WriteLine("al"); resultList.Add("al"); i += 4; continue; }
            if (command[i] == '(') { System.Console.WriteLine("o"); resultList.Add("o"); i += 2; continue; }

        }
        return string.Join("", resultList);
    }

    public int MaxFreqSum(string s)
    {
        //3541
        Dictionary<char, int> vowels = new Dictionary<char, int>();
        Dictionary<char, int> consonants = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if ("aiueo".Contains(s[i]))
            {
                if (!vowels.ContainsKey(s[i])) { vowels[s[i]] = 1; continue; }
                vowels[s[i]]++;
                continue;
            }
            if (!consonants.ContainsKey(s[i])) { consonants[s[i]] = 1; continue; }
            consonants[s[i]]++;
        }
        int maxCons = 0;
        foreach (var i in consonants)
        {
            if (i.Value > maxCons) { maxCons = i.Value; }
        }
        int maxVow = 0;
        foreach (var i in vowels)
        {
            if (i.Value > maxVow) { maxVow = i.Value; }
        }
        return maxCons + maxVow;
    }

    public int FindPermutationDifference(string s, string t)
    {
        Dictionary<char, int> sDict = new Dictionary<char, int>();
        Dictionary<char, int> tDict = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            sDict[s[i]] = i;
        }
        int result = 0;
        for (int i = 0; i < t.Length; i++)
        {
            // tDict[t[i]] = i;
            result += Math.Abs(i - sDict[t[i]]);
        }
        // foreach (var item in sDict)
        // {
        //     result += Math.Abs(item.Value - tDict[item.Key]);
        // }
        return result;
    }

    public int ReverseDegree(string s)
    {
        //3498
        int result = 0;
        int i = 1;
        foreach (char c in s)
        {
            result += (('a' - c + 26) * i++);
        }
        return result;

    }

    public int BalancedStringSplit(string s)
    {
        //1221 can be improved using int balance
        int result = 0;
        Dictionary<char, int> RLDict = new Dictionary<char, int>();
        RLDict['L'] = 0;
        RLDict['R'] = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'L') { RLDict['L']++; }
            if (s[i] == 'R') { RLDict['R']++; }
            if (RLDict['L'] == RLDict['R']) { RLDict['L'] = 0; RLDict['R'] = 0; result++; }
        }
        return result;
    }

    public int MostWordsFound(string[] sentences)
    {
        //2114
        int result = 0;
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Split(" ").Length > result) { result = sentences[i].Split(" ").Length; }
        }
        return result;
    }

    public string ReversePrefix(string word, char ch)
    {
        //2000 better use array method. dont need stack
        string result = "";
        int lastIdx = 0;
        Stack<string> strings = new Stack<string>();

        for (int i = 0; i < word.Length; i++)
        {
            strings.Push(word[i].ToString());
            if (word[i] == ch) { lastIdx = i + 1; break; }
        }
        while (strings.Count > 0 && lastIdx != 0)
        {
            result += strings.Pop();
        }

        return result + word[lastIdx..];
    }

    public string TruncateSentence(string s, int k)
    {
        //1816
        string[] sList = s.Split(" ");
        return string.Join(" ", sList[..k]);
    }

    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        //1662
        return string.Equals(string.Join("", word1), string.Join("", word2));
    }

    public string DecodeMessage(string key, string message)
    {
        //2325 bisa improve pake string builder
        Dictionary<char, char> keyDict = new();
        char myChar = 'a';
        foreach (char keyChar in key)
        {
            if (keyDict.Count == 26) { break; }
            if (keyChar != ' ' && !keyDict.ContainsKey(keyChar))
            {
                keyDict[keyChar] = myChar++;
                continue;
            }

        }

        string result = "";
        foreach (char msgChar in message)
        {
            result += msgChar == ' ' ? ' ' : keyDict[msgChar];
        }
        return result;
    }

    public string RestoreString(string s, int[] indices)
    {
        //1528
        string result = "";
        for (int i = 0; i < indices.Length; i++)
        {
            result += s[Array.IndexOf(indices, i)];
        }
        return result;
    }

    public string RestoreStringV2(string s, int[] indices)
    {
        //1528
        char[] result = new char[indices.Length];
        for (int i = 0; i < indices.Length; i++)
        {
            result[indices[i]] = s[i];
        }
        return string.Join("", result);
        // better pake new string(result)
    }

    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        //1773
        int result = 0;
        int idxFilter = ruleKey == "type" ? 0 : ruleKey == "color" ? 1 : 2;
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i][idxFilter] == ruleValue) { result++; }
        }
        return result;
    }

    public string RemoveOuterParentheses(string s)
    {
        //1021
        string[] sComp = new string[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            sComp[i] = s[i].ToString();
        }
        int num = 0;
        for (int i = 0; i < sComp.Length; i++)
        {
            if (sComp[i] == "(") { num++; } else { num--; }
            if (sComp[i] == "(" && num == 1) { sComp[i] = string.Empty; continue; }
            if (sComp[i] == ")" && num == 0) { sComp[i] = string.Empty; continue; }
        }
        return string.Join("", sComp);
    }

    public int PrefixCount(string[] words, string pref)
    {
        int count = 0;

        for (int i = 0; i < words.Length; i++)
        {
            int limit = pref.Length > words[i].Length ? words[i].Length : pref.Length;
            if (string.Equals(pref, words[i][..limit])) { count++; }
        }
        return count;
    }

    public int MaxDepth(string s)
    {
        //1614
        int max = 0;
        int count = 0;
        foreach (char i in s)
        {
            if (i == '(') { count++; }
            if (i == ')') { count--; }
            if (count > max) { max = count; }
        }
        return max;
    }

    public string FirstPalindrome(string[] words)
    {
        //2108
        foreach (string i in words)
        {
            int left = 0;
            int right = i.Length - 1;
            while (left <= right)
            {
                if (i[left++] != i[right--]) { break; }
                if (left == right || left > right) { return i; }
            }
        }
        return "";
    }

    public string ReverseWords(string s)
    {
        //557
        string[] words = s.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            char[] letters = words[i].ToCharArray();
            int left = 0;
            int right = letters.Length - 1;
            while (left < right)
            {
                char temp = letters[right];
                letters[right--] = letters[left];
                letters[left++] = temp;
                // left++; right--;
            }
            words[i] = string.Join(string.Empty, letters);
        }
        return string.Join(' ', words);
    }
}
