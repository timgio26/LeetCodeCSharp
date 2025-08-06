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

    [TestMethod]
    public void TestMinTimeToVisitAllPoints()
    {
        SolutionMath mySolution = new();
        Assert.AreEqual(7, mySolution.MinTimeToVisitAllPoints([[1, 1], [3, 4], [-1, 0]]));
        Assert.AreEqual(5, mySolution.MinTimeToVisitAllPoints([[3, 2], [-2, 2]]));
        int[][] testArr = [[450, 203], [105, 634], [655, 271], [-491, 559], [114, -635], [807, 643], [-208, -516], [-251, 952], [143, 93], [-355, 596], [-172, -771], [854, -659], [283, 827], [627, 211], [-308, -592], [-426, -996], [11, 838], [129, -629], [-157, -560], [-503, -125], [75, -104], [-606, -437], [594, 405], [-984, 288], [-281, -607], [-252, -936], [-988, -417], [61, 163], [-597, -189], [-50, -88], [-288, 611], [785, 227], [-470, 518], [-638, 528], [667, -526], [-704, 782], [-237, 605], [-686, 150], [11, 472], [-908, -262], [-108, 23], [-646, 807], [-424, -349], [51, -448], [518, -504], [194, -525], [205, 823], [350, 487], [-181, -399], [433, 126], [436, 244], [593, 646], [783, 365], [-797, 912], [-285, 587], [233, 596], [-496, -975], [-955, 996], [-339, 195], [-652, -408], [499, 399], [-990, -747], [825, 407], [-551, -879], [-792, 809], [-289, 895], [215, -621], [-433, -224], [-931, 69], [76, -279], [106, -50], [-454, -692], [-69, -653], [547, 383], [39, -101], [376, -782], [-352, -777], [611, 998], [-669, -557], [378, -959], [373, -401], [-230, -960], [-468, -691], [943, -548], [28, 200], [-900, 554], [-86, 982], [-194, -306], [578, 915], [-60, 798], [-96, 973], [-517, 520]];
        Assert.AreEqual(80201, mySolution.MinTimeToVisitAllPoints(testArr));
    }

    [TestMethod]
    public void TestProjectionArea()
    {
        SolutionMath mySolution = new();
        Assert.AreEqual(17, mySolution.ProjectionArea([[1, 2], [3, 4]]));
        Assert.AreEqual(5, mySolution.ProjectionArea([[2]]));
        Assert.AreEqual(8, mySolution.ProjectionArea([[1, 0], [0, 2]]));
    }

    [TestMethod]
    public void TestMaximum69Number()
    {
        SolutionMath mySolution = new();
        Assert.AreEqual(9969, mySolution.Maximum69Number(9669));
        Assert.AreEqual(9999, mySolution.Maximum69Number(9996));
        Assert.AreEqual(9999, mySolution.Maximum69Number(9999));
    }

    [TestMethod]
    public void TestSumOddLengthSubarrays()
    {
        SolutionMath mySolution = new();
        Assert.AreEqual(3, mySolution.SumOddLengthSubarrays([1, 2]));
        Assert.AreEqual(58, mySolution.SumOddLengthSubarrays([1, 4, 2, 5, 3]));
        Assert.AreEqual(66, mySolution.SumOddLengthSubarrays([10, 11, 12]));
    }

    [TestMethod]
    public void TestCountDigits()
    {
        SolutionMath solution = new SolutionMath();
        Assert.AreEqual(1, solution.CountDigits(7));
        Assert.AreEqual(2, solution.CountDigits(121));
        Assert.AreEqual(4, solution.CountDigits(1248));
    }

    [TestMethod]
    public void TestSumOfMultiples()
    {
        SolutionMath solution = new SolutionMath();
        Assert.AreEqual(21, solution.SumOfMultiples(7));
        Assert.AreEqual(40, solution.SumOfMultiples(10));
        Assert.AreEqual(30, solution.SumOfMultiples(9));
    }

    [TestMethod]
    public void TestNumberOfSteps()
    {
        SolutionMath solution = new SolutionMath();
        Assert.AreEqual(6, solution.NumberOfSteps(14));
        Assert.AreEqual(4, solution.NumberOfSteps(8));
        Assert.AreEqual(12, solution.NumberOfSteps(123));
    }

    [TestMethod]
    public void TestCountOperations()
    {
        SolutionMath solution = new SolutionMath();
        Assert.AreEqual(3, solution.CountOperations(2, 3));
        Assert.AreEqual(1, solution.CountOperations(10, 10));
    }

    [TestMethod]
    public void TestOddCells()
    {
        SolutionMath solutionMath = new SolutionMath();
        Assert.AreEqual(6, solutionMath.OddCells(2, 3, [[0, 1], [1, 1]]));
        Assert.AreEqual(0, solutionMath.OddCells(2, 2, [[1, 1], [0, 0]]));
    }

    [TestMethod]
    public void TestFindCdg()
    {
        SolutionMath solutionMath = new SolutionMath();
        Assert.AreEqual(2, solutionMath.FindGCD([2, 5, 6, 9, 10]));
        Assert.AreEqual(1, solutionMath.FindGCD([7, 5, 6, 8, 3]));
        Assert.AreEqual(3, solutionMath.FindGCD([3,3]));
    }
}
