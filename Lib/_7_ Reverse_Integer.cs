using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class _7__Reverse_Integer
    {
        public static int ReverseInteger(int x)
        {
            //if (x >= -9 && x <= 9)
            //    return x;
            List<char> ch = x.ToString().ToList();
            ch.Reverse();
            string s = string.Join("", ch);
            if (x >= 0)
            {
                long temp = long.Parse(s);
                if (temp > int.MaxValue)
                    return 0;
                return (int) temp;
            }
            else
            {
                long temp = long.Parse("-" + s.Replace("-", "").TrimStart('0'));
                if (temp < int.MinValue)
                    return 0;
                return (int)temp;
            }
        }
    }
}
