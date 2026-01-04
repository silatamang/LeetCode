//Program uses the concept of Two pointer in place

string s = "A man, a plan, a canal: Panama";
var result = Solution.IsPalindrome(s);
System.Console.WriteLine(result);
public static class Solution
{
   public static bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left]))
            {
                left++;
            }

            while (left < right && !char.IsLetterOrDigit(s[right]))
            {
                right--;
            }

            char l = char.ToLower(s[left]);
            char r = char.ToLower(s[right]);

            Console.WriteLine($"{l} === {r}");

            if (l != r)
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
}

}
