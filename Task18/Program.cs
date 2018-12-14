using System;

/*
    Задача: Дан массив натуральных чисел. Каждое из чисел присутствует в массиве ровно два раза, кроме одного. Найти число без пары.
*/

/*
    Идея: Воспользуемся операцией XOR (побитовое ИЛИ) и ее свойствами.
                a XOR a = 0
                a XOR 0 = a
                a XOR b = b XOR a
          Выполним XOR операцию для всех элементов массива:
                a1 XOR a2 XOR ..... an
          В результате парные элементы "обнулятся" и останется искомый элемент
*/

namespace Task18 {
    class Program {
        static void Main(string[] args) {
            int[] array = { 0, 4, -1, 5, -1, 4, 0 };
            Console.WriteLine(GetUniqueNumbeInArray(array));
            Console.Read();
        }

        static int GetUniqueNumbeInArray(int[] array) {
            int result = 0;

            if (array == null || array.Length == 0)
                return -1;

            for (int i = 0; i < array.Length; i++)
                result ^= array[i];

            return result;
        }
    }
}
