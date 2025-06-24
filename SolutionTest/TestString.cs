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
}
