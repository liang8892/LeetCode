using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _461.Hamming_Distance
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
                Console.WriteLine(sol.HammingDistance(int.Parse(binStr1), int.Parse(binStr2)));
            } while (true);
        }
    }

    public class Solution
    {
        public int HammingDistance(int x, int y)
        {
            int result = x ^ y;
            int hammingDistance = 0;
            for (int i = 0; i < 32; i++)
            {
                if (((result >> i) & 1) == 1)
                {
                    hammingDistance++;
                }
            }

            return hammingDistance;
        }
    }
}
