using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2
{
    class Lesson1_Task5
    {
        struct kavo
        {
            int[] nums;

            public kavo(int num)
            {
                nums = new int[num];

                Random random = new Random();
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = random.Next(0, 10);
                }
            }

            public int GetMax()
            {
                return nums.Max();
            }

            public int GetMin()
            {
                return nums.Min();
            }

            public double GetAvg()
            {
                return nums.Average();
            }

        }
    }
}
