//**Задача 11:**
//Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

using System;
using static System.Console;

Clear();

int number = new Random().Next(100,1000);
WriteLine($"Случайное число = {number}");

WriteLine($"{number/100}{number%10}{" - юпиии"}");