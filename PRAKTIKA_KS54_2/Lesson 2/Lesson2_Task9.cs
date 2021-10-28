using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_2
{
    class Lesson2_Task9
    {
        Random random = new Random();
        public void Metod()
        {
            char[,] array = new char[random.Next(20), random.Next(20)];
            var len = array.GetLength(0);
            for (int i = 0; i < len; i++)
            {
                new Thread(() => ThreadMetod(i, array)).Start();
                Thread.Sleep(10);
            }
        }
        public void ThreadMetod(int i, char[,] array)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = (char)random.Next();
            }
        }
    }
}
