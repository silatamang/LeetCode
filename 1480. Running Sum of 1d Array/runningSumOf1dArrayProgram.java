public class Main {
  public static void main(String[] args) {
    Main m = new Main();
    int[] result = m.runningSum(new int[] {1,1,1,1,1});

    //Java doesn't have foreach loop
    //Java's enhanced for-loop
    //for (Type variable : collection){}
    
    for(int i : result)
    {
    	System.out.println(i);
    }
  }
  
  public int[] runningSum(int[] nums)
  {
  	for(int i = 1; i < nums.length; i++)
    {
    	nums[i] += nums[i-1];
	}
    return nums;
  }
}
