using System;

/*
    Задача: Дан массив с целыми числами. Написать функцию, ктр преобразует массив следующим образом: 
            каждое i-е значение массива это произведение всех значений исходного массива за исключением i-го значения. В решении нельзя использовать операцию деления. 

    Идея: Так как нельзя использовать деление, то мы пройдем по массива два раза. 
          В первый раз мы будем получать произведение всех чисел до текущего элемента. 
          При втором проходе - произведение всех чисел после текущего элемента, идя с конца массива. 
          Затем мы перемножим значения соот-х индексов и получим результирующий массив.

    Пример: На входе [ 2, 4, 3, 5 ]
            На выходе [ 4*3*5, 2*3*5, 2*4*5, 2*4*3 ] = [ 60, 30, 40, 24 ]
*/


namespace Task26 {
    class Program {
        static void Main(string[] args) {
            int[] array = { 2, 4, 3, 5 };
            array = GetMultipleElementsInArray(array);

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
            Console.Read();
        }

        static int[] GetMultipleElementsInArray(int[] array) {
            //результирующий массив произведений
            int[] resultArray = new int[array.Length];

            // произведение всех значений до текущего
            int multiple = 1;
            int i = 0;
            while (i < array.Length) {
                resultArray[i] = multiple;
                multiple *= array[i];
                i++;
            }

            // произведение всех значений после текущего
            // также мы вычисляем текущее результирующее значение
            multiple = 1; i = array.Length - 1;
            while (i >= 0) {
                resultArray[i] *= multiple;
                multiple *= array[i];
                i--;
            }

            return resultArray;
        }

    }
}
