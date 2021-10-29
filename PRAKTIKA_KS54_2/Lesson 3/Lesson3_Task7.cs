using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_3
{
    class Lesson3_Task7
    {
        public static (T, T) Metod<T>(T[] array) where T : IComparable
        {
            T min = array[0], max = array[0];

            foreach (var item in array)
            {
                if (item.CompareTo(max) == 1)
                {
                    max = item;
                }
                if (item.CompareTo(min) == -1)
                {
                    min = item;
                }
            }

            return (min, max);
        }
    }
}
