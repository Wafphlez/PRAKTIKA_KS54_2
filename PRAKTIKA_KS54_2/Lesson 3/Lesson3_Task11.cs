using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_3
{
    class Lesson3_Task11
    {
        public static void Start()
        {
            MyClass<int, char> myClass1 = new MyClass<int, char>();

            myClass1.array1 = new int[] { 1, 2, 3 };
            myClass1.array2 = new char[] { 'a', 'b', 'c' };

            myClass1.Display();

            myClass1.Add(4, 'd');
            myClass1.Remove(1, 'a');

            myClass1.Display();
        }

        class MyClass<T, T1>
        {
            public T[] array1;
            public T1[] array2;

            public T this[int index]
            {
                get
                {
                    return array1[index];
                }
                set
                {
                    array1[index] = value;
                }
            }

            public void Add(T t, T1 t1)
            {
                List<T> list = new List<T>(array1);
                list.Add(t);
                array1 = list.ToArray();

                List<T1> list2 = new List<T1>(array2);
                list2.Add(t1);
                array2 = list2.ToArray();
            }

            public void Remove(T t, T1 t1)
            {
                List<T> list = new List<T>(array1);
                list.Remove(t);
                array1 = list.ToArray();

                List<T1> list2 = new List<T1>(array2);
                list2.Remove(t1);
                array2 = list2.ToArray();
            }

            public void Display()
            {
                foreach (var item in array1)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                foreach (var item in array2)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

            }

        }
    }
}
