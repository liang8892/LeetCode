using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib;

namespace Run
{
    class Program
    {
        static void Main(string[] args)
        {
            _7_ReverseInteger();
        }

        private static void _7_ReverseInteger()
        {
            int[] x = new int[] {1534236469};//{ 0, 11, -5, -11, 555, -666, 1658, -8656 };
            foreach (int i in x)
            {
                int y = _7__Reverse_Integer.ReverseInteger(i);
                Console.WriteLine("x＝" + i + ", y=" + y);
                Console.ReadKey();
            }
        }
    }
}
