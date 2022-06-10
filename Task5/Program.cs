//**Задача 9.**
//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

using System;
using static System.Console;

Clear();

int number = new Random().Next(10,100);
//int number = 77;
WriteLine($"Случайное число = {number}");

//int a1=number/10;
//int a2=number%10;

//if(a1>a2)
//{
//    WriteLine($"Максимальное число = {a1}");
//}
//else
//{
//    WriteLine($"Максимальное число = {a2}");
//}

//string answer=a1>a2?$"Максимальное число = {a1}":$"Максимальное число = {a2}";

string answer= number/10>number%10
?$"Максимальное число = {number/10}"
:number/10<number%10
    ?$"Максимальное число = {number%10}"
    :"Числа равны";

WriteLine(answer);
