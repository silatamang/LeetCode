/*
Time Complexity - O(n) - Linear Time - because of Two Pointer, we only check from left to right and right to left and never reset.
                                       Thus, left pointer can increment at most n times and right pointer can decrement at most n times.
                                       That means total pointer movements <= 2n, thus O(n)
                                       It would have been O(n^2) only if for every left we restarted from right.
                                       
Space Complexity - O(1) - Constant Space - No creation of extra data structures, directly worked on the original string input. 
*/
public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;

        while(left < right)
        {
            while(left < right && !char.IsLetterOrDigit(s[left])) left++;

            while(left < right && !char.IsLetterOrDigit(s[right])) right--;

            if(char.ToLower(s[left]) != char.ToLower(s[right])) return false;

            left++;
            right--;
        }

        return true;
    }
}
