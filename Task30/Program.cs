using System;

//Найти максимальный элемент без использования if/else и других операторов сравнения

/*
    Идея: воспользуемся битовыми операциями. Если у нас есть два числа a, b.
    Вычислим разность k = (a - b) и проверим знак k.
    Если k >= 0, то вернем 1. В этом случае a, b либо равны, либо a > b.
    Если k < 0, то 0. В этом случае a < b.
    Соот-но получаем: a * k + b * (1 ^ k); // 1 ^ k делает реверт 1 или 0.
*/

namespace Task30 {
class Program {
    static void Main(string[] args) {
        Console.WriteLine("UniLecs {0}");
        Console.WriteLine("Max = {0}", getMaxValue(10, 5));
        Console.WriteLine("Max = {0}", getMaxValue(-10, -5));
        Console.WriteLine("Max = {0}", getMaxValue(-1, 0));
        Console.WriteLine("Max = {0}", getMaxValue(1, 0));
        Console.WriteLine("Max = {0}", getMaxValue(1, 1));
        Console.WriteLine("Max = {0}", getMaxValue(-11, -11));
    }

    // x >= 0 -> 1
    // x < 0 -> 0
    static int sign(int x) {
        return ((x >> 31) & 1) ^ 1;
    }

    static int getMaxValue(int a, int b) {
        int signAB = sign(a - b);
        return a * signAB + (1 ^ signAB) * b;
    }
}
}
