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

    [TestMethod]
    public void TestGetFinalState()
    {
        SolutionMath mySolution = new();
        int[] expected = [8, 4, 6, 5, 6];
        CollectionAssert.AreEqual(expected, mySolution.GetFinalState([2, 1, 3, 5, 6], 5, 2));
        expected = [16, 8];
        CollectionAssert.AreEqual(expected, mySolution.GetFinalState([1, 2], 3, 4));
    }

    [TestMethod]
    public void TestMinOperations()
    {
        SolutionMath mySolution = new();
        Assert.IsTrue(mySolution.MinOperations([3, 9, 7], 5) == 4);
        Assert.IsTrue(mySolution.MinOperations([4, 1, 3], 4) == 0);
        Assert.IsTrue(mySolution.MinOperations([3, 2], 6) == 5);
    }

    [TestMethod]
    public void TestSubtractProductAndSum()
    {
        SolutionMath mySolution = new();
        Assert.AreEqual(15, mySolution.SubtractProductAndSum(234));
        Assert.AreEqual(21, mySolution.SubtractProductAndSum(4421));
    }
}
