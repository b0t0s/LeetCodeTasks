namespace Longest_Substring_Without_Repeating_Characters;

public static class SubstringWithoutRepeatingCharacters
{
	public static int LengthOfLongestSubstring(string s)
	{
		HashSet<char> temp = new();
		var maximum = 0;

		Range window = new(0, 0);
		while (window.End.Value < s.Length)
		{
			if (!temp.Contains(s[window.End.Value]))
			{
				temp.Add(s[window.End]);
				window = window.IncrementEnd();

				if (maximum < temp.Count)
					maximum = temp.Count;
			}
			else
			{
				window = window.IncrementStart();
				temp.Clear();
			}
		}

		return maximum;
	}
}

public static class RangeExtensionMethods
{
	public static Range IncrementStart(this Range window) => new(window.Start.Value + 1, window.Start.Value + 1);

	public static Range IncrementEnd(this Range window) => new(window.Start.Value, window.End.Value + 1);
}