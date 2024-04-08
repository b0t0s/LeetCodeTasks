using System.Text;

namespace Minimum_Remove_to_Make_Valid_Parentheses;

public static class MinimumRemoveToMakeValidParentheses
{
	//Test input: lee(t(c)o)de)
	//Test output: lee(t(c)o)de
	//Test input: a)b(c)d
	//Test output: ab(c)d
	public static string MinRemoveToMakeValid(string s)
	{
		StringBuilder result = new StringBuilder();
		var openParentheses = 0;

		for (var index = 0; index < s.Length; index++)
		{
			var t = s[index];
			if (t is '(')
				openParentheses++;
			else if (t is ')')
			{
				if (openParentheses <= 0)
					continue;

				openParentheses--;
			}

			result.Append(t);
		}

		if (result.ToString().Count(x => x == '(') - result.ToString().Count(x => x == ')') != 0)
		{
			// Remove unmatched opening parentheses by iterating backwards
			for (int i = result.Length - 1; i >= 0; i--)
			{
				if (result[i] == '(' && openParentheses > 0)
				{
					result.Remove(i, 1);
					openParentheses--;
				}
			}
		}

		return result.ToString();
	}
}