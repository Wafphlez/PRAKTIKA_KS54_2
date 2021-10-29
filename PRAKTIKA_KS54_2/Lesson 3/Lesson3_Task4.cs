using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_3
{
    class Lesson3_Task4
    {
        class MyClass<T>
        {
            private T myVar;

            public T MyProperty
            {
                get { return myVar; }
                set { myVar = value; }
            }
        }
    }
}
