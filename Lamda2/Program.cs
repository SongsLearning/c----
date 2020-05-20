
using System;

namespace ConsoleApp1
{
    class Program
    {
        delegate string Con(string[] arg);

        static void Main(string[] args)
        {

            Con con1 = (arr) =>
            {
                string result = "";
                foreach (string s in arr)
                {
                    result += s;
                }

                return result;
            };

            string[] a = { "a", "a" };

            Console.WriteLine(con1(a));
        }
    }
}