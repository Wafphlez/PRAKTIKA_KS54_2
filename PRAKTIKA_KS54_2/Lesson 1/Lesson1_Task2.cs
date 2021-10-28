using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2
{
    class Lesson1_Task2
    {
        enum Week
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6
        };

        public static void Start()
        {
            FindDayOfWeekByDate();

            FindDifferenceBetweenDaysOfWeek();

            Console.ReadKey();
        }

        private static void FindDifferenceBetweenDaysOfWeek()
        {
            try
            {
                int rawInput1 = int.Parse(Console.ReadLine());
                int input1 = (rawInput1 - 1) % 7;

                Console.WriteLine((Week)input1);

                int rawInput2 = int.Parse(Console.ReadLine());
                int input2 = (rawInput2 - 1) % 7;

                Console.WriteLine((Week)input2);

                int r;

                if (input1 <= input2)
                {
                    r = Math.Abs(input1 - input2);
                }
                else
                {
                    r = Math.Abs(input1 - input2 - 7);
                }

                Console.WriteLine("Разница - " + r + " д.");

            }
            catch (Exception)
            {

            }
        }

        private static void FindDayOfWeekByDate()
        {
            try
            {
                int rawInput = int.Parse(Console.ReadLine());

                while (rawInput != 0)
                {

                    int input = (rawInput - 1) % 7;
                    int week = rawInput / 7 + 1;

                    Console.WriteLine((Week)input + " Week: " + week);

                    rawInput = int.Parse(Console.ReadLine());

                }

            }
            catch (Exception)
            {

            }
        }
    }
}
