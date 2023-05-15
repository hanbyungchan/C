using System;

namespace _05_15_2
{
    class Program
    {
          private static void Main(string[] args)
          {
            Console.WriteLine("수학 성적 입력:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("과학 성적 입력:");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("영어 성적 입력:");
            int e = int.Parse(Console.ReadLine());

            grade grade = new grade(m, s, e);
            Console.WriteLine("세 과목의 평균:" + grade.average());
            //Console.WriteLine(grade.ToString("0.00"));
          }
    }
}
