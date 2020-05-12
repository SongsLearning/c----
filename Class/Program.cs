using System;

namespace Class
{
    public class part
    {
        part()
        {
            Console.WriteLine("part");
        }
    }

    class pan : part
    {
        pan()
        {
            Console.WriteLine("pan");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
