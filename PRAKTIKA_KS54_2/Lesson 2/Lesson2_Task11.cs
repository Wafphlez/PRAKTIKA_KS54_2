using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_2
{
    class Lesson2_Task11
    {
        public double result = 1;
        public void Metod()
        {
            Thread thread = new Thread(() =>
            {
                int n = 2;
                while (true)
                {
                    result *= (Math.Pow(n, 3) - 1) / (Math.Pow(n, 3) + 1);
                    n++;
                }
            });
            thread.Start();
            Thread.Sleep(5000);
            thread.Abort();
            Console.WriteLine(result);
        }
    }
}
