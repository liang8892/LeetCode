using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67.Add_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("一");
                string binStr1 = Console.ReadLine();
                Console.WriteLine("二");
                string binStr2 = Console.ReadLine();
                Solution sol = new Solution();
                Console.WriteLine("结果：");
                Console.WriteLine(sol.AddBinary(binStr1, binStr2));
            } while (true);
        }
    }

    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            int len1 = a.Length;
            int len2 = b.Length;

            if (len1 >= len2)
            {
                return DoAddBinary(a, b);
            }
            else
            {
                return DoAddBinary(b, a);
            }
        }

        public string DoAddBinary(string a, string b)
        {
            int len1 = a.Length;
            int len2 = b.Length;
            string newA = a.Remove(0, len1 - len2);
            int x = 0;//进位
            List<string> result = new List<string>();
            for (int i = len2 - 1; i >= 0; i--)
            {
                int inta = int.Parse(newA[i].ToString());
                int intb = int.Parse(b[i].ToString());
                if (x + inta + intb == 0)
                {
                    x = 0;
                    result.Add("0");
                }
                else if (x + inta + intb == 1)
                {
                    x = 0;
                    result.Add("1");
                }
                else if (x + inta + intb == 2)
                {
                    x = 1;
                    result.Add("0");
                }
                else if (x + inta + intb == 3)
                {
                    x = 1;
                    result.Add("1");
                }
            }
            if (x == 0)
            {
                for (int k = len1 - len2 - 1; k >= 0; k--)
                {
                    result.Add(a[k].ToString());
                }
            }
            else
            {
                for (int k = len1 - len2 - 1; k >= 0; k--)
                {
                    if (x + int.Parse(a[k].ToString()) == 1)
                    {
                        x = 0;
                        result.Add("1");
                    }
                    else if (x + int.Parse(a[k].ToString()) == 2)
                    {
                        x = 1;
                        result.Add("0");
                    }
                    else if (x + int.Parse(a[k].ToString()) == 0)
                    {
                        x = 0;
                        result.Add("0");
                    }
                }
                if (x == 1)
                {
                    result.Add("1");
                }
            }
            result.Reverse();
            return string.Join("", result);
        }
    }
}
