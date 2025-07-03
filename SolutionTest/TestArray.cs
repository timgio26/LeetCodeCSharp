using LeetCode.src;

namespace SolutionTest;

[TestClass]
public sealed class TestArray
{
    [TestMethod]
    public void TestTwoSum()
    {
        //arrange
        // int[] nums = [2, 7, 11, 15];
        // int target = 9;
        var mySolution = new Solution();

        int[] expected = [0, 1];
        CollectionAssert.AreEqual(mySolution.TwoSum([2, 7, 11, 15], 9), expected);

        expected = [1, 2];
        CollectionAssert.AreEqual(mySolution.TwoSum([3, 2, 4], 6), expected);

        expected = [0, 1];
        CollectionAssert.AreEqual(mySolution.TwoSum([3, 3], 6), expected);

    }

    [TestMethod]
    public void TestTwoSumV2()
    {
        //arrange
        // int[] nums = [2, 7, 11, 15];
        // int target = 9;
        var mySolution = new Solution();

        int[] expected = [0, 1];
        CollectionAssert.AreEqual(mySolution.TwoSumV2([2, 7, 11, 15], 9), expected);

        expected = [1, 2];
        CollectionAssert.AreEqual(mySolution.TwoSumV2([3, 2, 4], 6), expected);

        expected = [0, 1];
        CollectionAssert.AreEqual(mySolution.TwoSumV2([3, 3], 6), expected);

        expected = [0, 3];
        CollectionAssert.AreEqual(mySolution.TwoSumV2([0, 4, 3, 0], 0), expected);

    }

    [TestMethod]
    public void TestSortedSquares()
    {
        var mySolution = new Solution();

        int[] expected = [0, 1, 9, 16, 100];
        CollectionAssert.AreEqual(mySolution.SortedSquares([-4, -1, 0, 3, 10]), expected);
        CollectionAssert.AreEqual(mySolution.SortedSquaresV2([-4, -1, 0, 3, 10]), expected);
        expected = [4, 9, 9, 49, 121];
        CollectionAssert.AreEqual(mySolution.SortedSquares([-7, -3, 2, 3, 11]), expected);
        CollectionAssert.AreEqual(mySolution.SortedSquaresV2([-7, -3, 2, 3, 11]), expected);
    }

    [TestMethod]
    public void TestBuildArray()
    {

        Solution mySolution = new Solution();

        int[] expected = [0, 1, 2, 4, 5, 3];
        CollectionAssert.AreEqual(mySolution.BuildArray([0, 2, 1, 5, 3, 4]), expected);

        expected = [4, 5, 0, 1, 2, 3];
        CollectionAssert.AreEqual(mySolution.BuildArray([5, 0, 1, 2, 3, 4]), expected);

    }

    [TestMethod]
    public void TestFindWordsContaining()
    {
        Solution mySolution = new Solution();

        List<int> expected = [0, 1];
        CollectionAssert.AreEqual(expected, (List<int>)mySolution.FindWordsContaining(["leet", "code"], 'e'));

        expected = [0, 2];
        CollectionAssert.AreEqual(expected, (List<int>)mySolution.FindWordsContaining(["abc", "bcd", "aaaa", "cbc"], 'a'));

        expected = [];
        CollectionAssert.AreEqual(expected, (List<int>)mySolution.FindWordsContaining(["abc", "bcd", "aaaa", "cbc"], 'z'));
    }

    [TestMethod]
    public void TestGetConcatenation()
    {
        Solution mySolution = new();
        int[] expected = [1, 2, 1, 1, 2, 1];
        CollectionAssert.AreEqual(mySolution.GetConcatenation([1, 2, 1]), expected);

        expected = [1, 3, 2, 1, 1, 3, 2, 1];
        CollectionAssert.AreEqual(mySolution.GetConcatenation([1, 3, 2, 1]), expected);
    }
    [TestMethod]
    public void TestNumIdenticalPairs()
    {
        Solution mySolution = new();
        Assert.AreEqual(mySolution.NumIdenticalPairs([1, 2, 3, 1, 1, 3]), 4);
        Assert.AreEqual(mySolution.NumIdenticalPairs([1, 1, 1, 1]), 6);
        Assert.AreEqual(mySolution.NumIdenticalPairs([1, 2, 3]), 0);
    }

