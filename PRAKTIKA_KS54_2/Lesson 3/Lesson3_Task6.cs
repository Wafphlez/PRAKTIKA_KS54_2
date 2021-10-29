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
            MyClass<int> myClass1 = new MyClass<int>();
            MyClass<string> myClass2 = new MyClass<string>();
            MyClass<bool> myClass3 = new MyClass<bool>();

            Type d1 = typeof(MyClass<>);

            //MyClass<>.GenerateChain(myClass1, myClass2, myClass3);
            //ERROR;
        }


        public class MyClass<T>
        {
            public T myVar;

            public MyClass<T> myClass;

            public static void GenerateChain(params MyClass<T>[] myClasses)
            {
                for (int i = 0; i < myClasses.Length; i++)
                {
                    myClasses[i].myClass = myClasses[i + 1];
                }
            }
        }
    }
}
