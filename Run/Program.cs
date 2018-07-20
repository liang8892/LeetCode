using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib;

namespace Run
{
    class Program
    {
        static void Main(string[] args)
        {
            //_7_ReverseInteger();
            //_9_PalindromeNumber();
            _13_RomanToInteger();
        }

        private static void _7_ReverseInteger()
        {
            int[] x = new int[] {1534236469};//{ 0, 11, -5, -11, 555, -666, 1658, -8656 };
            foreach (int i in x)
            {
                int y = _7__Reverse_Integer.ReverseInteger(i);
                Console.WriteLine("x＝" + i + ", y=" + y);
                Console.ReadKey();
            }
        }

        private static void _9_PalindromeNumber()
        {
            int[] x = new[] { 0, 121, 11, -5, -11, 515, 666, 1658, 86556, 8668, 55655};
            foreach (int i in x)
            {
                bool y = _9_Palindrome_Number.IsPalindrome(i);
                Console.WriteLine("x＝" + i + ", " + y);
                Console.ReadKey();
            }
        }

        private static void _13_RomanToInteger()
        {
            string[] x = new[] { "III","IV","V","MMCMIV","L" };
            foreach (string s in x)
            {
                int y = _13_Roman_to_Integer.RomanToInt(s);
                Console.WriteLine(s + " = " + y);
                Console.ReadKey();
            }
        }
    }
}
