
using Generic;
using System;

namespace Generic
{

    class Mylist<T>
    {
        private T[] array;

        public Mylist()
        {
            array = new T[3];
        }

        public T this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine("배열 길이 재정의 : " + array.Length);

                }

                array[index] = value;
            }
        }

        public int length
        {
            get { return array.Length; }
        }

    }
}
class Program
{
    static void Main(string[] args)
    {
        Mylist<string> str_list = new Mylist<string>();
        str_list[0] = "abc";
        str_list[1] = "abc";
        str_list[2] = "abc";
        str_list[3] = "abc";
        str_list[4] = "abc";




        Mylist<int> int_list = new Mylist<int>();
        int_list[0] = 0;
        int_list[1] = 0;
        int_list[2] = 0;
        int_list[3] = 0;
        int_list[4] = 0;




        Console.WriteLine("Hello World!");
    }
}
