using LeetCode.src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Company.TestProject1;

[TestClass]
public class TestHashTable
{
    [TestMethod]
    public void TestFindIntersectionValues()
    {
        SolutionHashTable mySol = new();
        int[] expect = [2, 1];
        CollectionAssert.AreEqual(expect, mySol.FindIntersectionValues([2, 3, 2], [1, 2]));

        expect = [3, 4];
        CollectionAssert.AreEqual(expect, mySol.FindIntersectionValues([4, 3, 2, 3, 1], [2, 2, 5, 2, 3, 6]));

        expect = [0, 0];
        CollectionAssert.AreEqual(expect, mySol.FindIntersectionValues([3, 4, 2, 3], [1, 5]));
    }

    [TestMethod]
    public void TestNumberOfPairs()
    {
        SolutionHashTable mySol = new();
        Assert.AreEqual(5, mySol.NumberOfPairs([1, 3, 4], [1, 3, 4], 1));
        Assert.AreEqual(2, mySol.NumberOfPairs([1, 2, 4, 12], [2, 4], 3));
    }

    [TestMethod]
    public void TestMaximumNumberOfStringPairs()
    {
        SolutionHashTable mySol = new();
        Assert.AreEqual(2, mySol.MaximumNumberOfStringPairs(["cd", "ac", "dc", "ca", "zz"]));
        Assert.AreEqual(1, mySol.MaximumNumberOfStringPairs(["ab", "ba", "cc"]));
        Assert.AreEqual(0, mySol.MaximumNumberOfStringPairs(["aa", "ab"]));
    }

    [TestMethod]
    public void TestTwoOutOfThree()
    {
        SolutionHashTable mySol = new();
        int[] expected = [3, 2];
        CollectionAssert.AreEquivalent(expected, (List<int>)mySol.TwoOutOfThree([1, 1, 3, 2], [2, 3], [3]));
        expected = [2, 3, 1];
        CollectionAssert.AreEquivalent(expected, (List<int>)mySol.TwoOutOfThree([3, 1], [2, 3], [1, 2]));
        expected = [];
        CollectionAssert.AreEquivalent(expected, (List<int>)mySol.TwoOutOfThree([1, 2, 2], [4, 3, 3], [5]));
    }

    [TestMethod]
    public void TestFrequencySort()
    {
        SolutionHashTable mySol = new();
        int[] expected = [3, 1, 1, 2, 2, 2];
        CollectionAssert.AreEqual(expected, mySol.FrequencySort([1, 1, 2, 2, 2, 3]));
        expected = [1, 3, 3, 2, 2];
        CollectionAssert.AreEqual(expected, mySol.FrequencySort([2, 3, 1, 3, 2]));
        expected = [5, -1, 4, 4, -6, -6, 1, 1, 1];
        CollectionAssert.AreEqual(expected, mySol.FrequencySort([-1, 1, -6, 4, 5, -6, 1, 4, 1]));
    }

    [TestMethod]
    public void TestKthDistinct()
    {
        SolutionHashTable mySol = new();
        Assert.AreEqual("a", mySol.KthDistinct(["d", "b", "c", "b", "c", "a"], 2));
        Assert.AreEqual("aaa", mySol.KthDistinct(["aaa", "aa", "a"], 1));
        Assert.AreEqual("", mySol.KthDistinct(["a", "b", "a"], 3));
    }

    [TestMethod]
    public void TestMaxFrequencyElements()
    {
        SolutionHashTable mySol = new();
        Assert.AreEqual(4, mySol.MaxFrequencyElements([1, 2, 2, 3, 1, 4]));
        Assert.AreEqual(5, mySol.MaxFrequencyElements([1, 2, 3, 4, 5]));

    }

    [TestMethod]
    public void TestUniqueMorseRepresentations()
    {
        SolutionHashTable mySol = new();
        Assert.AreEqual(2, mySol.UniqueMorseRepresentations(["gin", "zen", "gig", "msg"]));
        Assert.AreEqual(1, mySol.UniqueMorseRepresentations(["a"]));
    }
}
