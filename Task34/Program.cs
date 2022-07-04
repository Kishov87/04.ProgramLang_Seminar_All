// **Задача 51:** Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
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
WriteLine(SumDiagArray(ar));

int SumDiagArray(int[,] array)
{
    int sum = 0;
    for(int i=0; i< array.GetLength(0)&&i< array.GetLength(1);i++)
    {
        sum+=array[i,i];
    }
    return sum;
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