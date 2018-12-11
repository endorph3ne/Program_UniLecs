using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Задача: Вывести первый уникальный символ в строке.
*/

/*
    Идея: Работаем с символами, поэтому нам достаточно посчитать количество каждого символа в строке и вывести первый, у кого кол-во вхождений равно 1.
*/

namespace Task11 {
    class Program {
        static void Main(string[] args) {
            string inputString = "11_22_333_4_5_4_6_7";
            Console.WriteLine(GetFirstUniqueSymbol(inputString));
            Console.Read();
        }

        static char GetFirstUniqueSymbol(string inputString) {
            Dictionary<char, int> amountSymbolsTable = new Dictionary<char, int>();
            
            for (int i = 0; i < inputString.Length; i++) {
                char currentSymbol = inputString[i];

                if (amountSymbolsTable.Keys.Contains(currentSymbol))
                    amountSymbolsTable[currentSymbol]++;
                else
                    amountSymbolsTable.Add(currentSymbol, 1);
            }
            
            foreach(char currentKey in amountSymbolsTable.Keys) {
                if (amountSymbolsTable[currentKey] == 1)
                    return currentKey;
            }

            return ' ';
        }
    }
}
