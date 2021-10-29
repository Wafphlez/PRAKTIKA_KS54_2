using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2
{
    class Lesson1_Task6
    {
        struct kavo
        {
            private int a;
            private int b;
            private int c;

            public kavo(int a)
            {
                this.a = a;
                b = default;
                c = default;
            }

            public kavo(int a, int b)
            {
                this.a = a;
                this.b = b;
                c = default;
            }

            public kavo(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public int Min
            {
                get
                {
                    return new[] { a, b, c }.Min();
                }
                set
                {
                    throw new NotSupportedException();
                }
            }

            public int Max
            {
                get
                {
                    return new[] { a, b, c }.Max();
                }
            }

        }
    }
}
