//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

using System;
using static System.Console; 

Clear();
Write("Введите число: ");
int N = int.Parse(ReadLine());
int q=1;

while(q<N)
{
    Write($"{Math.Pow(q, 2)},");
    q++;
}
 Write($"{Math.Pow(q, 2)}");