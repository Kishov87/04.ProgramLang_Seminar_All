//**Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

using System;
using static System.Console; 
Clear();

Write("Введите размер массива: ");
int size = int.Parse(ReadLine());
int[] array = GetRandomArray(size,-5,5);
WriteLine($"массив [{String.Join(", ", array)}]");

Write("Введите число: ");
int number = int.Parse(ReadLine());
WriteLine($"массив [{String.Join(", ", array)}] -> {FindNumber(array, number)} {number}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result=new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue +1);
    }
    return result;
}

string FindNumber(int[] array, int numbers)
{
    string flag = "не содержит число:";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == numbers)
        {
            flag = "содержит число:";
            break; 
        }
    }    
    return flag;
}