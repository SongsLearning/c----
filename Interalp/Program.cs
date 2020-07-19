using System;
using System.Threading;
using static System.Console;

namespace ConsoleApp2
{

    class sideTask
    {
        int count;

        public sideTask(int Count)
        {
            this.count = Count;
        }

        public void keepAlive()
        {
            try
            {
                Thread.SpinWait(1000000);

                while (count > 0)
                {
                    WriteLine(count-- + "left");
                    Thread.Sleep(10);
                }
                WriteLine("count : 0");
            }

            catch (ThreadAbortException e)
            {
                WriteLine(e);

            }
            finally
            {
                WriteLine("리소스");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            sideTask task = new sideTask(100);

            Thread t1 = new Thread(new ThreadStart(task.keepAlive));


            t1.IsBackground = false;

            t1.Start();

            Thread.Sleep(100);

            t1.Interrupt();

            t1.Join();

            Console.WriteLine("Hello World!");
        }
    }
}
