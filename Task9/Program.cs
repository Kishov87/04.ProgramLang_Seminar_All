//**Задача 16:**
//Напишите программу, которая принимает на вход два числа и 
//проверяет, является ли одно число квадратом другого.

using System;
using static System.Console;

Clear();
Write("Введите число a = ");
int a = Convert.ToInt32(ReadLine());
Write("Введите число b = ");
int b = Convert.ToInt32(ReadLine());

string answer = (a/b == b) || (b/a == a)
?"Одно число является квадратом другого"
:$"Числа не являются квадратами друг друга";

WriteLine(answer);