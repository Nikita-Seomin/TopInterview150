namespace Top_Interview_150._27._Remove_Element;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length==0) return 0;
        
        int k = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            nums[k] = nums[i];
            if (nums[i] != val)
            {
                ++k;
            }
        }

        return k;
    }
}