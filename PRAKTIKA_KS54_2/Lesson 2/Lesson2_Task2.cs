using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PRAKTIKA_KS54_2.Lesson_2
{
    class Lesson2_Task2
    {
        public static void Start()
        {
            Thread factorial = new Thread(GetFactorial);
            factorial.Start();
            
            Thread factorial2 = new Thread(GetFactorial2);
            factorial2.Start();

            Thread fibonacci = new Thread(GetFibonacci);
            fibonacci.Start();
        }

        private static void GetFactorial()
        {
            int n =10;

            Thread.Sleep(1000);

            Console.WriteLine($"Factorial of {n} = {Factorial(n)}");
        }

        private static int Factorial(int n)
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

        private static void GetFactorial2()
        {
            int n = 5;

            Thread.Sleep(2000);

            Console.WriteLine($"Factorial2 of {n} = {Factorial2(n)}");
        }

        private static long Factorial2(long n)
        {
            long result = 1;

            for (int i = n % 2 == 0 ? 2 : 1; i <= n; i += 2)
            {
                result *= i;
            }

            return result;
        }

        private static void GetFibonacci()
        {
            int n = 5;

            Thread.Sleep(3000);

            Console.WriteLine($"Fibonacci of {n} = {Fibonacci(n)}");
        }

        private static int Fibonacci(int n)
        {
            int num = n - 1;

            int[] fib = new int[num + 1];

            fib[0] = 1;
            fib[1] = 1;

            for (int i = 2; i <= num; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
            }

            return fib[num];
        }
    }
}
