using System;
using static System.Console;

Clear();
WriteLine("Введите число: ");
int number = Convert.ToInt32(ReadLine());
//int number1 = int.Parse(Console.ReadLine());

int sqrNumber = number*number;
//int sqrNumber1 = Convert.ToInt32(Math.Pow(number1,2));

WriteLine(sqrNumber);