    [TestMethod]
    public void TestTransformArray()
    {
        Solution mySolution = new();
        int[] expected = [0, 0, 1, 1];
        CollectionAssert.AreEqual(mySolution.TransformArray([4, 3, 2, 1]), expected);

        expected = [0, 0, 1, 1, 1];
        CollectionAssert.AreEqual(mySolution.TransformArray([1, 5, 1, 4, 2]), expected);
    }

    [TestMethod]
    public void TestFinalValueAfterOperations()
    {
        Solution mySolution = new();
        Assert.AreEqual(mySolution.FinalValueAfterOperations(["--X", "X++", "X++"]), 1);
        Assert.AreEqual(mySolution.FinalValueAfterOperations(["++X", "++X", "X++"]), 3);
        Assert.AreEqual(mySolution.FinalValueAfterOperations(["X++", "++X", "--X", "X--"]), 0);
    }

    [TestMethod]
    public void TestShuffle()
    {
        Solution mySolution = new();
        int[] expected = [2, 3, 5, 4, 1, 7];
        CollectionAssert.AreEqual(mySolution.Shuffle([2, 5, 1, 3, 4, 7], 3), expected);

        expected = [1, 4, 2, 3, 3, 2, 4, 1];
        CollectionAssert.AreEqual(mySolution.Shuffle([1, 2, 3, 4, 4, 3, 2, 1], 4), expected);

        expected = [1, 2, 1, 2];
        CollectionAssert.AreEqual(mySolution.Shuffle([1, 1, 2, 2], 2), expected);
    }

    [TestMethod]
    public void TestCanBeIncreasing()
    {
        Solution mySolution = new();
        Assert.IsTrue(mySolution.CanBeIncreasing([1, 2, 10, 5, 7]));
        Assert.IsFalse(mySolution.CanBeIncreasing([2, 3, 1, 2]));
        Assert.IsFalse(mySolution.CanBeIncreasing([1, 1, 1]));
        Assert.IsTrue(mySolution.CanBeIncreasing([1, 1]));
        Assert.IsFalse(mySolution.CanBeIncreasing([1, 4, 1, 2, 3]));
    }

    [TestMethod]
    public void TestMinimumOperations()
    {
        Solution mySolution = new();
        Assert.AreEqual(mySolution.MinimumOperations([1, 2, 3, 4]), 3);
        Assert.AreEqual(mySolution.MinimumOperations([3, 6, 9]), 0);
    }

