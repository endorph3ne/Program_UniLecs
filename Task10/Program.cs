using System;
using System.Collections.Generic;

/*
    Задача: Если элемент матрицы равен 0, то всю строку и весь столбец нужно обнулить.
*/

/*
    Идея: нужны счетчики, ктр записывают в каком столбце и в какой строке мы нашли 0. 
    Просто пройтись по матрице сразу изменяя значения мы не можем, ибо в матрице могут быть "родные" нули, ктр мы не должны учитывать при обнулении.
*/

namespace Task10 {
    class Program {
        static void Main(string[] args) {
            int[,] matrix = { { 1, 1, 1, 1 },
                              { 1, 0, 1, 1 },
                              { 1, 1, 1, 1 },
                              { 1, 1, 1, 0 } };

            ChangeMatrix(ref matrix);
            PrintMatrix(matrix);
            Console.Read();
        }

        static void ChangeMatrix(ref int[,] matrix) {
            List<int> zeroValueRowIndex = new List<int>();
            List<int> zeroValueColumnIndex = new List<int>();

            for (int i = 0; i < Math.Sqrt(matrix.Length); i++) {
                for (int j = 0; j < Math.Sqrt(matrix.Length); j++) {
                    if (matrix[i, j] == 0) {
                        zeroValueRowIndex.Add(i);
                        zeroValueColumnIndex.Add(j);
                    }
                }
            }

            foreach (var currentZeroValueRowIndex in zeroValueRowIndex) {
                for (int j = 0; j < Math.Sqrt(matrix.Length); j++)
                    matrix[currentZeroValueRowIndex, j] = 0;
            }

            foreach (var currentZeroValueColumnIndex in zeroValueColumnIndex) {
                for (int i = 0; i < Math.Sqrt(matrix.Length); i++)
                    matrix[i, currentZeroValueColumnIndex] = 0;
            }
        }

        static void PrintMatrix(int[,] matrix) {
            for (int i = 0; i < Math.Sqrt(matrix.Length); i++) {
                for (int j = 0; j < Math.Sqrt(matrix.Length); j++) {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
