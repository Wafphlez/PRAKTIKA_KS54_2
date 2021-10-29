using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_3
{

    class Lesson3_Task9
    {
        public static void Start()
        {
            Metod("123");
            Metod('s');
            Metod(11);
            Metod(false);
        }

        public static void Metod<T>(T t)
        {
            Console.WriteLine("WHAT?");
        }

        public static void Metod(char t)
        {
            Console.WriteLine("CHAR");
        }

        public static void Metod(int t)
        {
            Console.WriteLine("INT");
        }



    }
}
