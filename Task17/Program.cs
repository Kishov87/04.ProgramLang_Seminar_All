//**Задача 28:**
//Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.
//4  -> 24
//5  -> 120

using System;
using static System.Console; 

Clear();
Write("Введите число: ");
WriteLine($"Произведение чисел = {Getn(Convert.ToInt32(ReadLine()))}");

int Getn(int n)
{
    int result = 1;
    for(int i=1; i<=n; i++)
    {
        result*=i;
    }
    return result;
}