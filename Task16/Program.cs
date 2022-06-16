//Напишите программу, которая принимает на вход число 
//и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

using System;
using static System.Console; 

Clear();
Write("Введите число: ");
WriteLine($"Количество цифр = {CountNumb(Convert.ToInt32(ReadLine()))}");

int CountNumb(int r)
{
    if (r == 0) return 1;
    int count=0;
    for(count=0; r!=0; count++)
    {
        r = r/10;
    }
    return count;
}