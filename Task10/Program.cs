//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
//выдаёт номер четверти плоскости, в которой находится эта точка.

using System;
using static System.Console; 

Clear();
Write("Введите X = ");
int x = int.Parse(ReadLine());
Write("Введите Y = ");
int y = int.Parse(ReadLine());
int quater=0;

if(x>0&&y>0)
{
    quater=1;
}
if(x<0&&y>0)
{
    quater=2;
}
if(x<0&&y<0)
{
    quater=3;
}
if(x>0&&y<0)
{
    quater=4;
}

WriteLine ($"{quater} четверь");