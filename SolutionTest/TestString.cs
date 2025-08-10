using LeetCode.src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Company.TestProject1;

[TestClass]
public class TestString
{
    [TestMethod]
    public void TestScoreOfString()
    {
        SolutionString mySolution = new();
        Assert.AreEqual(mySolution.ScoreOfString("hello"), 13);
        Assert.AreEqual(mySolution.ScoreOfString("zaz"), 50);
    }

    [TestMethod]
    public void TestDefangIPaddr()
    {
        SolutionString mySolution = new();
        StringAssert.Equals(mySolution.DefangIPaddr("1.1.1.1"), "1[.]1[.]1[.]1");
        StringAssert.Equals(mySolution.DefangIPaddr("255.100.50.0"), "255[.]100[.]50[.]0");
    }

    [TestMethod]
    public void TestNumJewelsInStones()
    {
        SolutionString mySolution = new();
        Assert.AreEqual(mySolution.NumJewelsInStones("aA", "aAAbbbb"), 3);
        Assert.AreEqual(mySolution.NumJewelsInStones("z", "ZZ"), 0);

    }

    [TestMethod]
    public void TestConvertDateToBinary()
    {
        SolutionString mySolution = new();
        StringAssert.Equals(mySolution.ConvertDateToBinary("2080-02-29"), "100000100000-10-11101");
        StringAssert.Equals(mySolution.ConvertDateToBinary("1900-01-01"), "11101101100-1-1");
    }


    [TestMethod]
    public void TestInterpret()
    {
        SolutionString mySolution = new();
        StringAssert.Equals(mySolution.Interpret("G()(al)"), "Goal");
        StringAssert.Equals(mySolution.Interpret("G()()()()(al)"), "Gooooal");
        StringAssert.Equals(mySolution.Interpret("(al)G(al)()()G"), "alGalooG");
    }

    [TestMethod]
    public void TestMaxFreqSum()
    {
        SolutionString mySolution = new();
        Assert.AreEqual(mySolution.MaxFreqSum("successes"), 6);
        Assert.AreEqual(mySolution.MaxFreqSum("aeiaeia"), 3);
    }

    [TestMethod]
    public void TestFindPermutationDifference()
    {
        SolutionString mySolution = new();
        Assert.AreEqual(mySolution.FindPermutationDifference("abc", "bac"), 2);
        Assert.AreEqual(mySolution.FindPermutationDifference("abcde", "edbac"), 12);
    }

    [TestMethod]
    public void TestReverseDegree()
    {
        SolutionString mySolution = new();
        Assert.AreEqual(mySolution.ReverseDegree("abc"), 148);
        Assert.AreEqual(mySolution.ReverseDegree("zaza"), 160);
    }

    [TestMethod]
    public void TestBalancedStringSplit()
    {
        SolutionString mySolution = new();
        Assert.AreEqual(mySolution.BalancedStringSplit("RLRRLLRLRL"), 4);
        Assert.AreEqual(mySolution.BalancedStringSplit("RLRRRLLRLL"), 2);
    }

    [TestMethod]
    public void TestMostWordsFound()
    {
        SolutionString mySolution = new();
        string[] test = ["alice and bob love leetcode", "i think so too", "this is great thanks very much"];
        Assert.AreEqual(mySolution.MostWordsFound(test), 6);
        test = ["please wait", "continue to fight", "continue to win"];
        Assert.AreEqual(mySolution.MostWordsFound(test), 3);

    }

    [TestMethod]
    public void TestReversePrefix()
    {
        SolutionString mySolution = new();
        Assert.AreEqual("dcbaefd", mySolution.ReversePrefix("abcdefd", 'd'));
        Assert.AreEqual("zxyxxe", mySolution.ReversePrefix("xyxzxe", 'z'));
        Assert.AreEqual("abcd", mySolution.ReversePrefix("abcd", 'z'));
        Assert.AreEqual("j", mySolution.ReversePrefix("j", 'j'));
    }

    [TestMethod]
    public void TestTruncateSentence()
    {
        SolutionString mySolution = new();
        Assert.AreEqual(mySolution.TruncateSentence("Hello how are you Contestant", 4), "Hello how are you");
        Assert.AreEqual(mySolution.TruncateSentence("What is the solution to this problem", 4), "What is the solution");
        Assert.AreEqual(mySolution.TruncateSentence("chopper is not a tanuki", 5), "chopper is not a tanuki");
    }

    [TestMethod]
    public void TestArrayStringsAreEqual()
    {
        SolutionString mySolution = new();
        Assert.AreEqual(mySolution.ArrayStringsAreEqual(["ab", "c"], ["a", "bc"]), true);
        Assert.AreEqual(mySolution.ArrayStringsAreEqual(["a", "cb"], ["ab", "c"]), false);
        Assert.AreEqual(mySolution.ArrayStringsAreEqual(["abc", "d", "defg"], ["abcddefg"]), true);
    }

    [TestMethod]
    public void TestDecodeMessage()
    {
        SolutionString mySolution = new();
        Assert.AreEqual("this is a secret", mySolution.DecodeMessage("the quick brown fox jumps over the lazy dog", "vkbs bs t suepuv"));
        Assert.AreEqual("the five boxing wizards jump quickly", mySolution.DecodeMessage("eljuxhpwnyrdgtqkviszcfmabo", "zwx hnfx lqantp mnoeius ycgk vcnjrdb"));
    }