    [TestMethod]
    public void TestMaximumWealth()
    {
        Solution mySolution = new();
        Assert.AreEqual(mySolution.MaximumWealth([[1, 2, 3], [3, 2, 1]]), 6);
        Assert.AreEqual(mySolution.MaximumWealth([[1, 5], [7, 3], [3, 5]]), 10);
        Assert.AreEqual(mySolution.MaximumWealth([[2, 8, 7], [7, 1, 3], [1, 9, 5]]), 17);

        int[][] accounts = [[76, 6, 55, 11, 30, 65, 33, 74, 14, 16, 57, 79, 17, 87, 36, 61, 6], [10, 18, 5, 55, 94, 28, 8, 36, 73, 62, 23, 62, 20, 70, 91, 7, 10], [73, 52, 73, 50, 5, 13, 45, 52, 46, 66, 68, 31, 89, 38, 23, 70, 90], [53, 46, 30, 37, 72, 8, 71, 51, 40, 29, 73, 96, 63, 87, 63, 73, 61], [19, 42, 55, 82, 58, 24, 9, 39, 49, 4, 78, 87, 76, 22, 14, 5, 90], [94, 61, 54, 11, 53, 13, 62, 36, 87, 51, 59, 71, 14, 42, 10, 36, 75], [96, 96, 16, 75, 27, 16, 56, 48, 90, 38, 40, 7, 65, 20, 98, 54, 84], [13, 2, 3, 62, 89, 28, 68, 3, 36, 85, 59, 71, 61, 32, 44, 65, 33], [43, 29, 78, 49, 59, 18, 30, 39, 43, 43, 36, 33, 20, 20, 2, 23, 39], [72, 52, 52, 7, 89, 78, 18, 1, 7, 20, 24, 88, 15, 36, 34, 25, 32], [78, 91, 59, 10, 97, 39, 93, 76, 11, 22, 81, 59, 50, 100, 77, 61, 6], [67, 24, 53, 76, 81, 45, 38, 90, 52, 5, 91, 63, 66, 37, 59, 100, 20], [39, 56, 10, 80, 100, 89, 49, 75, 49, 4, 17, 7, 69, 48, 25, 53, 18], [91, 78, 84, 98, 31, 47, 97, 79, 1, 33, 68, 52, 30, 1, 2, 95, 47], [95, 62, 46, 59, 11, 57, 26, 2, 64, 27, 25, 45, 97, 43, 31, 40, 89], [59, 35, 65, 46, 50, 44, 60, 23, 99, 80, 47, 57, 44, 89, 69, 99, 48], [60, 72, 57, 2, 66, 25, 64, 37, 31, 78, 23, 75, 18, 19, 92, 91, 86], [58, 42, 94, 94, 24, 17, 17, 34, 97, 90, 25, 100, 46, 44, 74, 29, 77], [49, 62, 43, 14, 96, 38, 27, 93, 52, 92, 81, 62, 38, 89, 71, 30, 77], [1, 97, 54, 83, 95, 63, 22, 37, 36, 96, 4, 95, 12, 70, 93, 84, 40], [75, 32, 21, 19, 5, 51, 70, 69, 10, 34, 29, 23, 53, 85, 96, 71, 30], [88, 79, 42, 51, 40, 24, 7, 38, 56, 26, 82, 100, 19, 16, 92, 75, 100], [56, 14, 70, 31, 60, 45, 29, 71, 43, 8, 14, 1, 51, 63, 28, 99, 11], [56, 63, 54, 56, 50, 34, 99, 99, 11, 97, 15, 20, 62, 76, 45, 98, 60], [45, 37, 22, 71, 57, 40, 95, 52, 91, 78, 57, 99, 79, 45, 100, 79, 10], [74, 96, 40, 94, 75, 12, 74, 73, 18, 51, 73, 62, 69, 50, 63, 47, 91], [38, 60, 1, 74, 95, 28, 93, 100, 57, 66, 47, 55, 2, 89, 90, 80, 88], [9, 13, 73, 47, 78, 79, 46, 82, 7, 16, 36, 15, 87, 66, 3, 59, 55], [20, 66, 23, 18, 41, 13, 75, 70, 7, 3, 97, 74, 52, 60, 79, 79, 94], [50, 4, 65, 88, 30, 92, 72, 39, 22, 34, 7, 61, 45, 58, 32, 14, 73], [48, 61, 29, 70, 67, 21, 19, 72, 41, 14, 73, 26, 63, 73, 72, 13, 16], [79, 14, 31, 84, 20, 67, 41, 74, 87, 53, 52, 6, 14, 77, 33, 39, 18], [50, 70, 48, 65, 63, 20, 76, 80, 49, 76, 43, 41, 51, 33, 68, 78, 61], [97, 62, 37, 13, 31, 84, 89, 92, 33, 35, 95, 9, 77, 22, 29, 57, 71], [89, 16, 24, 84, 36, 59, 33, 100, 55, 48, 47, 45, 59, 11, 20, 67, 69], [65, 58, 96, 19, 9, 84, 92, 55, 69, 61, 80, 59, 78, 76, 19, 29, 61], [84, 66, 72, 59, 55, 71, 77, 23, 55, 63, 87, 57, 36, 72, 12, 58, 91]];
        Assert.AreEqual(mySolution.MaximumWealth(accounts), 1063);

    }

    [TestMethod]
    public void TestGetSneakyNumbers()
    {
        Solution mySolution = new Solution();
        int[] expected = [0, 1];
        CollectionAssert.AreEquivalent(mySolution.GetSneakyNumbers([0, 1, 1, 0]), expected);

        expected = [2, 3];
        CollectionAssert.AreEquivalent(mySolution.GetSneakyNumbers([0, 3, 2, 1, 3, 2]), expected);

        expected = [4, 5];
        CollectionAssert.AreEquivalent(mySolution.GetSneakyNumbers([7, 1, 5, 4, 3, 4, 6, 0, 9, 5, 8, 2]), expected);

    }

