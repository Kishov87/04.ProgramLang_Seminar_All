// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

using System;
using static System.Console; 

Clear();

Write("Введите размер строк:");
int m=int.Parse(ReadLine());
Write("Введите число столбцов:");
int n=int.Parse(ReadLine());
int[,] ar= FillArrayCHET(m, n);

if (ar.GetLength(0)== ar.GetLength(1))
{
    PrintArray(ar);
    WriteLine();
    //PrintArray(ReversArrayColumnsToRows2(ar));
    ReversArrayColumnsToRows2(ar);
    PrintArray(ar);
    WriteLine();
}
else
{
    WriteLine("Неправильная размерность массива!");
}

int[,] ReversArrayColumnsToRows1(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            resultArray[j,i] = array[i,j];
        }
    }
    return resultArray;
}

void ReversArrayColumnsToRows2(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int tempInt = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = tempInt;
        }
    }
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