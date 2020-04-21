using System;
using static System.Console;

namespace Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = -10;
            byte b = 40;

            WriteLine($"a={a},b={b}");

            short c = -30000;
            ushort d = 60000;

            WriteLine($"C={c},D={d}");

            // _는 구분해 주기 위해 많이 사용된다.
            int e = -1000_0000;
            uint f = 3_0000_0000;

            WriteLine($"e={e},f={f}");

            long g = -5000_0000_0000;
            ulong h = 200_0000_0000_0000;

            WriteLine($"g={g},h={h}");
        }
    }
}

