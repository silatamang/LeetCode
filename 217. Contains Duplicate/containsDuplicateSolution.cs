public class Solution {
    public bool ContainsDuplicate(int[] nums) {
      var set = new HashSet<int>(nums.Length);
      foreach(int i in nums)
      {
        if(!set.Add(i)) return true;
      }
      return false;
    }
}
