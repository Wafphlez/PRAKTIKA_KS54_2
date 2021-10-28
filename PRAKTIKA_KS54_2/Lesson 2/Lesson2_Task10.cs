using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_2
{
    class Lesson2_Task10
    {

        public static void Start()
        {
            double controlValue = 21.167168;

            double s = 0;

            Thread calc = new Thread(() =>
            {
                int n = 1;

                do
                {
                    s += (Math.Pow(2, n) * (n + 1) / Factorial(n));
                    n++;

                } while (true);

            });

            calc.Start();

            Thread.Sleep(100);

            calc.Abort();

            Console.WriteLine(s);
            Console.WriteLine(controlValue);
        }

        private static double Factorial(double n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
