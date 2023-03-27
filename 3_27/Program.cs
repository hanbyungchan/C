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
            Console.Write("숫자 입력:");
            int A = int.Parse(Console.ReadLine());
            Console.Write("숫자 입력:");
            int B = int.Parse(Console.ReadLine());
            Console.Write("연산자 입력:");
            bool C = bool.Parse(Console.ReadLine());

            if (C = +)
                Console.WriteLine(A + B);
            else if (C = -)
                Console.WriteLine(A - B);
            else if (C = *)
                Console.WriteLine(A * B);
            else if (C = /)
                Console.WriteLine(A / B);
            /*Console.Write("학점을 입력하시오:");
            int score = int.Parse(Console.ReadLine());

            switch (score)
            {
                case 100:
                case 99:
                case 98:
                case 97:
                case 96:
                case 95:
                case 94:
                case 93:
                case 92:
                case 91:
                case 90:
                Console.WriteLine("A학점");
                break;
                case 89:
                case 88:
                case 87:
                case 86:
                case 85:
                case 84:
                case 83:
                case 82:
                case 81:
                case 80:
                Console.WriteLine("B학점");
                break;
                case 79:
                case 78:
                case 77:
                case 76:
                case 75:
                case 74:
                case 73:
                case 72:
                case 71:
                case 70:
                Console.WriteLine("C학점");
                break;
                case 69:
                case 68:
                case 67:
                case 66:
                case 65:
                case 64:
                case 63:
                case 62:
                case 61:
                case 60:
                Console.WriteLine("D학점");
            default:
                Console.WriteLine("재수강으로 분발하세요.");
                break;*/
        }
    }
}