using System;

//Количество участников олимпиады

/*
    Идея: довольно простая задачка на арифметику. По сути мы имеем следующее:
    S/k + S/m + S/n + d = S
    k-я, m-я, n-я доля и d участников

    Путем не сложных манипуляций мы получим следующую формулу для S:
    S = k*m*n*d / k*m*n - m*n - k*m - k*n
 */

namespace Task37 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("UniLecs");
            Console.WriteLine(GetNumberOfUsers(2, 4, 7, 3)); // 28
            Console.WriteLine(GetNumberOfUsers(2, 2, 2, 3)); // -1
        }

        public static int GetNumberOfUsers(int k, int m, int n, int d) {
            int up = k * n * m * d;
            int down = k * n * m - n * m - k * m - k * n;
            if (down <= 0 || up % down != 0) {
                return -1;
            }

            int numberOfUsers = up / down;

            if (numberOfUsers % k == 0 && numberOfUsers % m == 0 && numberOfUsers % n == 0) {
                return numberOfUsers;
            }

            return -1;
        }
    }
}