    [TestMethod]
    public void TestRestoreString()
    {
        SolutionString mySolution = new();
        Assert.AreEqual("leetcode", mySolution.RestoreString("codeleet", [4, 5, 6, 7, 0, 2, 1, 3]));
        Assert.AreEqual("abc", mySolution.RestoreString("abc", [0, 1, 2]));
        Assert.AreEqual("leetcode", mySolution.RestoreStringV2("codeleet", [4, 5, 6, 7, 0, 2, 1, 3]));
        Assert.AreEqual("abc", mySolution.RestoreStringV2("abc", [0, 1, 2]));
    }

    [TestMethod]
    public void TestCountMatches()
    {
        SolutionString mySolution = new();
        Assert.AreEqual(2, mySolution.CountMatches([["phone", "blue", "pixel"], ["computer", "silver", "phone"], ["phone", "gold", "iphone"]], "type", "phone"));
        Assert.AreEqual(1, mySolution.CountMatches([["phone", "blue", "pixel"], ["computer", "silver", "lenovo"], ["phone", "gold", "iphone"]], "color", "silver"));
    }

    [TestMethod]
    public void TestRemoveOuterParentheses()
    {
        SolutionString mySolution = new();
        Assert.AreEqual("()()()", mySolution.RemoveOuterParentheses("(()())(())"));
        Assert.AreEqual("()()()()(())", mySolution.RemoveOuterParentheses("(()())(())(()(()))"));
        Assert.AreEqual("", mySolution.RemoveOuterParentheses("()()"));
    }

    [TestMethod]
    public void TestPrefixCount()
    {
        SolutionString mySolution = new();
        Assert.AreEqual(2, mySolution.PrefixCount(["pay", "attention", "practice", "attend"], "at"));
        Assert.AreEqual(0, mySolution.PrefixCount(["leetcode", "win", "loops", "success"], "code"));
    }

    [TestMethod]
    public void TestMaxDepth()
    {
        SolutionString mySolution = new();
        Assert.AreEqual(3, mySolution.MaxDepth("(1+(2*3)+((8)/4))+1"));
        Assert.AreEqual(3, mySolution.MaxDepth("(1)+((2))+(((3)))"));
        Assert.AreEqual(3, mySolution.MaxDepth("()(())((()()))"));

    }

    [TestMethod]
    public void TestFirstPalindrome()
    {
        SolutionString mySolution = new();
        Assert.AreEqual("ada", mySolution.FirstPalindrome(["abc", "car", "ada", "racecar", "cool"]));
        Assert.AreEqual("racecar", mySolution.FirstPalindrome(["notapalindrome", "racecar"]));
        Assert.AreEqual("", mySolution.FirstPalindrome(["def", "ghi"]));
        Assert.AreEqual("e", mySolution.FirstPalindrome(["xngla", "e", "itrn", "y", "s", "pfp", "rfd"]));
    }

    [TestMethod]
    public void TestReverseWords()
    {
        SolutionString mySolution = new();
        Assert.AreEqual("s'teL ekat edoCteeL tsetnoc", mySolution.ReverseWords("Let's take LeetCode contest"));
        Assert.AreEqual("rM gniD", mySolution.ReverseWords("Mr Ding"));
    }

    [TestMethod]
    public void TestCountSeniors()
    {
        SolutionString mySolution = new();
        Assert.AreEqual(2, mySolution.CountSeniors(["7868190130M7522", "5303914400F9211", "9273338290F4010"]));
        Assert.AreEqual(0, mySolution.CountSeniors(["1313579440F2036", "2921522980M5644"]));
    }

    [TestMethod]
    public void TestMaximumOddBinaryNumber()
    {
        SolutionString sol = new();
        Assert.AreEqual("001", sol.MaximumOddBinaryNumber("010"));
        Assert.AreEqual("1001", sol.MaximumOddBinaryNumber("0101"));
    }

    [TestMethod]
    public void TestCellsInRange()
    {
        SolutionString solutionString = new();
        List<string> strings = ["K1", "K2", "L1", "L2"];
        CollectionAssert.AreEqual(strings, (List<string>)solutionString.CellsInRange("K1:L2"));
        strings = ["A1", "B1", "C1", "D1", "E1", "F1"];
        CollectionAssert.AreEqual(strings, (List<string>)solutionString.CellsInRange("A1:F1"));
    }

    [TestMethod]
    public void TestSortSentence()
    {
        SolutionString solutionString = new();
        Assert.AreEqual("This is a sentence", solutionString.SortSentence("is2 sentence4 This1 a3"));
    }

    [TestMethod]
    public void TestClearDigits()
    {
        SolutionString solutionString = new();
        Assert.AreEqual("abc", solutionString.ClearDigits("abc"));
        Assert.AreEqual("", solutionString.ClearDigits("cb34"));
    }

    [TestMethod]
    public void TestReplaceDigits()
    {
        SolutionString solutionString = new();
        Assert.AreEqual("abcdef", solutionString.ReplaceDigits("a1c1e1"));
        Assert.AreEqual("abbdcfdhe", solutionString.ReplaceDigits("a1b2c3d4e"));
    }

    [TestMethod]
    public void TestMergeAlternately()
    {
        SolutionString solutionString = new();
        Assert.AreEqual("apbqrs", solutionString.MergeAlternately("ab", "pqrs"));
        Assert.AreEqual("apbqcd", solutionString.MergeAlternately("abcd", "pq"));
    }
}
