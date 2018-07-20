using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _717._1_bit_and_2_bit_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int i = 0;
                Solution sol = new Solution();
                List<int> bits = new List<int>();
                Console.WriteLine("个数");
                if (!int.TryParse(Console.ReadLine(), out i)) continue;
                do
                {
                    int j;
                    Console.WriteLine("第" + (bits.Count + 1) + "个");
                    if (int.TryParse(Console.ReadLine(), out j) && (j == 0 || j == 1))
                    {
                        bits.Add(j);
                    }
                } while (bits.Count < i);

                if (sol.IsOneBitCharacter(bits.ToArray()))
                {
                    Console.WriteLine("Output: True");
                }
                else
                {
                    Console.WriteLine("Output: False");
                }
            } while (true);
        }
    }

    public class Solution
    {
        public bool IsOneBitCharacter(int[] bits)
        {
            int len = bits.Length;

            if (len <= 2)
            {
                if (bits[0] == 0)
                    return true;
                return false;
            }
            else
            {
                for (int i = 0; i < len - 1; i++)
                {
                    if (bits[i] == 1)
                    {
                        if (i + 2 < len - 1)
                        {
                            i++;
                            continue;
                        }
                        if (i + 2 == len - 1)
                        {
                            return true;
                        }
                        return false;
                    }
                    else
                    {
                        if (i + 1 >= len - 1)
                            return true;
                    }
                }
            }
            
            return false;
        }
    }
}
