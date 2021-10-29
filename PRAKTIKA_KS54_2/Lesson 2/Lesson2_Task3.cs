using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_2
{
    class Lesson2_Task3
    {
        int number = 0;
        public void Metod()
        {
            Thread thread1 = new Thread(() =>
            {
                while (true)
                {
                    if (number % 2 == 1) Console.WriteLine("Проверка прошла успешно");
                    Thread.Sleep(1000);
                }
            });

            Thread thread2 = new Thread(() =>
            {
                while (true)
                {
                    if (number % 3 == 0) Console.WriteLine("Проверка прошла успешно");
                    Thread.Sleep(1500);
                }
            });

            thread1.Start();

            thread2.Start();

            while (true)
            {
                number = new Random().Next();
                Thread.Sleep(500);
            }
        }
    }
}
