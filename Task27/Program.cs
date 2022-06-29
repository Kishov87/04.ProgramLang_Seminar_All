// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

using System;
using static System.Console; 
Clear();
Write("Введите число: ");
int N=int.Parse(ReadLine());
WriteLine(string.Join(" ", Fibonacci(N)));
int[] Fibonacci(int n)
{
    int[] result = new int[n];
    for (int i = 2; i <= result.Length - 1; i++)
    {
        result[0] = 0;
        result[1] = 1;
        result[i] = result[i-1] + result[i-2]; 
    }
    return result;
}