namespace Palindrome_Number;

public static class PalindromeNumber
{
	public static bool IsPalindrome(int x)
	{
		if(x < 0)
			return false;
		if(x is <= 0 and <= 10)
			return true;

		var data = x.ToString();

		if(data.Distinct().Count() == 1)
			return true;

		var reversedData = new string(data.Reverse().ToArray());

		if (data.Length % 2 == 0)
		{
			var firstPart = data.Substring(0, data.Length / 2);
			var secondPart = reversedData.Substring(0, data.Length / 2);
			if(secondPart == firstPart)
				return true;
		}
		else
		{
			return data == reversedData;
		}

		return false;
	}
}