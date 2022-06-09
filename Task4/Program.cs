//1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

using System;
using static System.Console;

Clear();
Write("Введите рехзначное число: ");
int N = Convert.ToInt32(ReadLine());

if ((Math.Abs(N) < 100) || (Math.Abs(N) > 999))
{
    WriteLine("Введите не трехзначное число!!!");
    return;
}
WriteLine(N%10);