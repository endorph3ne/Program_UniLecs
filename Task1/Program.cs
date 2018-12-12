using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/*
    Задача: написать функцию, ктр проверяет все ли символы в строке встречаются один раз.
*/

/*
    Идея: 
          1 - Cоздадим обьект (hashMap), ктр будет подсчитывать количество символов в нашей строке. 
              Если на очередной итерации мы встретим повторный символ, то мы сразу вернем false.

          2 - Будем использовать регулярные выражения для нахождения дубликатов в строке. (Реализация для JS)
*/

namespace Task1 {
    class Program {
        static void Main(string[] args) {
            string inputString = Console.ReadLine();
            Console.WriteLine(CheckUniqueSymbols(inputString));
            Console.Read();
        }

        static bool CheckUniqueSymbols(string inputString) {
            HashSet<char> hashSet = new HashSet<char>();

            for (int i = 0; i < inputString.Length; i++) {
                if (hashSet.Contains(inputString[i]))
                    return false;
                else
                    hashSet.Add(inputString[i]);
            }

            return true;
        }

        //function checkUniqueSymbols(inputStr) {
        //    if (inputStr) {
        //        const hasDuplicateSymbols = inputStr.match(/ (\w)(.+) ?\1 /) !== null;
        //        return !hasDuplicateSymbols;
        //    }
        //    return false;
        //}
    }
}
