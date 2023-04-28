using System;

namespace _04_28_3
{
    class Program
    {
        public void Multiply(int min, int max)
        {
            int output = 1;
            for (int i = min; i <= max; i++)
            {
                output *= i;
                for (int j = min; j <= max + 1; j++)
                    Console.Write('★');
            }
        }
        static void Main(string[] args)
        {
            Console.Write("정수 하나 입력:");
            int a = int.Parse(Console.ReadLine());
            Multiply(0,a);
            
        }
    }
}
