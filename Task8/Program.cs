using System;

/*
    Задача: Дан массив целых чисел. Вывести максимальную сумму элементов в массиве. 
    Суммировать элементы можно только последовательно.
*/

/*
    Идея: будем использовать два обычных счетчика для подсчета суммы элементов. 
    Также, учитывая, что числа могут быть отрицательными, добавим еще одно условие. 
    В случае если локальная сумма будет меньше текущей максимальной, 
    то сравним отдельно последний элемент с максимальной суммой.
*/

namespace Task8 {
    class Program {
        static void Main(string[] args) {
            int[] array = { 1, 5, 7, -20, 3, 100, -250, 88, 33, 1, -40, 120 };
            Console.WriteLine(FindMaxSum(array));
            Console.Read();
        }

        static int FindMaxSum(int[] array) {
            int sum = 0; int maxSum = int.MinValue;

            if (array.Length == 0)
                return -1;
            
            for (int i = 0; i < array.Length; i++) {
                sum += array[i];

                if (sum > maxSum)
                    maxSum = sum;

                if (sum < 0)
                    sum = 0;
            }

            return maxSum;
        }
    }
}
