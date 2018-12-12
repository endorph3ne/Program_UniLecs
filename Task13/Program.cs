using System;
using System.Text;

/*
    Задача: Написать функцию, ктр "сжимает" строку.Если полученная строка оказалась больше исходной, то вывести исходную.
            Например, дана строка "ZZZABBEEE", получить строку вида "Z3A1B2E3", т.е.подставить счетчик вхождения символа.
*/

/*
    Идея: Задача не сложная, нам нужно просто пройти всю строку и использовать 
          локальные счетчики для подсчета последовательности символов (одного или нескольких символов). 
          Но фишка задачи в том, что строка после сжатия может оказаться больше первоначальной. 
*/

namespace Task13 {
    class Program {
        static void Main(string[] args) {
            string inputString = Console.ReadLine();
            Console.WriteLine(GetShortestString(inputString));
            Console.Read();
        }

        //Вернуть меньшую по длине строку
        static string GetShortestString(string inputString) {
            if (inputString.Length == 1)
                return inputString;
            
            string compressedString = CompressString(inputString);

            if (inputString.Length < compressedString.Length)
                return inputString;
            else
                return compressedString;
        }

        //Сжатие строки
        static string CompressString(string inputString) {
            StringBuilder result = new StringBuilder();
            int countCurrentSymbol = 1;

            //Сжатие строки без добавления последнего символа
            for (int i = 0; i < inputString.Length - 1; i++) {
                if (inputString[i] == inputString[i + 1])
                    countCurrentSymbol++;
                else {
                    result.Append(inputString[i]);
                    result.Append(countCurrentSymbol);
                    countCurrentSymbol = 1;
                }
            }

            //Добавление последнего символа
            int indexLastSymbol = inputString.Length - 1;
            int indexPreLastSymbol = inputString.Length - 2;
            char lastSymbol = inputString[indexLastSymbol] == inputString[indexPreLastSymbol] ? inputString[indexPreLastSymbol] : inputString[indexLastSymbol];
            int amountLastSymbol = inputString[indexLastSymbol] == inputString[indexPreLastSymbol] ? countCurrentSymbol : 1;

            result.Append(lastSymbol);
            result.Append(amountLastSymbol);

            return result.ToString();
        }
    }
}
