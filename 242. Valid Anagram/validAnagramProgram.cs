//Time Complexity - O(n) - Linear Time
//Space Complexity - O(1) - Constant Space for limited characters
//Use case of Top-Level Statement - no  need for using System, creating Main method
Solution solution= new Solution();

string s = "aBc";
string t = "Bac";

bool result = solution.IsAnagram(s, t);
Console.WriteLine(result);

public class Solution
{
    // public static void Main()
    // {
    //     string s = "aBc";
    //     string t = "Bac";
    //     bool result = IsAnagram(s, t);
    //     Console.WriteLine(result);

    // }
    public bool IsAnagram(string s, string t)
    {
        //In this question, the constraints are in lowercase thus addition and subtraction of character a is enough as it will have count[-negative number] which throws out of exception error
        if (s.Length != t.Length) return false;

        //One way is to convert strings to lower case if the question didn't have constraints of lower cases 

        s = s.ToLower();
        t = t.ToLower();


        int[] count = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }

        foreach (int i in count)
        {
            if (i != 0) return false;
        }
        return true;
    }
}
