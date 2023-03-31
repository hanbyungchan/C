using System;

namespace _3_31
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] intArray = new int[100];

            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[99]);*/

            /*int i = 0;
            int[] intArray = { 52, 273, 32, 65, 103 };

            while (i < intArray.Length)
            {
                Console.WriteLine(i + "번째 출력:" + intArray[i]);
                i++;*/

            /*int i = 0;
            int[] intArray = new int[3];
            Console.WriteLine("정수 3개 입력");

            while (i < intArray.Length)
            {
                Console.Write("{0}번째 입력:", i+1);
                intArray[i] = int.Parse(Console.ReadLine());
                i++;
            }
            i = 0;
            while (i < intArray.Length)
            {
                Console.WriteLine(i + "번째 출력:" + intArray[i]);
                i++;
            }*/

            /*int i = 0;
            Console.Write("배열의 크기(개수) 입력: ");
            int size = int.Parse(Console.ReadLine());
            int[] intArray = new int[size];

            Console.WriteLine($"정수 {size}개 입력");

            while (i < intArray.Length)
            {
                Console.Write("{0}번째 입력:", i + 1);
                intArray[i] = int.Parse(Console.ReadLine());
                i++;
            }
            i = 0;
            while (i < intArray.Length)
            {
                Console.WriteLine(i + "번째 출력:" + intArray[i]);
                i++;
            }*/

            int i = 0, hap = 0;
            Console.Write("배열의 크기(개수) 입력: ");
            int size = int.Parse(Console.ReadLine());
            int[] intArray = new int[size];

            Console.WriteLine($"정수 {size}개 입력");

            while (i < intArray.Length)
            {
                Console.Write("{0}번째 입력:", i + 1);
                intArray[i] = int.Parse(Console.ReadLine());
                i++;
            }
            i = 0;
            while (i < intArray.Length)
            {
                Console.WriteLine(i + "번째 출력:" + intArray[i]);
                hap += intArray[i];
                i++;
            }
            Console.WriteLine("합 출력:" + hap);
        }
    }
}