    [TestMethod]
    public void TestCountConsistentStrings()
    {
        Solution mySolution = new Solution();
        Assert.AreEqual(mySolution.CountConsistentStrings("ab", ["ad", "bd", "aaab", "baa", "badab"]), 2);
        Assert.AreEqual(mySolution.CountConsistentStrings("abc", ["a", "b", "c", "ab", "ac", "bc", "abc"]), 7);
        Assert.AreEqual(mySolution.CountConsistentStrings("cad", ["cc", "acd", "b", "ba", "bac", "bad", "ac", "d"]), 4);

        Assert.AreEqual(mySolution.CountConsistentStringsV2("ab", ["ad", "bd", "aaab", "baa", "badab"]), 2);
        Assert.AreEqual(mySolution.CountConsistentStringsV2("abc", ["a", "b", "c", "ab", "ac", "bc", "abc"]), 7);
        Assert.AreEqual(mySolution.CountConsistentStringsV2("cad", ["cc", "acd", "b", "ba", "bac", "bad", "ac", "d"]), 4);
    }

    [TestMethod]
    public void TestKidsWithCandies()
    {
        Solution mySolution = new Solution();
        List<bool> expected = [true, true, true, false, true];
        CollectionAssert.AreEqual((List<bool>)mySolution.KidsWithCandies([2, 3, 5, 1, 3], 3), expected);
        expected = [true, false, false, false, false];
        CollectionAssert.AreEqual((List<bool>)mySolution.KidsWithCandies([4, 2, 1, 1, 2], 1), expected);
        expected = [true, false, true];
        CollectionAssert.AreEqual((List<bool>)mySolution.KidsWithCandies([12, 1, 12], 10), expected);
    }

    [TestMethod]
    public void TestLargestLocal()
    {
        Solution mySolution = new Solution();
        int[][] expected = [[9, 9], [8, 6]];
        CollectionAssert.AreEqual(expected, mySolution.LargestLocal([[9, 9, 8, 1], [5, 6, 2, 6], [8, 2, 6, 4], [6, 2, 2, 2]]));
        expected = [[2, 2, 2], [2, 2, 2], [2, 2, 2]];
        CollectionAssert.AreEqual(expected, mySolution.LargestLocal([[1, 1, 1, 1, 1], [1, 1, 1, 1, 1], [1, 1, 2, 1, 1], [1, 1, 1, 1, 1], [1, 1, 1, 1, 1]]));
        // expected = [[5]];
        // CollectionAssert.AreEqual(expected, mySolution.LargestLocal([[2,5,5],[3,2,5],[1,2,3]]));
    }

    [TestMethod]
    public void TestDiagonalSum()
    {
        Solution mySolution = new Solution();
        Assert.AreEqual(25, mySolution.DiagonalSum([[1,2,3],
              [4,5,6],
              [7,8,9]]));
        Assert.AreEqual(8, mySolution.DiagonalSum([[1,1,1,1],
              [1,1,1,1],
              [1,1,1,1],
              [1,1,1,1]]));
        Assert.AreEqual(5, mySolution.DiagonalSum([[5]]));
    }

    [TestMethod]
    public void TestFindMissingAndRepeatedValues()
    {
        Solution mySolution = new Solution();
        int[] expected = [2, 4];
        CollectionAssert.AreEqual(expected, mySolution.FindMissingAndRepeatedValues([[1, 3], [2, 2]]));
        expected = [9, 5];
        CollectionAssert.AreEqual(expected, mySolution.FindMissingAndRepeatedValues([[9, 1, 7], [8, 9, 2], [3, 4, 6]]));
    }

    [TestMethod]
    public void TestSortPeople()
    {
        Solution mySolution = new Solution();
        string[] expected = ["Mary", "Emma", "John"];
        CollectionAssert.AreEqual(expected, mySolution.SortPeople(["Mary", "John", "Emma"], [180, 165, 170]));
        expected = ["Bob", "Alice", "Bob"];
        CollectionAssert.AreEqual(expected, mySolution.SortPeople(["Alice", "Bob", "Bob"], [155, 185, 150]));
    }

