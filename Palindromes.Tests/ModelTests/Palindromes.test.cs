using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;

namespace Palindromes.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void IsStringPalindrome_IsAPalindrome_True()
    {
      bool result = PalindromeChecker.IsStringPalindrome("101");
      Assert.AreEqual(true, result);
    }
    [TestMethod]
    public void CannotEqualTheVoid_IsAPalindrome_True()
    {
      bool result = PalindromeChecker.CannotEqualTheVoid("101");
      Assert.AreEqual(true, result);
    }
  }
}
