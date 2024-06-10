using Add_Two_Numbers;
using Defanging_an_IP_Address;
using FluentAssertions;
using Longest_Substring_Without_Repeating_Characters;
using Make_The_String_Great;
using Maximum_Nesting_Depth_of_the_Parentheses;
using Minimum_Remove_to_Make_Valid_Parentheses;
using Palindrome_Number;
using Roman_to_Integer;
using Types_For_Tasks;

namespace LeetCodeCollection;

internal class Program
{
	static void Main(string[] args)
	{
		#region TwoSum

		string.Join(", ", Two_Sum.TwoSumClass.TwoSum(new int[] { 3, 3 }, 6)).Should().Be(@"0, 1");
		string.Join(", ", Two_Sum.TwoSumClass.TwoSum(new int[] { 3, 2, 4 }, 6)).Should().Be(@"1, 2");
		string.Join(", ", Two_Sum.TwoSumClass.TwoSum(new int[] { 5, 2, 7 }, 12)).Should().Be(@"0, 2");
		string.Join(", ", Two_Sum.TwoSumClass.TwoSum(new double[] { 188.5, 188.5, 187.5, 189.5 }, 377)).Should().Be(@"0, 1");

		#endregion

		#region AddTwoNumbers

		AddTwoNumbersClass.AddTwoNumbers(new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4)))).val.Should().Be(7); // 7 -> 0 -> 8
		AddTwoNumbersClass.AddTwoNumbers(new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4)))).next.val.Should().Be(0); // 7 -> 0 -> 8
		AddTwoNumbersClass.AddTwoNumbers(new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4)))).next.next.val.Should().Be(8); // 7 -> 0 -> 8

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

		#region Make The String Great

		//MakeTheStringGreat.MakeGood("leEeetcode").Should().Be("leetcode");
		//MakeTheStringGreat.MakeGood("abBAcC").Should().Be(string.Empty);

		#endregion

		#region Minimum Remove to Make Valid Parentheses 

		MinimumRemoveToMakeValidParentheses.MinRemoveToMakeValid("a(bc").Should().Be("abc");
		MinimumRemoveToMakeValidParentheses.MinRemoveToMakeValid("(t(e)y))d(()(e(").Should().Be("(t(e)y)d()e");
		MinimumRemoveToMakeValidParentheses.MinRemoveToMakeValid("(a(b(c)d)").Should().BeOneOf(new List<string> { "a(b(c)d)", "(a(bc)d)"});
		MinimumRemoveToMakeValidParentheses.MinRemoveToMakeValid("())()(((").Should().Be("()()");
		MinimumRemoveToMakeValidParentheses.MinRemoveToMakeValid("))").Should().Be(string.Empty);
		MinimumRemoveToMakeValidParentheses.MinRemoveToMakeValid("))((").Should().Be(string.Empty);

		MinimumRemoveToMakeValidParentheses.MinRemoveToMakeValid("a)b(c)d").Should().Be("ab(c)d");
		MinimumRemoveToMakeValidParentheses.MinRemoveToMakeValid("lee(t(c)o)de)").Should().BeOneOf(new List<string>{"lee(t(c)ode)","lee(t(co)de)", "lee(t(c)o)de" });

		#endregion

		#region Minimum Remove to Make Valid Parentheses 

		RomanToInteger.RomanToInt("III").Should().Be(3);
		RomanToInteger.RomanToInt("LVIII").Should().Be(58);
		RomanToInteger.RomanToInt("MCMXCIV").Should().Be(1994);

		#endregion
	}
}