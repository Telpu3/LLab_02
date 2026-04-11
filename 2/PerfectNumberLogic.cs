using System.Collections.Generic;

namespace _2
{
    public class PerfectNumberLogic
    {
        // Задача 1: проверка, является ли число совершенным
        public static bool IsPerfect(int n)
        {
            if (n <= 1) return false;
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            return sum == n;
        }

        // Задача 2: получить список совершенных чисел до N с их делителями
        public static List<(int Number, List<int> Divisors)> GetPerfectNumbersUpTo(int n)
        {
            var result = new List<(int, List<int>)>();

            for (int num = 2; num <= n; num++)
            {
                var divisors = new List<int>();
                int sum = 0;

                for (int i = 1; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        divisors.Add(i);
                        sum += i;
                    }
                }

                if (sum == num)
                {
                    result.Add((num, divisors));
                }
            }

            return result;
        }

        // Задача 3: получить делители числа (для визуализации)
        public static List<int> GetProperDivisors(int n)
        {
            var divisors = new List<int>();
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    divisors.Add(i);
            }
            return divisors;
        }
    }
}