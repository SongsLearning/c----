using System;

namespace ConsoleApp13
{

    delegate int Compare(int a, int b);


    class mainapp
    {
        public static void bubblesort(int[] Dataset, Compare compare)
        {

            int temp;


            for (int i = 0; i < Dataset.Length - 1; i++)
            {
                for (int j = 0; j < Dataset.Length - (i + 1); j++)
                {
                    if (compare(Dataset[j], Dataset[j + 1]) > 0)
                    {
                        temp = Dataset[j + 1];
                        Dataset[j + 1] = Dataset[j];
                        Dataset[j] = temp;
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

            mainapp.bubblesort(array, delegate (
            int a, int b)
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
            });


            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }




        }
    }
}
