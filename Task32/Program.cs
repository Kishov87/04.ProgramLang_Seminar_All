// **Задача 49:** Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

using System;
using static System.Console; 

Clear();

Write("Введите размер строк:");
int m=int.Parse(ReadLine());
Write("Введите число столбцов:");
int n=int.Parse(ReadLine());

int[,] ar= FillArrayCHET(m, n);
PrintArray(ar);
WriteLine();
ar=GetCHET(ar);
PrintArray(ar);

int[,] GetCHET(int[,] array)
{
    for(int i=0; i< array.GetLength(0);i+=2)
    {
        for(int j=0; j< array.GetLength(1);j+=2)
        {
            array[i,j]*= array[i,j];
        }
    }
    return array;
}

int[,] FillArrayCHET(int rows, int columns)
{
    int[,] array=new int[rows, columns];
    for(int i=0; i< array.GetLength(0);i++)
    {
        for(int j=0; j< array.GetLength(1);j++)
        {
            array[i,j]= new Random().Next(1,10);
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