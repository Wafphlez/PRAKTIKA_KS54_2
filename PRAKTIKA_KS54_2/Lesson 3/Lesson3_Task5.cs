using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_3
{
    class Lesson3_Task5
    {
        class MyClass<T>
        {
            T[] array;

            public T this[int index]
            {
                get
                {
                    return array[index];
                }
                set
                {
                    array[index] = value;
                }
            }
        }
    }
}
