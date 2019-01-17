using System;

/*
        Задача: Дан числовой массив.Выполнить перестановку в массиве так, чтобы все четные элементы были слева, все нечетные - справа.

        Идея: 
                1. По сути это так называемая перестановка по предикату, в данном случае по условию, что элемент четный.
                   Для перестановки элементов используем xor и ее свойства.

                2. Назначаем 2 счетчика один сначала, другой с конца. Находим первый нечетный и первый четный и обмениваем их местами.
                   Переходим к следующим элеметам. И так до тех пор, пока не обменям все.
                   
*/

namespace Task22 {
    class Program {
        static void Main(string[] args) {
            int[] array = { 1, 0, 2, 3, 4, 5, 9, 8, 7 };
            int[] modifiedArray = SeparateOddEvenElementsInArray(array);

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{modifiedArray[i]} ");

            Console.Read();
        }

        static int[] SeparateOddEvenElementsInArrayXOR(int[] array) {
            int k = 0;

            for (int i = 0; i < array.Length; i++) {
                if (array[i] % 2 == 0) {
                    array[i] = array[i] ^ array[k];
                    array[k] = array[i] ^ array[k];
                    array[i] = array[i] ^ array[k];

                    k++;
                }
            }

            return array;
        }

        static int[] SeparateOddEvenElementsInArray(int[] array) {

            for (int i =0, j = array.Length - 1; i < j; i++, j--) {
                if (array[i] % 2 == 0)
                    i++;

                if (array[j] % 2 != 0)
                    j--;

                if (array[i] % 2 != 0 && array[j] % 2 == 0) {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }

            }

            return array;
        }
    }
}
