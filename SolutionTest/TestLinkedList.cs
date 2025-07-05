using LeetCode.src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Company.TestProject1;

[TestClass]
public class TestLinkedList
{
    [TestMethod]
    public void TestInsertGreatestCommonDivisors()
    {
        SolutionLinkedList mySol = new();
        ListNode input = new ListNode(18, new ListNode(6, new ListNode(10, new ListNode(3))));
        ListNode result = mySol.InsertGreatestCommonDivisors(input);
        Assert.AreEqual(18, result.val);
        Assert.AreEqual(6, result.next.val);
        Assert.AreEqual(6, result.next.next.val);
        Assert.AreEqual(2, result.next.next.next.val);
        Assert.AreEqual(10, result.next.next.next.next.val);
        Assert.AreEqual(1, result.next.next.next.next.next.val);
        Assert.AreEqual(3, result.next.next.next.next.next.next.val);
    }
}
