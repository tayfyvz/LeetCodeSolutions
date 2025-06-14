public class Solution
{
	public int[] SearchRange(int[] nums, int target)
	{
		int start = Find(nums, target, true);
		int end = Find(nums, target, false);

		return new int[] { start, end };
	}

	public int Find(int[] nums, int target, bool isLeft)
	{
		int start = 0;
		int end = nums.Length - 1;

		int desiredIndex = -1;

		while (start <= end)
		{
			int mid = (start + end) / 2;
			if (nums[mid] < target)
			{
				start = mid + 1;
			}
			else if (nums[mid] > target)
			{
				end = mid - 1;
			}
			
			else
			{
				desiredIndex = mid;
				if (isLeft)
				{
					end = mid - 1;
				}
				else
				{
					start = mid + 1;
				}
			}
		}

		return desiredIndex;
	}

}