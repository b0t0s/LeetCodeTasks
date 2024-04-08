namespace Roman_to_Integer;

public class RomanToInteger
{
	private static Dictionary<char, int> Symbols = new()
	{
		{'I', 1},
		{'V', 5},
		{'X', 10},
		{'L', 50},
		{'C', 100},
		{'D', 500},
		{'M', 1000}
	};

	public static int RomanToInt(string s)
	{

		var result = 0;
		var prev = ' ';

		for (int i = s.Length; i > 0; i--)
		{
			var c = s[i-1];
			var number = CharToInt(c);

			if (prev == 'V' && c == 'I')
			{
				number = 4;
				result -= CharToInt(prev);
			}

			if (prev == 'X' && c == 'I')
			{
				number = 9;
				result -= CharToInt(prev);
			}

			if (prev == 'L' && c == 'X')
			{
				number = 40;
				result -= CharToInt(prev);
			}

			if (prev == 'C' && c == 'X')
			{
				number = 90;
				result -= CharToInt(prev);
			}

			if (prev == 'D' && c == 'C')
			{
				number = 400;
				result -= CharToInt(prev);
			}

			if (prev == 'M' && c == 'C')
			{
				number = 900;
				result -= CharToInt(prev);
			}

			result += number;

			prev = c;
			if(i - 1 < 0)
				break;
		}

		return result;
	}

	public static int CharToInt(char symbol)
	{
		Symbols.TryGetValue(symbol, out var number);
		return number;
	}
}