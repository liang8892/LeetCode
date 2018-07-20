using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    class _9_Palindrome_Number
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            if (x > 0)
            {
                int pop = x % 10;
                int y = x / 10;
                while (y != 0)
                {
                    
                }
                if (pop == x)
                    return true;
                return false;
            }
            return true;
        }
    }
}
