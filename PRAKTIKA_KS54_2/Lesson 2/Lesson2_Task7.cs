using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_2
{
    class Lesson2_Task7
    {
        public void Metod()
        {
            Random random = new Random();
            int[] array = new int[random.Next()];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
            }

            Thread first = new Thread(() =>
            {
                Console.WriteLine("Min " + array.Min());
            });
            Thread second = new Thread(() =>
            {
                Console.WriteLine("Max " + array.Max());
            });
            first.Start();
            second.Start();
        }
    }
}
