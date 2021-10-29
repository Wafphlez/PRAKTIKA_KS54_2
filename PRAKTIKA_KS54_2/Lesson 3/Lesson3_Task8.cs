using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_3
{
    class Lesson3_Task8
    {
        public static T[] Metod<T>(T[] array) where T : IComparable
        {
            T[] sortedArray = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) == 1)
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return sortedArray;
        }
    }
}
