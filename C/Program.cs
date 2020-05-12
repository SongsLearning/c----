using System;

namespace Overloading
{
    class MainApp
    {//1. 매개변수 형식에 따라 호출되는 오버로딩
        static int Plus(int a, int b)
        {
            Console.WriteLine("Calling int Plus(int,int)...");
            return a + b;
        }

        static int Plus(int a, int b, int c)
        {
            Console.WriteLine("Calling int Plus(int,int,int)...");
            return a + b + c;
        }

        static double Plus(double a, double b)
        {
            Console.WriteLine("Calling double Plus(double,double)...");
            return a + b;
        }

        static double Plus(int a, double b)
        {
            Console.WriteLine("Calling double Plus(int, double)...");
            return a + b;
        }

        //2. 형식은 같으나 매개 변수의 개수만 유연하게 달라질 수 있는 경우에 적합.

        static int Sum(params int[] args)
        {
            Console.Write("Summing... ");

            int sum = 0;

            for (int i = 0; i < args.Length; i++)
            {
                if (i > 0)
                    Console.Write(", ");

                Console.Write(args[i]);

                sum += args[i];
            }
            Console.WriteLine();

            return sum;
        }

        //3. 순서와 상관없이 처리된 매개변수 -> 명명된 매개 변수 이름을 근거로 데이터를 할당
        // 매개 변수 이름 : 값

        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine("Name:{0}, Phone:{1}", name, phone);
        }
        //4. 기본값을 할당하는 매개변수-> string phone = "" 전화번호가 없을 수도 있다. 없을 경우 공백이 기본
        static void PrintProfile1(string name, string phone = "")
        {
            Console.WriteLine("Name:{0}, Phone:{1}", name, phone);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Plus(1, 2));
            Console.WriteLine(Plus(1, 2, 3));
            Console.WriteLine(Plus(1.0, 2.4));
            Console.WriteLine(Plus(1, 2.4));

            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);

            Console.WriteLine("Sum : {0}", sum);

            //명명된 매개변수 -> 가독성에 도움을 준다.
            PrintProfile(name: "박찬호", phone: "010-123-1234");
            PrintProfile(phone: "010-987-9876", name: "박지성");
            PrintProfile("박세리", "010-222-2222");
            PrintProfile("박상현", phone: "010-567-5678");

            //선택적 매개변수

            PrintProfile1("태연");
            PrintProfile1("윤아", "010-123-1234");
            PrintProfile1(name: "유리");
            PrintProfile1(name: "서현", phone: "010-789-7890");
        }
    }
}