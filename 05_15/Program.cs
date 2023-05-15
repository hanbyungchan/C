using System;

namespace _05_15
{
    /* internal class Program
     {

         class TV
         {
             public string company;
             public int year;
             public int TVinch;

             public TV(string company, int year, int TVinch)
             {
                 this.company = company;
                 this.year = year;
                 this.TVinch = TVinch;
             }

             public void show()
             {
                 Console.WriteLine($"{company}에서 만든 {year}년 {TVinch}인치");
             }
             private static void Main(string[] args)
             {
                 TV myTV = new TV("LG", 2017, 32);// LG에서 만든 2017년 32인치
                 myTV.show();
             }
         }
     }*/

    //class TV
    //{
    //    public string company;
    //    public int year;
    //    public int TVinch;

    //    public TV(string company, int year, int TVinch)
    //    {
    //        this.company = company;
    //        this.year = year;
    //        this.TVinch = TVinch;
    //    }

    //    public void show()
    //    {
    //        Console.WriteLine($"{company}에서 만든 {year}년 {TVinch}인치");
    //    }
        internal class Program
        {
            private static void Main(string[] args)
            {
                TV myTV = new TV("LG", 2017, 32);// LG에서 만든 2017년 32인치
                myTV.show();
            }
        }
    //}
}
