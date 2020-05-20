using System;

namespace ConsoleApp14
{


    class Program
    {
        delegate int cal(int a, int b);
        static void Main(string[] args)
        {
            cal cal1 = (a, b) => a + b;

            cal cal2 = delegate (int a, int b)
            {
                return a + b;
            };



            Console.WriteLine("3 + " + " 4 = " + cal1(3, 4));
        }
    }
}
