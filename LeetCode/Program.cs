// See https://aka.ms/new-console-template for more information
using LeetCode.src;

var mySolution = new Solution();
foreach (var item in mySolution.GetSneakyNumbers([0,1,1,0]))
{
    System.Console.WriteLine(item);
}

// mySolution.CanBeIncreasing([1, 4, 1, 2, 3]);

// System.Console.WriteLine(mySolution.CountConsistentStrings("ab", ["ad", "bd", "aaab", "baa", "badab"]));
