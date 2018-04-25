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
    public void IsPalindrome_A_but_tuba_Abuttuba()
    {
        string testOutput = "Abuttuba";
        Assert.AreEqual(testOutput, Palindrome.IsPalindrome("A but tuba"));
    }
  }
}