    [TestMethod]
    public void TestArithmeticTriplets()
    {
        Solution mySolution = new Solution();
        Assert.AreEqual(2, mySolution.ArithmeticTriplets([0, 1, 4, 6, 7, 10], 3));
        Assert.AreEqual(2, mySolution.ArithmeticTriplets([4, 5, 6, 7, 8, 9], 2));
    }

    [TestMethod]
    public void TestNumberOfEmployeesWhoMetTarget()
    {
        Solution mySolution = new Solution();
        Assert.AreEqual(3, mySolution.NumberOfEmployeesWhoMetTarget([0, 1, 2, 3, 4], 2));
        Assert.AreEqual(0, mySolution.NumberOfEmployeesWhoMetTarget([5, 1, 4, 2, 2], 6));
    }

    [TestMethod]
    public void TestCountPairs()
    {
        Solution mySolution = new Solution();
        Assert.AreEqual(3, mySolution.CountPairs([-1, 1, 2, 3, 1], 2));
        Assert.AreEqual(10, mySolution.CountPairs([-6, 2, 5, -2, -7, -1, 3], -2));
    }

    [TestMethod]

    public void TestLeftRightDifference()
    {
        Solution mySolution = new Solution();
        int[] expected = [15, 1, 11, 22];
        CollectionAssert.AreEqual(expected, mySolution.LeftRightDifference([10, 4, 8, 3]));
        expected = [0];
        CollectionAssert.AreEqual(expected, mySolution.LeftRightDifference([1]));
    }

    [TestMethod]
    public void TestSmallerNumbersThanCurrent()
    {
        Solution mySolution = new Solution();
        int[] expected = [4, 0, 1, 1, 3];
        CollectionAssert.AreEqual(expected, mySolution.SmallerNumbersThanCurrent([8, 1, 2, 2, 3]));
        expected = [2, 1, 0, 3];
        CollectionAssert.AreEqual(expected, mySolution.SmallerNumbersThanCurrent([6, 5, 4, 8]));
        expected = [0, 0, 0, 0];
        CollectionAssert.AreEqual(expected, mySolution.SmallerNumbersThanCurrent([7, 7, 7, 7]));
    }

    [TestMethod]
    public void TestMinMovesToSeat()
    {
        Solution mySolution = new Solution();
        Assert.AreEqual(4, mySolution.MinMovesToSeat([3, 1, 5], [2, 7, 4]));
        Assert.AreEqual(7, mySolution.MinMovesToSeat([4, 1, 5, 9], [1, 3, 2, 6]));
        Assert.AreEqual(4, mySolution.MinMovesToSeat([2, 2, 6, 6], [1, 3, 2, 6]));
    }

    [TestMethod]
    public void TestMinOperations()
    {
        Solution mySolution = new Solution();
        int[] expect = [1, 1, 3];
        CollectionAssert.AreEqual(expect, mySolution.MinOperations("110"));
        expect = [11, 8, 5, 4, 3, 4];
        CollectionAssert.AreEqual(expect, mySolution.MinOperations("001011"));
    }

    [TestMethod]
    public void TestMaxWidthOfVerticalArea()
    {
        Solution mySolution = new Solution();
        Assert.AreEqual(1, mySolution.MaxWidthOfVerticalArea([[8, 7], [9, 9], [7, 4], [9, 7]]));
        Assert.AreEqual(3, mySolution.MaxWidthOfVerticalArea([[3, 1], [9, 0], [1, 0], [1, 4], [5, 3], [8, 8]]));
    }

    [TestMethod]
    public void TestMinimumAverage()
    {
        Solution mySolution = new Solution();
        Assert.AreEqual(5.5, mySolution.MinimumAverage([7, 8, 3, 4, 15, 13, 4, 1]));
        Assert.AreEqual(5.5, mySolution.MinimumAverage([1, 9, 8, 3, 10, 5]));
        Assert.AreEqual(5.0, mySolution.MinimumAverage([1, 2, 3, 7, 8, 9]));
    }

