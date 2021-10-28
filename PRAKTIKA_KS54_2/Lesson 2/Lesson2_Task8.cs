using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_2
{
    class Lesson2_Task8
    {
        static int[,] nums = new int[10, 10];

        public static void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                new Thread(() =>
                {
                    for (int j = 0; j < 10; j++)
                    {
                        nums[i, j] = (int)Math.Pow((i + 2), j);
                    }

                }).Start();
                Thread.Sleep(100);
            }
        }
    }
}
