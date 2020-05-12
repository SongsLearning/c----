using System;




namespace ConsoleApp1
{

    public static class interger
    {
        public static int squar(this int myint)
        {
            return myint * myint;
        }

        public static int power(this int myint, int expont)
        {
            int resurlt = myint;
            for (int i = 1; i < expont; i++)
            {
                resurlt = resurlt * myint;
            }
            return resurlt;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3^2 :" + 3.squar());
            Console.WriteLine("3^4 :" + 3.power(4));
            Console.WriteLine("2^10 :" + 2.power(10));
        }
    }
}
