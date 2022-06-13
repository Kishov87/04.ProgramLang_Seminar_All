//**Задача 18:**
//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти 
//(x и y).

using System;
using static System.Console; 

Clear();
Write("Введите четверть = ");
int quater = Convert.ToInt32(ReadLine());
string X=null, Y=null;

if((quater < 1)||(quater > 4))
{
    WriteLine("Чеверть должна быть от 1 до 4!");
    return;
}
if(quater == 1)
{
    X = "X+";
    Y = "Y+";
}
if(quater == 2)
{
    X = "X-";
    Y = "Y+";
}
if(quater == 3)
{
    X = "X-";
    Y = "Y-";
 }
if(quater == 4)
{
    X = "X+";
    Y = "Y-";
}

WriteLine($"X= {X}: Y={Y}");