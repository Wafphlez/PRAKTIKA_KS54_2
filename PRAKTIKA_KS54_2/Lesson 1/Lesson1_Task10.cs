using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2
{
    class Lesson1_Task10
    {
        struct kavo
        {
            int max, index;

            public static kavo Metod(int[] array)
            {
                int maximum = int.MinValue;

                int ind = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > maximum)
                    {
                        maximum = array[i];
                        ind = i;
                    }
                }

                return new kavo() { max = maximum, index = ind };
            }
        }
    }
}
