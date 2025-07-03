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
        Assert.AreEqual(2, mySol.NumberOfPairs([1,2,4,12], [2, 4], 3));
    }
}
