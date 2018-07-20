using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class _9_Palindrome_Number
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            if (x >= 0 && x < 10)
                return true;
            //反转后的数字
            int rever = x % 10;
            if (rever == 0)
                return false;
            x /= 10;
            while (x > 0 && x > rever)
            {
                rever = rever*10 + x%10;
                if (x == rever)
                    return true;
                x /= 10;
            }
            if (x == rever)
                return true;
            return false;
        }
    }
}
