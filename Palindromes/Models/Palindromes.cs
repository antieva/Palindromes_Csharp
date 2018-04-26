using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace PalindromesApp
{
    public class Palindrome
    {
        public static string ToAlphaOnly(string input)
        {
            Regex rgx = new Regex("[^a-zA-Z]");
            return rgx.Replace(input, "");
        }

        public static bool IsPalindrome(string myString)
        {
            myString = ToAlphaOnly(myString.ToLower());
            if (myString == "") {
              return false;
            }
            for (int i = 0; i < myString.Length / 2; i++) {
                if (myString[i] != myString[myString.Length - 1 - i]) {
                    return false;
                }
            }
            return true;

          // The alternative code bellow works wothout Regex if there is at least one alphabetic character in the argument string.
          // If there are no letters among the other characters the function returns true though it suppose to be false.
            // myString = myString.ToLower();
            // int i = 0;
            // int j = myString.Length - 1;
            // while(i != j) {
            //     if (!Char.IsLetter(myString[i])) {
            //         i++;
            //         continue;
            //     }
            //     if (!Char.IsLetter(myString[j])) {
            //         j--;
            //         continue;
            //     }
            //     if (myString[i] != myString[j]) {
            //         return false;
            //     }
            //     i++;
            //     j--;
            // }
            // return true;
        }
    }
}
