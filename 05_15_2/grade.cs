using System;
using System.Collections.Generic;
using System.Text;

namespace _05_15_2
{
    class grade
    {
        private int math;
        private int science;
        private int english;

        public grade(int math, int science, int english)
        {
            this.math = math;
            this.science = science;
            this.english = english;
        }

        public double average()
        {
            return (math + science + english) / 3.0;
        }
    }
}
