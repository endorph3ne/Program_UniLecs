using System;

/*
    Задача:  Поменять значения двух переменных без использования третьей.
*/

/*
    Идея: Использовать математические операции и XOR
*/

namespace Task17 {
    class Program {
        static void Main(string[] args) {
            int a = 3;
            int b = 5;

            SwapByXOR(ref a, ref b);

            Console.Read();
        }

        static void SwapByMathOperations(ref int a, ref int b) {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        static void SwapByXOR(ref int a, ref int b) {
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
        }
    }
}
