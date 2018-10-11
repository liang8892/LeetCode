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

            //将字符串按长度排序
            SortStringArray(ref strs);
            //计算最长公共前缀
            string commonPrefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                commonPrefix = CommonPrefix(commonPrefix, strs[i]);
            }
            
            ////找出长度最小的字符串
            //string shortest = ShortestStr(strs);
            //用最小长度的字符串与每一个字符串对比，查找最大


            return commonPrefix;
        }

        /// <summary>
        /// 将字符串按长度排序
        /// </summary>
        /// <param name="strs"></param>
        private static void SortStringArray(ref string[] strs)
        {
            for (int i = 0; i < strs.Length - 1; i++)
            {
                for (int j = i + 1; j < strs.Length; j++)
                {
                    if (strs[i].Length > strs[j].Length)
                        ChangePosition(ref strs, i, j);
                }

            }
        }

        /// <summary>
        /// 交换数组中两个元素的位置
        /// </summary>
        /// <param name="strs">数组</param>
        /// <param name="position1">位置一</param>
        /// <param name="position2">位置二</param>
        private static void ChangePosition(ref string[] strs, int position1, int position2)
        {
            string temp = strs[position1];
            strs[position1] = strs[position2];
            strs[position2] = temp;
        }
        
        /// <summary>
        /// 计算两个字符串的公共前缀（str2长度大于等于str1）
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        private static string CommonPrefix(string str1, string str2)
        {
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                    return str1.Substring(0, i);
            }
            return str1;
        }


        /// <summary>
        /// 找出数组中长度最小的字符串
        /// </summary>
        /// <param name="strs">数组</param>
        /// <returns>长度最小的字符串</returns>
        private static string ShortestStr(string[] strs)
        {
            for (int j = 0; j < strs.Length - 1; j++)
            {
                if (strs[j].Length > strs[j].Length)
                    ChangePosition(ref strs, 0, j);
            }
            return strs[0];
        }

    }
}
