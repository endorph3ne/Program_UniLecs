using System;

/*
    Задача: Найти элемент в отсортированной матрице (матрица, в ктр строки и столбцы отсортированы)

    Идея: Так как матрица отсортирована мы можем сделать следующие выводы:
          - если 1-й элемент в столбце больше искомого значения X, то X находится левее
          - если последний элемент в строке меньше Х, то Х находится в в строке ниже
*/

namespace Task25 {
    class Program {
        static void Main(string[] args) {
            int[,] array = { {1, 5, 10, 20},
                             {7, 9, 15, 28},
                             {12, 25, 30, 36},
                             {22, 35, 45, 50} };
            int inputElement = Int32.Parse(Console.ReadLine());

            var resultPosition = SearchElementInSortedMatrix(array, inputElement);
            Console.WriteLine(resultPosition);
            Console.Read();
        }

        static (int row, int column) SearchElementInSortedMatrix(int[,] array, int inputElement) {
            var resultPos = (row: -1, column: -1);

            int row = 0;
            int column = (int)Math.Sqrt(array.Length) - 1;

            while (row < Math.Sqrt(array.Length) && column >= 0) {
                if (array[row, column] == inputElement)
                    return (row, column);

                if (array[row, column] > inputElement)
                    column--;
                else
                    row++;
            }

            return (-1, -1);
        }
    }
}
