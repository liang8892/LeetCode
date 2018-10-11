using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class _14_Longest_Common_Prefix
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0 || strs.Contains(""))
                return "";
            if (strs.Length == 1)
                return strs[0];

            //List<string> listStr = strs.ToList();
            Array.Sort(strs);

            //将字符串按长度排序
            SortStringArray(ref strs);

            return "";
        }

        private static void SortStringArray(ref string[] strs)
        {
            for (int i = 0; i < strs.Length - 1; i++)
            {
                for (int j = 1; j < strs.Length - 1; j++)
                {
                    if (strs[i].Length > strs[j].Length)
                        ChangePosition(ref strs, i, j);
                }

            }
        }

        private static void ChangePosition(ref string[] strs, int position1, int position2)
        {
            string temp = strs[position1];
            strs[position1] = strs[position2];
            strs[position2] = temp;
        }
    }
}
