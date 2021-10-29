using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_2
{
    class Lesson2_Task5
    {
        int[] array = new int[26];

        public void Metod()
        {
            Thread first = new Thread(() =>
            {
                int i = 0;
                while (true)
                {
                    if (array.Length / 2 < i) break;
                    array[i] = (int)Math.Pow(2, i);
                    i++;
                }
            });

            Thread second = new Thread(() =>
            {
                int i = 0;
                while (true)
                {
                    if (array.Length / 2 < i) break;
                    array[array.Length - 1 - i] = (int)Math.Pow(3, i);
                    i++;
                }
            });

            first.Start();

            second.Start();
        }
    }
}
