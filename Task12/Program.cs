using System;
using System.Collections.Generic;

/*
    Задача: Дан числовой массив. Проверить, есть ли такие два числа в массиве, перемножив которые мы получим заданное число X.
*/

/*
    Идея: Заведем обьект HashMap: число -> количество вхождений в массив.
          Дальше каждый элемент из HashMap будем проверять на делитель числа X.    
*/

namespace Task12 {
    class Program {
        static void Main(string[] args) {
            int[] array = { 1, 0, 3, 3, -10 };
            Console.WriteLine(ContainsDividers(array, 9));
            Console.Read();
        }

        static bool ContainsDividers(int[] array, int x) {
            Dictionary<int, int> amountNumberTable = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++) {
                int currentNumber = array[i];

                if (currentNumber == 0)
                    continue;

                //Заполняем таблицу возможных делителей
                if (amountNumberTable.ContainsKey(currentNumber))
                    amountNumberTable[currentNumber]++;
                else
                    amountNumberTable.Add(currentNumber, 1);
            }

            foreach (int currentKey in amountNumberTable.Keys) {
                //Если делители одинаковы и их больше 1-го
                if (currentKey * currentKey == x && amountNumberTable[currentKey] > 1)
                    return true;

                int secondDvider = x / currentKey;

                if (amountNumberTable.ContainsKey(secondDvider))
                    return true;
            }

            return false;
        }
    }
}
