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
}
