using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class _13_Roman_to_Integer
    {
        enum Roman
        {
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000,
            IV = 4,
            IX = 9,
            XL = 40,
            XC = 90,
            CD = 400,
            CM = 900
        };
        public static int RomanToInt(string s)
        {
            int result = 0;
            if (s != "")
            {
                if (s.Contains("IV"))
                {
                    result += 4;
                    s = s.Replace("IV", "");
                }
                if(s.Contains("IX"))
                {
                    result += 9;
                    s = s.Replace("IX", "");
                }
                if (s.Contains("XL"))
                {
                    result += 40;
                    s = s.Replace("XL", "");
                }
                if (s.Contains("XC"))
                {
                    result += 90;
                    s = s.Replace("XC", "");
                }
                if (s.Contains("CD"))
                {
                    result += 400;
                    s = s.Replace("CD", "");
                }
                if (s.Contains("CM"))
                {
                    result += 900;
                    s = s.Replace("CM", "");
                }

                if (s != "")
                {
                    char[] ch = s.ToCharArray();
                    foreach (char c in ch)
                    {
                        switch (c)
                        {
                            case 'M':
                                result += 1000;
                                break;
                            case 'D':
                                result += 500;
                                break;
                            case 'C':
                                result += 100;
                                break;
                            case 'L':
                                result += 50;
                                break;
                            case 'X':
                                result += 10;
                                break;
                            case 'V':
                                result += 5;
                                break;
                            case 'I':
                                result += 1;
                                break;
                        }
                    }
                }
            }
            
            return result;
        }
    }
}
