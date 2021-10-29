using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2
{
    class Lesson1_Task11
    {
        struct kavo
        {
            public int num;

            public static kto operator +(kavo first, kavo second)
            {
                return new kto() { a = first.num, b = second.num };
            }
        }

        struct kto
        {
            public int a, b;

            public kavo[] GetFirsts()
            {
                return new kavo[] { new kavo() { num = a }, new kavo() { num = b } };
            }
        }
    }
}
