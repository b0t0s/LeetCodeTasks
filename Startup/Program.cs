﻿using Add_Two_Numbers;
using Defanging_an_IP_Address;
using FluentAssertions;
using Longest_Substring_Without_Repeating_Characters;
using Make_The_String_Great;
using Maximum_Nesting_Depth_of_the_Parentheses;
using Palindrome_Number;
using Types_For_Tasks;

namespace LeetCodeCollection;

internal class Program
{
	static void Main(string[] args)
	{
		#region TwoSum

		Console.WriteLine("[{0}]", string.Join(", ", Two_Sum.TwoSumClass.TwoSum(new int[] { 3, 3 }, 6)));
		Console.WriteLine("[{0}]", string.Join(", ", Two_Sum.TwoSumClass.TwoSum(new int[] { 3, 2, 4 }, 6)));
		Console.WriteLine("[{0}]", string.Join(", ", Two_Sum.TwoSumClass.TwoSum(new int[] { 5, 2, 7 }, 12)));
		Console.WriteLine("[{0}]", string.Join(", ", Two_Sum.TwoSumClass.TwoSum(new double[] { 188.5, 188.5, 187.5, 189.5 }, 377)));

		#endregion

		#region AddTwoNumbers

		Console.WriteLine(AddTwoNumbersClass.AddTwoNumbers(new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4)))).val); // 7 -> 0 -> 8
		Console.WriteLine(AddTwoNumbersClass.AddTwoNumbers(new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4)))).next.val); // 7 -> 0 -> 8
		Console.WriteLine(AddTwoNumbersClass.AddTwoNumbers(new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4)))).next.next.val); // 7 -> 0 -> 8

		#endregion

		#region Defang IP

		var output = IpDefanger.defangIPaddr("255.100.50.0");
		output.Should().Be("255[.]100[.]50[.]0");

		#endregion

		#region Maximum_Nesting_Depth_of_the_Parentheses

		MaximumNestingDepthOfTheParentheses.MaxDepth("(1+(2*3)+((8)/4))+1").Should().Be(3);

		#endregion

		#region Maximum_Nesting_Depth_of_the_Parentheses

		SubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("dvdf").Should().Be(3);
		SubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("abcabcbb").Should().Be(3);
		SubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("pwwkew").Should().Be(3);

		#endregion

		#region Palindrome Number


		PalindromeNumber.IsPalindrome(121).Should().Be(true);
		PalindromeNumber.IsPalindrome(-121).Should().Be(false);
		PalindromeNumber.IsPalindrome(10).Should().Be(false);

		#endregion

		#region Palindrome Number


		MakeTheStringGreat.MakeGood("leEeetcode").Should().Be("leetcode");
		MakeTheStringGreat.MakeGood("abBAcC").Should().Be(string.Empty);

		#endregion

	}
}