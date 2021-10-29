using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2
{
    class Task8
    {
        public struct kavo
        {
            public char symbol;
        }

        public static kavo[] Metod(string text)
        {
            kavo[] array = new kavo[text.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new kavo() { symbol = text[i] };
            }

            return array;
        }

        public static string Metod(kavo[] structures)
        {
            string text = "";

            for (int i = 0; i < structures.Length; i++)
            {
                text += structures[i].symbol;
            }

            return text;
        }
    }
}
