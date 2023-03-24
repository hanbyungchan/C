using System;

namespace _03_24
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("첫번째 수 입력:");
             int A = int.Parse(Console.ReadLine());
             Console.Write("두번째 수 입력:");
             int B = int.Parse(Console.ReadLine());

             if (A>B)
                 Console.WriteLine($"두 수 중에 큰 수는 {A}이고, 작은 수는 {B}이다.");            
             else
                 Console.WriteLine($"두 수 중에 큰 수는 {B}이고, 작은 수는 {A}이다.");    
            */
            /*Console.Write("숫자 입력:");
            int A = int.Parse(Console.ReadLine());

            if (A > 0)
                Console.WriteLine($"{A}는 양수입니다.");
            else
            {
                if(A < 0)
                    Console.WriteLine($"{A}는 음수입니다.");
                else
                    Console.WriteLine($"{A}는 zero입니다.");
            }*/

            /*Console.Write("나이 입력:");
            double Y = double.Parse(Console.ReadLine());
            if (Y < 9)
                Console.WriteLine("입장 불가!");
            else
            {
                Console.Write("키 입력:");
                double H = double.Parse(Console.ReadLine());
                if (H >= 130)
                    Console.WriteLine("고속 롤러코스터 입장 가능");
                else
                    Console.WriteLine("저속 롤러코스터 입장 가능");
            }*/
            /*Console.Write("십의 자리 숫자:");
            int A = int.Parse(Console.ReadLine());
            Console.Write("일의 자리 숫자:");
            int B = int.Parse(Console.ReadLine());

                Console.WriteLine($"2자리 정수 입력(10-99) : {A}{B}.");
            if (A == B)
                Console.WriteLine("YES! 10의 자리와 1의 자리가 같습니다.");
            else
            {               
                if (A == 0)
                    Console.WriteLine("10~99 사이의 정수만 입력하세요.");
            }*/
            Console.Write("첫번째 정수:");
            int X = int.Parse(Console.ReadLine());
            Console.Write("두번째 정수:");
            int Y = int.Parse(Console.ReadLine());
            Console.Write("세번째 정수:");
            int Z = int.Parse(Console.ReadLine());

            if (X < Y)
            {
                if (Y < Z)
                Console.WriteLine("");
                else (Z < X)
                        Console.WriteLine("중간 값은 ");
            }
            else
            {
                if (Y =< Z)
                    Console.WriteLine("");
            }
        }
    }
}
