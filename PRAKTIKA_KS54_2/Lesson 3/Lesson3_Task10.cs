using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_3
{
    class Lesson3_Task10
    {
        public class Myclass<T>
        {
            T[] array;

            public static Myclass<T> operator +(Myclass<T> a, Myclass<T> b)
            {
                Myclass<T> myclass = new Myclass<T>();
                List<T> list = new List<T>();

                list.AddRange(a.array);
                list.AddRange(b.array);

                myclass.array = list.ToArray();

                return myclass;
            }

        }
    }
}
