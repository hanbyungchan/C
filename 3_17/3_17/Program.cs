using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //01 단위변환 (inch -> cm)
            /*
            Console.WriteLine("inch 입력 : ");
            string inch = Console.ReadLine();
            int inch2 = int.Parse(inch);
            Console.WriteLine(inch2 + "inch =" + inch2 * 2.54 + "cm");
            

            //02 사칙연산 프로그램
            Console.Write("1. 첫번째 정수입력 :");
            string first = Console.ReadLine();
            Console.Write("2. 두번째 정수입력 :");
            string second = Console.ReadLine();

            int first2 = int.Parse(first);
            int second2 = int.Parse(second);

            Console.WriteLine(first2 + "+" + second2 + "=" + (first2 + second2));
            Console.WriteLine(first2 + "-" + second2 + "=" + (first2 - second2));
            Console.WriteLine(first2 + "*" + second2 + "=" + (first2 * second2));

            double a = first2;
            double b = second2;

            double number = (a / b);
            Console.WriteLine(number.ToString(first2 + "/" + second2 + "=" + "0.00"));
            

            //03 원의 공식
            Console.Write("원의 반지름 입력 : ");
            string A = Console.ReadLine();
            int A2 = int.Parse(A);

            double PI = 3.14159;
            double number1 = (2 * PI * A2);
            Console.WriteLine(number1.ToString("둘레 = " + "0.000"));

            double number2 = (2 * A2 * A2);
            Console.WriteLine(number2.ToString("넓이 = " + "0.000"));
            */

            //04 문자 계산 프로그램
            Console.Write("문자 입력 : ");
            int s1 = Console.Read();

            Console.WriteLine("1. 연산 수행 전");
            Console.WriteLine("- 아스키 코드 값 : " + s1);
            Console.WriteLine("- 변형된 문자 출력 :" + Convert.ToChar(s1));

            Console.WriteLine("2. 연산 수행 후");
            Console.WriteLine("- 아스키 코드 값 : " + (s1 + 5));
            Console.WriteLine("- 변형된 문자 출력 :" + Convert.ToChar(s1 + 5));



        }
    }
}
