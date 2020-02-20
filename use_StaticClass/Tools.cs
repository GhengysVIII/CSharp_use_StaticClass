using System;
using System.Collections.Generic;
using System.Text;

namespace Use_StaticClass {
    public static class Tools {
        public static bool EstPalindrome(this string str) {
            str = str.ToLower();
            return str == str.Reverse() ? true : false;
        } 
        
        public static string Reverse(this string str) {
            char[] reversedArray = str.ToCharArray();
            Array.Reverse(reversedArray);
            return new string(reversedArray);
        }

    }
}
