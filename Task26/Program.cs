// **Задача 42:** Напишите программу, 
//которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

using System;
using static System.Console; 
Clear();

Write("Введите число: ");
int number10=int.Parse(ReadLine());
int size=$"{number10}".Length;
WriteLine(BinNumber(number10));

string BinNumber(int number)
{
    string number_bin="";
    while (number>0)
    {
        if(number%2==0)
        {
            number_bin+="1";
        }
        else
        {
            number_bin+="0";
        }
        number/=2;
    }
    return number_bin;
}