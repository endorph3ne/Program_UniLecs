using System;
using System.Collections.Generic;

/*
    Задача: Написать функцию, ктр будет проверять можно ли преобразовать строку так, чтобы она стала палиндромом.

    Пример:
        "bob" => true - уже является палиндромом
        "bbo" => true - можно сделать палиндромом
        "cat" => false - нельзя сделать палиндромом
*/

/*
    Идея: Создадим обьект(HashMap<char, number>), ктр будет подсчитывать кол-во вхождений каждого символа в строку.
*/

namespace Task5 {
    class Program {
        static void Main(string[] args) {
            string inputString = Console.ReadLine();
            Console.WriteLine(CheckStringAsPalindrome(inputString));
            Console.Read();
        }

        static bool CheckStringAsPalindrome(string inputString) {
            Dictionary<char, int> hashSymbolMap = new Dictionary<char, int>();

            for (int i = 0; i < inputString.Length; i++) {
                char currentChar = inputString[i];

                if (hashSymbolMap.ContainsKey(currentChar))
                    hashSymbolMap[currentChar] += 1;
                else
                    hashSymbolMap.Add(currentChar, 1);
            }

            int oddSymbolsCount = 0;

            foreach (char currentKey in hashSymbolMap.Keys) {
                if (hashSymbolMap[currentKey] % 2 != 0)
                    oddSymbolsCount++;
            }

            return oddSymbolsCount % 2 == 1 || oddSymbolsCount == 0;
        }
    }
}
