using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2
{
    class Lesson1_Task9
    {
        struct kavo
        {
            public string text;

            public kto Metod(int a)
            {
                return new kto() { symbol = text[a] };
            }
        }
        struct kto
        {
            public char symbol;
        }
    }
}
