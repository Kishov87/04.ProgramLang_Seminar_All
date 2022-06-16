//**Задача 30:**
//Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

using System;
using static System.Console; 

void PrintArray(int[]array)
{
    Write("[");
    for(int i=0; i<8; i++)
    {
        Write($"{array[i]},");
    }
    Write("]");
}

int[] FillArray(int[]array)
{
    int[]array1= new int[a];
    for(int a=0; a<8; a++)
    {
        array1[a]= new Random().Next(0,2);
    }
    return array1;
}