using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_3
{
    class Lesson3_Task6
    {
        public static void Start()
        {
            MyClass<int> myClass1 = new MyClass<int>() { myVar = 1 };
            MyClass<int> myClass2 = new MyClass<int>() { myVar = 2 };
            MyClass<int> myClass3 = new MyClass<int>() { myVar = 3 };

            myClass2.myClass = myClass3;
            myClass1.myClass = myClass2;

            myClass1.Metod();
        }


        public class MyClass<T>
        {
            public T myVar;

            public MyClass<T> myClass;

            public void Metod()
            {
                Console.WriteLine(myVar);

                if (myClass != null) myClass.Metod();
            }
        }
    }
}
