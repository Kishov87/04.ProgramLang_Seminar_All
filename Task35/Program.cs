//Фишка C# библиотека в рамках одномерный массив библиотека using System.Linq; 

using System;
using static System.Console; 
using System.Linq;

Clear();

// WriteLine("Введите массив через пробел:");
// int[] array=ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).Where(x=>x%2==0).ToArray();
// WriteLine(String.Join(",",array)); //-- посчитать все четные числа в массиве одномерном

// int array=ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).Count(x=>x%2==0);
// WriteLine(array); // - посчитать количество четных элементов массива

// int[] array=ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).OrderBy(x=>x).ToArray();
// WriteLine(String.Join(",",array)); //-- массив выстроить в порядке по счету из 3 2 1 -> 1 2 3

// WriteLine("Введите длину массива:");
// int t=int.Parse(ReadLine());

// int[] array = new int[t].Select(x=>x= new Random().Next(-10,10)).ToArray();
// WriteLine(String.Join(",",array)); //-- создать одномерный массив с ввода в конслось

// int[] array = new int[t].Select(x=>x= new Random().Next(-10,10)).Where(x=>x%2==0).ToArray();
// WriteLine(String.Join(",",array)); //-- создать одномерный массив с ввода в консоль где только четные элементы