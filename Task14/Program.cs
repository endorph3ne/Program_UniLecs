using System;
using System.Collections.Generic;
using System.Text;

/*
    Задача: вывод слов в строке в обратном порядке.Слова разделены только пробелами.
*/

/*
    Идея: формируем слово, кладем его в стек, затем ковертируем стек в массив, а после в строку.
*/

namespace Task14 {
    class Program {
        static void Main(string[] args) {
            string inputString = Console.ReadLine();
            Console.WriteLine(RevertWordsInString(inputString));
            Console.Read();
        }

        static string RevertWordsInString(string inputString) {
            Stack<string> stackWords = new Stack<string>();
            StringBuilder buildedWord = new StringBuilder();

            for (int i = 0; i < inputString.Length; i++) {
                char currentSymbol = inputString[i];

                if (currentSymbol != ' ')
                    buildedWord.Append(currentSymbol);
                else {
                    stackWords.Push(buildedWord.ToString());
                    buildedWord.Clear();
                }

                if (i == inputString.Length - 1 && currentSymbol != ' ')
                    stackWords.Push(buildedWord.ToString());
            }

            return String.Join(" ", stackWords.ToArray());
        }
    }
}
