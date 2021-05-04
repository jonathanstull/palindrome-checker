using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeChecker;

namespace PalindromeChecker.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void SplitString_TakesAndSplitsAString_True()
    {
      string testString1 = "racecar";
      char[] testString2 = { 'r', 'a', 'c', 'e', 'c', 'a', 'r' };
      Palindrome2 testPalindrome = new Palindrome2();
      CollectionAssert.AreEqual(testString2, testPalindrome.SplitString(testString1));
    }
        [TestMethod]
    public char ReverseString_TakesSplitStringAndReversesIt_True()
    {
      string testString1 = "epicodus";
      char[] testString2 = { "e", "p", "i", "c", "o", "d", "u", "s" };
      char[] reversedString =  { "s", "u", "d", "o", "c", "i", "p", "e" };
      Palindrome2 testPalindrome = new Palindrome2();
      CollectionAssert.AreNotEqual(reversedString, testPalindrome.ReverseString(testString2));
    }
    
    

      //// take string 
      //// split string up 
      //// reverse string 
      //// compare first string with reversed string
  }
}