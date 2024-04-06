namespace Two_Sum;

public static class TwoSumClass
{
	public static int[] TwoSum(int[] nums, int target)
	{
		for (int i = 0; i < nums.Length; i++)
		{
			for (int j = 0; j < nums.Length; j++)
			{
				if (nums[i] + nums[j] == target && i != j)
				{
					return new int[] { i, j };
				}
			}
		}
		return null;
	}

	public static double[] TwoSum(double[] nums, int target)
	{
		for (int i = 0; i < nums.Length; i++)
		{
			for (int j = 0; j < nums.Length; j++)
			{
				if (nums[i] + nums[j] == target && i != j)
				{
					return new double[] { i, j };
				}
			}
		}
		return null;
	}
}