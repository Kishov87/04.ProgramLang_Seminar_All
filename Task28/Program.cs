// Задача 45: Напишите программу, которая будет 
// создавать копию заданного массива с помощью поэлементного копирования.

using System;
using static System.Console; 
Clear();

Write("Введите элементы массива через пробел: ");
int[] array = GetArrayFromString(ReadLine());
WriteLine($"[{String.Join(", ", array)}]");
WriteLine($"[{String.Join(", ", CopyArray(array))}]");

int[] GetArrayFromString(string arrayStr)
{
    string[] arS=arrayStr.Split(new char[]{' ',',','*'},StringSplitOptions.RemoveEmptyEntries);
    int[] result=new int[arS.Length];
    for(int i=0; i<arS.Length;i++)
    {
        result[i]=int.Parse(arS[i]);
    }
    return result;
}

int[] CopyArray(int[] array)
{
    int[] result=new int[array.Length];
    for(int i = 0; i<array.Length;i++)
    {
        result[i]=array[i];
    }
    return result;
}
