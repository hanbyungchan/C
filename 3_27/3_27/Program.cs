using System;

namespace _3_27
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("방향키 입력:");
            ConsoleKeyInfo info = Console.ReadKey();
            switch (info.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("위로 이동");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("오른쪽으로 이동");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("아래로 이동");
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("왼쪽으로 이동");
                    break;
                default:
                    Console.WriteLine("다른 키를 눌렀습니다.");
                    break;*/
            /*Console.Write("십의 자리 숫자:");
            int A = int.Parse(Console.ReadLine());
            Console.Write("일의 자리 숫자:");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine($"2자리 정수 입력(10-99) : {A}{B}.");
            if (A == B)
                Console.WriteLine("YES! 10의 자리와 1의 자리가 같습니다.");
            else if (A == 0)
                Console.WriteLine("10~99 사이의 정수만 입력하세요.");*/
            /*Console.Write("첫번째 정수:");
            int X = int.Parse(Console.ReadLine());
            Console.Write("두번째 정수:");
            int Y = int.Parse(Console.ReadLine());
            Console.Write("세번째 정수:");
            int Z = int.Parse(Console.ReadLine());

            if ((X < Y && Y < Z) || (Z < Y && Y < X))
            {
                Console.WriteLine("중간 값:" + Y);
            }
            else if ((Y < X && X < Z) || (Z < X && X < Y))
            {
                Console.WriteLine("중간 값:" + X);
            }
            else if ((Y < Z && Z < X) || (X < Z && Z < Y))
            {
                Console.WriteLine("중간 값:" + Z);
            }*/
            /*Console.Write("학점을 입력하시오:");
            int score = int.Parse(Console.ReadLine());

            if (90 <= score)
                Console.WriteLine("A학점");
            else if (80 <= score)
                Console.WriteLine("B학점");
            else if (70 <= score)
                Console.WriteLine("C학점");
            else if (60 <= score)
                Console.WriteLine("D학점");
            else
                Console.WriteLine("재수강으로 분발하세요.");*/
            /*Console.Write("숫자 입력:");
            int A = int.Parse(Console.ReadLine());
            Console.Write("숫자 입력:");
            int B = int.Parse(Console.ReadLine());
            Console.Write("연산자 입력:");
            char C = char.Parse(Console.ReadLine());

            if (C == '+')
                Console.WriteLine(A + B);
            else if (C == '-')
                Console.WriteLine(A - B);
            else if (C == '*')
                Console.WriteLine(A * B);
            else if (C == '/')
                Console.WriteLine(A / B);*/
            /*Console.Write("학점을 입력하시오:");
            int score = int.Parse(Console.ReadLine());

            switch (score)
            {
            (score / 10)
                case 10:
                case 9:
                Console.WriteLine("A학점");
                break;

                case 8:
                Console.WriteLine("B학점");
                break;

                case 7:
                Console.WriteLine("C학점");
                break;

                case 6:
                Console.WriteLine("D학점");
            default:
                Console.WriteLine("재수강으로 분발하세요.");
                break;*/
            Console.Write("숫자 입력:");
            int A = int.Parse(Console.ReadLine());
            Console.Write("숫자 입력:");
            int B = int.Parse(Console.ReadLine());
            Console.Write("연산자 입력:");
            char C = char.Parse(Console.ReadLine());

            switch (C)
            {
                case '+':
                Console.WriteLine(A + B);
                break;

                case '-':
                Console.WriteLine(A - B);
                break;

                case '*':
                Console.WriteLine(A * B);
                break;

                case '/':
                Console.WriteLine(A / B);
                break;
            }
        }
    }
}