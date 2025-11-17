using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    	  Program p = new Program();
        int[] result = p.RunningSum(new int[]{3,1,2,10,1}); 
        foreach(int i in result)
        {
          Console.WriteLine(i);
        }
    }
    
    public int[] RunningSum(int[] nums) {

        for(int i = 1; i < nums.Length; i++ )
        {
            nums[i] += nums[i-1];
        }

        return nums;
    }
  }
}
