//**Задача 24:**
//Напишите программу, которая принимает на вход число (А) 
//и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

using System;
using static System.Console; 

Clear();
Write("Введите число: ");
// int N = Convert.ToInt32(ReadLine());

// int sum = GetSum(N);
// WriteLine($"Сумма чисел = {sum}");

WriteLine($"Сумма чисел = {GetSum(Convert.ToInt32(ReadLine()))}");

int GetSum(int r)
{
    int result = 0;
    for(int i=1; i<=r; i++)
    {
        result+=i;
    }
    return result;
}
