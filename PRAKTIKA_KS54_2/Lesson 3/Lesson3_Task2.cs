using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_3
{
    class Lesson3_Task2
    {
        public static void Start()
        {
            Metod("123", 123);

            Metod<byte, int>(1, 1);
        }

        private static void Metod<T, U>(T t, U u)
        {
            Console.WriteLine(t);
            Console.WriteLine(u);
        }

    }
}
