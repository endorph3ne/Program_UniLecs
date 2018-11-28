using System;

/*
    Напишите метод, заменяющий все пробелы в строке символами '%20'.  
    Можно предположить, что длина строки позволяет сохранить дополнительные символы и «истинная» длина строки известна.
*/

/*
    Идея: Фишка задачи в том, что строки в C# неизменяемые, и вместо строки нужно использовать символьный массив. 
    А один символ пробела нужно поменять на 3 символа'%20', поэтому нужно играть с размером результирующего массива.
*/

namespace Task3 {
    class Program {
        static void Main(string[] args) {
            string inputString = Console.ReadLine();
            char[] inputCharArray = ReplaceSpaceBySpecialSymbols(inputString.ToCharArray(), inputString.Length);

            for (int i = 0; i < inputCharArray.Length; i++)
                Console.Write(inputCharArray[i]);

            Console.Read();
        }

        static char[] ReplaceSpaceBySpecialSymbols(char[] array, int lenght) {
            int spaceCount = 0;
            for (int i = 0; i < lenght; i++) {
                if (array[i] == ' ')
                    spaceCount++;
            }

            // т.к. заменяем 1 символ 3-мя, то понадобится еще N*2 символов (N - кол-во пробелов)
            int newLenght = lenght + spaceCount * 2;
            char[] newArray = new char[newLenght];
            for (int i = lenght - 1; i >= 0; i--) {
                if (array[i] == ' ') {
                    newArray[newLenght - 1] = '0';
                    newArray[newLenght - 2] = '2';
                    newArray[newLenght - 3] = '%';
                    newLenght -= 3;
                }
                else {
                    newArray[newLenght - 1] = array[i];
                    newLenght -= 1;
                }
            }

            return newArray;
        }
    }
}
