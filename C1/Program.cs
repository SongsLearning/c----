using System;

namespace _6._4RefRetrun
{
    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price :{price}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Product carrot = new Product();//1.메모리 지정
            ref int ref_local_price = ref carrot.GetPrice();//2.주소형식을 통한 주소 반환
            int normal_local_price = carrot.GetPrice();//3. 결과 값만 반환

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price :{ref_local_price}");//2.1 주소에 있는 값 출력
            Console.WriteLine($"Normal Local Price :{normal_local_price}");//3.1 결과 값만 출력

            ref_local_price = 200;//원본값을 변경

            carrot.PrintPrice();//2.2 price값 변경
            Console.WriteLine($"Local Price :{ref_local_price}");
            Console.WriteLine($"Normal Local Price :{normal_local_price}");
        }
    }
}