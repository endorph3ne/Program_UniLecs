using System;
using System.Linq;

/*
    Задача: Дана строка, слова в ней указаны через пробел. Вывести слова в порядке убывания длины.
*/

/*
    Идея: Сплит строки + OrderByDescending по длине слов
*/

namespace Task7 {
    class Program {
        static void Main(string[] args) {
            string inputString = Console.ReadLine();
            Console.WriteLine(GetSortedWordsByLong(inputString));
            Console.Read();
        }

        static string GetSortedWordsByLong(string inputString) {
            string[] stringArr = inputString.Split(' ');
            stringArr = stringArr.OrderByDescending(x => x.Length).ToArray();
            return string.Join(" ", stringArr);
        }
    }
}
