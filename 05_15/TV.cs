using System;
using System.Collections.Generic;
using System.Text;

namespace _05_15
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
    }
}
