using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
