using System;

/*
    Задача: Напишите программу, которая будет печатать числа Фибоначчи максимально долго (без ошибок времени выполнения)
*/

/*
    Идея: 1. Фишка этой задачи, вовремя определить переполнение буфера и не получить Overflow Exception. 
          2. Есть еще одно похожее решение с использованием типа double. 
             На очередной итерации переведя сумму a + b в тип double мы можем избежать переполнения типа integer.
*/

namespace Task9 {
    class Program {
        static void Main(string[] args) {
            PrintFibonacci2(0, 1);
            Console.Read();
        }

        static void PrintFibonacci(int a, int b) {
            int sum = a + b;
            Console.WriteLine("{0}", sum);

            a = b;
            b = sum; 

            if (Int32.MaxValue - b > a)
                PrintFibonacci(a, b);
        }

        static void PrintFibonacci2(int a, int b) {
            if (0.0 + a + b < Int32.MaxValue) {
                double sum = a + b;
                Console.WriteLine("{0}", sum);

                a = b;
                b = (int)sum;

                PrintFibonacci2(a, b);
            }
        }
    }
}
