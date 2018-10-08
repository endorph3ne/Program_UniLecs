using System;

//Задача: дан массив arr, в ктр в случайном порядке находятся натуральные числа от 1 до N.  
//Каждое число встречается в массиве не более одного раза. Но одно число заменили на 0. Найти это число.


namespace Task21 {
    class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] inputStringArray = Console.ReadLine().Split(' ');
            int[] array = new int[inputStringArray.Length];

            for (int i = 0; i < n; i++)
                array[i] = Convert.ToInt32(inputStringArray[i]);

            Console.WriteLine("Without XOR: {0}", GetRemovedElementInArray(array, n));
            Console.WriteLine("With XOR: {0}", GetRemovedElementInArray_XOR(array, n));
            Console.Read();
        }

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
    }
}
