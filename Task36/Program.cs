// Задача 53: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

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
PrintArray(reversArray(ar));

int[,] reversArray(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        resultArray[0, i] = array[array.GetLength(0)-1, i];
        resultArray[array.GetLength(0)-1, i] = array[0, i];
    }
    for (int i = 1; i < array.GetLength(0)-1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            resultArray[i,j] = array[i,j];
        }
    }
    return resultArray;
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

