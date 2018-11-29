using System;
using System.Linq;

/*
    Задача: Написать функцию, ктр определяет, является ли одна строка перестановкой другой.
*/

/*
    Идея: Решить эту задачу можно несколькими способами:
        1. Создать обьект для каждой из строки(HashMap<char, number>), ктр будет подсчитывать количество каждого символа. 
           Дальше просто сравним результаты этих двух обьектов.
        2. Мы можем воспользоваться простой сортировкой двух строк и сравнить полученные результаты. 
           Если одна строка является перестановкой другой, то результаты будут совпадать.
*/

namespace Task6 {
    class Program {
        static void Main(string[] args) {
            string firstInputString = Console.ReadLine();
            string secondInputString = Console.ReadLine();

            Console.WriteLine(IsSameString(firstInputString, secondInputString));
            Console.Read();
        }

        static bool IsSameString(string firstString, string secondString) {
            // если размеры строк отличаются то сразу выводим false
            if (firstString.Length != firstString.Length)
                return false;

            // преобразуем строки в символьные массивы для сортировки
            char[] firstArr = firstString.OrderBy(x => x).ToArray();
            char[] secondArr = secondString.OrderBy(x => x).ToArray();

            // сравниваем две отсортированные "строки"
            for (int i = 0; i < firstString.Length; i++) {
                if (firstArr[i] != secondArr[i])
                    return false;
            }

            return true;
        }
    }
}
