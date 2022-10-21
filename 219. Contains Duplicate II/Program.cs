bool result = ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1 }, 3);
Console.WriteLine(result);

bool ContainsNearbyDuplicate(int[] nums, int k)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j <= i + k && j < nums.Length; j++)
        {
            if (nums[j] == nums[i])
                return true;
        }
    }

    return false;
}
