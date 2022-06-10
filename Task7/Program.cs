//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если второе число не кратно числу первому, 
//то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

using System;
using static System.Console;

Clear();
Write("Введите первое число: ");
int number1 = Convert.ToInt32(ReadLine());
Write("Введите второе число: ");
int number2 = Convert.ToInt32(ReadLine());
int N = number1%number2;

if (number1<number2)
{
    WriteLine("Нужно чтобы первое число было больше второго! ");
    return;
}
string answer = N == 0 
?"Число кратное"
:$"Число не кратное. Остаток = {N}";

WriteLine(answer);