//5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"

using System;
using static System.Console;

Write("Введите число: ");
int N = Convert.ToInt32(ReadLine());
int CurentN = N * -1;
while (CurentN <= N)
{
    Write (CurentN);
    Write (", ");
    CurentN = CurentN + 1;
}                                   
WriteLine("Конец!");