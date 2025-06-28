// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using LeetCode.src;

var mySolution = new Solution();
// foreach (var item in mySolution.GetSneakyNumbers([0, 1, 1, 0]))
// {
//     System.Console.WriteLine(item);
// }

// System.Console.WriteLine(Convert.ToString(2,2));

SolutionString mySolutionStr = new();
// mySolutionStr.Interpret("(al)G(al)()()G");
// System.Console.WriteLine(mySolution.CountConsistentStrings("ab", ["ad", "bd", "aaab", "baa", "badab"]));
// System.Console.WriteLine('a' - 'b'+26);

// System.Console.WriteLine("wawa"+"fdsfsdfs");
// System.Console.WriteLine(mySolutionStr.TruncateSentence("chopper is not a tanuki", 5));
// char myChar = 'a';
// myChar++;
// System.Console.WriteLine(myChar);

// System.Console.WriteLine(mySolutionStr.DecodeMessage("the quick brown fox jumps over the lazy dog", "vkbs bs t suepuv"));

// foreach (var row in mySolution.LargestLocal([[2, 5, 5], [3, 2, 5], [1, 2, 3]]))
// {
//     foreach (var col in row)
//     {
//         System.Console.WriteLine(col);
//     }
// }

// foreach (var row in mySolution.LargestLocal([[9,9,8,1],[5,6,2,6],[8,2,6,4],[6,2,2,2]]))
// {
//     foreach (var col in row)
//     {
//         System.Console.WriteLine(col);
//     }
// }
// foreach (var i in mySolution.FindMissingAndRepeatedValues([[9,1,7],[8,9,2],[3,4,6]]))
// {
//     System.Console.WriteLine(i);
// }
// mySolutionStr.PrefixCount(["leetcode", "win", "loops", "success"], "code");
// int[] nums = [1,1,1,1,1];
// System.Console.WriteLine(nums[..0].Sum());
// int[] leftSum = new int[nums.Length];
// foreach (var col in leftSum)
// {
//     System.Console.WriteLine(col);
// }
// mySolution.LeftRightDifference([10, 4, 8, 3]);
foreach (var i in mySolution.MinOperations("110"))
{
    System.Console.WriteLine(i);
}

