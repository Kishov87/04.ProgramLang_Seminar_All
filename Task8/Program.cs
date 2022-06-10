//**Задача 14:**
//Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

using System;
using static System.Console;

Clear();
Write("Введите число: ");
int number1 = Convert.ToInt32(ReadLine());
int a1 = 7;
int a2 = 23;

int N1 = number1%a1;
int N2 = number1%a2;

//if ((number1 < a1) || (number1 < a2))
//{
//    WriteLine("Нужно чтобы число было больше 23! ");
//    return;
//}
string answer1 = N1 ==0 & N2 == 0 
?"Число кратное 23 и 7 одновременно"
:$"Число не кратное 23 и 7.";

WriteLine(answer1);