/*
Time Complexity - O(n) - Linear Time
Space Complexity - O(1) - Constant Space
*/

public class Solution {
    public int[] RunningSum(int[] nums) {
      
        for(int i = 1; i < nums.Length; i++ )
        {
            // nums[0] is already the correct running sum, so we start loop from i=1
            nums[i] += nums[i-1];
        }
        return nums;
    }
}

