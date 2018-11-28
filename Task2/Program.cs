using System;

/*
    Найти минимальный элемент в отсортированном по возрастанию и циклически сдвинутом массиве
*/

/*
    Идея: Можно найти минимальный элемент простым перебором всех элементов, 
    но т.к. мы знаем, что массив отсортирован по возрастанию мы можем решить эту задачу более оптимально.

    Мы будем делить массив пополам и сравнивать крайние точки двух массивов. 
    Идея в том чтобы найти отрезок сдвига, когда отрезок будет из 2-х точек мы найдем минимальный элемент.
*/

namespace Task2 {
    class Program {
        static void Main(string[] args) {
            int[] array = { 8, 9, 10, 12, 13, 14, 15, 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine(GetMinItemInCyclicallySortedArray(array));
            Console.Read();
        }

        static int GetMinItemInCyclicallySortedArray(int[] array) {
            if (array.Length == 0)
                return -1;

            if (array.Length == 1)
                return array[0];

            int start = 0;
            int end = array.Length - 1;


            while (end - start > 1) {
                double middleFloat = (double)(start + end) / 2;
                int middle = (int)Math.Round(middleFloat);

                // if we found min element in the first part of array
                if (array[start] > array[middle])
                    end = middle;

                // if we found min element in the second part of array
                if (array[middle] > array[end])
                    start = middle;
            }

            return array[start] < array[end] ? array[start] : array[end];
        }
    }
}
