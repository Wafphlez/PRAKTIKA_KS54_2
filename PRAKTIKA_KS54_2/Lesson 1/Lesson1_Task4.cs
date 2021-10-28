using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2
{
    class Lesson1_Task4
    {
        struct kavo
        {
            char[] chars;

            public kavo(string str)
            {
                chars = new char[str.Length];

                for (int i = 0; i < str.Length; i++)
                {
                    chars[i] = str[i];
                }
            }

            public kavo(char ch, int num)
            {
                chars = new char[num];

                for (int i = 0; i < chars.Length; i++)
                {
                    chars[i] = ch;
                }
            }

            char this[int num]
            {
                get
                {
                    return chars[num];
                }

                set
                {
                    chars[num] = value;
                }
            }

            public void Reverse()
            {
                chars.Reverse();
            }

            public override string ToString()
            {
                string newStr = "";

                for (int i = 0; i < chars.Length; i++)
                {
                    newStr += chars[i] + $"[{i}] ";
                }

                return newStr;
            }
        }

        public static void Start()
        {
            kavo kavo1 = new kavo("AbCdEfG");

            Console.WriteLine(kavo1.ToString());
            kavo1.Reverse();
            Console.WriteLine(kavo1.ToString());

        }
    }
}

