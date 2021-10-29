using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2
{
    class Lesson1_Task7
    {
        struct kavo
        {
            int a;
            int b;

            public kavo(int a, int b)
            {
                this.a = a;
                this.b = b;
            }

            public static kavo operator +(kavo a, kavo b)
            {
                return new kavo(a.a + b.a, b.a + b.b);
            }

            public static kavo operator -(kavo a, kavo b)
            {
                return new kavo(a.a - b.a, b.a - b.b);
            }

            public static kavo operator *(kavo a, kavo b)
            {
                return new kavo(a.a * b.a, b.a * b.b);
            }

            public static int operator +(kavo a)
            {
                return new[] { a.a, a.b }.Max();
            }

            public static int operator -(kavo a)
            {
                return new[] { a.a, a.b }.Min();
            }
        }

        public static void Start()
        {
            kavo kavo1 = new kavo(2, 10);

            int kavo3 = +kavo1;
        }
    }
}
