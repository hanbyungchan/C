using System;

namespace _04_28_2
{
    class Program
    {
        class Test
        {

            static void Main(string[] args)
            {
                //Test test = new Test();
                Console.Write("정수 하나 입력:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(Power(a));
                minus1();
                minus2(10, 20);
                Console.WriteLine("minus3{} 메서드 = " + minus3());
                Console.WriteLine("minus4{} 메서드 = " + minus4());
            }
            public static int Power(int x) //void Main 위에 있어도 되고, 아래 있어도 됨(어디서든 참조 가능)
            {
                return x * x;
            }
            //1.변환값X, 매개변수X
            public static void minus1()
            {
                int a = 5, b = 2;
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            }
            //2.변환값X, 매개변수O
            public static void minus2()
            {
                Console.WriteLine("{0} - {1} = {2}");
            }
            //3.변환값O, 매개변수X
            public static void minus3()
            {
                int a = 5, b = 3;
                return (a - b);
            }
            //4.변환값O, 매개변수O
            public static void minus4()
            {
                return (a - b);
            }
        }

    }
}
