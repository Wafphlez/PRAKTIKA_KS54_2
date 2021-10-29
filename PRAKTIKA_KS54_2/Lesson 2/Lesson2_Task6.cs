using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_2
{
    class Lesson2_Task6
    {
        class MyClass
        {
            public int[] nums;
            public char[] chars;
        }

        public void Start()
        {
            MyClass myClass = new MyClass();

            new Thread(() =>
            {
                Random random = new Random();
                myClass.nums = new int[random.Next(5, 20)];

                random = new Random();

                for (int i = 0; i < myClass.nums.Length; i++)
                {
                    myClass.nums[i] = random.Next(0, 10);
                }
            }).Start();

            new Thread(() =>
            {
                Random random = new Random();
                myClass.chars = new char[random.Next(5, 20)];

                for (int i = 0; i < myClass.nums.Length; i++)
                {
                    myClass.chars[i] = (char)random.Next(0, 1000);
                }

            }).Start();


        }


    }
}
