using System;

namespace LeetCode.src;


public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class SolutionLinkedList
{
    public int getGCD(int num1, int num2)
    {

        int small = num1 < num2 ? num1 : num2;
        int big = num1 > num2 ? num1 : num2;
        int rem = big % small;
        while (rem != 0)
        {

            big = small;
            small = rem;
            rem = big % small;

        }
        return small;
    }
    public ListNode InsertGreatestCommonDivisors(ListNode head)
    {
        //2807
        ListNode current = head;
        while (current != null && current.next != null)
        {
            int num1 = current.val;
            int num2 = current.next.val;
            int gcd = getGCD(num1, num2);
            ListNode newNode = new ListNode(gcd, current.next);
            current.next = newNode;
            current = newNode.next;
        }
        return head;
    }

    public int GetDecimalValue(ListNode head)
    {
        //1290
        List<string> ints2 = [];
        while (head != null)
        {
            ints2.Add(head.val.ToString());
            head = head.next;
        }
        string binStr = string.Concat(ints2);
        return Convert.ToInt32(binStr, 2);
    }

    public ListNode DeleteDuplicates(ListNode head)
    {
        //83 bisa improve pake int? prev = null; or in place
        ListNode listNode = new();
        ListNode result = listNode;
        int pref = new();
        int count = 0;
        while (head != null)
        {
            if (head.val != pref || count == 0)
            {
                ListNode newNode = new(head.val);
                listNode.next = newNode;
                listNode = listNode.next;
            }
            pref = head.val;
            head = head.next;
            count++;
        }
        return result.next;
    }

    public ListNode MergeNodes(ListNode head)
    {
        //2181
        ListNode listNode = new();
        ListNode result = listNode;
        int val = 0;
        while (head != null)
        {
            if (val > 0 & head.val == 0)
            {
                ListNode newNode = new(val);
                listNode.next = newNode;
                listNode = listNode.next;
                val = 0;
            }
            val += head.val;
            head = head.next;
        }
        return result.next;
    }

    public ListNode ReverseList(ListNode head)
    {
        //206 bisa improve pake reverse pointer current.next = prev;
        Stack<int> ints = new();
        while (head != null)
        {
            ints.Push(head.val);
            head = head.next;
        }

        ListNode listNode = new();
        ListNode result = listNode;
        foreach (int i in ints)
        {
            ListNode newNode = new(i);
            listNode.next = newNode;
            listNode = listNode.next;
        }
        return result.next;
    }
}
