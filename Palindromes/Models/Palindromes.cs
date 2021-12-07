using System;

namespace Palindrome.Models
{
  public class PalindromeChecker
  {
    public static bool IsStringPalindrome(string userInputString)
    {
      char[] reverseArray = userInputString.ToCharArray();
      Array.Reverse(reverseArray);
      string joinedWord = new string(reverseArray);
      return joinedWord == userInputString;
    }
    public static bool CannotEqualTheVoid(string userInputString)
    {
      int endPoint = userInputString.Length-1;
      for(int i = 0; i<userInputString.Length; i++)
      {
        if(userInputString[i] != userInputString[endPoint])
        {
          return false;
        }
        endPoint --;
      }
      return true;
    }
  }
}