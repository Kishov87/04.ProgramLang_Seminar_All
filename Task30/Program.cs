// **Задача 48:** Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле:
//  Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

using System;
using static System.Console; 

Clear();

Write("Введите размер строк:");
int m=int.Parse(ReadLine());
Write("Введите число столбцов:");
int n=int.Parse(ReadLine());

int[,] ar= FillArrayMplusN(m, n);
PrintArray(ar);

int[,] FillArrayMplusN(int rows, int columns)
{
    int[,] array=new int[rows, columns];
    for(int i=0; i< array.GetLength(0);i++)
    {
        for(int j=0; j< array.GetLength(1);j++)
        {
            array[i,j]= i+j;
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i=0; i< array.GetLength(0);i++)
    {
        for(int j=0; j< array.GetLength(1);j++)
        {
            Write($"{array[i,j]} ");
        }
        WriteLine();
    }
}