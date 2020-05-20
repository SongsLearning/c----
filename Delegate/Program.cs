using System;
using System.Data;
using System.Runtime.InteropServices;

namespace ConsoleApp6
{
    delegate int compare(int a, int b);

    class myapp
    {
        public static int Ascend(int a, int b)
        {
            if (a > b)
            {
                return 1;
            }
            else if (a == b)
            {
                return 0;
            }
            else
                return -1;
        }

        public static int DeAscend(int a, int b)
        {
            if (a < b)
            {
                return 1;
            }
            else if (a == b)
            {
                return 0;
            }
            else
                return -1;
        }

        public static void bubble(int[] dataset, compare compare)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for (i = 0; i < dataset.Length - 1; i++)
            {
                for (j = 0; j < dataset.Length - (i + 1); j++)
                {
                    if (compare(dataset[j], dataset[j + 1]) > 0)
                    {
                        temp = dataset[j + 1];
                        dataset[j + 1] = dataset[j];
                        dataset[j] = temp;
                    }

                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };

            myapp.bubble(array, new compare(myapp.Ascend));

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}