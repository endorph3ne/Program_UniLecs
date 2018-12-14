using System;

/*
    Задача: Дан массив arr, в ктр в случайном порядке находятся натуральные числа от 1 до N.  
            Каждое число встречается в массиве не более одного раза. Но одно число заменили на 0. Найти это число.
*/

/*

/*
    Идея: 
          1. Вариант с одним числом
             ----------------------
             Задача довольно простая и решение тривиальное, считаем сумму элементов в массиве и вычитаем из суммы элементов от 1 до N. 
             Также можно воспользоваться операцией XOR.

          2. Вариант с двумя числами
             -----------------------
             Для нахождения двух отсутствующих чисел суммы всех элементов нам будет недостаточно, поэтому найдем также произведение всех элементов. 
             После этого мы получим систему уравнений и придем к квадратному уравнению.
                x + y = TotalSum - SumInArray
                x * y = TotalP / PInArray
            где x, y - искомые два числа, Total Sum - сумма всех элементов от 1 до N, TotalP - произведение всех чисел от 1 до N;
            Далее следует решить квадратное уравнение.
*/


namespace Task21 {
    class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] inputStringArray = Console.ReadLine().Split(' ');
            int[] array = new int[inputStringArray.Length];
            int first;
            int second;

            for (int i = 0; i < n; i++)
                array[i] = Convert.ToInt32(inputStringArray[i]);

            GetRemovedElementsInArray(array, out first, out second);
            Console.WriteLine("First: {0}", first);
            Console.WriteLine("Second: {0}", second);
            Console.Read();
        }

        #region Variant №1
        static int GetRemovedElementInArray(int[] array, int n) {
            int totalSum = n * (n + 1) / 2; //Формула арифметичской прогрессии;
            int arraySum = 0;

            for (int i = 0; i < n; i++)
                arraySum += array[i];

            return totalSum - arraySum;
        }

        static int GetRemovedElementInArray_XOR(int[] array, int n) {
            int totalXorSum = 0;
            int arrayXorSum = 0;

            for (int i = 1; i <= n; i++)
                totalXorSum ^= i;

            for (int i = 0; i < n; i++)
                arrayXorSum ^= array[i];

            return totalXorSum ^ arrayXorSum;
        }
        #endregion

        #region Variant №2
        public static void GetRemovedElementsInArray(int[] array, out int first, out int second) {
            // находим общую сумму и произведение элементов массива
            int totalSum = 0;
            int totalP = 1;
            for (int i = 1; i <= array.Length; i++) {
                totalSum += i;
                totalP *= i;
            }

            // находим фактические сумму и произведение элементов массива
            int arraySum = 0;
            int arrayP = 1;
            for (int i = 0; i < array.Length; i++) {
                arraySum += array[i];
                arrayP *= array[i] != 0 ? array[i] : 1;
            }

            //Находим разницу между общими значениями и фактическими
            int diffBetweenSums = totalSum - arraySum;
            double diffBetweenP = (double)totalP / (double)arrayP;

            // формула корня квадратного уравнения
            first = (int)Math.Round((diffBetweenSums + Math.Sqrt(diffBetweenSums * diffBetweenSums - 4 * diffBetweenP)) / 2);
            second = diffBetweenSums - first;
        }
        #endregion
    }

}
