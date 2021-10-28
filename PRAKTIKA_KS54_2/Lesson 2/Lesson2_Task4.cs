using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_2
{
    class Lesson2_Task4
    {
        public static void Start()
        {
            char[] chars = new char[50];

            new Thread(() =>
            {
                for (int i = 0; i <= chars.Length - 1; i += 2)
                {
                    chars[i] = 'Y';
                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 1; i <= chars.Length - 1; i += 2)
                {
                    chars[i] = 'Ы';
                }
            }).Start();

            foreach (var item in chars)
            {
                Console.Write(item + " ");
            }
        }
    }
}
