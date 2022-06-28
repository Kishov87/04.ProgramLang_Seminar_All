// **Задача 35:** Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// *Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

using System;
using static System.Console; 
Clear();

Write("Введите размер массива: ");
int size = int.Parse(ReadLine());
int[] array = GetRandomArray(size,0,1000);
WriteLine($"массив [{String.Join(", ", array)}] -> {FindNumbersArray(array, 10, 99)}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result=new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue +1);
    }
    return result;
}

int FindNumbersArray(int[] array, int left, int right, int result = 0)
{
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] >= left) && (array[i] <= right))
        {
            result++;
        }
    }    
    return result;
}