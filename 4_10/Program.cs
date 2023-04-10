using System;

namespace _4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Random r = new Random();
            int[] intArray = new int[6];
            for (int i = 0; i < 6; i++)
                intArray[i] = r.Next(1, 46); //1~45까지 숫자
            Console.WriteLine("생성된 6개의 랜덤한 숫자 출력:");

            for (int i = 0; i < 6; i++)
                Console.Write("{0,5}", intArray[i]);*/

            /*Console.Write("나이 입력:");
            double Y = double.Parse(Console.ReadLine());
            for (int i = 0; i < 100; i++)
            {
                string input = "exit";
                Console.WriteLine(input.ToLower());
            }
            eak;
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

            for (; ; )
            {
                Console.WriteLine("정수 하나 입력:");
                int num = int.Parse(Console.ReadLine());
                if (num==0)
                {
                    Console.WriteLine("종료");
                    break;
                }
                Console.WriteLine("1-{0}까지 2의 배수이면서, 3의 배수가 아닌 수", num);
                for (int i = 1; i <= num; i++)
                    if (i % 2 == 0 && i % 3 != 0)
                        Console.Write("{0,4}", i);
                Console.WriteLine();
            }
        }
    }
}