    [TestMethod]
    public void TestRunningSum()
    {
        Solution mySolution = new();
        int[] expected = [1, 3, 6, 10];
        CollectionAssert.AreEqual(expected, mySolution.RunningSum([1, 2, 3, 4]));
        expected = [1, 2, 3, 4, 5];
        CollectionAssert.AreEqual(expected, mySolution.RunningSum([1, 1, 1, 1, 1]));
    }

    [TestMethod]
    public void TestStableMountains()
    {
        Solution mySolution = new();
        List<int> expected = [3, 4];
        CollectionAssert.AreEqual(expected, (List<int>)mySolution.StableMountains([1, 2, 3, 4, 5], 2));
        expected = [1, 3];
        CollectionAssert.AreEqual(expected, (List<int>)mySolution.StableMountains([10, 1, 10, 1, 10], 3));
        expected = [];
        CollectionAssert.AreEqual(expected, (List<int>)mySolution.StableMountains([10, 1, 10, 1, 10], 10));
    }

    [TestMethod]
    public void TestCountPairs2176()
    {
        Solution mySolution = new();
        Assert.AreEqual(4, mySolution.CountPairs2176([3, 1, 2, 2, 2, 1, 3], 2));
        Assert.AreEqual(0, mySolution.CountPairs2176([1, 2, 3, 4], 1));
    }

    [TestMethod]
    public void TestSubarraySum()
    {
        Solution mySolution = new();
        Assert.AreEqual(11, mySolution.SubarraySum([2, 3, 1]));
        Assert.AreEqual(13, mySolution.SubarraySum([3, 1, 1, 2]));
    }

    [TestMethod]
    public void TestMinCosts()
    {
        Solution mySolution = new();
        int[] expected = [5, 3, 3, 1, 1, 1];
        CollectionAssert.AreEqual(expected, mySolution.MinCosts([5, 3, 4, 1, 3, 2]));
        expected = [1, 1, 1, 1, 1];
        CollectionAssert.AreEqual(expected, mySolution.MinCosts([1, 2, 4, 6, 7]));

    }

    [TestMethod]
    public void TestLuckyNumbers()
    {
        Solution mySolution = new();
        int[] expected = [15];
        CollectionAssert.AreEqual(expected, (List<int>)mySolution.LuckyNumbers([[3, 7, 8], [9, 11, 13], [15, 16, 17]]));
        expected = [12];
        CollectionAssert.AreEqual(expected, (List<int>)mySolution.LuckyNumbers([[1, 10, 4, 2], [9, 3, 8, 7], [15, 16, 17, 12]]));
        expected = [7];
        CollectionAssert.AreEqual(expected, (List<int>)mySolution.LuckyNumbers([[7, 8], [1, 2]]));
    }

    [TestMethod]
    public void TestMinOperations1827()
    {
        Solution mySolution = new();
        Assert.AreEqual(3, mySolution.MinOperations1827([1, 1, 1]));
        Assert.AreEqual(14, mySolution.MinOperations1827([1, 5, 2, 4, 1]));
        Assert.AreEqual(0, mySolution.MinOperations1827([8]));
    }

    [TestMethod]
    public void TestNumberGame()
    {
        Solution mySolution = new();
        int[] expect = [3, 2, 5, 4];
        CollectionAssert.AreEqual(expect, mySolution.NumberGame([5, 4, 2, 3]));
        expect = [5, 2];
        CollectionAssert.AreEqual(expect, mySolution.NumberGame([2, 5]));
    }

    [TestMethod]
    public void TestLargestAltitude()
    {
        Solution mySolution = new();
        Assert.AreEqual(1, mySolution.LargestAltitude([-5, 1, 5, 0, -7]));
        Assert.AreEqual(0, mySolution.LargestAltitude([-4, -3, -2, -1, 4, 3, 2]));
    }

    [TestMethod]
    public void TestCountNegatives()
    {
        Solution mySolution = new();
        Assert.AreEqual(8, mySolution.CountNegatives([[4, 3, 2, -1], [3, 2, 1, -1], [1, 1, -1, -2], [-1, -1, -2, -3]]));
        Assert.AreEqual(0, mySolution.CountNegatives([[3,2],[1,0]]));
    }
}
