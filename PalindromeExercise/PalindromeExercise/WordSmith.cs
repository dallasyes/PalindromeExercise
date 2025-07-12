using System.Linq;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string str)
    {
        str = str.ToLower();
        string reversed = new string(str.Reverse().ToArray());
        return str == reversed;
    }
}