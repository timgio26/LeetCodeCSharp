// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using LeetCode.src;

Solution mySolution = new();

foreach (int i in mySolution.LuckyNumbers([[1, 10, 4, 2], [9, 3, 8, 7], [15, 16, 17, 12]]))
{
    System.Console.WriteLine(i);
}
