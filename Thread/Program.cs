using System;
using System.Threading;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void pp()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("pp! : " + i);
                Thread.Sleep(10);//m/s 사용하고 1/1000초 스레드 지연 점유를 내려 놓는다.
            }
        }


        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(pp));

            Console.WriteLine("시작");
            t1.Start();


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("main! : " + i);
                Thread.Sleep(10);
            }


            Console.WriteLine("정지");
            t1.Join();
            Console.WriteLine("끝");

        }
    }
}
