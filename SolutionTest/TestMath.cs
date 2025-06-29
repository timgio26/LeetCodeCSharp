using LeetCode.src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Company.TestProject1;

[TestClass]
public class TestMath
{
    [TestMethod]
    public void TestDifferenceOfSums()
    {
        SolutionMath mySolution = new();
        Assert.AreEqual(mySolution.DifferenceOfSums(10, 3), 19);
        Assert.AreEqual(mySolution.DifferenceOfSums(5, 6), 15);
        Assert.AreEqual(mySolution.DifferenceOfSums(5, 1), -15);
    }

    [TestMethod]
    public void TestMinimumSum()
    {
        SolutionMath mySolution = new();
        Assert.AreEqual(52, mySolution.MinimumSum(2932));
        Assert.AreEqual(13, mySolution.MinimumSum(4009));
    }
}
