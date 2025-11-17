class Solution {
    public int[] runningSum(int[] nums) {
        // In Java, array length is accessed via nums.length whereas nums.Length (capital L) in C# 
        for(int i =1; i < nums.length; i++)
        {
            nums[i] += nums[i-1];
        }

        return nums;
    }
}
