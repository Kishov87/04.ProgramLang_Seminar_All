//**Задача 20:**
//Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

using System;
using static System.Console; 

Clear();

Write("Введите координаты: ");

Write("Координаты X1: ");
int x1 = int.Parse(ReadLine());
Write("Координаты Y1: ");
int y1 = int.Parse(ReadLine());
Write("Координаты X2: ");
int x2 = int.Parse(ReadLine());
Write("Координаты Y2: ");
int y2 = int.Parse(ReadLine());
int answer = 0;

int sqrX=Convert.ToInt32(Math.Pow((x2-x1), 2));
int sqrY=Convert.ToInt32(Math.Pow((y2-y1), 2));

WriteLine($"Расстояние = {Math.Sqrt(sqrX+sqrY)}");