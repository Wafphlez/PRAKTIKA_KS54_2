using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2
{
    class Lesson1_Task3
    {
        private struct kavo
        {
            int num;
            string str;
            char sym;


            public kavo(int num, string str, char sym)
            {
                this.num = num;
                this.str = str;
                this.sym = sym;
            }

            public kavo(int num, string str)
            {
                this.num = num;
                this.str = str;
                this.sym = default;
            }

            public kavo(string str)
            {
                this.num = default;
                this.str = str;
                this.sym = default;
            }   

            public void ShowValues()
            {
                Console.WriteLine("num : "+num);
                Console.WriteLine("str : "+str);
                Console.WriteLine("sym : "+sym);
            }
        }

        public static void Start()
        {
            var kavo1 = new kavo(1, "abba", 'a');
            kavo1.ShowValues();
        }
    }
}
