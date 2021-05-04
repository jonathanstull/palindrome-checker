using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeChecker;

namespace PalindromeChecker.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    public void GatherInput_GatherInputFromUser_UserInput()
    {
    Palindrome testPalindrome = new Palindrome();
    string userInput = "racecar";
    Assert.AreEqual(string userInput, testPalindrome.GatherInput(userInput));
    }
  }
}