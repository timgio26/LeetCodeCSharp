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
}
