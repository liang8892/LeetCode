using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    //给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串，判断字符串是否有效。
    //有效字符串需满足：
    //左括号必须用相同类型的右括号闭合。
    //左括号必须以正确的顺序闭合。
    //注意空字符串可被认为是有效字符串。

    //示例 1:
    //输入: "()"
    //输出: true

    //示例 2:
    //输入: "()[]{}"
    //输出: true

    //示例 3:
    //输入: "(]"
    //输出: false

    //示例 4:
    //输入: "([)]"
    //输出: false

    //示例 5:
    //输入: "{[]}"
    //输出: true


    public class _20_Valid_Parentheses
    {
        private static char[] leftChars = new char[] { '(', '[', '{' };
        private static char[] rightChars = new char[] { ')', ']', '}' };

        public static bool IsValid(string s)
        {
            //空字符串，返回true
            if (string.IsNullOrEmpty(s))
                return true;

            //第一步：第一个若是右括号，返回false
            if (rightChars.Contains(s[0]))
                return false;

            //第二步：将左括号与右括号分别装入两个List
            List<char> left = new List<char>();
            List<char> right = new List<char>();
            int startIndex = 0;
            do
            {
                startIndex = GetLeft(s, startIndex, ref left);
                startIndex = GetRight(s, startIndex, ref right);
            } while (Check(left, right));

            //左括号与右括号的个数若不一致，返回false
            if (left.Count != right.Count)
                return false;

            //第三步：n个左括号之后要跟n个右括号，且右括号的顺序要与左括号顺序相反
            for (int i = 0; i < left.Count; i++)
            {

            }
            return false;
        }

        /// <summary>
        /// 获取连续的左括号
        /// </summary>
        /// <param name="s"></param>
        /// <param name="startIndex">开始位置的索引值</param>
        /// <param name="left"></param>
        /// <returns></returns>
        private static int GetLeft(string s,int startIndex, ref List<char> left)
        {
            for (int i = startIndex; i < s.Length; i++)
            {
                if (leftChars.Contains(s[i]))
                {
                    startIndex++;
                    left.Add(s[i]);
                    continue;
                }
                if (rightChars.Contains(s[i]))
                {
                    break;
                }
            }
            return startIndex;
        }

        /// <summary>
        /// 获取连续的右括号
        /// </summary>
        /// <param name="s"></param>
        /// <param name="startIndex">开始位置的索引值</param>
        /// <param name="left"></param>
        /// <returns></returns>
        private static int GetRight(string s, int startIndex, ref List<char> right)
        {
            for (int i = startIndex; i < s.Length; i++)
            {
                if (rightChars.Contains(s[i]))
                {
                    startIndex++;
                    right.Add(s[i]);
                    continue;
                }
                if (leftChars.Contains(s[i]))
                {
                    break;
                }
            }
            return startIndex;
        }

        /// <summary>
        /// 翻转右括号的集合后，判断其是否与左括号顺序一致
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private static bool Check(List<char> left, List<char> right)
        {
            if (left.Count == 0 || left.Count != right.Count)
                return false;

            right.Reverse();
            return left.SequenceEqual(right);
        }
    }
}
