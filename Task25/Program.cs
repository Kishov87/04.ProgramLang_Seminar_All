// Задача 40: Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.

using System;
using static System.Console; 

Clear();

int size = 3;
int[] array = GetRandomArray(size,1,10);
DefTri(array);
WriteLine($"массив [{String.Join(", ", array)}] -> треугольник с сторонами такой длины {(DefTri(array)?"может":"не может")} существовать");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result=new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue +1);
    }
    return result;
}

bool DefTri(int[] array)
{
    int a = array[0];
    int b = array[1];
    int c = array[2];
    return ((a+b)>c && (a+c)>b && (b+c)>a);
}

