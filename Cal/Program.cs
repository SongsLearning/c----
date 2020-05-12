
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 숫자 0 할당
            int num1 = 0; int num2 = 0;

            // 타이틀 출력
            Console.WriteLine("C# 콘솔 계산기\r");
            Console.WriteLine("------------------------\n");

            // 첫번째 숫자를 입력 받는다.
            Console.WriteLine("숫자를 입력하고 엔터를 눌러주세요");
            num1 = Convert.ToInt32(Console.ReadLine());

            // 두번째 숫자를 입력 받는다.
            Console.WriteLine("또 다른 숫자를 입력하고 엔터를 눌러주세요");
            num2 = Convert.ToInt32(Console.ReadLine());

            // 옵션 선택
            Console.WriteLine("다음은 옵션 리스트입니다.:");
            Console.WriteLine("\ta - 더하기");
            Console.WriteLine("\ts - 빼기");
            Console.WriteLine("\tm - 곱하기");
            Console.WriteLine("\td - 나누기");
            Console.Write("옵션을 선택해 주세요 ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"결과: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"결과: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"결과: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"결과: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // 앱 닫기
            Console.Write("아무키나 눌러 앱을 종료해주세요...");
            Console.ReadKey();
        }
    }
}