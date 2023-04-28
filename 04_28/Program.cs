using System;

namespace _04_28 메소드 4가지 형태
{
    class Program
    {
            //1.반환값이 없고, 매개변수도 없는 경우
            void minus1()
            {
                int a = 5, b = 3;
                Console.WriteLine("%d - %d = %d\n", a, b, a - b);
            }
            //2.반환값이 없고, 매개변수가 있는 경우
            void minus2(int a, int b)
            {
                Console.WriteLine("%d - %d = %d\n", a, b, a - b);
            }
            //3.반환값이 있고, 매개변수가 없는 경우
            void minus3()
            {
                int a = 5, b = 3;
                return (a - b);
            }
            //4.반환값이 있고, 매개변수도 있는 경우
            void minus4(int a, int b)
            {
                return (a - b);
            }
            void main()
            {
                minus1();
                minus2(10, 20);
                Console.WriteLine("minus3() 함수의 값 = %d\n", minus3()); //변환값
                Console.WriteLine("minus4() 함수의 값 = %d\n", minus4(20, 5)); //매개변수 + 변환값
            }
    }
}
