using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_3
{
    class Lesson3_Task8<T> : IComparable<T>
    {
        public static void Start()
        {

        }

        private static void Metod<T>(T[] array)
        {
            //ERROR;
        }

        public int CompareTo(T other)
        {
            if (other == null) return 1;

            return 0;
        }
    }
}
