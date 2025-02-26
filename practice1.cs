
using System;

class Program
{
    static int SumOfDigits(int n)
    {
        // Функция для подсчёта суммы цифр числа
        int totalSum = 0;
        while (n > 0)
        {
            totalSum += n % 10;  // Добавляем последнюю цифру
            n /= 10;             // Удаляем последнюю цифру
        }
        return totalSum;
    }

    static int EvenNumbersSumInRange(int start, int end)
    {
        // Подсчёт суммы цифр всех чётных чисел в заданном диапазоне
        int result = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)      // Проверяем, является ли число чётным
            {
                result += SumOfDigits(i);
            }
        }
        return result;
    }

    static void Main()
    {
        // Вызов функции для диапазона от 1 до 100
        Console.WriteLine(EvenNumbersSumInRange(1, 100));
    }
}
