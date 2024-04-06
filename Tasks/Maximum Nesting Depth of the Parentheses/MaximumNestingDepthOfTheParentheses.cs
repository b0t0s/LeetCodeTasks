namespace Maximum_Nesting_Depth_of_the_Parentheses;

public static class MaximumNestingDepthOfTheParentheses
{
	/// <summary>
	/// Input: s = "(1+(2*3)+((8)/4))+1"
	/// Output: 3
	/// Explanation: Digit 8 is inside of 3 nested parentheses in the string.
	/// </summary>
	/// <param name="s"></param>
	/// <returns></returns>
	public static int MaxDepth(string s)
	{
		var depth = 0;
		var tempValue = 0;

		for (int i = 0; i < s.Length; i++)
		{
			if (s[i] == '(')
			{
				tempValue++;
				depth = Math.Max(depth, tempValue);
			}
			else if (s[i] == ')')
				tempValue--;
		}

		return depth;
	}
}