
using System;
using static System.Console;

namespace ConsoleApp6
{
    abstract class product
    {
        private static int serial = 0;
        public string serialID
        {
            get { return string.Format("{0:d5}", serial++); }
        }
        abstract public DateTime productdate
        {
            get;
            set;
        }
    }
    class myproduct : product
    {
        public override DateTime productdate
        {
            get;
            set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            product product_1 = new myproduct()
            {
                productdate = new DateTime(2018, 1, 10)
            };
            WriteLine("product: " + product_1.serialID +
            "product Date: " + product_1.productdate);


            product product_2 = new myproduct()
            { productdate = new DateTime(2018, 2, 3) };

            WriteLine("product: " + product_2.serialID +
            "product Date: " + product_2.productdate);

        }
    }
}
