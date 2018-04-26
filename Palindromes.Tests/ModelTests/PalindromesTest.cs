using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PalindromesApp;
using System;

namespace PalindromesApp.Tests
{
  [TestClass]
  public class PalindromsTest
  {

    [TestMethod]
    public void IsPalindrome_A_true()
    {
        Assert.AreEqual(true, Palindrome.IsPalindrome("A"));
    }

    [TestMethod]
    public void IsPalindrome_noon_true()
    {
        Assert.AreEqual(true, Palindrome.IsPalindrome("noon"));
    }

    [TestMethod]
    public void IsPalindrome_A_but_tuba_true()
    {
        Assert.AreEqual(true, Palindrome.IsPalindrome("A but tuba"));
    }

    [TestMethod]
    public void IsPalindrome_NotAPalindrome_false()
    {
        Assert.AreEqual(false, Palindrome.IsPalindrome("Not a Palindrome"));
    }

    [TestMethod]
    public void IsPalindrome_ADogAPlanACanalPagoda_true()
    {
        Assert.AreEqual(true, Palindrome.IsPalindrome("A dog, a plan, a canal: pagoda."));
    }

    [TestMethod]
    public void IsPalindrome_LongPalindromeWithSignsAndNumbers_true()
    {
        Assert.AreEqual(true, Palindrome.IsPalindrome("123Are we not pure? “No sir!” Panama’s moody Noriega brags. “It is garbage!” Irony dooms a man; a prisoner up to new era."));
    }

    [TestMethod]
    public void IsPalindrome_1234_false()
    {
        Assert.AreEqual(false, Palindrome.IsPalindrome("1234"));
    }
  }
}
