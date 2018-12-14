using System;

/*
    Задача: Дан массив натуральных чисел. Каждое из чисел присутствует в массиве ровно два раза, кроме одного. Найти число без пары.
*/

/*
    Идея:
          1. Вариант с одним уникальным числом
             ---------------------------------
             Воспользуемся операцией XOR (побитовое ИЛИ) и ее свойствами.
                    a XOR a = 0
                    a XOR 0 = a
                    a XOR b = b XOR a
             Выполним XOR операцию для всех элементов массива:
                    a1 XOR a2 XOR ..... an
             В результате парные элементы "обнулятся" и останется искомый элемент

          2. Вариант с двумя уникальными числами
             -----------------------------------
             Если просто сделать xor всех чисел в массиве, понятно что результатом будет first^second - xor двух непарных чисел.
             Давайте сделаем xor всех чисел, у которых в бите i допустим 1. 
             При xor'е всех чисел у которых i-й бит равен 1 некоторые пары одинаковых чисел попадут в "один набор", другие в другой.
             В любом случае xor парных чисел будет равен нулю, но при этом в 1й блок попадет лишь одно из непарных чисел. 
             В итоге мы получим first или second.  Так как у нас есть значение first^second, то мы получим и второе число.
*/

namespace Task18 {
    class Program {
        static void Main(string[] args) {
            int[] array = { 0, 4, -1, 7, -1, 4, 9, 0 };
            int first;
            int second;

            GetUniqueNumbersInArray(array, out first, out second);
            Console.WriteLine("first - {0}", first);
            Console.WriteLine("second - {0}", second);
            Console.Read();
        }

        static int GetUniqueNumberInArray(int[] array) {
            int result = 0;

            if (array == null || array.Length == 0)
                return -1;

            for (int i = 0; i < array.Length; i++)
                result ^= array[i];

            return result;
        }

        static void GetUniqueNumbersInArray(int[] array, out int first, out int second) {
            int xor = 0;
            first = 0;
            second = 0;

            if (array == null || array.Length == 0)
                return;

            // xor для каждого элемента
            for (int i = 0; i < array.Length; i++)
                xor ^= array[i];

            // берем крайний правый ненулевой бит
            // в нашем примере, xor = 14 (1110); 13 (1101)
            int rightBit = xor & ~(xor - 1); //  2 (0010)


            // Находим xor для всех элементов у которых этот бит установлен в 1
            for (int i = 0; i < array.Length; i++) {
                if ((array[i] & rightBit) > 0)
                    first ^= array[i];
            }

            // second = first ^ (first^second)
            second = first ^ xor;
        }
    }
}
