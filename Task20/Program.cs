using System;

/*
    Задача: Дана строка STR, степенью K строки STR будет строка вида: STR1+STR2+... +STRk(плюс означает конкатенацию). 
            Корнем k степени из строки STR называется такая строка T(если это возможно), что T степени K = STR.
            Написать функцию, ктр выводит строку STR в степени K.

            Например: 
                1. STR = "abc", K = 3;
                STR степени K = "abcabcabc"

                2. STR ="abcabc", K = -2; 
                STR степени K = "abc"

                3. STR ="abcabc", K = -3; 
                STR степени K = "some error message"
/*

/*
     Идея: Для случая K >= 0 все довольно тривиально, мы просто выводим заданную строку K раз.
           Для случая K < 0, нам нужно понять размер "корня" из строки, это мы делаем делением размера заданной строки на степень. 
           После мы проверяем все ли подстроки одинаковы.
*/

namespace Task20 {
    class Program {
        static void Main(string[] args) {
            string inputString = Console.ReadLine();
            int degree = int.Parse(Console.ReadLine());
            Console.WriteLine(GetDegreeOfString(inputString, degree));
            Console.Read();
        }

        static string GetDegreeOfString(string inputString, int degree) {
            const string error = "error";

            if (degree == 0)
                return String.Empty;
            else if (Math.Abs(degree) == 1)
                return inputString;
            else if (degree > 1) {
                string result = inputString;
                for (int i = 0; i < degree - 1; i++)
                    result += inputString;
                return result;
            }
            else if (degree < 0) {
                double lenghtBaseDegree = inputString.Length / Math.Abs(degree);
                string BaseDegree = inputString.Substring(0, (int)lenghtBaseDegree);
                string createdString = String.Empty;
                for (int i = 0; i < Math.Abs(degree); i++) {
                    createdString += BaseDegree;
                }

                if (createdString == inputString)
                    return BaseDegree;
                else
                    return error;
            }

            return error;
        }
    }
}
