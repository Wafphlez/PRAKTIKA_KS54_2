using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_3
{
    class Lesson3_Task3
    {
        public static void Start()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Metod(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        private static void Metod<T>(T[] t)
        {
            T a = t[t.Length - 1];

            Array.Copy(t, 0, t, 1, t.Length - 1);

            t[0] = a;
        }

    }
}
